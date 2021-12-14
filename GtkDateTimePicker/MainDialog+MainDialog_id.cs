using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace GtkDateTimePicker
{
    partial class MainDialog
    {

		//[UI] private Gtk.Dialog MainWindow = null;
		[UI] private Gtk.Button cancelBtn = null;
		[UI] private Gtk.Button okBtn = null;
		[UI] private Gtk.Calendar dateCalendar = null;
		[UI] private Gtk.SpinButton hoursBtn = null;
		[UI] private Gtk.SpinButton minitusBtn = null;
	}
}
