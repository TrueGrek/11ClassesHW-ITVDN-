using System;

namespace _11ClassesHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Парк машин: ");
            var park = new CarCollection<string>();

            park.AddCar("Жигули", new DateTime(1985, 12, 5)); //Добавление нового элемента в коллекцию
            park.AddCar("Тойота", new DateTime(2000, 4, 7));
            park.AddCar("Форд", new DateTime(2005, 5, 3));
            park.AddCar("Мерседес", new DateTime(2003, 11, 3));

            Console.WriteLine(park.ToString());
            Console.WriteLine("В парке находится: {0} машин", park.Lenght);

            Console.WriteLine("Введите номер интересующей вас машины:");
            string stroka = Console.ReadLine();

            int nomer = Convert.ToInt32(stroka);
            Console.WriteLine(park[nomer - 1]);
            Console.ReadKey();
        }
    }
    public interface IMyList<T> //Параметризированный интерфейс IMyList
    {
        void Add(T a);
        T this[int index] { get; }
        int Count { get; }
        void Clear();
        bool Contains(T item);
    }

    class MyList<T> : IMyList<T> //Параметризированный класс MyList<T> который наследуется от параметризированного интерфейса IMyList<T>
    {
        private T[] array; //Массив элементов типа T

        public MyList() //Конструктор по умолчанию
        {
            array = new T[0]; //Инициализация массива
        }

        public void Add(T a)  //Метод добавления значения в коллекцию
        {
            T[] tempArray = new T[array.Length + 1]; //Создаем новый массив
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i]; //Копирование элементов в новый массив
            }
            tempArray[array.Length] = a; //Добавляем новый элемент в конец массива
            array = tempArray; //Присваиваем переменной array ссылку на tempArray
        }

        public T this[int index] //Индексатор
        {
            get //Акссесор
            {
                return array[index];
            }
        }

        public int Count //Свойство для возвращения длины коллекции
        {
            get //Акссесор
            {
                return array.Length;
            }
        }

        public void Clear() //Метод очистки коллекции
        {
            array = new T[0]; //Заменяем текущий массив пустым массивом
        }

        public bool Contains(T item) //Метод-предикат предназначеный для проверки наличия значения в коллекции
        {
            for (int i = 0; i < array.Length; i++) //Проход по всем элементам
            {
                if ((int)(object)array[i] == (int)(object)item) //Сравнение значений
                {
                    return true; //Если искомое значение присутствует в коллекции возвращаем true
                }
            }
            return false;//Если искомое значение не присутствует в коллекции возвращаем false
        }

        public override string ToString() //Переопредиление метода ToString базового класса Object 
        {
            string stroka = null;
            for (int i = 0; i < array.Length; i++)
            {
                stroka += array[i] + " "; //Записывем значения из массива в переменную строкового типа
            }
            return "Размерность массива " + array.Length + " Элементы массива:" + stroka;
        }
    }
}
