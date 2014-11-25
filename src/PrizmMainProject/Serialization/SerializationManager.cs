using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Serialization
{
    public static class SerializationManager
    {
        public static readonly IFormatter formatter = new BinaryFormatter();
        public static readonly string fileName = "dataStuff.myData";
        public static FileStream s = new FileStream(fileName, FileMode.Create);

        public static void SaveToFile(MillData data) 
        {
            formatter.Serialize(s, data);
            s.Close();
        }


        public static MillData GetFromFile(string File) 
        {
            FileStream readFile = new FileStream(File, FileMode.Open);
            MillData data = (MillData)formatter.Deserialize(readFile);
            return data;
        }
    }
}
