using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using InventorySystem.Classes.Device_Related;
using InventorySystem.Classes;
using System.IO;
using System.Windows.Forms;

namespace InventorySystem
{
    class FileSystem
    {
        public static bool Save_Container_List(List<InventorySystemContainer> ContainerList)
        {
            BinaryFormatter BinF = new BinaryFormatter();

            using (FileStream fstream = new FileStream("ContainerListData.dat", FileMode.OpenOrCreate))
            {
                try
                {
                    BinF.Serialize(fstream, ContainerList);
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


        public static bool Load_Container_List(ref List<InventorySystemContainer> ContainerList)
        {
            BinaryFormatter BinF = new BinaryFormatter();

            using (FileStream fstream = new FileStream("ContainerListData.dat", FileMode.OpenOrCreate))
            {
                if (File.Exists("ContainerListData.dat") && fstream.Length != 0)
                {
                    try
                    {
                        ContainerList = (List<InventorySystemContainer>)BinF.Deserialize(fstream);
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
