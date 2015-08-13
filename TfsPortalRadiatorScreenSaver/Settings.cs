namespace TfsPortalRadiatorScreenSaver
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Microsoft.Win32;

	public class Settings
	{
		private const string ScreensSaverRegistryKey = "Software\\APD Communications\\TFS Information Radiator Screen Saver";

		public string TfsServerName { get; set; }

		public ushort TfsPortNumber { get; set; }

		public string ColectionName { get; set; }

		public string ProjectName { get; set; }

		public bool ShowFeatures { get; set; }

		public bool ShowBacklog { get; set; }

		public bool ShowTaskBoard { get; set; }

		public bool ShowBuilds { get; set; }

		public bool ShowPortalPage{ get; set; }

		public bool ShowSprintGoal { get; set; }

		public bool ShowVelocity { get; set; }

		public bool ShowBurndown { get; set; }

		public bool TemplteIsScrum { get; set; }

		public IList<string> SprintGoals { get; private set; }

		public Settings()
		{
			this.SprintGoals = new List<string>();
		}

		public void SaveSettings()
		{
			using (var key = Registry.CurrentUser.CreateSubKey(ScreensSaverRegistryKey))
			{
				if (key != null)
				{
					key.SetValue("TfsServerName", this.TfsServerName, RegistryValueKind.String);
					key.SetValue("TfsPortNumber", this.TfsPortNumber, RegistryValueKind.DWord);
					key.SetValue("ColectionName", this.ColectionName, RegistryValueKind.String);
					key.SetValue("ProjectName", this.ProjectName, RegistryValueKind.String);

					key.SetValue("ShowBacklog", this.ShowBacklog, RegistryValueKind.DWord);
					key.SetValue("ShowBuilds", this.ShowBuilds, RegistryValueKind.DWord);
					key.SetValue("ShowBurndown", this.ShowBurndown, RegistryValueKind.DWord);
					key.SetValue("ShowFeatures", this.ShowFeatures, RegistryValueKind.DWord);
					key.SetValue("ShowPortalPage", this.ShowPortalPage, RegistryValueKind.DWord);
					key.SetValue("ShowSprintGoal", this.ShowSprintGoal, RegistryValueKind.DWord);
					key.SetValue("ShowTaskBoard", this.ShowTaskBoard, RegistryValueKind.DWord);
					key.SetValue("ShowVelocity", this.ShowVelocity, RegistryValueKind.DWord);
					key.SetValue("TemplteIsScrum", this.TemplteIsScrum, RegistryValueKind.DWord);
					
					key.SetValue("SprintGoals", this.SprintGoals.ToArray(), RegistryValueKind.MultiString);
				}
			}
		}

		public void LoadSettings()
		{
			using (var key = Registry.CurrentUser.OpenSubKey(ScreensSaverRegistryKey))
			{
				if (key != null)
				{
					object readValue;

					this.TfsServerName = (string)key.GetValue("TfsServerName", "TFS");

					readValue = key.GetValue("TfsPortNumber", (ushort)8080);
					this.TfsPortNumber = Convert.ToUInt16(readValue);

					this.ColectionName = (string)key.GetValue("ColectionName", "APDCollection");

					this.ProjectName = (string)key.GetValue("ProjectName", "APD%20Agile");

					readValue = key.GetValue("ShowBacklog", true);
					this.ShowBacklog = Convert.ToBoolean(readValue);

					readValue = key.GetValue("ShowBuilds", true);
					this.ShowBuilds = Convert.ToBoolean(readValue);

					readValue = key.GetValue("ShowBurndown", false);
					this.ShowBurndown = Convert.ToBoolean(readValue);

					readValue = key.GetValue("ShowFeatures", false);
					this.ShowFeatures = Convert.ToBoolean(readValue);

					readValue = key.GetValue("ShowPortalPage", true);
					this.ShowPortalPage = Convert.ToBoolean(readValue);

					readValue = key.GetValue("ShowSprintGoal", true);
					this.ShowSprintGoal = Convert.ToBoolean(readValue);

					readValue = key.GetValue("ShowTaskBoard", true);
					this.ShowTaskBoard = Convert.ToBoolean(readValue);

					readValue = key.GetValue("ShowVelocity", false);
					this.ShowVelocity = Convert.ToBoolean(readValue);

					readValue = key.GetValue("TemplteIsScrum", false);
					this.TemplteIsScrum = Convert.ToBoolean(readValue);

					readValue = (string[])key.GetValue("SprintGoals", new string[] { "What is the ultimate answer?" });
					foreach (var item in (string[])readValue)
					{
						this.SprintGoals.Add(item);
					}
				}
				else
				{
					this.TfsServerName = "TFS";
					this.TfsPortNumber = 8080;
					this.ColectionName = "APDCollection";
					this.ProjectName = "APD%20Agile";
					this.ShowBacklog = true;
					this.ShowBuilds = true;
					this.ShowBurndown = false;
					this.ShowFeatures = false;
					this.ShowPortalPage = false;
					this.ShowSprintGoal = true;
					this.ShowTaskBoard = true;
					this.ShowVelocity = false;
					this.TemplteIsScrum = false;	// if not SCRUM we assume Agile.
					this.SprintGoals = new List<string> { "No one set a theme" };
				}
			}
		}
	}
}
