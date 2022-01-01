using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace GtkDateTimePicker
{
     partial class DateDialog : Dialog
    {
        
        [UI] private Gtk.Button cancelBtn = null;
        [UI] private Gtk.Button okBtn = null;
        [UI] private Gtk.Calendar dateCalendar = null;
        [UI] private Gtk.SpinButton hoursBtn = null;
        [UI] private Gtk.SpinButton minitusBtn = null;
        
        public DateDialog() : this(new Builder("DateDialog.glade"))
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

        private DateDialog(Builder builder) : base(builder.GetRawOwnedObject("DateDialog"))
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