using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Admin_Tool
{
    public partial class AdminTool : Form
    {
        public AdminTool()
        {
            InitializeComponent();
            pasteData();
        }


        // input a closed Remedy ticket into the texbox will open a new IE window 
        // to allow the user to reopen the specified ticket on behalf of the user         
        private void remedyBtn_Click(object sender, EventArgs e)
        {
            var remUrl = "https://vocfeedback.gsk.com/IM_update/viewTicket.asp?ticket_id=";
            var remInput = remUrl += remedyTextBox.Text;

            Process.Start("IExplore.exe", remInput);
        }

        // input service catalogue request ID number into textbox will 
        // open a new IE window to allow the user to check the status of the inputted request ID
        private void scRequestBtn_Click(object sender, EventArgs e)
        {
            var scUrl = "http://iwha.gsk.com/servicesdashboard/InstanceInfoRedirect.aspx?instance_id=";
            var scInput = scUrl += scTextBox.Text;
       
            Process.Start("IExplore.exe", scInput);
        }

            
        // a group of common resolving agencies.  On button click will copy the string to the clipboard of the button pressed.
        private void btn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch ((sender as Button).Name)
            {
                case "lincolnBtn":
                    Clipboard.SetText("IT-HELP-LOUNGE-LINCOLN");
                    break;
                case "missBtn":
                    Clipboard.SetText("IT-HELP-LOUNGE-MISSISSAUGA");
                    break;
                case "navyYardBtn":
                    Clipboard.SetText("IT-HELP-LOUNGE-NAVY-YARD");
                    break;
                case "merionEastBtn":
                    Clipboard.SetText("IT-HELP-LOUNGE-MERION-EAST");
                    break;
                case "adminBtn":
                    Clipboard.SetText("IT-SUPPORT-ADMIN-US");
                    break;
                case "merionWestBtn":
                    Clipboard.SetText("IT-HELP-LOUNGE-MERION-WEST");
                    break;
                case "providenceBtn":
                    Clipboard.SetText("IT-HELP-LOUNGE-UPPER-PROVIDNCE");
                    break;
                case "rockGmsBtn":
                    Clipboard.SetText("IT-HELP-LOUNGE-ROCKVILLE-GMS");
                    break;
                case "rockVxBtn":
                    Clipboard.SetText("IT-HELP-LOUNGE-ROCKVILLE-VX");
                    break;
                case "hubBtn":
                    Clipboard.SetText("IT-SUPPORT-HUB-RTP");
                    break;
                case "rdBtn":
                    Clipboard.SetText("IT-HELP-LOUNGE-RTP-BUILDING-5");
                    break;
                case "sandersBtn":
                    Clipboard.SetText("IT-HELP-LOUNGE-RTP-SANDERS");
                    break;
                case "warrenBtn":
                    Clipboard.SetText("IT-HELP-LOUNGE-WARREN");
                    break;
                case "zebulonBtn":
                    Clipboard.SetText("IT-HELP-LOUNGE-ZEBULON");
                    break;
                case "mobileBtn":
                    Clipboard.SetText("IT-HELP-LOUNGE-RTP-MOBILE");
                    break;
               
            }
          }

        private void PasteData()
        {
            IDataObject ClipData = Clipboard.GetDataObject();
            timerRefresh.Start();
            if (ClipData.GetDataPresent(DataFormats.Text))
            {
                string s = Clipboard.GetData(DataFormats.Text).ToString();
                clipboardLabel.Text = s;
            }
        }

        // A simple copy tool.  Input into the text box will copy the input to the clipboard allowing the user to paste 
        private void copyBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                Clipboard.SetText(copyTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter something to be copied", "Entry Error"]);
            }
            
        }
    }
}
