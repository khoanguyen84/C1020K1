using CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using CoffeeManagement.Ultilities;

namespace CoffeeManagement.Services
{
    public class TableService : BaseService
    {
        public Tables data { get; set; }
        private readonly string fileName = "tables.json";
        private readonly string fullPath;

        public TableService()
        {
            fullPath = $@"{path}\{fileName}";
            data = Helper.ReadFile<Tables>(fullPath);
        }

        #region public

        public void Update(int tableId, int status)
        {
            Table table = FindTable(tableId);
            if(table.tableId != 0)
            {
                table.status = status;
                Helper.WriteFile<Tables>(fullPath, data);
            }
        }

        public void Display()
        {
            foreach (Table tb in data.tables)
            {
                Console.WriteLine(tb.ToString());
            }
        }
        public Table FindTable(int tableId)
        {
            foreach (Table tb in data.tables)
            {
                if (tb.tableId == tableId)
                {
                    return tb;
                }
            }
            return new Table();
        }
        #endregion
    }
}
