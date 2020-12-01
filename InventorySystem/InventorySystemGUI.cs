using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.Classes;
using InventorySystem.Classes.Device_Related;

namespace InventorySystem
{
    partial class LibraryGUI : Form
    {
        private InventorySystemContainer MainInvSysContainer;
        private InventorySystemController MainInvSysController;

        public LibraryGUI()
        {
            MainInvSysContainer = new InventorySystemContainer();
            MainInvSysController = new InventorySystemController();
            InitializeComponent();

            MainInvSysContainer.Load_Main_Device_List();

            Set_dataGridView_List();
        }

        public InventorySystemContainer Get_MainInvSysContainer()
        {
            return MainInvSysContainer;
        }


        public  InventorySystemController Get_MainInvSysController()
        {
            return MainInvSysController;
        }


        public void Set_dataGridView_List()
        {
            dataGridView_List.Rows.Clear();

            List<DevicePC> list = MainInvSysContainer.Get_Main_Device_List().Get_PCList();

            int list_size = list.Count;

            for (int i = 0; i < list_size; i++)
            {
                dataGridView_List.Rows.Add();

                dataGridView_List.Rows[i].Cells[0].Value = i+1;
                dataGridView_List.Rows[i].Cells[1].Value = list[i].ID;
                dataGridView_List.Rows[i].Cells[2].Value = list[i].Name;
                dataGridView_List.Rows[i].Cells[3].Value = list[i].Type;
                dataGridView_List.Rows[i].Cells[4].Value = list[i].RegistrationDate;
            }
        }


        private void button_Add_Section_Click(object sender, EventArgs e)
        {
            Form_Add_Device FABS = new Form_Add_Device();

            MainInvSysController.Add_Device(FABS, ref MainInvSysContainer);

            Set_dataGridView_List();
        }


        private void button_Delete_Section_Click(object sender, EventArgs e)
        {
            if (dataGridView_List.SelectedRows.Count > 0)
            {
                var selected = dataGridView_List.SelectedCells;
                string id = Convert.ToString(selected[1].Value);

                MainInvSysController.Delete_Device(ref MainInvSysContainer, id);

                Set_dataGridView_List();
            }
        }


        private void button_Find_Click(object sender, EventArgs e)
        {
            if(textBox_Input_To_Find.TextLength != 0)
            {
                List<DevicePC> Found_List = new List<DevicePC>();
                Found_List = MainInvSysController.Find_PC(MainInvSysContainer, textBox_Input_To_Find.Text);

                dataGridView_List.Rows.Clear();

                int list_size = Found_List.Count;

                for (int i = 0; i < list_size; i++)
                {
                    dataGridView_List.Rows.Add();

                    dataGridView_List.Rows[i].Cells[0].Value = i + 1;
                    dataGridView_List.Rows[i].Cells[1].Value = Found_List[i].ID;
                    dataGridView_List.Rows[i].Cells[2].Value = Found_List[i].Name;
                    dataGridView_List.Rows[i].Cells[3].Value = Found_List[i].Type;
                    dataGridView_List.Rows[i].Cells[4].Value = Found_List[i].RegistrationDate;
                }
            }

            else
                Set_dataGridView_List();
        }


        private void button_Info_Click(object sender, EventArgs e)
        {
            if (dataGridView_List.SelectedRows.Count > 0)
            {
                Form_Edit_Device FED = new Form_Edit_Device();

                var selected = dataGridView_List.SelectedCells;
                string id = Convert.ToString(selected[1].Value);

                DevicePC device = MainInvSysContainer.Get_PC(id);

                FED.richTextBox_ID.Text = device.ID;
                FED.richTextBox_Type.Text = device.Type;
                FED.richTextBox_Name.Text = device.Name;
                FED.richTextBox_RegDate.Text = Convert.ToString(device.RegistrationDate);
                FED.richTextBox_Case.Text = device.Case;
                FED.richTextBox_PowerSupply.Text = device.PowerSupply;
                FED.richTextBox_Motherboard.Text = device.Moterboard;
                FED.richTextBox_CPU.Text = device.CPU;
                FED.richTextBox_RAM.Text = device.RAM;
                FED.richTextBox_Drive.Text = device.Drive;
                FED.richTextBox_GraphicsCard.Text = device.GraphicsCard;
                FED.StartPosition = FormStartPosition.CenterScreen;

                FED.button_Add.Enabled = false;
                FED.button_Add.Visible = false;
                FED.button_Cancel.Enabled = false;
                FED.button_Cancel.Visible = false;

                FED.Show();
            }
        }

