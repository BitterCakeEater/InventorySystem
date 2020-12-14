using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Classes.Device_Related
{
    [Serializable]
    class DeviceMonitor : Device, ICloneable
    {
        public string Diagonal { get; set; }
        public string Resolution { get; set; }
        public string Frequency { get; set; }
        public string Connector { get; set; }

        public DeviceMonitor(string id, Types type, string name, DateTime RegDate,
                        string diag, string res, string freq, string conn) :
                        base(id, type, name, RegDate)
        {
            Diagonal = diag;
            Resolution = res;
            Frequency = freq;
            Connector = conn;
        }

        public void Rewrite(string diag, string res, string freq, string conn)
        {
            this.Diagonal = diag;
            this.Resolution = res;
            this.Frequency = freq;
            this.Connector = conn;
        }

        public object Clone()
        {
            DeviceMonitor DM = new DeviceMonitor(this.ID, this.Type, this.Name, this.RegistrationDate,
                                     this.Diagonal, this.Resolution, this.Frequency, this.Connector);

            return DM;
        }
    }
}
