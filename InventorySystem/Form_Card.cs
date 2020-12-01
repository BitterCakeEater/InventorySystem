using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.Classes.Device_Related;

namespace InventorySystem
{
    partial class Form_Card : Form
    {
        public Form_Card()
        {
            InitializeComponent();
        }


        //public void Set_Data(Card card, string library_cipher, int number)
        //{
        //    label_Cipher.Text += library_cipher;
        //    label_Number.Text += Convert.ToString(number);

        //    Set_dataGridView_Copies(card);
        //}


        //public void Set_dataGridView_Copies(Card card)
        //{
        //    dataGridView_Card.Rows.Clear();

        //    List<CardRecord> Rec_List = new List<CardRecord>();

        //    Rec_List = card.Get_Record_List();

        //    int Card_Size = Rec_List.Count;

        //    for (int i = 0; i < Card_Size; i++)
        //    {
        //        dataGridView_Card.Rows.Add();

        //        dataGridView_Card.Rows[i].Cells[0].Value = Rec_List[i].Reader_Name;
        //        dataGridView_Card.Rows[i].Cells[1].Value = Rec_List[i].Reader_Card_Number;
        //        dataGridView_Card.Rows[i].Cells[2].Value = Rec_List[i].Issue_Date.ToShortDateString();
        //        dataGridView_Card.Rows[i].Cells[3].Value = Rec_List[i].Term_Date.ToShortDateString();

        //        if (Rec_List[i].Return_Date == DateTime.MinValue)
        //            dataGridView_Card.Rows[i].Cells[4].Value = "-";

        //        else
        //            dataGridView_Card.Rows[i].Cells[4].Value = Rec_List[i].Return_Date.ToShortDateString();
        //    }
        //}
    }
}
