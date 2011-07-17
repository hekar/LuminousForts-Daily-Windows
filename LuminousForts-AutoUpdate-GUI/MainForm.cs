/*
 * Created by SharpDevelop.
 * User: hekar
 * Date: 6/26/2011
 * Time: 1:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LuminousForts_AutoUpdate_Service;
using LuminousForts_AutoUpdate_Shared;

namespace LuminousForts_AutoUpdate_GUI
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private Config config = null;
		private Timer timer;
		private SVNUpdater svnUpdater;
		
		public MainForm()
		{
			InitializeComponent();
			timer = new Timer();
			config = new Config();
			svnUpdater = new SVNUpdater(config, icon);
			icon.DoubleClick += new EventHandler(icon_Click);
			ShowInTaskbar = false;
			Reload();
		}

		private void Reload()
		{
			LoadConfig();
			timer.Stop();
			timer.Interval = config.UpdateInterval * 1000;
			timer.Tick += new EventHandler(timer_Tick);
			timer.Start();
		}
		
		void icon_Click(object sender, EventArgs e)
		{
			if (WindowState != FormWindowState.Minimized)
			{
				WindowState = FormWindowState.Minimized;
			}
			else
			{
				WindowState = FormWindowState.Normal;
			}
		}
		
		public void LoadConfig()
		{
			config.LoadConfig();
			configTable.Items.Clear();
			foreach (KeyValuePair<string,string> pair in config.Properties)
			{
				configTable.Items.Add(new ListViewItem(new string[] {pair.Key, pair.Value}));
			}
		}
		
		void ReloadToolStripMenuItemClick(object sender, EventArgs e)
		{
			Reload();
		}
		
		void ForceUpdateToolStripMenuItemClick(object sender, EventArgs e)
		{
			svnUpdater.Update();
		}		
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		ListViewItem selected = null;
		void ConfigTableSelectedIndexChanged(object sender, EventArgs e)
		{
			if (configTable.SelectedItems.Count > 0)
			{
				selected = configTable.SelectedItems[0];
			}
		}
		
		void ConfigTableDoubleClick(object sender, EventArgs e)
		{
			if (selected != null)
			{
				EditItem editDlg = new EditItem();
				string key = selected.SubItems[0].Text;
				string value = selected.SubItems[1].Text;
				
				editDlg.Key = key;
				editDlg.Value = value;
				DialogResult result = editDlg.ShowDialog();
				
				if (result == DialogResult.OK)
				{
					selected.SubItems[1].Text = editDlg.Value;
					config.Properties[editDlg.Key] = editDlg.Value;
					config.WriteConfig();
					timer.Interval = config.UpdateInterval;
					Reload();
				}
			}
		}
		
		void timer_Tick(object sender, EventArgs e)
		{
			try 
			{
				svnUpdater.Update();
			}
			catch (Exception)
			{
			}
		}		
	}
}
