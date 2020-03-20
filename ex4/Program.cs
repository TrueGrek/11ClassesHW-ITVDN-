using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList m = new MyArrayList(); //Создание переменной типа MyArrayList

            m.Add(5); //Добавление записей в коллекцию
            m.Add("Hello");
            m.Add('d');
            m.Add(5.78);

            Console.WriteLine("Массив:");
            Console.WriteLine(m.ToString()); //Отображение значений коллекции

            // Delay.
            Console.ReadKey();
        }
    }
    class MyArrayList
    {
        private object[] array; 

        public MyArrayList() 
        {
            array = new object[0]; 
        }

        public void Add(object a) //Метод добавления значения
        {
            object[] tempArray = new object[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            tempArray[array.Length] = a;
            array = tempArray;
        }

        public object this[int index]//Индексатор
        {
            get
            {
                return array[index];
            }
        }

        public int Count //Свойство для возвращения количества элементов в массиве
        {
            get //Аксессор
            {
                return array.Length;
            }
        }

        public void Clear() //Метод очистки массива 
        {
            array = new object[0];
        }

        public bool Contains(object item) //Метод-предикат предназначеный для поиска элемента в массиве
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == item) //Сравнение элементов массива с параметром item
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString() //Переопределенный метод ToString базового класса object
        {
            string stroka = null;
            for (int i = 0; i < array.Length; i++)
            {
                stroka += array[i] + " ";
            }
            return "Размерность массива " + array.Length + " Элементы массива:" + stroka;
        }
    }
}
