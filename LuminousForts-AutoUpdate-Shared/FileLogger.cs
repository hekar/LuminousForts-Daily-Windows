/*
 * Created by SharpDevelop.
 * User: hekar
 * Date: 7/17/2011
 * Time: 1:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace LuminousForts_AutoUpdate_Shared
{
	/// <summary>
	/// Description of FileLogger.
	/// </summary>
	public class FileLogger
	{
		private static FileLogger instance = null;
		public static FileLogger Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new FileLogger();
				}
				
				return instance;
			}
		}
		
		private string logFile = "log.txt";
		public FileLogger()
		{
		}
		
		public FileLogger(string logFile)
		{
			this.logFile = logFile;
		}
		
		public void Write(string message)
		{
			try
			{
				StreamWriter writer = new StreamWriter(logFile, true);
				writer.WriteLine(DateTime.Now.ToString() + ":" + message);
				writer.Close();
			}
			catch (IOException)
			{
				Console.WriteLine(message);
			}
		}
	}
}
