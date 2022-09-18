/*
 * Created by SharpDevelop.
 * User: BITL
 * Date: 3/20/2016
 * Time: 4:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
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
			DateLabel.Text = DateTime.Now.ToString("MM-dd-yyyy");
		}

		void Button1Click(object sender, System.EventArgs e)
		{
			string gameName = "FIREFIGHT RELOADED";

			if (SDKUpdate.Checked)
			{
				gameName += "'s SDK";
			}
			
			if (Snapshot.Checked)
			{
				string snapshotName = (!string.IsNullOrWhiteSpace(SnapshotNameBox.Text) ? SnapshotNameBox.Text : "Snapshot");
				if (SDKUpdate.Checked)
				{
					gameName += " " + snapshotName;
				}
				else
				{
					gameName += "'s " + snapshotName;
				}
			}

			string title = "";

			if (MajorUpdate.Checked)
            {
				title += "Major Update for ";
			}
			else
            {
				title += "Update for ";
			}

			title += gameName + " Released (" + DateLabel.Text + 
				((!string.IsNullOrWhiteSpace(NameBox.Text)) ? ", " + NameBox.Text : "") 
				+ ")";

			string content = "";

			if (MajorUpdate.Checked)
			{
				content += "A major update ";
			}
			else
            {
				content += "An update ";
			}

			content += "for " + gameName + " has been released. The update will be applied when you restart " + gameName + ".";
			string discord = "Be sure to join our Discord server at [url]" + DiscordBox.Text + "[/url] for more future updates!";
			content += "\r\n\r\n" + ChangesBox.Text + "\r\n\r\n" + discord;

			ResultForm btnFm1 = new ResultForm();
			btnFm1.TitleBox.Text = title;
			btnFm1.ContentsBox.Text = content;
			btnFm1.Show();
		}
    }
}
