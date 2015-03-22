using Gtk;

namespace ooplab01
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			new MainWindow ().Show ();
			Application.Run ();
		}
	}	
}
