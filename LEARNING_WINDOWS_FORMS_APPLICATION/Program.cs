﻿namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	static class Program
	{
		[System.STAThread]
		static void Main()
		{
			// **************************************************
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			// **************************************************

			// **************************************************
			MainForm frmMain = new MainForm();

			System.Windows.Forms.Application.Run(frmMain);

			if (frmMain != null)
			{
				if (frmMain.IsDisposed == false)
				{
					frmMain.Dispose();
				}

				frmMain = null;
			}
			// **************************************************
		}
	}
}
