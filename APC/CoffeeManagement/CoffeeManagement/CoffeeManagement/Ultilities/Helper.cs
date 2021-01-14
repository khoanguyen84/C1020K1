using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
namespace CoffeeManagement.Ultilities
{
    public class Helper
    {
        public static T ReadFile<T>(string fullPath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    var tableData = sr.ReadToEnd();
                    return JsonConvert.DeserializeObject<T>(tableData);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public static void WriteFile<T>(string fullPath, T data)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath))
                {
                    sw.Write(JsonConvert.SerializeObject(data,Formatting.Indented));
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
