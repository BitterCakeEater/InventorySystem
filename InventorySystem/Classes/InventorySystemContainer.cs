using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventorySystem.Classes.Device_Related;
using Library.Classes;

namespace InventorySystem.Classes
{
    class InventorySystemContainer
    {
        private DeviceList MainDeviceList;

        public InventorySystemContainer()
        {
            MainDeviceList = new DeviceList();
        }

        //save/load
        public bool Save_Main_Device_List()
        {
            return FileSystem.Save_Device_List(MainDeviceList);
        }


        public bool Load_Main_Device_List()
        {
            return FileSystem.Load_Device_List(ref MainDeviceList);
        }

        //get
        public DeviceList Get_Main_Device_List()
        {
            return MainDeviceList;
        }


        public DevicePC Get_PC(string id)
        {
            return MainDeviceList.Get_PC(id);
        }

        public DeviceMonitor Get_Monitor(string id)
        {
            return MainDeviceList.Get_Monitor(id);
        }

        public DevicePrinter Get_Printer(string id)
        {
            return MainDeviceList.Get_Printer(id);
        }


        public void Add_PC(string id, Types type, string name, DateTime RegDate,
                           string ca, string ps, string motherb, string cpu, string ram, string drive, string gc)
        {
            MainDeviceList.Add_PC(id, type, name, RegDate, ca, ps, motherb, cpu, ram, drive, gc);
        }

        public void Add_Monitor(string id, Types type, string name, DateTime RegDate,
                           string diag, string res, string freq, string conn)
        {
            MainDeviceList.Add_Monitor(id, type, name, RegDate, diag, res, freq, conn);
        }

        public void Add_Printer(string id, Types type, string name, DateTime RegDate,
                           string pt, string ps, string col, string sc)
        {
            MainDeviceList.Add_Printer(id, type, name, RegDate, pt, ps, col, sc);
        }


        public void Change_PC(string id, 
                           string ca, string ps, string motherb, string cpu, string ram, string drive, string gc)
        {
            MainDeviceList.Change_PC(id, ca, ps, motherb, cpu, ram, drive, gc);
        }

        public void Change_Monitor(string id,
                           string diag, string res, string freq, string conn)
        {
            MainDeviceList.Change_Monitor(id, diag, res, freq, conn);
        }

        public void Change_Printer(string id,
                           string pt, string ps, string col, string sc)
        {
            MainDeviceList.Change_Printer(id, pt, ps, col, sc);
        }


        public void Delete_Device(string id)
        {
            MainDeviceList.Delete_Device(id);
        }


        public bool Find_Device(string id, string name, DateTime RegDate)
        {
            return MainDeviceList.Find_Device(id, name, RegDate);
        }

        public bool Find_Device_ID(string id)
        {
            return MainDeviceList.Find_Device_ID(id);
        }
    }
}
