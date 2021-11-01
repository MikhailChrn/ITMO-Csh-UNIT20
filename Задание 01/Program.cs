using System;

namespace Задание_01
{
    //1.В приложении объявить тип делегата, который ссылается на метод.Требования к сигнатуре метода следующие:
    //-метод получает входным параметром переменную типа double;
    //-метод возвращает значение типа double, которое является результатом вычисления.

    //Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
    //-длину окружности по формуле D = 2 * π * R;
    //-площадь круга по формуле S = π* R²;
    //-объем шара.Формула V = 4 / 3 * π * R³.
    //Методы должны быть объявлены как статические.

    class Program
    {
        delegate double ConvertorDelegate(double radius); //Делегат для конвертора
        public static class CircleConvertor //Класс калькулятор радиуса в окружность
        {
            public static double LengthFromRadius(double radius)
            {
                double length = 2 * Math.PI * radius;
                return length;
            }

            public static double SquareFromRadius(double radius)
            {
                double square = Math.PI * Math.Pow(radius, 2);
                return square;
            }

            public static double BallVolumeFromRadius(double radius)
            {
                double volume = (4 / 3) * Math.PI * Math.Pow(radius, 3);
                return volume;
            }
        }

        static void Main(string[] args)
        {
            double r = 0;
            //Объявляем три экземпляра делегата для методов класса калькулятора радиуса в окружность
            ConvertorDelegate lengthDelegate = CircleConvertor.LengthFromRadius;
            ConvertorDelegate squareDelegate = CircleConvertor.SquareFromRadius;
            ConvertorDelegate volumeDelegate = CircleConvertor.BallVolumeFromRadius;

        ReadRadius:
            Console.WriteLine("Введите значение радиуса окружности R:");
            try { r = Convert.ToDouble(Console.ReadLine()); }
            catch { Console.WriteLine("Введено некорректное значение!"); goto ReadRadius; }

            //Вызываем методы класса калькулятора радиуса в окружность с помощью делегатов
            Console.WriteLine("Длина данной окружности составляет: {0:F2}.", lengthDelegate(r));
            Console.WriteLine("Площадь круга данной окружности составляет: {0:F2}.", squareDelegate(r));
            Console.WriteLine("Объём шара для данной окружности составляет: {0:F2}.", volumeDelegate(r));

            Console.ReadKey();
        }

    }
}
