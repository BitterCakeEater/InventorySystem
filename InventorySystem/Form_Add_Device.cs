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

        private void button_Add_Click(object sender, EventArgs e)
        {
            bool ok = true;
            //int num;

            //foreach (char symbol in richTextBox_Type.Text)
            //{
            //    if (char.IsDigit(symbol))
            //    {
            //        ok = false;

            //        MessageBox.Show(
            //            "Форма 'Автори' не може містити цифри!",
            //            "Увага!",
            //            MessageBoxButtons.OK,
            //            MessageBoxIcon.Warning,
            //            MessageBoxDefaultButton.Button1);

            //        break;
            //    }
            //}


            //if (Convert.ToInt32(richTextBox_Case.Text) > DateTime.Now.Year)
            //{
            //    ok = false;

            //    MessageBox.Show(
            //        "Невірно вказаний рік видання!",
            //        "Увага!",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning,
            //        MessageBoxDefaultButton.Button1);
            //}


            //try
            //{
            //    num = Convert.ToInt32(richTextBox_Case.Text);
            //}
            //catch
            //{
            //    ok = false;

            //    MessageBox.Show(
            //        "Некорректна кількість екземплярів!",
            //        "Увага!",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning,
            //        MessageBoxDefaultButton.Button1);
            //}

            if (ok == true)
                this.DialogResult = DialogResult.OK;
        }
    }
}
