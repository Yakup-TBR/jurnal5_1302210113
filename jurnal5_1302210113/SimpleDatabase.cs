using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnal5_1302210113
{
    internal class SimpleDatabase<T>
    {
        private T storedData;
        //private Date inputDate;

        public SimpleDatabase(T storedData)
        {
            this.storedData = storedData;
        }

        public void AddNewData(T storedData)
        {

        }

    }
}
