﻿/*
 * Created by SharpDevelop.
 * User: hekar
 * Date: 6/26/2011
 * Time: 6:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;

namespace LuminousForts_AutoUpdate_Shared
{
	/// <summary>
	/// Description of HLDSProcess.
	/// </summary>
	public class HLDSProcess
	{
		Config config;
		Process process = null;
		public HLDSProcess(Config config)
		{
			this.config = config;
		}
		
		public bool Start()
		{
			process = new Process();
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.WorkingDirectory = config.HLDSWorkDir;
			string[] argv = config.HLDSCommand.Split(' ');
			process.StartInfo.FileName = argv[0];
			String args = "";
			for (int i = 1; i < argv.Length; i++)
			{
				args += argv[i];
			}
			process.StartInfo.Arguments = args;
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
