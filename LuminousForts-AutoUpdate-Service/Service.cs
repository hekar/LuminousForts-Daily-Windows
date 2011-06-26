/*
 * Created by SharpDevelop.
 * User: hekar
 * Date: 6/26/2011
 * Time: 1:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.ServiceProcess;
using System.Threading;
using LuminousForts_AutoUpdate_Shared;

namespace LuminousForts_AutoUpdate_Service
{
	/// <summary>
	/// Description of Service.
	/// </summary>
	public class Service : ServiceBase
	{
		SVNProcess svn = null;
		public Service()
		{
		}
		
		protected override void OnStart(string[] args)
		{
			Config config = new Config();
			svn = new SVNProcess(config);
			try
			{
				config.LoadConfig();
			}
			catch (IOException)
			{
				this.EventLog.WriteEntry("[LuminousForts-AutoUpdate]Failure to read Configuration file");
			}
			
			while (true)
			{
				if (svn.HasExited)
				{
					svn.Update();
				}
				
				Thread.Sleep(30);
			}
		}
		
		protected override void OnStop()
		{
			if (svn != null && !svn.HasExited)
			{
				svn.Stop();
			}
		}
	}
}
