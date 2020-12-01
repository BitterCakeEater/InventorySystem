using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Classes.Device_Related
{
    [Serializable]
    class Device
    {
        //Main info
        public string ID { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public DateTime RegistrationDate { get; set; }
        
        public Device(string id, string type, string name, DateTime RegDate)
        {
            ID = id;
            Type = type;
            Name = name;
            RegistrationDate = RegDate;
        }     
    }
}
