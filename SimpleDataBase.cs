using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterNGeneric
{
    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }


        public void addNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < this.storedData.Count; i++)
            {
                Console.Write($"Data {i + 1} berisi {this.storedData[i].ToString()} yang disimpan pada waktu {inputDates[i].ToString()}");
            }

        }

    }
    class Program1
    {
        private static void Main()
        {
            SimpleDataBase<float> data = new SimpleDataBase<float>();
            data.addNewData(12);
            data.addNewData(34);
            data.addNewData(56);
            data.PrintAllData();
        }
       


    }
}
