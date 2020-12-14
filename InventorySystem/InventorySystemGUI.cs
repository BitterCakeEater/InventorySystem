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
        private DateTime ChosenDate;
        private DateTime BufferDate;
        private List<DateTime> Dates;

        InventorySystemContainer BufferContainer;

        private bool Loaded = false;
        private bool Saved = true;

        private List<InventorySystemContainer> MainInvSysContainers;
        private InventorySystemController MainInvSysController;

        private string Login = "admin";
        private string Password = "admin";

        public LibraryGUI()
        {
            MainInvSysContainers = new List<InventorySystemContainer>();
            MainInvSysController = new InventorySystemController();
            Dates = new List<DateTime>();
            InitializeComponent();

            BufferDate = DateTime.MinValue;

            if (LogIn())
                Load_Data();

            else
                this.Close();
        }

        public bool LogIn()
        {
            Form_LogIn FLI = new Form_LogIn();
            FLI.StartPosition = FormStartPosition.CenterParent;
            FLI.ShowDialog();
            if(FLI.DialogResult == DialogResult.OK)
            {
                if(FLI.textBox_Login.Text == Login && FLI.textBox_Password.Text == Password)
                    return true;

                else
                    return Wrong_Info();
            }
            else
                return false;
        }

        public bool Wrong_Info()
        {
            Form_LogIn FLI = new Form_LogIn();
            FLI.StartPosition = FormStartPosition.CenterParent;
            FLI.textBox_Login.Text = "Невірний логін або пароль";
            FLI.ShowDialog();
            if (FLI.DialogResult == DialogResult.OK)
            {
                if (FLI.textBox_Login.Text == Login && FLI.textBox_Password.Text == Password)
                    return true;

                else
                    return Wrong_Info();
            }
            else
                return false;
        }

        public void Load_Data()
        {
            Loaded = FileSystem.Load_Container_List(ref MainInvSysContainers);
            if (!Loaded)
            {
                BufferDate = DateTime.Now;

                BufferContainer = new InventorySystemContainer(BufferDate);

                Saved = false;
            }

            Loaded = true;

            Create_Dates_List();

            if (Saved != false)
                Set_dataGridView_List();
        }

        public void Create_Dates_List()
        {
            Dates.Clear();
            comboBox_Dates.Items.Clear();

            if (MainInvSysContainers.Count != 0)
            {
                foreach (var elem in MainInvSysContainers)
                {
                    Dates.Add(elem.CreationDate);
                }

                Dates.Sort();                

                foreach (var date in Dates)
                {
                    comboBox_Dates.Items.Add(date);
                }

                comboBox_Dates.SelectedIndex = Dates.Count - 1;

                ChosenDate = Dates[Dates.Count - 1];
            }
            else
            {
                Dates.Add(BufferDate);

                comboBox_Dates.Items.Add(BufferDate);

                comboBox_Dates.SelectedIndex = Dates.Count - 1;

                ChosenDate = Dates[Dates.Count - 1];
            }
        }

        public InventorySystemContainer Get_MainInvSysContainer(DateTime date)
        {
            return MainInvSysContainers[MainInvSysContainers.FindIndex(getInfo => getInfo.CreationDate.Date == date.Date && getInfo.CreationDate.Hour == date.Hour &&
                                       getInfo.CreationDate.Minute == date.Minute && getInfo.CreationDate.Second == date.Second)];
        }

        public void Set_MainInvSysContainer(InventorySystemContainer ISC, DateTime date)
        {
            MainInvSysContainers[MainInvSysContainers.FindIndex(getInfo => getInfo.CreationDate.Date == date.Date && getInfo.CreationDate.Hour == date.Hour &&
                                       getInfo.CreationDate.Minute == date.Minute && getInfo.CreationDate.Second == date.Second)] = ISC;
        }

        public  InventorySystemController Get_MainInvSysController()
        {
            return MainInvSysController;
        }


        public void Set_dataGridView_List()
        {
            dataGridView_List.Rows.Clear();

            if (Loaded)
            {
                List<DevicePC> list_pc = Get_MainInvSysContainer(ChosenDate).Get_Main_Device_List().Get_PCList();

                int list_size_pc = list_pc.Count;
                int i;

                for (i = 0; i < list_size_pc; i++)
                {
                    dataGridView_List.Rows.Add();

                    dataGridView_List.Rows[i].Cells[0].Value = i + 1;
                    dataGridView_List.Rows[i].Cells[1].Value = list_pc[i].ID;
                    dataGridView_List.Rows[i].Cells[2].Value = list_pc[i].Name;
                    dataGridView_List.Rows[i].Cells[3].Value = list_pc[i].Type;
                    dataGridView_List.Rows[i].Cells[4].Value = list_pc[i].RegistrationDate;
                }

                List<DeviceMonitor> list_mon = Get_MainInvSysContainer(ChosenDate).Get_Main_Device_List().Get_MonList();

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

                List<DevicePrinter> list_pr = Get_MainInvSysContainer(ChosenDate).Get_Main_Device_List().Get_PrList();

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
        }


        public void Set_dataGridView_List(InventorySystemContainer ISC)
        {
            dataGridView_List.Rows.Clear();

            if (Loaded)
            {
                List<DevicePC> list_pc = ISC.Get_Main_Device_List().Get_PCList();

                int list_size_pc = list_pc.Count;
                int i;

                for (i = 0; i < list_size_pc; i++)
                {
                    dataGridView_List.Rows.Add();

                    dataGridView_List.Rows[i].Cells[0].Value = i + 1;
                    dataGridView_List.Rows[i].Cells[1].Value = list_pc[i].ID;
                    dataGridView_List.Rows[i].Cells[2].Value = list_pc[i].Name;
                    dataGridView_List.Rows[i].Cells[3].Value = list_pc[i].Type;
                    dataGridView_List.Rows[i].Cells[4].Value = list_pc[i].RegistrationDate;
                }

                List<DeviceMonitor> list_mon = ISC.Get_Main_Device_List().Get_MonList();

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

                List<DevicePrinter> list_pr = ISC.Get_Main_Device_List().Get_PrList();

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
        }


        private void button_Add_Section_Click(object sender, EventArgs e)
        {
            Form_Add_Device FAD = new Form_Add_Device();

            if (BufferContainer == null)
            {
                BufferContainer = new InventorySystemContainer(ChosenDate);
                BufferContainer = (InventorySystemContainer)Get_MainInvSysContainer(ChosenDate).Clone();
            }

            if (MainInvSysController.Add_Device(FAD, ref BufferContainer))
            {

                if (BufferDate == DateTime.MinValue)
                {
                    BufferDate = DateTime.Now;
                    BufferContainer.CreationDate = BufferDate;
                }

                Saved = false;

                //Set_MainInvSysContainer(ISC, ChosenDate);

                Set_dataGridView_List(BufferContainer);
            }
        }


        private void button_Delete_Section_Click(object sender, EventArgs e)
        {
            if (dataGridView_List.SelectedRows.Count > 0)
            {
                var selected = dataGridView_List.SelectedCells;
                string id = Convert.ToString(selected[1].Value);

                if (BufferContainer == null)
                {
                    BufferContainer = new InventorySystemContainer(ChosenDate);
                    BufferContainer = (InventorySystemContainer)Get_MainInvSysContainer(ChosenDate).Clone();
                }

                if (MainInvSysController.Delete_Device(ref BufferContainer, id))
                {
                    if (BufferDate == DateTime.MinValue)
                    {
                        BufferDate = DateTime.Now;
                        BufferContainer.CreationDate = BufferDate;
                    }

                    Saved = false;

                    //Set_MainInvSysContainer(ISC, ChosenDate);

                    Set_dataGridView_List(BufferContainer);
                }
            }
        }


        private void button_Find_Click(object sender, EventArgs e)
        {
            if(textBox_Input_To_Find.TextLength != 0)
            {
                List<DevicePC> Found_List_PC = new List<DevicePC>();
                if(Saved)
                    Found_List_PC = MainInvSysController.Find_PC(Get_MainInvSysContainer(ChosenDate), textBox_Input_To_Find.Text);
                else
                    Found_List_PC = MainInvSysController.Find_PC(BufferContainer, textBox_Input_To_Find.Text);

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
                if (Saved)
                    Found_List_Mon = MainInvSysController.Find_Monitor(Get_MainInvSysContainer(ChosenDate), textBox_Input_To_Find.Text);
                else
                    Found_List_Mon = MainInvSysController.Find_Monitor(BufferContainer, textBox_Input_To_Find.Text);

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
                if (Saved)
                    Found_List_Pr = MainInvSysController.Find_Printer(Get_MainInvSysContainer(ChosenDate), textBox_Input_To_Find.Text);
                else
                    Found_List_Pr = MainInvSysController.Find_Printer(BufferContainer, textBox_Input_To_Find.Text);

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
            {
                if (Saved)
                    Set_dataGridView_List();
                else
                    Set_dataGridView_List(BufferContainer);
            }              
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
                    DevicePC device;

                    if (Saved)
                        device = Get_MainInvSysContainer(ChosenDate).Get_PC(id);
                    else
                        device = BufferContainer.Get_PC(id);

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

                    FED.Text = "Інформація про пристрій";
                    FED.Show();
                }

                else if(type == "Monitor")
                {
                    Form_Edit_Monitor FEM = new Form_Edit_Monitor();

                    DeviceMonitor device;

                    if(Saved)
                        device = Get_MainInvSysContainer(ChosenDate).Get_Monitor(id);
                    else
                        device = BufferContainer.Get_Monitor(id);

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

                    FEM.Text = "Інформація про пристрій";
                    FEM.Show();
                }

                else if (type == "Printer")
                {
                    Form_Edit_Printer FEP = new Form_Edit_Printer();

                    DevicePrinter device;

                    if(Saved)
                        device = Get_MainInvSysContainer(ChosenDate).Get_Printer(id);
                    else
                        device = BufferContainer.Get_Printer(id);

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

                    FEP.Text = "Інформація про пристрій";
                    FEP.Show();
                }
            }
        }

        private void button_ChangeInfo_Click(object sender, EventArgs e)
        {
            if (dataGridView_List.SelectedRows.Count > 0)
            {
                var selected = dataGridView_List.SelectedCells;
                string id = Convert.ToString(selected[1].Value);
                string type = Convert.ToString(selected[3].Value);

                if (BufferContainer == null)
                {
                    BufferContainer = new InventorySystemContainer(ChosenDate);
                    BufferContainer = (InventorySystemContainer)Get_MainInvSysContainer(ChosenDate).Clone();
                }

                if (MainInvSysController.Edit_Device(ref BufferContainer, id, type))
                {
                    if (BufferDate == DateTime.MinValue)
                    {
                        BufferDate = DateTime.Now;
                        BufferContainer.CreationDate = BufferDate;
                    }

                    Saved = false;
                    //Set_MainInvSysContainer(ISC, ChosenDate);

                    Set_dataGridView_List(BufferContainer);
                }
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (!Saved)
            {
                if (BufferContainer.Get_Main_Device_List().Get_MonList().Count != 0 ||
                    BufferContainer.Get_Main_Device_List().Get_PCList().Count != 0 ||
                    BufferContainer.Get_Main_Device_List().Get_PrList().Count != 0)
                {
                    MainInvSysContainers.Add(BufferContainer);

                    Saved = true;

                    BufferContainer = new InventorySystemContainer();
                    BufferContainer = null;
                    BufferDate = DateTime.MinValue;

                    FileSystem.Save_Container_List(MainInvSysContainers);

                    Create_Dates_List();
                    Set_dataGridView_List();
                }
            }
            else if (Saved)
            {
                BufferContainer = new InventorySystemContainer(ChosenDate);
                BufferContainer = (InventorySystemContainer)Get_MainInvSysContainer(ChosenDate).Clone();

                BufferDate = DateTime.Now;

                BufferContainer.CreationDate = BufferDate;

                MainInvSysContainers.Add(BufferContainer);

                Saved = true;

                BufferContainer = new InventorySystemContainer();
                BufferContainer = null;
                BufferDate = DateTime.MinValue;

                FileSystem.Save_Container_List(MainInvSysContainers);

                Create_Dates_List();
                Set_dataGridView_List();
            }
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            DateTime bufferTime = Convert.ToDateTime(comboBox_Dates.SelectedItem);

            if (!Saved)
            {
                Form_Save_Attention FSA = new Form_Save_Attention();
                FSA.StartPosition = FormStartPosition.CenterParent;
                FSA.ShowDialog();
                if (FSA.DialogResult == DialogResult.Yes)
                    button_Save_Click(null, null);
                else
                {
                    Saved = true;
                    BufferContainer = new InventorySystemContainer();
                    BufferContainer = null;
                    BufferDate = DateTime.MinValue;
                }
            }

            else if(Saved && BufferContainer != null)
            {
                BufferContainer = new InventorySystemContainer();
                BufferContainer = null;
                BufferDate = DateTime.MinValue;
            }

            ChosenDate = bufferTime;
            comboBox_Dates.SelectedItem = bufferTime;

            Set_dataGridView_List();
        }

        private void InventorySystemGUI_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (!Saved)
            {
                Form_Save_Attention FSA = new Form_Save_Attention();
                FSA.StartPosition = FormStartPosition.CenterParent;
                FSA.ShowDialog();
                if (FSA.DialogResult == DialogResult.Yes)
                    button_Save_Click(null, null);
                else
                {
                    Saved = true;
                    BufferContainer = new InventorySystemContainer();
                    BufferContainer = null;
                    BufferDate = DateTime.MinValue;
                }
            }
        }
    }
}
