using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	
	protected void OnBotonClicked (object sender, System.EventArgs e)
	{
		
		if(entry2.Text == "Lourdes" && entry1.Text == "12345")
		{
			MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.None,"Bienvenido! tus datos son correctos");
			md.Show();
		}
		else {
			MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.None,"Datos incorrectos intenta de nuevo");
			md.Show();
		} 
	}
}
