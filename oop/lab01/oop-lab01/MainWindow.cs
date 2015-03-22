using Gtk;
using System;

namespace ooplab01
{

	public partial class MainWindow: Window
	{
		string nameInputText;
		string governmentFormInputText;
		string squareInputText;

		public MainWindow () : base (WindowType.Toplevel)
		{
			Build ();
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}

		protected void OnMakeObjectClicked (object sender, EventArgs a)
		{
			getEntriesText ();

			Country country = new Country.CountryBuilder ()
			.Name (nameInputText)
			.GovernmentForm (governmentFormInputText)
			.Square (squareInputText)
			.Build ();

			ShowMessageBox ("Object created at address: " + country.GetHashCode ());
		}

		void getEntriesText ()
		{
			nameInputText = nameInput.Text;
			governmentFormInputText = governmentFormInput.Text;
			squareInputText = squareInput.Text;
		}

		public static void ShowMessageBox (string text)
		{
			var messageDialog = new MessageDialog (null,
				                   DialogFlags.Modal,
				                   MessageType.Info,
				                   ButtonsType.Ok,
				                   text);
			messageDialog.Run ();
			messageDialog.Destroy ();
		}

		protected void OnMakeCopyButtonClicked (object sender, EventArgs e)
		{
			getEntriesText ();

			Country country = new Country (nameInputText, governmentFormInputText, squareInputText);
			Country countryCopy = new Country (country);

			ShowMessageBox ("Object created from copy at address: " + countryCopy.GetHashCode ());
		}
	}
}