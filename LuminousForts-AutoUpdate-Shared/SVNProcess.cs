/*
 * Created by SharpDevelop.
 * User: hekar
 * Date: 6/26/2011
 * Time: 1:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;

namespace LuminousForts_AutoUpdate_Shared
{
	/// <summary>
	/// Description of SVNProcess.
	/// </summary>
	public class SVNProcess
	{
		Process process = null;
		Config config;
		public SVNProcess(Config config)
		{
			this.config = config;
		}
		
		public bool Update()
		{
			process = new Process();
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.WorkingDirectory = config.LuminousFortsPath;
			process.StartInfo.FileName = config.SVNPath + "svn";
			process.StartInfo.Arguments = "update";
			process.Start();
			
			process.WaitForExit();
			
			return process.ExitCode == 0;
		}
		
		public void Stop()
		{
			if (process != null)
			{
				process.Kill();
			}
			
			process = null;
		}		
		
		public bool HasExited
		{
			get
			{
				return process == null || process.HasExited;
			}
		}
	}
}
