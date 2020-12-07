using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Classes.Device_Related
{
    [Serializable]
    public enum Types
    {
        PC = 1,
        Monitor = 2,
        Printer = 3
    }

    [Serializable]
    class Device
    {
        //Main info
        public string ID { get; set; }        
        public Types Type;
        public string Name { get; set; }
        public DateTime RegistrationDate { get; set; }
        
        public Device(string id, Types type, string name, DateTime RegDate)
        {
            ID = id;
            Type = type;
            Name = name;
            RegistrationDate = RegDate;
        }     
    }
}
