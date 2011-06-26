/*
 * Created by SharpDevelop.
 * User: hekar
 * Date: 6/26/2011
 * Time: 6:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Windows.Forms;

using LuminousForts_AutoUpdate_Service;
using LuminousForts_AutoUpdate_Shared;

namespace LuminousForts_AutoUpdate_GUI
{
	/// <summary>
	/// Description of SVNUpdater.
	/// </summary>
	public class SVNUpdater
	{
		private SVNProcess svn;
		private HLDSProcess hlds;
		private BackgroundWorker svnWorker;
		private Config config;
		NotifyIcon icon;
		
		public SVNUpdater(Config config, NotifyIcon icon)
		{
			this.icon = icon;
			this.config = config;
			svn = new SVNProcess(config);
			hlds = new HLDSProcess(config);
			InitializeWorker();
		}
		
		private void InitializeWorker()
		{
			svnWorker = new BackgroundWorker();
			svnWorker.DoWork += new DoWorkEventHandler(svnWorker_DoWork);
			svnWorker.ProgressChanged += new ProgressChangedEventHandler(svnWorker_ProgressChanged);
			svnWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(svnWorker_RunWorkerCompleted);
			svnWorker.WorkerReportsProgress = true;
			svnWorker.WorkerSupportsCancellation = true;
		}

		public void Update()
		{
			svnWorker.RunWorkerAsync();
		}
		
		void svnWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			svnWorker.ReportProgress(0);
			if (svn.Update())
			{
				svnWorker.ReportProgress(100);
				e.Result = true;
			}
			else
			{
				svnWorker.ReportProgress(1);
				e.Result = false;
			}
		}
		
		void svnWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			if (e.ProgressPercentage == 1)
			{
				icon.ShowBalloonTip(5, "Failure", "Failure to update LuminousForts (Check your SVN Installation)", ToolTipIcon.Info);
			}
			else if (e.ProgressPercentage < 100)
			{
				icon.ShowBalloonTip(5, "Updating", "Updating to Latest Version of LuminousForts from SVN", ToolTipIcon.Info);
			}
			else
			{
				icon.ShowBalloonTip(5, "Updated", "Update complete", ToolTipIcon.Info);
			}
		}
		
		void svnWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if ((bool)e.Result)
			{
				try
				{
					hlds.Stop();
					hlds.Start();
				}
				catch (Exception ex) 
				{
					MessageBox.Show(ex.Message, "Failed to run HLDS");
				}
			}
		}
	}
}
