using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, string>();
            dic.AddToDictionary("table", "стол"); //Добавлаем значения в словарь
            dic.AddToDictionary("apple", "яблоко");
            dic.AddToDictionary("sun", "солнце");
            dic.AddToDictionary("pencil", "карандаш");
            dic.AddToDictionary("cap", "чашка");
            dic.AddToDictionary("tea", "чай");

            Console.WriteLine(dic.ToString());
            Console.WriteLine();
            Console.WriteLine("В словаре {0} записей", dic.Lenght);

            Console.WriteLine("Введите номер записи в словаре:");
            string str = Console.ReadLine();
            
                int nomer = Convert.ToInt32(str);
                Console.WriteLine(dic[nomer - 1]); 
            

            Console.WriteLine("Введите значение для поиска");
            string p = Console.ReadLine();
            Console.WriteLine(dic[p]); 


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
