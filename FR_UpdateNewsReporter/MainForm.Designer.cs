/*
 * Created by SharpDevelop.
 * User: BITL
 * Date: 3/20/2016
 * Time: 4:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FR_UpdateNewsReporter
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
            if (disposing)
            {
                if (components != null)
                {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CreatePost = new System.Windows.Forms.Button();
            this.MajorUpdate = new System.Windows.Forms.CheckBox();
            this.ChangesBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DiscordBox = new System.Windows.Forms.TextBox();
            this.SDKUpdate = new System.Windows.Forms.CheckBox();
            this.Snapshot = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SnapshotNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date:";
            // 
            // DateLabel
            // 
            this.DateLabel.Location = new System.Drawing.Point(145, 9);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(169, 16);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(56, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name (Optional):";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(145, 25);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(169, 20);
            this.NameBox.TabIndex = 3;
            this.NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(187, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Changes:";
            // 
            // CreatePost
            // 
            this.CreatePost.Location = new System.Drawing.Point(12, 274);
            this.CreatePost.Name = "CreatePost";
            this.CreatePost.Size = new System.Drawing.Size(406, 23);
            this.CreatePost.TabIndex = 8;
            this.CreatePost.Text = "Create Post";
            this.CreatePost.UseVisualStyleBackColor = true;
            this.CreatePost.Click += new System.EventHandler(this.Button1Click);
            // 
            // MajorUpdate
            // 
            this.MajorUpdate.AutoSize = true;
            this.MajorUpdate.Location = new System.Drawing.Point(328, 25);
            this.MajorUpdate.Name = "MajorUpdate";
            this.MajorUpdate.Size = new System.Drawing.Size(90, 17);
            this.MajorUpdate.TabIndex = 9;
            this.MajorUpdate.Text = "Major Update";
            this.MajorUpdate.UseVisualStyleBackColor = true;
            // 
            // ChangesBox
            // 
            this.ChangesBox.Location = new System.Drawing.Point(12, 116);
            this.ChangesBox.Multiline = true;
            this.ChangesBox.Name = "ChangesBox";
            this.ChangesBox.Size = new System.Drawing.Size(406, 152);
            this.ChangesBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(406, 2);
            this.label4.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(56, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Discord Link:";
            // 
            // DiscordBox
            // 
            this.DiscordBox.Location = new System.Drawing.Point(145, 47);
            this.DiscordBox.Name = "DiscordBox";
            this.DiscordBox.Size = new System.Drawing.Size(169, 20);
            this.DiscordBox.TabIndex = 13;
            this.DiscordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SDKUpdate
            // 
            this.SDKUpdate.AutoSize = true;
            this.SDKUpdate.Location = new System.Drawing.Point(328, 49);
            this.SDKUpdate.Name = "SDKUpdate";
            this.SDKUpdate.Size = new System.Drawing.Size(48, 17);
            this.SDKUpdate.TabIndex = 14;
            this.SDKUpdate.Text = "SDK";
            this.SDKUpdate.UseVisualStyleBackColor = true;
            // 
            // Snapshot
            // 
            this.Snapshot.AutoSize = true;
            this.Snapshot.Location = new System.Drawing.Point(328, 72);
            this.Snapshot.Name = "Snapshot";
            this.Snapshot.Size = new System.Drawing.Size(71, 17);
            this.Snapshot.TabIndex = 15;
            this.Snapshot.Text = "Snapshot";
            this.Snapshot.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Snapshot Name";
            // 
            // SnapshotNameBox
            // 
            this.SnapshotNameBox.Location = new System.Drawing.Point(145, 70);
            this.SnapshotNameBox.Name = "SnapshotNameBox";
            this.SnapshotNameBox.Size = new System.Drawing.Size(169, 20);
            this.SnapshotNameBox.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 307);
            this.Controls.Add(this.SnapshotNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Snapshot);
            this.Controls.Add(this.SDKUpdate);
            this.Controls.Add(this.DiscordBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChangesBox);
            this.Controls.Add(this.MajorUpdate);
            this.Controls.Add(this.CreatePost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "FIREFIGHT RELOADED Update News Reporter";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox DiscordBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox MajorUpdate;
        private System.Windows.Forms.Button CreatePost;
        private System.Windows.Forms.TextBox ChangesBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox SDKUpdate;
        private System.Windows.Forms.CheckBox Snapshot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SnapshotNameBox;
    }
}
