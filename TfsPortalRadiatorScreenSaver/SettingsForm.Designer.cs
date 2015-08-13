namespace TfsPortalRadiatorScreenSaver
{
	partial class SettingsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCollection = new System.Windows.Forms.TextBox();
			this.txtProject = new System.Windows.Forms.TextBox();
			this.txtHostName = new System.Windows.Forms.TextBox();
			this.txtPortNumber = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.chkFeatures = new System.Windows.Forms.CheckBox();
			this.chkBacklog = new System.Windows.Forms.CheckBox();
			this.chkTasks = new System.Windows.Forms.CheckBox();
			this.chkBuilds = new System.Windows.Forms.CheckBox();
			this.chkPortal = new System.Windows.Forms.CheckBox();
			this.chkSpintGoal = new System.Windows.Forms.CheckBox();
			this.chkVelocity = new System.Windows.Forms.CheckBox();
			this.chkBurndown = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cmdOK = new System.Windows.Forms.Button();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txtGoals = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "TFS Collection";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "TFS Project";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "TFS Server name";
			// 
			// txtCollection
			// 
			this.txtCollection.Location = new System.Drawing.Point(136, 68);
			this.txtCollection.Name = "txtCollection";
			this.txtCollection.Size = new System.Drawing.Size(162, 20);
			this.txtCollection.TabIndex = 2;
			this.txtCollection.Text = "ApdCollection";
			// 
			// txtProject
			// 
			this.txtProject.Location = new System.Drawing.Point(136, 94);
			this.txtProject.Name = "txtProject";
			this.txtProject.Size = new System.Drawing.Size(162, 20);
			this.txtProject.TabIndex = 3;
			this.txtProject.Text = "APD Agile";
			// 
			// txtHostName
			// 
			this.txtHostName.Location = new System.Drawing.Point(136, 14);
			this.txtHostName.Name = "txtHostName";
			this.txtHostName.Size = new System.Drawing.Size(162, 20);
			this.txtHostName.TabIndex = 0;
			this.txtHostName.Text = "tfs";
			// 
			// txtPortNumber
			// 
			this.txtPortNumber.Location = new System.Drawing.Point(136, 42);
			this.txtPortNumber.MaxLength = 5;
			this.txtPortNumber.Name = "txtPortNumber";
			this.txtPortNumber.Size = new System.Drawing.Size(162, 20);
			this.txtPortNumber.TabIndex = 1;
			this.txtPortNumber.Text = "8080";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 45);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "TFS Server port number";
			// 
			// chkFeatures
			// 
			this.chkFeatures.AutoSize = true;
			this.chkFeatures.Location = new System.Drawing.Point(136, 120);
			this.chkFeatures.Name = "chkFeatures";
			this.chkFeatures.Size = new System.Drawing.Size(67, 17);
			this.chkFeatures.TabIndex = 4;
			this.chkFeatures.Text = "Features";
			this.chkFeatures.UseVisualStyleBackColor = true;
			// 
			// chkBacklog
			// 
			this.chkBacklog.AutoSize = true;
			this.chkBacklog.Checked = true;
			this.chkBacklog.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkBacklog.Location = new System.Drawing.Point(223, 120);
			this.chkBacklog.Name = "chkBacklog";
			this.chkBacklog.Size = new System.Drawing.Size(65, 17);
			this.chkBacklog.TabIndex = 5;
			this.chkBacklog.Text = "Backlog";
			this.chkBacklog.UseVisualStyleBackColor = true;
			// 
			// chkTasks
			// 
			this.chkTasks.AutoSize = true;
			this.chkTasks.Checked = true;
			this.chkTasks.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkTasks.Location = new System.Drawing.Point(309, 120);
			this.chkTasks.Name = "chkTasks";
			this.chkTasks.Size = new System.Drawing.Size(81, 17);
			this.chkTasks.TabIndex = 6;
			this.chkTasks.Text = "Task Board";
			this.chkTasks.UseVisualStyleBackColor = true;
			// 
			// chkBuilds
			// 
			this.chkBuilds.AutoSize = true;
			this.chkBuilds.Checked = true;
			this.chkBuilds.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkBuilds.Location = new System.Drawing.Point(396, 120);
			this.chkBuilds.Name = "chkBuilds";
			this.chkBuilds.Size = new System.Drawing.Size(54, 17);
			this.chkBuilds.TabIndex = 7;
			this.chkBuilds.Text = "Builds";
			this.chkBuilds.UseVisualStyleBackColor = true;
			// 
			// chkPortal
			// 
			this.chkPortal.AutoSize = true;
			this.chkPortal.Checked = true;
			this.chkPortal.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkPortal.Location = new System.Drawing.Point(467, 120);
			this.chkPortal.Name = "chkPortal";
			this.chkPortal.Size = new System.Drawing.Size(81, 17);
			this.chkPortal.TabIndex = 8;
			this.chkPortal.Text = "Portal Page";
			this.chkPortal.UseVisualStyleBackColor = true;
			// 
			// chkSpintGoal
			// 
			this.chkSpintGoal.AutoSize = true;
			this.chkSpintGoal.Checked = true;
			this.chkSpintGoal.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkSpintGoal.Location = new System.Drawing.Point(136, 143);
			this.chkSpintGoal.Name = "chkSpintGoal";
			this.chkSpintGoal.Size = new System.Drawing.Size(78, 17);
			this.chkSpintGoal.TabIndex = 9;
			this.chkSpintGoal.Text = "Sprint Goal";
			this.chkSpintGoal.UseVisualStyleBackColor = true;
			// 
			// chkVelocity
			// 
			this.chkVelocity.AutoSize = true;
			this.chkVelocity.Enabled = false;
			this.chkVelocity.Location = new System.Drawing.Point(223, 143);
			this.chkVelocity.Name = "chkVelocity";
			this.chkVelocity.Size = new System.Drawing.Size(63, 17);
			this.chkVelocity.TabIndex = 10;
			this.chkVelocity.Text = "Velocity";
			this.chkVelocity.UseVisualStyleBackColor = true;
			// 
			// chkBurndown
			// 
			this.chkBurndown.AutoSize = true;
			this.chkBurndown.Enabled = false;
			this.chkBurndown.Location = new System.Drawing.Point(309, 143);
			this.chkBurndown.Name = "chkBurndown";
			this.chkBurndown.Size = new System.Drawing.Size(74, 17);
			this.chkBurndown.TabIndex = 11;
			this.chkBurndown.Text = "Burndown";
			this.chkBurndown.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "Pages To Show";
			// 
			// cmdOK
			// 
			this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.cmdOK.Location = new System.Drawing.Point(457, 284);
			this.cmdOK.Name = "cmdOK";
			this.cmdOK.Size = new System.Drawing.Size(75, 23);
			this.cmdOK.TabIndex = 16;
			this.cmdOK.Text = "OK";
			this.cmdOK.UseVisualStyleBackColor = true;
			this.cmdOK.Click += new System.EventHandler(this.CmdOK_Click);
			// 
			// cmdCancel
			// 
			this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdCancel.Location = new System.Drawing.Point(538, 284);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(75, 23);
			this.cmdCancel.TabIndex = 17;
			this.cmdCancel.Text = "Cancel";
			this.cmdCancel.UseVisualStyleBackColor = true;
			this.cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 190);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 13);
			this.label6.TabIndex = 19;
			this.label6.Text = "Sprint Goals";
			// 
			// txtGoals
			// 
			this.txtGoals.AcceptsReturn = true;
			this.txtGoals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtGoals.Location = new System.Drawing.Point(135, 190);
			this.txtGoals.Multiline = true;
			this.txtGoals.Name = "txtGoals";
			this.txtGoals.Size = new System.Drawing.Size(478, 88);
			this.txtGoals.TabIndex = 15;
			this.txtGoals.Text = "Be excellent to each other\r\nParty on dude\r\nAlways know where your towel is";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 166);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(87, 13);
			this.label7.TabIndex = 22;
			this.label7.Text = "Project Template";
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Enabled = false;
			this.radioButton3.Location = new System.Drawing.Point(309, 166);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(53, 17);
			this.radioButton3.TabIndex = 14;
			this.radioButton3.Text = "CMMI";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Checked = true;
			this.radioButton2.Location = new System.Drawing.Point(223, 166);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(48, 17);
			this.radioButton2.TabIndex = 13;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Agile";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(136, 166);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(64, 17);
			this.radioButton1.TabIndex = 12;
			this.radioButton1.Text = "SCRUM";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// settingsBindingSource
			// 
			this.settingsBindingSource.DataSource = typeof(TfsPortalRadiatorScreenSaver.Settings);
			// 
			// SettingsForm
			// 
			this.AcceptButton = this.cmdOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cmdCancel;
			this.ClientSize = new System.Drawing.Size(625, 319);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtGoals);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdOK);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.chkBurndown);
			this.Controls.Add(this.chkVelocity);
			this.Controls.Add(this.chkSpintGoal);
			this.Controls.Add(this.chkPortal);
			this.Controls.Add(this.chkBuilds);
			this.Controls.Add(this.chkTasks);
			this.Controls.Add(this.chkBacklog);
			this.Controls.Add(this.chkFeatures);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtPortNumber);
			this.Controls.Add(this.txtHostName);
			this.Controls.Add(this.txtProject);
			this.Controls.Add(this.txtCollection);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "SettingsForm";
			this.Text = "SettingsForm";
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCollection;
		private System.Windows.Forms.TextBox txtProject;
		private System.Windows.Forms.TextBox txtHostName;
		private System.Windows.Forms.TextBox txtPortNumber;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox chkFeatures;
		private System.Windows.Forms.CheckBox chkBacklog;
		private System.Windows.Forms.CheckBox chkTasks;
		private System.Windows.Forms.CheckBox chkBuilds;
		private System.Windows.Forms.CheckBox chkPortal;
		private System.Windows.Forms.CheckBox chkSpintGoal;
		private System.Windows.Forms.CheckBox chkVelocity;
		private System.Windows.Forms.CheckBox chkBurndown;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button cmdOK;
		private System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.BindingSource settingsBindingSource;
		private System.Windows.Forms.TextBox txtGoals;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
	}
}