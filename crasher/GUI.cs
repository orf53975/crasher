using crasher.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crasher
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            GetLabelInfos();
        }

        private void GetLabelInfos()
        {
            System.Threading.Thread.Sleep(1000);
            //SET LOCAL INFOS 
            labelMacAdress.Text = ClientHelper.GetMacAddress();
            labelMacAdress.ForeColor = Color.LightGreen;

            labelMachineName.Text = ClientHelper.GetMachineName();
            labelMachineName.ForeColor = Color.LightGreen;

            //SET PUBLIC INFOS
            if (ClientHelper.IsConnectedToMre())
            {
                labelMREConnection.Text = "Connected";
                labelMREConnection.ForeColor = Color.LightGreen;
            }
            else
            {
                labelMREConnection.Text = "Failed";
                labelMREConnection.ForeColor = Color.Red;
            }

            labelTotalCannons.Text = MREHelper.GetTotUsers().ToString();
            labelTotalCannons.ForeColor = Color.LightGreen;
        }
    }
}
