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
        private List<DeviceMonitor> MonList;
        private List<DevicePrinter> PrList;

        public DeviceList()
        {
            PCList = new List<DevicePC>();
            MonList = new List<DeviceMonitor>();
            PrList = new List<DevicePrinter>();
        }

        public List<DevicePC> Get_PCList()
        {
            return PCList;
        }

        public List<DeviceMonitor> Get_MonList()
        {
            return MonList;
        }

        public List<DevicePrinter> Get_PrList()
        {
            return PrList;
        }

        public DevicePC Get_PC(string id)
        {
            return PCList[PCList.FindIndex(getinfo => getinfo.ID == id)];
        }

        public DeviceMonitor Get_Monitor(string id)
        {
            return MonList[MonList.FindIndex(getinfo => getinfo.ID == id)];
        }

        public DevicePrinter Get_Printer(string id)//////stopPoint
        {
            return PrList[MonList.FindIndex(getinfo => getinfo.ID == id)];
        }

        public void Add_PC(string id, Types type, string name, DateTime RegDate,
                           string ca, string ps, string motherb, string cpu, string ram, string drive, string gc)
        {
            PCList.Add(new DevicePC(id, type, name, RegDate, ca, ps, motherb, cpu, ram, drive, gc));
        }

        public void Add_Monitor(string id, Types type, string name, DateTime RegDate,
                           string diag, string res, string freq, string conn)
        {
            MonList.Add(new DeviceMonitor(id, type, name, RegDate, diag, res, freq, conn));
        }

        public void Change_PC(string id,
                           string ca, string ps, string motherb, string cpu, string ram, string drive, string gc)
        {
            PCList.Find(getInfo => getInfo.ID == id).Rewrite(ca, ps, motherb, cpu, ram, drive, gc);

        }

        public void Change_Monitor(string id,
                           string diag, string res, string freq, string conn)
        {
            MonList.Find(getInfo => getInfo.ID == id).Rewrite(diag, res, freq, conn);

        }

        public bool Find_Device(string id, string name, DateTime RegDate)
        {
            if (PCList.Count > 0)
            {
                DevicePC found1 = PCList.Find(getinfo => getinfo.ID == id &&
                                                   getinfo.Name == name &&
                                                   getinfo.RegistrationDate == RegDate);
                if (found1 != null)
                    return true;
            }

            if (MonList.Count > 0)
            {
                DeviceMonitor found2 = MonList.Find(getinfo => getinfo.ID == id &&
                                                    getinfo.Name == name &&
                                                    getinfo.RegistrationDate == RegDate);
                if (found2 != null)
                    return true;
            }

            return false;
        }

        public bool Find_Device_ID(string id)
        {
            if (PCList.Count > 0)
            {
                DevicePC found1 = PCList.Find(getinfo => getinfo.ID == id);
                if (found1 != null)
                    return true;
            }

            if (MonList.Count > 0)
            {
                DeviceMonitor found2 = MonList.Find(getinfo => getinfo.ID == id);
                if (found2 != null)
                    return true;
            }

            return false;
        }


        public void Delete_Device(string id)
        {
            DevicePC pc_to_remove = PCList.Find(getinfo => getinfo.ID == id);
            if (pc_to_remove != null)
            {
                PCList.Remove(pc_to_remove);
                return;
            }

            DeviceMonitor mon_to_remove = MonList.Find(getinfo => getinfo.ID == id);
            if (mon_to_remove != null)
            {
                MonList.Remove(mon_to_remove);
                return;
            }     
        }
    }
}
