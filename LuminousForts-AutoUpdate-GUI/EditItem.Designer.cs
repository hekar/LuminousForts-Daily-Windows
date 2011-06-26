/*
 * Created by SharpDevelop.
 * User: hekar
 * Date: 6/26/2011
 * Time: 2:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LuminousForts_AutoUpdate_GUI
{
	partial class EditItem
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
			this.keyLabel = new System.Windows.Forms.Label();
			this.valueLabel = new System.Windows.Forms.Label();
			this.key = new System.Windows.Forms.TextBox();
			this.value = new System.Windows.Forms.TextBox();
			this.okay = new System.Windows.Forms.Button();
			this.cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// keyLabel
			// 
			this.keyLabel.Location = new System.Drawing.Point(12, 9);
			this.keyLabel.Name = "keyLabel";
			this.keyLabel.Size = new System.Drawing.Size(100, 23);
			this.keyLabel.TabIndex = 0;
			this.keyLabel.Text = "Key";
			// 
			// valueLabel
			// 
			this.valueLabel.Location = new System.Drawing.Point(12, 45);
			this.valueLabel.Name = "valueLabel";
			this.valueLabel.Size = new System.Drawing.Size(100, 23);
			this.valueLabel.TabIndex = 1;
			this.valueLabel.Text = "Value";
			// 
			// key
			// 
			this.key.Enabled = false;
			this.key.Location = new System.Drawing.Point(118, 12);
			this.key.Name = "key";
			this.key.Size = new System.Drawing.Size(252, 22);
			this.key.TabIndex = 2;
			// 
			// value
			// 
			this.value.Location = new System.Drawing.Point(118, 46);
			this.value.Name = "value";
			this.value.Size = new System.Drawing.Size(252, 22);
			this.value.TabIndex = 3;
			// 
			// okay
			// 
			this.okay.Location = new System.Drawing.Point(207, 102);
			this.okay.Name = "okay";
			this.okay.Size = new System.Drawing.Size(89, 34);
			this.okay.TabIndex = 4;
			this.okay.Text = "&OK";
			this.okay.UseVisualStyleBackColor = true;
			this.okay.Click += new System.EventHandler(this.OkayClick);
			// 
			// cancel
			// 
			this.cancel.Location = new System.Drawing.Point(302, 102);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(89, 34);
			this.cancel.TabIndex = 5;
			this.cancel.Text = "&Cancel";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.CancelClick);
			// 
			// EditItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 148);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.okay);
			this.Controls.Add(this.value);
			this.Controls.Add(this.key);
			this.Controls.Add(this.valueLabel);
			this.Controls.Add(this.keyLabel);
			this.Name = "EditItem";
			this.Text = "EditItem";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.Button okay;
		private System.Windows.Forms.TextBox value;
		private System.Windows.Forms.TextBox key;
		private System.Windows.Forms.Label valueLabel;
		private System.Windows.Forms.Label keyLabel;
	}
}