        private void button_ChangeInfo_Click(object sender, EventArgs e)
        {
            Form_Edit_Device FED = new Form_Edit_Device();

            var selected = dataGridView_List.SelectedCells;
            string id = Convert.ToString(selected[1].Value);

            MainInvSysController.Edit_Device(FED, ref MainInvSysContainer, id);

            Set_dataGridView_List();
        }


        //public void Add_Book(string library_cipher, int number)
        //{
        //    MainLibraryController.Add_Book(ref MainLibraryContainer, library_cipher, number);

        //    Set_dataGridView_Catalog();
        //}


        //public void Delete_Book(string library_cipher, int number)
        //{
        //    MainLibraryController.Delete_Book(ref MainLibraryContainer, library_cipher, number);

        //    Set_dataGridView_Catalog();
        //}


        //public int Get_Amount_Of_Books(string library_cipher)
        //{
        //    return MainLibraryController.Get_Amount_Of_Books(ref MainLibraryContainer, library_cipher);
        //}


        //public int Get_Amount_Of_Available_Books(string library_cipher)
        //{
        //    return MainLibraryController.Get_Amount_Of_Available_Books(ref MainLibraryContainer, library_cipher);
        //}


        //public void Take_Book(string library_cipher, int number, string reader_name, int reader_number)
        //{
        //    MainLibraryController.Take_Book(ref MainLibraryContainer, library_cipher, number, reader_name, reader_number);

        //    Set_dataGridView_Catalog();
        //}


        //public void Return_Book(string library_cipher, int number, string reader_name, int reader_number)
        //{
        //    MainLibraryController.Return_Book(ref MainLibraryContainer, library_cipher, number, reader_name, reader_number);

        //    Set_dataGridView_Catalog();
        //}


        //private void button_Find_Info_Click(object sender, EventArgs e)
        //{
        //    List<Book> found_books = new List<Book>();

        //    if (radioButton_Issued_Books.Checked)
        //        found_books = MainLibraryController.Find_Books_By_Date(MainLibraryContainer, Convert.ToDateTime(dateTimePicker_First_Date.Text), Convert.ToDateTime(dateTimePicker_Second_Date.Text), true);

        //    else if (radioButton_Returned_Books.Checked)
        //        found_books = MainLibraryController.Find_Books_By_Date(MainLibraryContainer, Convert.ToDateTime(dateTimePicker_First_Date.Text), Convert.ToDateTime(dateTimePicker_Second_Date.Text), false);

        //    dataGridView_Books_Info.Rows.Clear();

        //    int list_size = found_books.Count;

        //    for (int i = 0; i < list_size; i++)
        //    {
        //        dataGridView_Books_Info.Rows.Add();

        //        dataGridView_Books_Info.Rows[i].Cells[0].Value = found_books[i].Title;
        //        dataGridView_Books_Info.Rows[i].Cells[1].Value = found_books[i].Authors;
        //        dataGridView_Books_Info.Rows[i].Cells[2].Value = found_books[i].Library_Cipher;
        //        dataGridView_Books_Info.Rows[i].Cells[3].Value = found_books[i].Number;
        //        dataGridView_Books_Info.Rows[i].Cells[4].Value = found_books[i].Publishing_Year;
        //        dataGridView_Books_Info.Rows[i].Cells[5].Value = found_books[i].Publishing_Place;
        //        dataGridView_Books_Info.Rows[i].Cells[6].Value = found_books[i].Publisher_Name;
        //    }
        //}
    }
}
