using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class Form_Add_Monitor : Form
    {
        public Form_Add_Monitor()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            bool ok = true;

            if (richTextBox_Diagonal.Text == "" || richTextBox_Connector.Text == "" ||  richTextBox_ID.Text == "" ||
                richTextBox_Frequency.Text == "" || richTextBox_Name.Text == "" || richTextBox_Resolution.Text == "" ||  
                richTextBox_Type.Text == "")
            {
                ok = false;

                MessageBox.Show(
                    "Заповінть усі поля!",
                    "Увага!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
            }

            if (ok == true)
                this.DialogResult = DialogResult.OK;
        }
    }
}
