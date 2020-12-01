using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventorySystem.Classes.Device_Related;
using System.Windows.Forms;

namespace InventorySystem.Classes
{
    class InventorySystemController
    {
        public void Add_Device(Form_Add_Device FAD, ref InventorySystemContainer InvSysContainer)
        {
            FAD.StartPosition = FormStartPosition.CenterParent;
            FAD.ShowDialog();

            if(FAD.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                //If ID number is already present
                if (InvSysContainer.Find_PC_ID(FAD.richTextBox_ID.Text))
                {
                    MessageBox.Show(
                    "Пристрій з таким ідентифікатором вже існує!",
                    "Увага!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);

                    Form_Add_Device New_FAD = new Form_Add_Device();

                    New_FAD.richTextBox_Type.Text = FAD.richTextBox_Type.Text;
                    New_FAD.richTextBox_Name.Text = FAD.richTextBox_Name.Text;
                    New_FAD.richTextBox_Case.Text = FAD.richTextBox_Case.Text;
                    New_FAD.richTextBox_PowerSupply.Text = FAD.richTextBox_PowerSupply.Text;
                    New_FAD.richTextBox_Motherboard.Text = FAD.richTextBox_Motherboard.Text;
                    New_FAD.richTextBox_CPU.Text = FAD.richTextBox_CPU.Text;
                    New_FAD.richTextBox_RAM.Text = FAD.richTextBox_RAM.Text;
                    New_FAD.richTextBox_Drive.Text = FAD.richTextBox_Drive.Text;
                    New_FAD.richTextBox_GraphicsCard.Text = FAD.richTextBox_GraphicsCard.Text;
                    New_FAD.StartPosition = FormStartPosition.CenterParent;

                    Add_Device(New_FAD, ref InvSysContainer);
                }
                else
                {
                    InvSysContainer.Add_PC(FAD.richTextBox_ID.Text,
                                           FAD.richTextBox_Type.Text,
                                           FAD.richTextBox_Name.Text, 
                                           DateTime.Now,
                                           FAD.richTextBox_Case.Text,
                                           FAD.richTextBox_PowerSupply.Text,
                                           FAD.richTextBox_Motherboard.Text,
                                           FAD.richTextBox_CPU.Text,
                                           FAD.richTextBox_RAM.Text,
                                           FAD.richTextBox_Drive.Text,
                                           FAD.richTextBox_GraphicsCard.Text);
                }
            }

            InvSysContainer.Save_Main_Device_List();
        }


        public void Edit_Device(Form_Edit_Device FED, ref InventorySystemContainer InvSysContainer, string id)
        {
            DevicePC device = InvSysContainer.Get_PC(id);

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
            FED.StartPosition = FormStartPosition.CenterParent;

            FED.richTextBox_ID.ReadOnly = true;
            FED.richTextBox_Type.ReadOnly = true;
            FED.richTextBox_Name.ReadOnly = true;
            FED.richTextBox_RegDate.ReadOnly = true;

            FED.ShowDialog();

            if (FED.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                InvSysContainer.Change_PC(id,
                                            FED.richTextBox_Case.Text,
                                            FED.richTextBox_PowerSupply.Text,
                                            FED.richTextBox_Motherboard.Text,
                                            FED.richTextBox_CPU.Text,
                                            FED.richTextBox_RAM.Text,
                                            FED.richTextBox_Drive.Text,
                                            FED.richTextBox_GraphicsCard.Text);

                InvSysContainer.Save_Main_Device_List();
            }                
        }


        public void Delete_Device(ref InventorySystemContainer InvSysContainer, string id)
        {
            Form_Delete_Attention FDA = new Form_Delete_Attention();

            FDA.StartPosition = FormStartPosition.CenterParent;

            FDA.ShowDialog();
           
            if (FDA.DialogResult == DialogResult.Yes)
            {
                InvSysContainer.Delete_PC(id);

                InvSysContainer.Save_Main_Device_List();
            }
        }


        public List<DevicePC> Find_PC(InventorySystemContainer InvSysContainer, string str_to_find)
        {
            List<DevicePC> rez = new List<DevicePC>();

            IEnumerable<DevicePC> r = InvSysContainer.Get_Main_Device_List().
                                            Get_PCList().Where(getInfo =>
                                                Convert.ToString(getInfo.ID).Contains(str_to_find) ||
                                                Convert.ToString(getInfo.Name).Contains(str_to_find));

            rez = r.ToList<DevicePC>();

            return rez;
        }


        //public void Add_Book_Section(Form_Add_Device FABS, ref LibraryContainer LibContainer)
        //{
        //    FABS.StartPosition = FormStartPosition.CenterParent;
        //    FABS.ShowDialog();

        //    if (FABS.DialogResult == System.Windows.Forms.DialogResult.OK)
        //    {
        //        if (LibContainer.Find_Book_Section(FABS.richTextBox_ID.Text, FABS.richTextBox_Type.Text, Convert.ToInt32(FABS.richTextBox_Case.Text), FABS.richTextBox_PowerSupply.Text, FABS.richTextBox_Motherboard.Text))
        //        {
        //            MessageBox.Show(
        //            "Ідентична книга вже існує!",
        //            "Увага!",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Warning,
        //            MessageBoxDefaultButton.Button1);

        //            Form_Add_Device New_FABS = new Form_Add_Device();

        //            New_FABS.richTextBox_CPU.Text = FABS.richTextBox_CPU.Text;
        //            New_FABS.richTextBox_Type.Text = FABS.richTextBox_Type.Text;
        //            New_FABS.richTextBox_Name.Text = FABS.richTextBox_Name.Text;
        //            New_FABS.richTextBox_PowerSupply.Text = FABS.richTextBox_PowerSupply.Text;
        //            New_FABS.richTextBox_Motherboard.Text = FABS.richTextBox_Motherboard.Text;
        //            New_FABS.richTextBox_ID.Text = FABS.richTextBox_ID.Text;
        //            New_FABS.richTextBox_Case.Text = FABS.richTextBox_Case.Text;
        //            New_FABS.StartPosition = FormStartPosition.CenterParent;

        //            Add_Book_Section(New_FABS, ref LibContainer);
        //        }

        //        else if(LibContainer.Get_Main_Catalog().Get_Book_Section(FABS.richTextBox_Name.Text) != null)
        //        {
        //            MessageBox.Show(
        //            "Книга з таким шифром вже існує!",
        //            "Увага!",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Warning,
        //            MessageBoxDefaultButton.Button1);

        //            Form_Add_Device New_FABS = new Form_Add_Device();

        //            New_FABS.richTextBox_CPU.Text = FABS.richTextBox_CPU.Text;
        //            New_FABS.richTextBox_Type.Text = FABS.richTextBox_Type.Text;
        //            New_FABS.richTextBox_Name.Text = FABS.richTextBox_Name.Text;
        //            New_FABS.richTextBox_PowerSupply.Text = FABS.richTextBox_PowerSupply.Text;
        //            New_FABS.richTextBox_Motherboard.Text = FABS.richTextBox_Motherboard.Text;
        //            New_FABS.richTextBox_ID.Text = FABS.richTextBox_ID.Text;
        //            New_FABS.richTextBox_Case.Text = FABS.richTextBox_Case.Text;
        //            New_FABS.StartPosition = FormStartPosition.CenterParent;

        //            Add_Book_Section(New_FABS, ref LibContainer);
        //        }

        //        else
        //            LibContainer.Add_Book_Section(FABS.richTextBox_ID.Text, 
        //                                          FABS.richTextBox_Type.Text, 
        //                                          FABS.richTextBox_Name.Text, 
        //                                          Convert.ToInt32(FABS.richTextBox_Case.Text), 
        //                                          FABS.richTextBox_PowerSupply.Text, FABS.richTextBox_Motherboard.Text, 
        //                                          Convert.ToInt32(FABS.richTextBox_CPU.Text), 
        //                                          Convert.ToInt32(FABS.richTextBox_CPU.Text));

        //        LibContainer.Save_Main_Catalog();
        //    }
        //}


        //public void Delete_Book_Section(ref LibraryContainer LibContainer, string library_cipher)
        //{
        //    Form_Delete_Attention FDA = new Form_Delete_Attention();

        //    FDA.StartPosition = FormStartPosition.CenterParent;

        //    FDA.label1.Text = "Ви дійсно бажаете видалити цей розділ книг?";

        //    FDA.ShowDialog();

        //    if (FDA.DialogResult == DialogResult.Yes)
        //    {
        //        foreach(var book in LibContainer.Get_Main_Catalog().Get_Book_Section(library_cipher).Get_Books_Copies())
        //        {
        //            if (!LibContainer.Get_Main_Catalog().Book_Is_Not_Taken(library_cipher, book.Number))
        //            {
        //                LibContainer.Get_Main_Catalog().Return_Book(library_cipher, 
        //                                                            book.Number, 
        //                                                            book.Story_Card.Get_Last_Record().Reader_Name, 
        //                                                            book.Story_Card.Get_Last_Record().Reader_Card_Number);

        //                LibContainer.Get_Main_Registration_List().Return_Book(LibContainer.Get_Main_Catalog().Get_Book(library_cipher, book.Number), 
        //                                                                      book.Story_Card.Get_Last_Record().Reader_Card_Number);
        //            }
        //        }

        //        LibContainer.Delete_Book_Section(library_cipher);

        //        LibContainer.Save_Main_Catalog();
        //        LibContainer.Save_Main_Registration_List();
        //    }

        //}


        //public List<BookSection> Find_Book(LibraryContainer LibContainer, string str_to_find)
        //{
        //    List<BookSection> rez = new List<BookSection>();

        //    IEnumerable<BookSection> r = LibContainer.Get_Main_Catalog().
        //                                    Get_Books_List().Where(getInfo => 
        //                                        Convert.ToString(getInfo.Library_Cipher).Contains(str_to_find) || 
        //                                        Convert.ToString(getInfo.Title).Contains(str_to_find));

        //    rez = r.ToList<BookSection>();

        //    return rez;
        //}


        //public void Add_Book(ref LibraryContainer LibContainer, string library_cipher, int number)
        //{
        //    LibContainer.Get_Main_Catalog().Get_Book_Section(library_cipher).Add_Books_Copies(number);

        //    LibContainer.Save_Main_Catalog();
        //}


        //public void Delete_Book(ref LibraryContainer LibContainer, string library_cipher, int number)
        //{
        //    Form_Delete_Attention FDA = new Form_Delete_Attention();

        //    FDA.StartPosition = FormStartPosition.CenterParent;
        //    FDA.label1.Text = "Ви дійсно бажаете видалити цю книгу?";

        //    FDA.ShowDialog();

        //    if (FDA.DialogResult == DialogResult.Yes)
        //    {
        //        var book = LibContainer.Get_Main_Catalog().Get_Book_Section(library_cipher).Get_Book(number);

        //        if (!LibContainer.Get_Main_Catalog().Book_Is_Not_Taken(library_cipher, number))
        //        {
        //            LibContainer.Get_Main_Catalog().Return_Book(library_cipher, 
        //                                                        number, 
        //                                                        book.Story_Card.Get_Last_Record().Reader_Name, 
        //                                                        book.Story_Card.Get_Last_Record().Reader_Card_Number);

        //            LibContainer.Get_Main_Registration_List().Return_Book(LibContainer.Get_Main_Catalog().Get_Book(library_cipher, number), 
        //                                                                  book.Story_Card.Get_Last_Record().Reader_Card_Number);
        //        }

        //        LibContainer.Get_Main_Catalog().Delete_Book(library_cipher, number);

        //        LibContainer.Save_Main_Catalog();
        //        LibContainer.Save_Main_Registration_List();
        //    }              
        //}


        //public int Get_Amount_Of_Books(ref LibraryContainer LibContainer, string library_cipher)
        //{
        //    return LibContainer.Get_Main_Catalog().Get_Book_Section(library_cipher).Copies_Amount;
        //}


        //public int Get_Amount_Of_Available_Books(ref LibraryContainer LibContainer, string library_cipher)
        //{
        //    return LibContainer.Get_Main_Catalog().Get_Book_Section(library_cipher).Copies_Available;
        //}


        //public void Take_Book(ref LibraryContainer LibContainer, string library_cipher, int number, string reader_name, int reader_number)
        //{
        //    if(LibContainer.Get_Main_Catalog().Book_Is_Not_Taken(library_cipher, number))
        //    {
        //        LibContainer.Get_Main_Catalog().Take_Book(library_cipher, number, reader_name, reader_number);

        //        LibContainer.Get_Main_Registration_List().Take_Book(LibContainer.Get_Main_Catalog().Get_Book(library_cipher, number), reader_number);

        //        LibContainer.Save_Main_Catalog();
        //        LibContainer.Save_Main_Registration_List();
        //    }          
        //}


        //public void Return_Book(ref LibraryContainer LibContainer, string library_cipher, int number, string reader_name, int reader_number)
        //{
        //    if (!LibContainer.Get_Main_Catalog().Book_Is_Not_Taken(library_cipher, number))
        //    {
        //        LibContainer.Get_Main_Catalog().Return_Book(library_cipher, number, reader_name, reader_number);

        //        LibContainer.Get_Main_Registration_List().Return_Book(LibContainer.Get_Main_Catalog().Get_Book(library_cipher, number), reader_number);

        //        LibContainer.Save_Main_Catalog();
        //        LibContainer.Save_Main_Registration_List();
        //    }

        //}


        //public List<Book> Find_Books_By_Date(LibraryContainer LibContainer, DateTime from, DateTime to, bool taken)
        //{
        //    List<Book> found = new List<Book>();

        //    foreach (var book_list in LibContainer.Get_Main_Catalog().Get_Books_List())

        //        foreach (var book in book_list.Get_Books_Copies())

        //            foreach (var record in book.Story_Card.Get_Record_List())

        //                if (taken == true)
        //                {
        //                    if (record.Issue_Date.Date >= from.Date && record.Issue_Date.Date <= to.Date && !found.Contains(book))
        //                    {
        //                        found.Add(book);
        //                        break;
        //                    }
        //                }
        //                else
        //                    if (record.Return_Date.Date >= from.Date && record.Return_Date.Date <= to.Date && !found.Contains(book))
        //                    {
        //                        found.Add(book);
        //                        break;
        //                    }

        //    return found;
        //}
    }
}
