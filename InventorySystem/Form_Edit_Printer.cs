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
    public partial class Form_Edit_Printer : Form
    {
        public Form_Edit_Printer()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            bool ok = true;

            if (richTextBox_PrintTech.Text == "" || richTextBox_Scanner.Text == "" || richTextBox_ID.Text == "" ||
                richTextBox_Colors.Text == "" || richTextBox_Name.Text == "" || richTextBox_PaperSize.Text == "" ||
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
