using crasher.Helpers;
using crasher.Model;
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

            //ACCESS APPLICATION FROM DIFFERENT THREADS
            CheckForIllegalCrossThreadCalls = false;
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            GetLabelInfos();
            Program.GUiStarted = true;

            SizeLastColumn(listViewAttack);
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






        //Form visualization methods
        private void SizeLastColumn(ListView lv)
        {
            lv.Columns[lv.Columns.Count - 1].Width = -2;
        }

        private void listViewAttack_Resize(object sender, EventArgs e)
        {
            SizeLastColumn((ListView)sender);
        }

        private void listViewAttack_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listViewAttack.Columns[e.ColumnIndex].Width;
        }


        //START SELECTED ATTACK
        private void buttonStartAttack_Click(object sender, EventArgs e)
        {
            if(listViewAttack.SelectedIndices.Count > 0)
            {
                ListViewItem record = listViewAttack.Items[listViewAttack.SelectedIndices[0]];
                Attack selected = GUIHelper.GetSelectedAttackFromRecord(record);
                DialogResult result = MessageBox.Show(null, "Are you sure you wanna start the attack written below \n\n" + selected.ToString() + "?","Confirm attack", MessageBoxButtons.YesNo);
                
                if(result == DialogResult.Yes)
                {
                    //START ATTACK
                    AttackSettings.Threading = checkBoxThreads.Checked;
                    selected.Start();
                }

            }
            else
            {
                MessageBox.Show("You have to select the attack you wanna start from the table");
            }
        }
    }
}
