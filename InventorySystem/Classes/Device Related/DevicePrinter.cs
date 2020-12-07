using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Classes.Device_Related
{
    [Serializable]
    class DevicePrinter : Device
    {
        public string PrintTechnology { get; set; }
        public string PaperSize { get; set; }
        public string Colors { get; set; }

        public DevicePrinter(string id, Types type, string name, DateTime RegDate,
                        string pt, string ps, string col) :
                        base(id, type, name, RegDate)
        {
            PrintTechnology = pt;
            PaperSize = ps;
            Colors = col;
        }

        public void Rewrite(string pt, string ps, string col)
        {
            this.PrintTechnology = pt;
            this.PaperSize = ps;
            this.Colors = col;
        }
    }
}
