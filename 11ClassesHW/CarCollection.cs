using System;
using System.Collections.Generic;
using System.Text;

namespace _11ClassesHW
{
    class CarCollection<T> : MyList<T>
    {
        private readonly MyList<string> carName; 
        private readonly MyList<DateTime> carYear;

        public CarCollection()
        {
            carName = new MyList<string>();
            carYear = new MyList<DateTime>();

        }
        public void AddCar(string deadPool, DateTime year)
        {
            carName.Add(deadPool);
            carYear.Add(year);
        }
        public new string this[int index]
        {
            get
            {
                if (index < carName.Count)
                    return carName[index] + " " + carYear[index].Year + " г";
                return "В списке нет машины под таким номером!";
            }
        }
        public int Lenght
        {
            get
            {
                return carName.Count;
            }
        }

        public void Remove()
        {
            carName.Clear();
            carYear.Clear();
        }

        public override string ToString() //Метод отображения содержимого
        {
            string stroka = null;
            for (int i = 0; i < carName.Count; i++)
            {
                stroka += "№" + (i + 1) + " " + carName[i] + " " + carYear[i].Year + " г \n";
            }
            if (stroka != null) return stroka;
            return "В парке нет ни одной машины!";
        }
    }
}
