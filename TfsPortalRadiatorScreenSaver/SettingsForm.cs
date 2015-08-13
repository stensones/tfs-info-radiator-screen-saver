namespace TfsPortalRadiatorScreenSaver
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.Linq;
	using System.Text;
	using System.Windows.Forms;

	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			this.InitializeComponent();
		}

		public Settings Settings { get; private set; }

		private void SettingsForm_Load(object sender, EventArgs e)
		{
			this.Settings = new Settings();
			this.Settings.LoadSettings();
			this.UpdateDisplay();
		}

		private void CmdCancel_Click(object sender, EventArgs e)
		{
			this.Settings.LoadSettings();
			this.UpdateDisplay();
			this.Close();
		}

		private void CmdOK_Click(object sender, EventArgs e)
		{
			this.WriteSettingsFromUi();
			this.Settings.SaveSettings();
			this.Close();
		}

		private void UpdateDisplay()
		{
			this.txtCollection.Text = this.Settings.ColectionName;
			this.txtProject.Text = this.Settings.ProjectName;
			this.txtHostName.Text = this.Settings.TfsServerName;
			this.txtPortNumber.Text = this.Settings.TfsPortNumber.ToString();

			this.chkBacklog.Checked = this.Settings.ShowBacklog;
			this.chkBuilds.Checked = this.Settings.ShowBuilds;
			this.chkBurndown.Checked = this.Settings.ShowBurndown;
			this.chkFeatures.Checked = this.Settings.ShowFeatures;
			this.chkPortal.Checked = this.Settings.ShowPortalPage;
			this.chkSpintGoal.Checked = this.Settings.ShowSprintGoal;
			this.chkTasks.Checked = this.Settings.ShowTaskBoard;
			this.chkVelocity.Checked = this.Settings.ShowVelocity;

			this.txtGoals.Text = string.Empty;
			foreach (var line in this.Settings.SprintGoals)
			{
				this.txtGoals.Text += line + "\r\n";
			}
		}

		private void WriteSettingsFromUi()
		{
			this.Settings.ColectionName = this.txtCollection.Text;
			this.Settings.ProjectName = this.txtProject.Text;
			this.Settings.TfsServerName = this.txtHostName.Text;
			this.Settings.TfsPortNumber = ushort.Parse(this.txtPortNumber.Text);
			
			this.Settings.ShowBacklog = this.chkBacklog.Checked;
			this.Settings.ShowBuilds = this.chkBuilds.Checked;
			this.Settings.ShowBurndown = this.chkBurndown.Checked;
			this.Settings.ShowFeatures = this.chkFeatures.Checked;
			this.Settings.ShowPortalPage = this.chkPortal.Checked;
			this.Settings.ShowSprintGoal = this.chkSpintGoal.Checked;
			this.Settings.ShowTaskBoard = this.chkTasks.Checked;
			this.Settings.ShowVelocity = this.chkVelocity.Checked;

			this.Settings.SprintGoals.Clear();
			foreach (var item in this.txtGoals.Lines)
			{
				this.Settings.SprintGoals.Add(item);
			}
		}
	}
}
