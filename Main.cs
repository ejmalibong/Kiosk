using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackCoffeeLibrary;
using Kiosk.Class;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Kiosk
{
    public partial class Main : Form
    {
        private Connection dbConnection = new Connection();
        private BlackCoffeeLibrary.Main dbMain = new BlackCoffeeLibrary.Main();
        private SqlDbMethod dbMethod;

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_RESTORE = 9;

        private Process browserProcess = null;

        private bool isRestoring = false;  // Flag to prevent multiple restore attempts

        public Main()
        {
            InitializeComponent();

            dbMethod = new SqlDbMethod(dbConnection.GetConnectionString());
            this.Resize += new EventHandler(Main_Resize);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                DateTime dateNow = Convert.ToDateTime(dbMethod.GetServerDate());

                lblDate.Text = dateNow.ToString("MMM dd, yyyy");
                lblTime.Text = dateNow.ToString("hh:mm tt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(dbMain.SetExceptionMessage(ex), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblHandbook_Click(object sender, EventArgs e)
        {
            OpenBrowser(@"\\192.168.20.11\IMS Forms\Level 1 - Integrated Manual (PDF)\NBP-IM-003 Rev.3 Employee Handbook, Code of Conduct and General Work Policies.pdf");
        }

        private void lblLeaveApp_Click(object sender, EventArgs e)
        {
            OpenClickOnceApp("LeaveFilingSystem", @"%AppData%\Microsoft\Windows\Start Menu\Programs\Leave Application\Leave Application.appref-ms", "Leave application not found.");
        }

        private void lblDtr_Click(object sender, EventArgs e)
        {
            OpenBrowser("https://nbp.com.ph/nbcep/index-scan-dtr.php");
        }

        private void lblLoadBalance_Click(object sender, EventArgs e)
        {
            OpenClickOnceApp("LoadBalanceChecker", @"%AppData%\Microsoft\Windows\Start Menu\Programs\Load Balance Checker\Load Balance Checker.appref-ms", "Canteen purchases viewer application not found.");
        }

        private void picSss_Click(object sender, EventArgs e)
        {
            OpenBrowser("https://member.sss.gov.ph/");
        }

        private void picPagibig_Click(object sender, EventArgs e)
        {
            OpenBrowser("https://www.pagibigfundservices.com/virtualpagibig_profile/Verification/");
        }

        private void panelHandbook_Click(object sender, EventArgs e)
        {
            OpenBrowser(@"\\192.168.20.11\IMS Forms\Level 1 - Integrated Manual (PDF)\NBP-IM-003 Rev.3 Employee Handbook, Code of Conduct and General Work Policies.pdf");
        }

        private void panelLeaveApp_Click(object sender, EventArgs e)
        {
            OpenClickOnceApp("LeaveFilingSystem", @"%AppData%\Microsoft\Windows\Start Menu\Programs\Leave Application\Leave Application.appref-ms", "Leave application not found.");
        }

        private void panelDtr_Click(object sender, EventArgs e)
        {
            OpenBrowser("https://nbp.com.ph/nbcep/index-scan-dtr.php");
        }

        private void panelLoadBalance_Click(object sender, EventArgs e)
        {
            OpenClickOnceApp("LoadBalanceChecker", @"%AppData%\Microsoft\Windows\Start Menu\Programs\Load Balance Checker\Load Balance Checker.appref-ms", "Canteen purchases viewer application not found.");
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            ResizePanels();
        }

        private void ResizePanels()
        {
            // Get the total available height for the panels
            int availableHeight = this.ClientSize.Height - panel.Height; // Exclude the top panel
            int panelCount = 6; // Total visible panels

            int panelHeight = availableHeight / panelCount;

            // Adjust each panel
            AdjustPanel(panelHandbook, lblHandbook, panelHeight);
            AdjustPanel(panelLeaveApp, lblLeaveApp, panelHeight);
            AdjustPanel(panelDtr, lblDtr, panelHeight);
            AdjustPanel(panelLoadBalance, lblLoadBalance, panelHeight);
            AdjustPanel(panelOrderingSystem, lblOrderingSystem, panelHeight);
            // Adjust panelGovs with picture boxes
            AdjustPanelWithPictures(panelGovs, picSss, picPagibig, panelHeight);
        }

        private void AdjustPanel(Panel panel, Label label, int panelHeight)
        {
            panel.Height = panelHeight;

            // Dynamically adjust font size
            float fontSize = panelHeight * 0.4f; // 40% of panel height
            fontSize = Math.Max(fontSize, 10); // Set a minimum font size

            label.Font = new Font("Arial", fontSize, FontStyle.Bold);

            // Enable and then disable AutoSize for proper alignment
            label.AutoSize = true;
            label.AutoSize = false;

            // Set label size to fit within the panel
            label.Width = panel.Width;
            label.Height = panel.Height;

            // Center the label within the panel
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Left = (panel.Width - label.Width) / 2;
            label.Top = (panel.Height - label.Height) / 2;
        }

        private void AdjustPanelWithPictures(Panel panel, PictureBox pic1, PictureBox pic2, int panelHeight)
        {
            panel.Height = panelHeight;

            // Define picture box size (keeping aspect ratio)
            int picWidth = (int)(panel.Width * 0.4); // 40% of panel width
            int picHeight = (int)(panelHeight * 0.8); // 80% of panel height

            // Ensure a minimum size
            picWidth = Math.Max(picWidth, 50);
            picHeight = Math.Max(picHeight, 50);

            // Set sizes for both PictureBoxes
            pic1.Size = new Size(picWidth, picHeight);
            pic2.Size = new Size(picWidth, picHeight);

            // Position them side by side in the center
            int spacing = (panel.Width - (2 * picWidth)) / 3; // Space between them

            pic1.Left = spacing;
            pic2.Left = pic1.Right + spacing;
            pic1.Top = (panel.Height - picHeight) / 2;
            pic2.Top = pic1.Top;
        }

        private void OpenBrowser(string url)
        {
            try
            {
                // Check if there is already an existing browser process running
                if (browserProcess != null)
                {
                    try
                    {
                        if (!browserProcess.HasExited)
                        {
                            browserProcess.Kill();
                            browserProcess.WaitForExit();
                        }
                    }
                    catch (Exception) { } // Ignore errors if the process is already closed

                    browserProcess = null; // Reset to null after closing
                }

                // Initialize and start the browser process
                browserProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = url,
                        WindowStyle = ProcessWindowStyle.Maximized
                    }
                };

                browserProcess.Start();

                // Run a background thread to monitor when the browser exits
                new System.Threading.Thread(() =>
                {
                    browserProcess.WaitForExit();
                    browserProcess = null; // Reset process reference

                    // Check if the form is not closing and if it's not disposed
                    if (!this.IsDisposed && !isRestoring)
                    {
                        // Restore window only if it's not closing and not already in the restoring process
                        this.Invoke((MethodInvoker)delegate
                        {
                            RestoreWindow();
                        });
                    }

                })
                { IsBackground = true }.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening the browser: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RestoreWindow()
        {
            try
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.WindowState = FormWindowState.Normal;
                }

                // Ensure that Activate is not causing recursive form events
                if (!this.ContainsFocus)
                {
                    this.Activate();  // Brings the window to the front if it's minimized
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error restoring the window: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Reusable method for opening ClickOnce applications
        private void OpenClickOnceApp(string appName, string relativePath, string errorMessage)
        {
            try
            {
                string file = Environment.ExpandEnvironmentVariables(relativePath);

                if (!File.Exists(file))
                {
                    MessageBox.Show(errorMessage, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the app is already running
                Process runningProcess = Process.GetProcessesByName(appName).FirstOrDefault();

                if (runningProcess != null)
                {
                    // If the app is running, bring it to the foreground
                    IntPtr hWnd = runningProcess.MainWindowHandle;
                    if (hWnd != IntPtr.Zero)
                    {
                        ShowWindow(hWnd, SW_RESTORE);  // Restore if minimized
                        SetForegroundWindow(hWnd);  // Bring to front
                        return;
                    }
                } else
                {
                    // If not running, start a new instance
                    Process prc = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = file,
                            Arguments = "-n",
                            WindowStyle = ProcessWindowStyle.Maximized
                        }
                    };

                    prc.Start();
                    prc.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(dbMain.SetExceptionMessage(ex), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Disable the resize or maximize button of the form if the form is maximized, 
            // then enable it if the form is minimized.
            this.SizeChanged += new EventHandler(Main_SizeEventHandler);
            this.MaximizeBox = false;
        }

        private void Main_SizeEventHandler(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.MaximizeBox = true;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.MaximizeBox = false;
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDBLCLK = 163; // Define double-click event
            const int WM_NCLBUTTONDOWN = 161;   // Define left button down event
            const int WM_SYSCOMMAND = 274;      // Define system command event
            const int HTCAPTION = 2;            // Define that WM_NCLBUTTONDOWN is at title bar
            const int SC_MOVE = 61456;          // Trap move action

            // Disable moving of the title bar
            if (m.Msg == WM_SYSCOMMAND && m.WParam.ToInt32() == SC_MOVE)
            {
                return; // Exit without processing further
            }

            // Track whether clicked on the title bar
            if (m.Msg == WM_NCLBUTTONDOWN && m.WParam.ToInt32() == HTCAPTION)
            {
                return; // Exit without processing further
            }

            // Disable double-click on title bar
            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                return; // Exit without processing further
            }

            base.WndProc(ref m); // Call the base class's WndProc to process the message
        }

        // Handle form activation to ensure it's maximized and doesn't overlap the taskbar
        private void Main_Activated(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            // Ensure the form is not forcing the taskbar to be hidden by removing TopMost
            this.TopMost = false;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                // Prevent further closing events if the form is being restored
                if (isRestoring)
                {
                    e.Cancel = true;  // Cancel the form closing event if it's restoring
                    return;
                }

                isRestoring = true;  // Mark that we're in the process of restoring the window

                // Check if browser process is running, then kill it
                if (browserProcess != null && !browserProcess.HasExited)
                {
                    browserProcess.Kill();
                    browserProcess.WaitForExit();
                    browserProcess = null; // Reset process reference
                }

                foreach (Process prc in Process.GetProcessesByName("LeaveFilingSystem"))
                {
                    prc.Kill();
                    prc.WaitForExit();
                }

                foreach (Process prc in Process.GetProcessesByName("LoadBalanceChecker"))
                {
                    prc.Kill();
                    prc.WaitForExit();
                }

                // Ensure the form closes properly by allowing it to finish its closing process
                e.Cancel = false; // Let the form close after browser is terminated
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while closing: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isRestoring = false;  // Reset the restoring flag
            }
        }
    }
}
