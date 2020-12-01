using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Classes.Device_Related
{
    [Serializable]
    class DeviceList
    {
        private List<DevicePC> PCList;

        public DeviceList()
        {
            PCList = new List<DevicePC>();
        }

        public List<DevicePC> Get_PCList()
        {
            return PCList;
        }

        public DevicePC Get_PC(string id)
        {
            return PCList[PCList.FindIndex(getinfo => getinfo.ID == id)];
        }

        public void Add_PC(string id, string type, string name, DateTime RegDate,
                           string ca, string ps, string motherb, string cpu, string ram, string drive, string gc)
        {
            PCList.Add(new DevicePC(id, type, name, RegDate, ca, ps, motherb, cpu, ram, drive, gc));
        }

        public void Change_PC(string id,  
                           string ca, string ps, string motherb, string cpu, string ram, string drive, string gc)
        {
            PCList.Find(getInfo => getInfo.ID == id).Rewrite(ca, ps, motherb, cpu, ram, drive, gc);
           
        }

        public bool Find_PC(string id, string type, string name, DateTime RegDate)
        {
            DevicePC found = PCList.Find(getinfo => getinfo.ID == id &&
                                                    getinfo.Type == type &&
                                                    getinfo.Name == name &&
                                                    getinfo.RegistrationDate == RegDate);

            if (found != null)
                return true;

            return false;
        }

        public bool Find_PC_ID(string id)
        {
            DevicePC found = PCList.Find(getinfo => getinfo.ID == id);

            if (found != null)
                return true;

            return false;
        }


        public void Delete_PC(string id)
        {
            DevicePC pc_to_remove = PCList.Find(getinfo => getinfo.ID == id);

            PCList.Remove(pc_to_remove);
        }
    }
}
