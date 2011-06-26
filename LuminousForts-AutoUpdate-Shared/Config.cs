/*
 * Created by SharpDevelop.
 * User: hekar
 * Date: 6/26/2011
 * Time: 2:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace LuminousForts_AutoUpdate_Shared
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class Config
	{
		private string ConfigFile = "config.txt";
		Dictionary<String, String> props;
		public Config()
		{
			props = new Dictionary<string, string>();
		}
		
		public void LoadConfig()
		{
			StreamReader reader = new StreamReader(ConfigFile);
			string config = reader.ReadToEnd();
			reader.Close();
			
			foreach (string line in config.Split('\n'))
			{
				String[] pair = line.Split(":".ToCharArray(), 2, StringSplitOptions.None);
			    
		     	if (!props.ContainsKey(pair[0]))
		     	{
		     		if (pair.Length >= 2)
		     		{
		     			props.Add(pair[0].Trim(), pair[1].Trim());
		     		}
		     		else if (pair.Length == 1)
		     		{
		     			props.Add(pair[0].Trim(), "");
		     		}
		     	}
			}
			
			props["svn_path"] = SVNPath;
			props["game_folder"] = LuminousFortsPath;
			props["hlds_workdir"] = HLDSWorkDir;
		}
		
		public void WriteConfig()
		{
			StreamWriter writer = new StreamWriter(ConfigFile);
			foreach (KeyValuePair<string,string> pair in props)
			{
				writer.WriteLine(pair.Key + ":" + pair.Value);
			}
			writer.Close();
		}

		private static string AddDirectoryEnding(string path)
		{
			string fixedPath = path.Replace('\\', Path.DirectorySeparatorChar).Replace('/', Path.DirectorySeparatorChar);
			if (!fixedPath.EndsWith(Path.DirectorySeparatorChar.ToString()))
			{
				fixedPath += Path.DirectorySeparatorChar;
			}
			
			return fixedPath;
		}
		
		public string SVNPath
		{
			get
			{
				return AddDirectoryEnding(props["svn_path"]);
			}
		}
		
		public string LuminousFortsPath
		{
			get
			{
				return AddDirectoryEnding(props["game_folder"]);
			}
		}
		
		public string HLDSCommand
		{
			get
			{
				return props["hlds_command"];
			}
		}
		
		public string HLDSWorkDir
		{
			get
			{
				return AddDirectoryEnding(props["hlds_workdir"]);
			}
		}

		public int UpdateInterval
		{
			get
			{
				return int.Parse(props["update_interval"]);
			}
		}		
		
		public Dictionary<string, string> Properties
		{
			get { return props; }
			set { props = value; }
		}
	}
}