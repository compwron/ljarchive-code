using System;
using System.Windows.Forms;

namespace EF.ljArchive.WindowsForms
{
	/// <summary>
	/// Summary description for EntryPoint.
	/// </summary>
	public class EntryPoint
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Explorer e = null;
			
			// run internally system invariant to avoid date and decimal weirdness
			Application.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

			if (System.Environment.Version.Major > 1) // .NET 2.0 XP styles
				System.Windows.Forms.Application.EnableVisualStyles();
#if DEBUG
			e = new Explorer();
			Application.Run(e);
#else
			try
			{
				e = new Explorer();
				Application.Run(e);
			}
			catch (Exception ex)
			{
				Dialogs.GeneralError.Go("ljArchive encountered the following fatal error: " + ex.ToString(), null);
			}
#endif
			if (e != null && e.UpdateRequested)
				System.Diagnostics.Process.Start(System.IO.Path.Combine(Application.StartupPath, _updateFileName));
		}

		private const string _updateFileName = "Update.exe";
	}
}
