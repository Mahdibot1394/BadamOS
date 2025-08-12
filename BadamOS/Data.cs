using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.System.FileSystem;

namespace BadamOS
{
    public class Data
    {
        public static Dictionary<string, string> Datas = new Dictionary<string, string>()
        {
            {"**OS Name", "BadamOS"},
            {"Username", "USER"},
            {"DEFAULT","1"},

        };
        public static void AddData(string key, string value)
        {
            
        }
        public static void DelData(string key)
        {
            Datas.Remove(key);
        }
        public static string GetData(string key)
        {
            return Datas[key];
        }
    }
}
