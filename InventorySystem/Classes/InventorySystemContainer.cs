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

  
        public void Add_PC(string id, string type, string name, DateTime RegDate,
                           string ca, string ps, string motherb, string cpu, string ram, string drive, string gc)
        {
            MainDeviceList.Add_PC(id, type, name, RegDate, ca, ps, motherb, cpu, ram, drive, gc);
        }

        
        public void Change_PC(string id, 
                           string ca, string ps, string motherb, string cpu, string ram, string drive, string gc)
        {
            MainDeviceList.Change_PC(id, ca, ps, motherb, cpu, ram, drive, gc);
        }


        public void Delete_PC(string id)
        {
            MainDeviceList.Delete_PC(id);
        }


        public bool Find_PC(string id, string type, string name, DateTime RegDate)
        {
            return MainDeviceList.Find_PC(id, type, name, RegDate);
        }

        public bool Find_PC_ID(string id)
        {
            return MainDeviceList.Find_PC_ID(id);
        }
    }
}
