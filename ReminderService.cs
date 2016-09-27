using System;

namespace Hydrate
{
    internal class ReminderService
    {
        ReminderWindow reminderWindow = null;
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        public void showReminder()
        {
            reminderWindow = new ReminderWindow();
            reminderWindow.Show();
        }

        public void showReminders()
        {
            showReminder();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 60*60*1000;
            myTimer.Start();
        }

        private void TimerEventProcessor(object sender, EventArgs e)
        {
            showReminder();   
        }


    }
}