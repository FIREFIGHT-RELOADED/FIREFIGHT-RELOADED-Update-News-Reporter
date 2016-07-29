﻿/*
 * Created by SharpDevelop.
 * User: BITL
 * Date: 3/20/2016
 * Time: 4:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FR_UpdateNewsReporter
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			label2.Text = DateTime.Now.ToString("MM-dd-yyyy");		
		}
		
		void Button1Click(object sender, System.EventArgs e)
		{
			string title = "Update for FIREFIGHT RELOADED Released (06-10-1998)";
			
			if (textBox1.Text != "" && checkBox1.Checked != false)
			{
				title = "Major Update for FIREFIGHT RELOADED Released (" + label2.Text + ", " + textBox1.Text + ")";
			}
			else if (textBox1.Text != "")
			{
				title = "Update for FIREFIGHT RELOADED Released (" + label2.Text + ", " + textBox1.Text + ")";
			}
			else if (checkBox1.Checked != false)
			{
				title = "Major Update for FIREFIGHT RELOADED Released (" + label2.Text + ")";
			}
			else
			{
				title = "Update for FIREFIGHT RELOADED Released (" + label2.Text + ")";
			}
			
			string contentstarter = "An update for FIREFIGHT RELOADED has been released. The update will be applied when you restart FIREFIGHT RELOADED.";
			
			if (checkBox1.Checked != false)
			{
				contentstarter = "A major update for FIREFIGHT RELOADED has been released. The update will be applied when you restart FIREFIGHT RELOADED.";
			}
			else
			{
				contentstarter = "An update for FIREFIGHT RELOADED has been released. The update will be applied when you restart FIREFIGHT RELOADED.";
			}
			
			ResultForm btnFm1 = new ResultForm();
			btnFm1.textBox1.Text = title;
			btnFm1.textBox2.Text = contentstarter;
			btnFm1.richTextBox1.Text = richTextBox1.Text;
			btnFm1.Show();
		}
	}
}