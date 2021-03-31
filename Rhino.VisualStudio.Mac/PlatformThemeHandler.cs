﻿using System;
using System.Collections.Generic;
using Eto;
using Eto.Drawing;
using MonoDevelop.Ide.Gui;
using Rhino.VisualStudio;
using Rhino.VisualStudio.Mac;

[assembly: ExportHandler(typeof(IPlatformTheme), typeof(PlatformThemeHandler))]

namespace Rhino.VisualStudio.Mac
{
	public class PlatformThemeHandler : IPlatformTheme
	{
		public Color ProjectBackground => Styles.NewProjectDialog.ProjectConfigurationLeftHandBackgroundColor.ToEto();

		public Color ProjectForeground => Styles.BaseForegroundColor.ToEto();

		public Color ProjectDialogBackground => ProjectBackground; // not used on mac anyway..

		public Color ErrorForeground => Styles.ErrorForegroundColor.ToEto();

		public Color SummaryBackground => Styles.NewProjectDialog.ProjectConfigurationRightHandBackgroundColor.ToEto();

		public Color SummaryForeground => Styles.NewProjectDialog.ProjectConfigurationPreviewLabelColor.ToEto();

		public Color DesignerBackground => Styles.BaseBackgroundColor.ToEto();

		public Color DesignerPanel => Styles.BackgroundColor.ToEto();
	}
}