﻿using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace GtkDateTimePicker
{
    public partial class MainWindow2 : Window
    {
        //[UI] private Gtk.Window historyWindow = null;
        [UI] private Gtk.Button openBtn = null;
        
        public MainWindow2() : this(new Builder("MainWindow2.glade"))
        {
        }

        private MainWindow2(Builder builder) : base(builder.GetRawOwnedObject("MainWindow2"))
        {
            builder.Autoconnect(this);
            DeleteEvent += Window_DeleteEvent;
        }                

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }
        
        private void on_openBtn_clicked(object sender , EventArgs e)
        {
			
            MainDialog MainDialog1 = new MainDialog();
            
            MainDialog1.DateTimeObj = DateTime.Now;
            
            var r = MainDialog1.Run();

            Console.WriteLine(r);
            if (r == 1)
            {
                Console.WriteLine(MainDialog1.DateTimeObj);
            }

        }
        
        

    }
}