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
    public partial class Form_Add_Device : Form
    {
        public Form_Add_Device()
        {
            InitializeComponent();
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            if (!radioButton_Monitor.Checked && !radioButton_PC.Checked && !radioButton_Printer.Checked)
                MessageBox.Show(
                            "Оберіть тип присторю!",
                            "Увага!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1);

            else
                this.DialogResult = DialogResult.OK;
        }
    }
}
