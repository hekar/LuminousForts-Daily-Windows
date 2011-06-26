/*
 * Created by SharpDevelop.
 * User: hekar
 * Date: 6/26/2011
 * Time: 2:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LuminousForts_AutoUpdate_GUI
{
	/// <summary>
	/// Description of EditItem.
	/// </summary>
	public partial class EditItem : Form
	{
		public EditItem()
		{
			InitializeComponent();
		}
		
		void OkayClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}
		
		void CancelClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
		
		public string Key
		{
			get { return key.Text; }
			set { key.Text = value; }
		}
		
		public string Value
		{
			get { return this.value.Text; }
			set { this.value.Text = value; }
		}
	}
}
