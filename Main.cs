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

namespace Kiosk
{
    public partial class Main : Form
    {
        private Connection dbConnection = new Connection();
        private BlackCoffeeLibrary.Main dbMain = new BlackCoffeeLibrary.Main();
        private SqlDbMethod dbMethod;

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
            clickHandbook();
        }

        private void lblLeaveApp_Click(object sender, EventArgs e)
        {
            clickLeaveApp();
        }

        private void lblDtr_Click(object sender, EventArgs e)
        {
            clickDtr();
        }

        private void lblLoadBalance_Click(object sender, EventArgs e)
        {
            clickLoadBalance();
        }

        private void lblOrderingSystem_Click(object sender, EventArgs e)
        {
            clickOrderingSystem();
        }

        private void picSss_Click(object sender, EventArgs e)
        {
            clickSss();
        }

        private void picPagibig_Click(object sender, EventArgs e)
        {
            clickPagibig();
        }

        private void panelHandbook_Click(object sender, EventArgs e)
        {
            clickHandbook();
        }

        private void panelLeaveApp_Click(object sender, EventArgs e)
        {
            clickLeaveApp();
        }

        private void panelDtr_Click(object sender, EventArgs e)
        {
            clickDtr();
        }

        private void panelLoadBalance_Click(object sender, EventArgs e)
        {
            clickLoadBalance();
        }

        private void panelOrderingSystem_Click(object sender, EventArgs e)
        {
            clickOrderingSystem();
        }

        private void clickHandbook()
        {
            try
            {
                string file = @"\\192.168.20.11\IMS Forms\Level 1 - Integrated Manual (PDF)\NBP-IM-003 Rev.3 Employee Handbook, Code of Conduct and General Work Policies.pdf";
                if (File.Exists(file))
                {
                    Process prc = new Process();
                    prc.StartInfo.FileName = file;
                    prc.StartInfo.Arguments = "-n";
                    prc.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;

                    prc.Start();
                    prc.WaitForExit();
                }
                else
                {
                    MessageBox.Show("Employee handbook not found from IMS folder.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(dbMain.SetExceptionMessage(ex), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clickLeaveApp()
        {
            try
            {
                string file = @"%AppData%\Microsoft\Windows\Start Menu\Programs\Leave Application\Leave Application.appref-ms";
                file = Environment.ExpandEnvironmentVariables(file);

                if (File.Exists(file))
                {
                    Process prc = new Process();
                    prc.StartInfo.FileName = file;
                    prc.StartInfo.Arguments = "-n";
                    prc.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;

                    prc.Start();
                    prc.WaitForExit();
                }
                else
                {
                    MessageBox.Show("Leave application not found.", "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(dbMain.SetExceptionMessage(ex), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clickDtr()
        {
            try
            {
                Process prc = new Process();
                prc.StartInfo.FileName = "https://nbp.com.ph/nbcep/index.php";
                prc.StartInfo.Arguments = "-n";
                prc.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;

                prc.Start();
                prc.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(dbMain.SetExceptionMessage(ex), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clickLoadBalance()
        {
            try
            {
                string file = @"%AppData%\Microsoft\Windows\Start Menu\Programs\Load Balance Checker\Load Balance Checker.appref-ms";
                file = Environment.ExpandEnvironmentVariables(file);

                if (File.Exists(file))
                {
                    Process prc = new Process();
                    prc.StartInfo.FileName = file;
                    prc.StartInfo.Arguments = "-n";
                    prc.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;

                    prc.Start();
                    prc.WaitForExit();
                }
                else
                {
                    MessageBox.Show("Canteen purchases viewer application not found.", "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(dbMain.SetExceptionMessage(ex), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clickOrderingSystem()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(dbMain.SetExceptionMessage(ex), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clickSss()
        {
            try
            {
                Process prc = new Process();
                prc.StartInfo.FileName = "https://member.sss.gov.ph/";
                prc.StartInfo.Arguments = "-n";
                prc.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;

                prc.Start();
                prc.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(dbMain.SetExceptionMessage(ex), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clickPagibig()
        {
            try
            {
                Process prc = new Process();
                prc.StartInfo.FileName = "https://www.pagibigfundservices.com/virtualpagibig_profile/Verification/";
                prc.StartInfo.Arguments = "-n";
                prc.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;

                prc.Start();
                prc.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(dbMain.SetExceptionMessage(ex), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            ResizePanels();
        }

        private void ResizePanels()
        {
            // Get the total available height for the panels
            int availableHeight = this.ClientSize.Height - panel.Height; // Exclude the top panel
            int panelCount = 5; // Total visible panels

            int panelHeight = availableHeight / panelCount;

            // Adjust each panel
            AdjustPanel(panelHandbook, lblHandbook, panelHeight);
            AdjustPanel(panelLeaveApp, lblLeaveApp, panelHeight);
            AdjustPanel(panelDtr, lblDtr, panelHeight);
            AdjustPanel(panelLoadBalance, lblLoadBalance, panelHeight);
            AdjustPanel(panelGovs, lblLoadBalance, panelHeight);
            //AdjustPanel(panelOrderingSystem, lblOrderingSystem, panelHeight);
        }

        private void AdjustPanel(Panel panel, Label label, int panelHeight)
        {
            panel.Height = panelHeight;

            // Calculate font size dynamically based on panel height
            float fontSize = panelHeight * 0.4f; // 40% of panel height (adjust as needed)
            fontSize = Math.Max(fontSize, 10); // Set a minimum font size

            label.Font = new Font("Arial", fontSize, FontStyle.Bold);

            // Enable auto-sizing, then disable it to manually control positioning
            label.AutoSize = true;
            label.AutoSize = false;

            // Set the label size to fit inside the panel
            label.Width = panel.Width;
            label.Height = panel.Height;

            // Center the label within the panel
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Left = (panel.Width - label.Width) / 2;
            label.Top = (panel.Height - label.Height) / 2;
        }
    }
}
