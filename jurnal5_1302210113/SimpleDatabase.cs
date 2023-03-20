using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnal5_1302210113
{
    internal class SimpleDatabase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDate;

        public SimpleDatabase(T storedData)
        {
            List<T> data = new List<T>();
        }

        public void AddNewData(T storeData)
        {
            this.storedData.Add(storeData);
            this.inputDate.Add(DateTime.Now);
        }

        public void printAllData()
        {
            Console.WriteLine("Data " + storedData[0] + "berisi" + storedData[1] + ", yang disimpan pada waktu" + inputDate);
        }

    }
}
