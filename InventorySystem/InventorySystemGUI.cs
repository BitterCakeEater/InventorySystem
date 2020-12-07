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

            List<DevicePC> list_pc = MainInvSysContainer.Get_Main_Device_List().Get_PCList();

            int list_size_pc = list_pc.Count;
            int i;

            for (i = 0; i < list_size_pc; i++)
            {
                dataGridView_List.Rows.Add();

                dataGridView_List.Rows[i].Cells[0].Value = i+1;
                dataGridView_List.Rows[i].Cells[1].Value = list_pc[i].ID;
                dataGridView_List.Rows[i].Cells[2].Value = list_pc[i].Name;
                dataGridView_List.Rows[i].Cells[3].Value = list_pc[i].Type;
                dataGridView_List.Rows[i].Cells[4].Value = list_pc[i].RegistrationDate;
            }

            List<DeviceMonitor> list_mon = MainInvSysContainer.Get_Main_Device_List().Get_MonList();

            int list_size_mon = list_mon.Count;

            int j = 0;
            for (i = list_size_pc; i < list_size_pc + list_size_mon; i++)
            {
                 dataGridView_List.Rows.Add();

                dataGridView_List.Rows[i].Cells[0].Value = i + 1;
                dataGridView_List.Rows[i].Cells[1].Value = list_mon[j].ID;
                dataGridView_List.Rows[i].Cells[2].Value = list_mon[j].Name;
                dataGridView_List.Rows[i].Cells[3].Value = list_mon[j].Type;
                dataGridView_List.Rows[i].Cells[4].Value = list_mon[j].RegistrationDate;
                j++;
            }

            List<DevicePrinter> list_pr = MainInvSysContainer.Get_Main_Device_List().Get_PrList();

            int list_size_pr = list_pr.Count;

            j = 0;
            for (i = list_size_pc + list_size_mon; i < list_size_pc + list_size_mon + list_size_pr; i++)
            {
                dataGridView_List.Rows.Add();

                dataGridView_List.Rows[i].Cells[0].Value = i + 1;
                dataGridView_List.Rows[i].Cells[1].Value = list_pr[j].ID;
                dataGridView_List.Rows[i].Cells[2].Value = list_pr[j].Name;
                dataGridView_List.Rows[i].Cells[3].Value = list_pr[j].Type;
                dataGridView_List.Rows[i].Cells[4].Value = list_pr[j].RegistrationDate;
                j++;
            }
        }


        private void button_Add_Section_Click(object sender, EventArgs e)
        {
            Form_Add_Device FAD = new Form_Add_Device();

            MainInvSysController.Add_Device(FAD, ref MainInvSysContainer);

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
                List<DevicePC> Found_List_PC = new List<DevicePC>();
                Found_List_PC = MainInvSysController.Find_PC(MainInvSysContainer, textBox_Input_To_Find.Text);

                dataGridView_List.Rows.Clear();

                int list_size_pc = Found_List_PC.Count;

                for (int i = 0; i < list_size_pc; i++)
                {
                    dataGridView_List.Rows.Add();

                    dataGridView_List.Rows[i].Cells[0].Value = i + 1;
                    dataGridView_List.Rows[i].Cells[1].Value = Found_List_PC[i].ID;
                    dataGridView_List.Rows[i].Cells[2].Value = Found_List_PC[i].Name;
                    dataGridView_List.Rows[i].Cells[3].Value = Found_List_PC[i].Type;
                    dataGridView_List.Rows[i].Cells[4].Value = Found_List_PC[i].RegistrationDate;
                }

                List<DeviceMonitor> Found_List_Mon = new List<DeviceMonitor>();
                Found_List_Mon = MainInvSysController.Find_Monitor(MainInvSysContainer, textBox_Input_To_Find.Text);

                int list_size_mon = Found_List_Mon.Count;

                int j = 0;
                for (int i = list_size_pc; i < list_size_pc + list_size_mon; i++)
                {
                    dataGridView_List.Rows.Add();

                    dataGridView_List.Rows[i].Cells[0].Value = i + 1;
                    dataGridView_List.Rows[i].Cells[1].Value = Found_List_Mon[j].ID;
                    dataGridView_List.Rows[i].Cells[2].Value = Found_List_Mon[j].Name;
                    dataGridView_List.Rows[i].Cells[3].Value = Found_List_Mon[j].Type;
                    dataGridView_List.Rows[i].Cells[4].Value = Found_List_Mon[j].RegistrationDate;
                    j++;
                }

                List<DevicePrinter> Found_List_Pr = new List<DevicePrinter>();
                Found_List_Pr = MainInvSysController.Find_Printer(MainInvSysContainer, textBox_Input_To_Find.Text);

                int list_size_pr = Found_List_Pr.Count;

                j = 0;
                for (int i = list_size_pc + list_size_mon; i < list_size_pc + list_size_mon + list_size_pr; i++)
                {
                    dataGridView_List.Rows.Add();

                    dataGridView_List.Rows[i].Cells[0].Value = i + 1;
                    dataGridView_List.Rows[i].Cells[1].Value = Found_List_Pr[j].ID;
                    dataGridView_List.Rows[i].Cells[2].Value = Found_List_Pr[j].Name;
                    dataGridView_List.Rows[i].Cells[3].Value = Found_List_Pr[j].Type;
                    dataGridView_List.Rows[i].Cells[4].Value = Found_List_Pr[j].RegistrationDate;
                    j++;
                }
            }

            else
                Set_dataGridView_List();
        }


        private void button_Info_Click(object sender, EventArgs e)
        {
            if (dataGridView_List.SelectedRows.Count > 0)
            {
                var selected = dataGridView_List.SelectedCells;
                string id = Convert.ToString(selected[1].Value);
                string type = Convert.ToString(selected[3].Value);

                if (type == "PC")
                {
                    Form_Edit_PC FED = new Form_Edit_PC();

                    DevicePC device = MainInvSysContainer.Get_PC(id);

                    FED.richTextBox_ID.Text = device.ID;
                    FED.richTextBox_Type.Text = "PC";
                    FED.richTextBox_Name.Text = device.Name;
                    FED.richTextBox_RegDate.Text = Convert.ToString(device.RegistrationDate);
                    FED.richTextBox_Case.Text = device.Case;
                    FED.richTextBox_PowerSupply.Text = device.PowerSupply;
                    FED.richTextBox_Motherboard.Text = device.Moterboard;
                    FED.richTextBox_CPU.Text = device.CPU;
                    FED.richTextBox_RAM.Text = device.RAM;
                    FED.richTextBox_Drive.Text = device.Drive;
                    FED.richTextBox_GraphicsCard.Text = device.GraphicsCard;

                    FED.richTextBox_ID.ReadOnly = true;
                    FED.richTextBox_Type.ReadOnly = true;
                    FED.richTextBox_Name.ReadOnly = true;
                    FED.richTextBox_RegDate.ReadOnly = true;
                    FED.richTextBox_Case.ReadOnly = true;
                    FED.richTextBox_PowerSupply.ReadOnly = true;
                    FED.richTextBox_Motherboard.ReadOnly = true;
                    FED.richTextBox_CPU.ReadOnly = true;
                    FED.richTextBox_RAM.ReadOnly = true;
                    FED.richTextBox_Drive.ReadOnly = true;
                    FED.richTextBox_GraphicsCard.ReadOnly = true;

                    FED.StartPosition = FormStartPosition.CenterScreen;

                    FED.button_Add.Enabled = false;
                    FED.button_Add.Visible = false;
                    FED.button_Cancel.Enabled = false;
                    FED.button_Cancel.Visible = false;

                    FED.Show();
                }

                else if(type == "Monitor")
                {
                    Form_Edit_Monitor FEM = new Form_Edit_Monitor();

                    DeviceMonitor device = MainInvSysContainer.Get_Monitor(id);

                    FEM.richTextBox_ID.Text = device.ID;
                    FEM.richTextBox_Type.Text = "Monitor";
                    FEM.richTextBox_Name.Text = device.Name;
                    FEM.richTextBox_RegDate.Text = Convert.ToString(device.RegistrationDate);
                    FEM.richTextBox_Connector.Text = device.Connector;
                    FEM.richTextBox_Diagonal.Text = device.Diagonal;
                    FEM.richTextBox_Frequency.Text = device.Frequency;
                    FEM.richTextBox_Resolution.Text = device.Resolution;

                    FEM.richTextBox_ID.ReadOnly = true;
                    FEM.richTextBox_Type.ReadOnly = true;
                    FEM.richTextBox_Name.ReadOnly = true;
                    FEM.richTextBox_RegDate.ReadOnly = true;
                    FEM.richTextBox_Connector.ReadOnly = true;
                    FEM.richTextBox_Diagonal.ReadOnly = true;
                    FEM.richTextBox_Frequency.ReadOnly = true;
                    FEM.richTextBox_Resolution.ReadOnly = true;

                    FEM.StartPosition = FormStartPosition.CenterScreen;

                    FEM.button_Add.Enabled = false;
                    FEM.button_Add.Visible = false;
                    FEM.button_Cancel.Enabled = false;
                    FEM.button_Cancel.Visible = false;

                    FEM.Show();
                }

                else if (type == "Printer")
                {
                    Form_Edit_Printer FEP = new Form_Edit_Printer();

                    DevicePrinter device = MainInvSysContainer.Get_Printer(id);

                    FEP.richTextBox_ID.Text = device.ID;
                    FEP.richTextBox_Type.Text = "Printer";
                    FEP.richTextBox_Name.Text = device.Name;
                    FEP.richTextBox_RegDate.Text = Convert.ToString(device.RegistrationDate);
                    FEP.richTextBox_PrintTech.Text = device.PrintTechnology;
                    FEP.richTextBox_PaperSize.Text = device.PaperSize;
                    FEP.richTextBox_Colors.Text = device.Colors;
                    FEP.richTextBox_Scanner.Text = device.Scanner;

                    FEP.richTextBox_ID.ReadOnly = true;
                    FEP.richTextBox_Type.ReadOnly = true;
                    FEP.richTextBox_Name.ReadOnly = true;
                    FEP.richTextBox_RegDate.ReadOnly = true;
                    FEP.richTextBox_PrintTech.ReadOnly = true;
                    FEP.richTextBox_PaperSize.ReadOnly = true;
                    FEP.richTextBox_Colors.ReadOnly = true;
                    FEP.richTextBox_Scanner.ReadOnly = true;

                    FEP.StartPosition = FormStartPosition.CenterScreen;

                    FEP.button_Add.Enabled = false;
                    FEP.button_Add.Visible = false;
                    FEP.button_Cancel.Enabled = false;
                    FEP.button_Cancel.Visible = false;

                    FEP.Show();
                }
            }
        }

        private void button_ChangeInfo_Click(object sender, EventArgs e)
        {
            var selected = dataGridView_List.SelectedCells;
            string id = Convert.ToString(selected[1].Value);
            string type = Convert.ToString(selected[3].Value);

            MainInvSysController.Edit_Device(ref MainInvSysContainer, id, type);

            Set_dataGridView_List();
        }
    }
}
