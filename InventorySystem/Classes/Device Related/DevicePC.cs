using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Classes.Device_Related
{
    [Serializable]
    class DevicePC : Device, ICloneable
    {
        public string Case { get; set; }
        public string PowerSupply { get; set; }
        public string Moterboard { get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Drive { get; set; }
        public string GraphicsCard { get; set; }

        public DevicePC(string id, Types type, string name, DateTime RegDate,
                        string ca, string ps, string motherb, string cpu, string ram, string drive, string gc) :
                        base(id, type, name, RegDate)
        {
            Case = ca;
            PowerSupply = ps;
            Moterboard = motherb;
            CPU = cpu;
            RAM = ram;
            Drive = drive;
            GraphicsCard = gc;
        }

        public void Rewrite(string ca, string ps, string motherb, string cpu, string ram, string drive, string gc)
        {
            this.Case = ca;
            this.PowerSupply = ps;
            this.Moterboard = motherb;
            this.CPU = cpu;
            this.RAM = ram;
            this.Drive = drive;
            this.GraphicsCard = gc;
        }

        public object Clone()
        {
            DevicePC DP = new DevicePC(this.ID, this.Type, this.Name, this.RegistrationDate,
                                     this.Case, this.PowerSupply, this.Moterboard, this.CPU,
                                     this.RAM, this.Drive, this.GraphicsCard);

            return DP;
        }
    }
}
