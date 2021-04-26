using System;
using System.IO;
using System.Windows.Forms;
using RawPrint /*With compliments of https://github.com/frogmorecs/RawPrint */;

namespace IQPrinterKicker
{
    public partial class frmMain : Form
    {
        bool DebugMode = false;

        public frmMain()
        {
            InitializeComponent();

        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            try
            {
                //Retrieve the array of CMD Args. Warning : This is done on a dumb scale
                //If any required args is not present errors will occur.
                //Thus we wrap the process in a try and call the UI if it fails
                string[] CMD_Args = Environment.GetCommandLineArgs();

                //Attempt to see if debug msg's should be thrown. 
                //We wrap it in a try to safeguard when this arg is not present
                try
                {
                    if (CMD_Args[3].ToString() == "debug")
                    {
                        DebugMode = true;
                    }
                }
                catch (Exception)
                {
                }


                string PrinterName = CMD_Args[1].ToString().Replace(";", "");
                string KickString = CMD_Args[2].ToString().Replace(";", "");


                DebugMessage("Arguments Rcvd:" + Environment.NewLine + 
                    "Printer Name: " + PrinterName + Environment.NewLine +
                    "Kickstring : " + KickString);

                SendPrinterKick(PrinterName, KickString, false);
            }
            catch (Exception)
            {

            }

            //If the UI is allowed to open, we prepare as such
            ListPrinters();
            this.WindowState = FormWindowState.Normal;

        }

        private void btnTest_Click(object sender, EventArgs e)
        {

            if (cmbxPrinterList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a printer to target");
                return;
            }

            SendPrinterKick(cmbxPrinterList.SelectedItem.ToString(), edtKickString.Text, true);
        }

        #region Custom Methods

        private void DebugMessage(string Msg)
        {
            if (DebugMode)
            {
                MessageBox.Show(Msg, "Debug Message - " + Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private string ProcessRDPPrinter(string PrinterName)
        {
            string PrinterBaseName = PrinterName.Substring(0, PrinterName.LastIndexOf("(redirected "));
            try
            {
                foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    if (printer.Contains(PrinterBaseName))
                    {
                        DebugMessage("Processed RDP printer name to :\n" + printer);
                        return printer;
                    }
                }

                DebugMessage("No RDP printer counterpart could be found for printer name :\n" + PrinterName);
                //If no printer is found that matches the base name, just return the original printer
                return PrinterName;
            }
            catch (Exception exRDpProcessException)
            {
                MessageBox.Show("An error occurred while processing RDP enabled printer:" + Environment.NewLine +
                    exRDpProcessException.ToString(),Application.ProductName,MessageBoxButtons.OK);
                return PrinterName;
            }
        }

        private void ListPrinters()
        {
            try
            {
                cmbxPrinterList.Items.Clear();

                foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                {
                    cmbxPrinterList.Items.Add(printer);
                }

            }
            catch (Exception)
            {

            }
            
        }

        private void SendPrinterKick(string PrinterName,string KickString,bool isTest=false)
        {
            try
            {

                #region Remote Desktop Compatibility

                //First try to overcome RDP printer with changed number issue
                if (PrinterName.Contains("(redirected"))
                {
                    DebugMessage("RDP Printer Detected | Reprocessing to current redirect ID");
                    PrinterName = ProcessRDPPrinter(PrinterName);
                }

                #endregion

                #region Process Kickstring

                //We expect a Kickstring in the following format : 027-112-048-055-121
                //We wrap it in a try catch to send a targeted error telling the user the kickstring
                //is wrong


                byte[] KickBytes = new byte[5];
                try
                {
                    string[] RawKickBytes = KickString.Split('-');
                    int iCounter = 0;

                    foreach (var KickByte in RawKickBytes)
                    {
                        KickBytes[iCounter] = Convert.ToByte(KickByte);
                        iCounter += 1;
                    }
                }
                catch (Exception)
                {
                    //The kick string is not valid. 
                    throw new Exception("An invalid kick string was provided.\n" + "Kick string is expected in the following format : 027-112-048-055-121");
                }

                #endregion

                #region Prepare printer file/command file

                using (StreamWriter TempFile = new StreamWriter(Path.Combine(Application.StartupPath, "temp.txt")))
                {
                    TempFile.WriteLine(System.Text.ASCIIEncoding.ASCII.GetString(new byte[] { KickBytes[0], KickBytes[1], KickBytes[2], KickBytes[3], KickBytes[4] }));
                }

                #endregion

                #region Use RawPrint to Send Printer Command

                // Create an instance of the Printer
                IPrinter printer = new Printer();

                // Print the file
                printer.PrintRawFile(PrinterName, Path.Combine(Application.StartupPath, "temp.txt"), "temp.txt");
                DebugMessage("Kick command sent");
                #endregion

            }
            catch (Exception exPrintError)
            {
                MessageBox.Show(exPrintError.ToString(),Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Error);

                //We ensure to remove residue files after processing requests
                File.Delete(Path.Combine(Application.StartupPath, "temp.txt"));

                return;
            }
            finally
            {
                //We ensure to remove residue files after processing requests
                File.Delete(Path.Combine(Application.StartupPath, "temp.txt"));

                //If this is a UI test, give the user visual feedback
                if (isTest)
                {
                    MessageBox.Show("Successfully sent kick command", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Application.Exit();
                }
            }
            
        
        }

        #endregion

        private void chckbxEnableDebugMode_CheckedChanged(object sender, EventArgs e)
        {
            DebugMode = chckbxEnableDebugMode.Checked;
        }
    }
}
