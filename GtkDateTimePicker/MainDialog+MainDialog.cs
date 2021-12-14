using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace GtkDateTimePicker
{
    partial class MainDialog
    {
    
		private void on_cancelBtn_clicked(object sender , EventArgs e){
			this.Destroy();
		}
		
		private void on_okBtn_clicked(object sender , EventArgs e){
			this.Destroy();
		}
		
    }
}
