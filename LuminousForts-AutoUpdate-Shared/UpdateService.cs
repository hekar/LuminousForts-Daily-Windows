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
	public class UpdateService
	{
		Logger logger;
		SVNProcess svn;
		public UpdateService(Logger logger, Config config)
		{
			this.logger = logger;
			svn = new SVNProcess(config);
		}
		
		public void OnStart(string[] args)
		{
			Config config = new Config();
			
			try
			{
				config.LoadConfig();
			}
			catch (IOException)
			{
				logger.WriteEntry("[LuminousForts-AutoUpdate]Failure to read Configuration file");
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
		
		public void OnStop()
		{
			if (!svn.HasExited)
			{
				svn.Stop();
			}
		}
	}
}
