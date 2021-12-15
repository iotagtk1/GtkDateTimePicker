using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace GtkDateTimePicker
{
     partial class MainDialog : Dialog
    {
        
        [UI] private Gtk.Button cancelBtn = null;
        [UI] private Gtk.Button okBtn = null;
        [UI] private Gtk.Calendar dateCalendar = null;
        [UI] private Gtk.SpinButton hoursBtn = null;
        [UI] private Gtk.SpinButton minitusBtn = null;
        
        public MainDialog() : this(new Builder("MainDialog.glade"))
        {
        
        }
        
        private DateTime _dateTimeObj;
        public DateTime DateTimeObj
        {
            get
            {
                DateTime _dateTimeObj = new DateTime(dateCalendar.Year, dateCalendar.Month, dateCalendar.Day, hoursBtn.ValueAsInt, minitusBtn.ValueAsInt, 0, 0);
                return _dateTimeObj;
            }
            set
            {
                _dateTimeObj = value;
                dateCalendar.Date = _dateTimeObj;
                hoursBtn.Value = value.Hour;
                minitusBtn.Value = value.Minute;
            }
        }
        
        private void on_cancelBtn_clicked(object sender , EventArgs e){
            this.Destroy();
        }
		
        private void on_okBtn_clicked(object sender , EventArgs e){
            this.Destroy();
        }

        private MainDialog(Builder builder) : base(builder.GetRawOwnedObject("MainDialog"))
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
        }
        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }

        
    }
}