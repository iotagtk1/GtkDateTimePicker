using System;
using Gtk;

namespace GtkDateTimePicker
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.Init();

            var app = new Application("org.GtkDateTimePicker.GtkDateTimePicker", GLib.ApplicationFlags.None);
            app.Register(GLib.Cancellable.Current);

            var win = new MainWindow2();
            app.AddWindow(win);

            win.Show();
            Application.Run();
        }
    }
}
