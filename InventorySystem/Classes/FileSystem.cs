using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using InventorySystem.Classes.Device_Related;
using System.IO;
using System.Windows.Forms;

namespace Library.Classes
{
    class FileSystem
    {
        public static bool Save_Device_List(DeviceList DevList)
        {
            BinaryFormatter BinF = new BinaryFormatter();

            using (FileStream fstream = new FileStream("DeviceListData.dat", FileMode.OpenOrCreate))
            {
                try
                {
                    BinF.Serialize(fstream, DevList);
                    fstream.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(
                    ex.Message,
                    "Увага!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);

                    return false;
                }
            }

            return true;
        }


        public static bool Load_Device_List(ref DeviceList DevList)
        {
            BinaryFormatter BinF = new BinaryFormatter();

            using (FileStream fstream = new FileStream("DeviceListData.dat", FileMode.OpenOrCreate))
            {
                if (File.Exists("DeviceListData.dat") && fstream.Length != 0)
                {
                    try
                    {
                        DevList = (DeviceList)BinF.Deserialize(fstream);
                        fstream.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(
                        ex.Message,
                        "Увага!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);

                        return false;
                    }

                    return true;
                }

                else
                    return false;
            }
        }        
    }
}
