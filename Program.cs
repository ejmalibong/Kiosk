using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackCoffeeLibrary;
using Kiosk.Class;

namespace Kiosk
{
    static class Program
    {
        // Unique name for your app's mutex
        private static readonly string mutexName = "KioskApp_UniqueMutex";

        // WinAPI imports to find and activate the existing window
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_RESTORE = 9;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isNewInstance;
            using (Mutex mutex = new Mutex(true, mutexName, out isNewInstance))
            {
                if (!isNewInstance)
                {
                    // Bring the existing window to front
                    // Make sure the window title here matches your Main form's Text property
                    IntPtr hWnd = FindWindow(null, "Kiosk"); // Replace "Kiosk" with your actual window title

                    if (hWnd != IntPtr.Zero)
                    {
                        ShowWindow(hWnd, SW_RESTORE);
                        SetForegroundWindow(hWnd);
                    }

                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main());
            }
        }
    }
}
