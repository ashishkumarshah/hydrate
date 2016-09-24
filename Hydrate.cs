using System;
using System.Windows.Forms;

namespace Hydrate
{
	/// <summary>
	/// 
	/// </summary>
	static class Hydrate
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// Show the system tray icon.					
			using (SystemTrayIcon systemTrayIcon = new SystemTrayIcon())
			{
				systemTrayIcon.initialize();
                ReminderService reminderService = new ReminderService();
                reminderService.showReminders();
				// Make sure the application runs!
				Application.Run();
			}
		}
	}
}