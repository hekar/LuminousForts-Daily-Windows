/*
 * Created by SharpDevelop.
 * User: hekar
 * Date: 6/26/2011
 * Time: 1:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LuminousForts_AutoUpdate_GUI
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.forceUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configTable = new System.Windows.Forms.ListView();
			this.Key = new System.Windows.Forms.ColumnHeader();
			this.Value = new System.Windows.Forms.ColumnHeader();
			this.icon = new System.Windows.Forms.NotifyIcon(this.components);
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.toolsToolStripMenuItem,
									this.aboutToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(728, 26);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.reloadToolStripMenuItem,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 22);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// reloadToolStripMenuItem
			// 
			this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
			this.reloadToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.reloadToolStripMenuItem.Text = "Reload";
			this.reloadToolStripMenuItem.Click += new System.EventHandler(this.ReloadToolStripMenuItemClick);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.forceUpdateToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(55, 22);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// forceUpdateToolStripMenuItem
			// 
			this.forceUpdateToolStripMenuItem.Name = "forceUpdateToolStripMenuItem";
			this.forceUpdateToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.forceUpdateToolStripMenuItem.Text = "Force Update";
			this.forceUpdateToolStripMenuItem.Click += new System.EventHandler(this.ForceUpdateToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.helpToolStripMenuItem});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// configTable
			// 
			this.configTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Key,
									this.Value});
			this.configTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.configTable.FullRowSelect = true;
			this.configTable.Location = new System.Drawing.Point(0, 26);
			this.configTable.Name = "configTable";
			this.configTable.Size = new System.Drawing.Size(728, 403);
			this.configTable.TabIndex = 1;
			this.configTable.UseCompatibleStateImageBehavior = false;
			this.configTable.View = System.Windows.Forms.View.Details;
			this.configTable.SelectedIndexChanged += new System.EventHandler(this.ConfigTableSelectedIndexChanged);
			this.configTable.DoubleClick += new System.EventHandler(this.ConfigTableDoubleClick);
			// 
			// Key
			// 
			this.Key.Text = "Key";
			this.Key.Width = 240;
			// 
			// Value
			// 
			this.Value.Text = "Value";
			this.Value.Width = 450;
			// 
			// icon
			// 
			this.icon.Icon = ((System.Drawing.Icon)(resources.GetObject("icon.Icon")));
			this.icon.Text = "icon";
			this.icon.Visible = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(728, 429);
			this.Controls.Add(this.configTable);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.Text = "LuminousForts AutoUpdater";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem forceUpdateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon icon;
		private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ListView configTable;
		private System.Windows.Forms.ColumnHeader Value;
		private System.Windows.Forms.ColumnHeader Key;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
	}
}
