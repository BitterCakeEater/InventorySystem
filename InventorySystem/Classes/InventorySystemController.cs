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
                Types t;

                if (FAD.radioButton_PC.Checked)
                {
                    Form_Add_PC FAP = new Form_Add_PC();
                    FAP.StartPosition = FormStartPosition.CenterParent;
                    FAP.richTextBox_Type.ReadOnly = true;
                    FAP.richTextBox_Type.Text = "PC";
                    FAP.ShowDialog();

                    t = Types.PC;

                    if (InvSysContainer.Find_Device_ID(FAP.richTextBox_ID.Text))
                    {
                        while (InvSysContainer.Find_Device_ID(FAP.richTextBox_ID.Text))
                        {
                            MessageBox.Show(
                            "Пристрій з таким ідентифікатором вже існує!",
                            "Увага!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1);

                            FAP.ShowDialog();
                        }
                    }
                    else if(FAP.DialogResult != DialogResult.Cancel)
                    {
                        InvSysContainer.Add_PC(FAP.richTextBox_ID.Text,
                                           t,
                                           FAP.richTextBox_Name.Text,
                                           DateTime.Now,
                                           FAP.richTextBox_Case.Text,
                                           FAP.richTextBox_PowerSupply.Text,
                                           FAP.richTextBox_Motherboard.Text,
                                           FAP.richTextBox_CPU.Text,
                                           FAP.richTextBox_RAM.Text,
                                           FAP.richTextBox_Drive.Text,
                                           FAP.richTextBox_GraphicsCard.Text);
                        
                    }
                }
                else if (FAD.radioButton_Monitor.Checked)
                {
                    Form_Add_Monitor FAM = new Form_Add_Monitor();
                    FAM.StartPosition = FormStartPosition.CenterParent;
                    FAM.richTextBox_Type.ReadOnly = true;
                    FAM.richTextBox_Type.Text = "Monitor";
                    FAM.ShowDialog();

                    t = Types.Monitor;

                    if (InvSysContainer.Find_Device_ID(FAM.richTextBox_ID.Text))
                    {
                        while (InvSysContainer.Find_Device_ID(FAM.richTextBox_ID.Text))
                        {
                            MessageBox.Show(
                            "Пристрій з таким ідентифікатором вже існує!",
                            "Увага!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1);

                            FAM.ShowDialog();
                        }
                    }
                    else if (FAM.DialogResult != DialogResult.Cancel)
                    {
                        InvSysContainer.Add_Monitor(FAM.richTextBox_ID.Text,
                                           t,
                                           FAM.richTextBox_Name.Text,
                                           DateTime.Now,
                                           FAM.richTextBox_Diagonal.Text,
                                           FAM.richTextBox_Resolution.Text,
                                           FAM.richTextBox_Frequency.Text,
                                           FAM.richTextBox_Connector.Text);

                    }
                }
                else if (FAD.radioButton_Printer.Checked)
                {
                    Form_Add_Printer FAP = new Form_Add_Printer();
                    FAP.StartPosition = FormStartPosition.CenterParent;
                    FAP.richTextBox_Type.ReadOnly = true;
                    FAP.richTextBox_Type.Text = "Printer";
                    FAP.ShowDialog();

                    t = Types.Printer;

                    if (InvSysContainer.Find_Device_ID(FAP.richTextBox_ID.Text))
                    {
                        while (InvSysContainer.Find_Device_ID(FAP.richTextBox_ID.Text))
                        {
                            MessageBox.Show(
                            "Пристрій з таким ідентифікатором вже існує!",
                            "Увага!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1);

                            FAP.ShowDialog();
                        }
                    }
                    else if (FAP.DialogResult != DialogResult.Cancel)
                    {
                        InvSysContainer.Add_Printer(FAP.richTextBox_ID.Text,
                                           t,
                                           FAP.richTextBox_Name.Text,
                                           DateTime.Now,
                                           FAP.richTextBox_PrintTech.Text,
                                           FAP.richTextBox_PaperSize.Text,
                                           FAP.richTextBox_Colors.Text,
                                           FAP.richTextBox_Scanner.Text);

                    }
                }
            }

            InvSysContainer.Save_Main_Device_List();
        }


        public void Edit_Device(ref InventorySystemContainer InvSysContainer, string id, string type)
        {
            if (type == "PC")
            {
                Form_Edit_PC FEP = new Form_Edit_PC();

                DevicePC device = InvSysContainer.Get_PC(id);

                FEP.richTextBox_ID.Text = device.ID;
                FEP.richTextBox_Type.Text = "PC";
                FEP.richTextBox_Name.Text = device.Name;
                FEP.richTextBox_RegDate.Text = Convert.ToString(device.RegistrationDate);
                FEP.richTextBox_Case.Text = device.Case;
                FEP.richTextBox_PowerSupply.Text = device.PowerSupply;
                FEP.richTextBox_Motherboard.Text = device.Moterboard;
                FEP.richTextBox_CPU.Text = device.CPU;
                FEP.richTextBox_RAM.Text = device.RAM;
                FEP.richTextBox_Drive.Text = device.Drive;
                FEP.richTextBox_GraphicsCard.Text = device.GraphicsCard;
                FEP.StartPosition = FormStartPosition.CenterParent;

                FEP.richTextBox_ID.ReadOnly = true;
                FEP.richTextBox_Type.ReadOnly = true;
                FEP.richTextBox_Name.ReadOnly = true;
                FEP.richTextBox_RegDate.ReadOnly = true;

                FEP.ShowDialog();

                if (FEP.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    InvSysContainer.Change_PC(id,
                                                FEP.richTextBox_Case.Text,
                                                FEP.richTextBox_PowerSupply.Text,
                                                FEP.richTextBox_Motherboard.Text,
                                                FEP.richTextBox_CPU.Text,
                                                FEP.richTextBox_RAM.Text,
                                                FEP.richTextBox_Drive.Text,
                                                FEP.richTextBox_GraphicsCard.Text);

                    InvSysContainer.Save_Main_Device_List();
                }
            } 
            
            else if(type == "Monitor")
            {
                Form_Edit_Monitor FEM = new Form_Edit_Monitor();

                DeviceMonitor device = InvSysContainer.Get_Monitor(id);

                FEM.richTextBox_ID.Text = device.ID;
                FEM.richTextBox_Type.Text = "Monitor";
                FEM.richTextBox_Name.Text = device.Name;
                FEM.richTextBox_RegDate.Text = Convert.ToString(device.RegistrationDate);
                FEM.richTextBox_Connector.Text = device.Connector;
                FEM.richTextBox_Diagonal.Text = device.Diagonal;
                FEM.richTextBox_Frequency.Text = device.Frequency;
                FEM.richTextBox_Resolution.Text = device.Resolution;
                FEM.StartPosition = FormStartPosition.CenterScreen;

                FEM.richTextBox_ID.ReadOnly = true;
                FEM.richTextBox_Type.ReadOnly = true;
                FEM.richTextBox_Name.ReadOnly = true;
                FEM.richTextBox_RegDate.ReadOnly = true;

                FEM.ShowDialog();

                if (FEM.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    InvSysContainer.Change_Monitor(id,
                                                FEM.richTextBox_Connector.Text,
                                                FEM.richTextBox_Diagonal.Text,
                                                FEM.richTextBox_Frequency.Text,
                                                FEM.richTextBox_Resolution.Text);

                    InvSysContainer.Save_Main_Device_List();
                }
            }

            else if (type == "Printer")
            {
                Form_Edit_Printer FEP = new Form_Edit_Printer();

                DevicePrinter device = InvSysContainer.Get_Printer(id);

                FEP.richTextBox_ID.Text = device.ID;
                FEP.richTextBox_Type.Text = "Monitor";
                FEP.richTextBox_Name.Text = device.Name;
                FEP.richTextBox_RegDate.Text = Convert.ToString(device.RegistrationDate);
                FEP.richTextBox_PrintTech.Text = device.PrintTechnology;
                FEP.richTextBox_PaperSize.Text = device.PaperSize;
                FEP.richTextBox_Colors.Text = device.Colors;
                FEP.richTextBox_Scanner.Text = device.Scanner;
                FEP.StartPosition = FormStartPosition.CenterScreen;

                FEP.richTextBox_ID.ReadOnly = true;
                FEP.richTextBox_Type.ReadOnly = true;
                FEP.richTextBox_Name.ReadOnly = true;
                FEP.richTextBox_RegDate.ReadOnly = true;

                FEP.ShowDialog();

                if (FEP.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    InvSysContainer.Change_Printer(id,
                                                FEP.richTextBox_PrintTech.Text,
                                                FEP.richTextBox_PaperSize.Text,
                                                FEP.richTextBox_Colors.Text,
                                                FEP.richTextBox_Scanner.Text);

                    InvSysContainer.Save_Main_Device_List();
                }
            }
        }


        public void Delete_Device(ref InventorySystemContainer InvSysContainer, string id)
        {
            Form_Delete_Attention FDA = new Form_Delete_Attention();

            FDA.StartPosition = FormStartPosition.CenterParent;

            FDA.ShowDialog();
           
            if (FDA.DialogResult == DialogResult.Yes)
            {
                InvSysContainer.Delete_Device(id);

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

        public List<DeviceMonitor> Find_Monitor(InventorySystemContainer InvSysContainer, string str_to_find)
        {
            List<DeviceMonitor> rez = new List<DeviceMonitor>();

            IEnumerable<DeviceMonitor> r = InvSysContainer.Get_Main_Device_List().
                                            Get_MonList().Where(getInfo =>
                                                Convert.ToString(getInfo.ID).Contains(str_to_find) ||
                                                Convert.ToString(getInfo.Name).Contains(str_to_find));

            rez = r.ToList<DeviceMonitor>();

            return rez;
        }

        public List<DevicePrinter> Find_Printer(InventorySystemContainer InvSysContainer, string str_to_find)
        {
            List<DevicePrinter> rez = new List<DevicePrinter>();

            IEnumerable<DevicePrinter> r = InvSysContainer.Get_Main_Device_List().
                                            Get_PrList().Where(getInfo =>
                                                Convert.ToString(getInfo.ID).Contains(str_to_find) ||
                                                Convert.ToString(getInfo.Name).Contains(str_to_find));

            rez = r.ToList<DevicePrinter>();

            return rez;
        }
    }
}
