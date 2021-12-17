using System;

namespace task_15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression(); //создаем объект класса
            arithProgression.setStart(6);  //устанавлваем начальное значение
            Console.WriteLine("Арифметическая прогрессия:");
            Console.WriteLine(arithProgression.getNext());  //выводим следующее число ряда
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            arithProgression.reset();   //сбрасываем к начальному значению
            Console.WriteLine();
            GeomProgression geomProgression = new GeomProgression();    //создаем объект класса
            geomProgression.setStart(6);    //устанавлваем начальное значение
            Console.WriteLine("Геометрическая прогрессия:");
            Console.WriteLine(geomProgression.getNext());   //выводим следующее число ряда
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            geomProgression.reset();    //сбрасываем к начальному значению
            Console.ReadKey();
        }
    }
    interface ISeries   //интерфейс
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries    //класс арифм прогрессии
    {
        int firstNumber;
        int step = 3;
        int next;
        public void setStart(int x) //устанавливает начальное значение
        {
            firstNumber = x;
            next = x;
        }
        public int getNext()    //возвращает следующее число ряда
        {
            next = next + step;
            return next;
        }
        public void reset() //выполняет сброс к начальному значению
        {
            next = firstNumber;
        }
    }
    class GeomProgression : ISeries //класс геом прогрессии
    {
        int firstNumber;
        int step = 3;
        int next;
        public void setStart(int x) //устанавливает начальное значение
        {
            firstNumber = x;
            next = x;
        }
        public int getNext()    //возвращает следующее число ряда
        {
            next = next * step;
            return next;
        }
        public void reset() //выполняет сброс к начальному значению
        {
            next = firstNumber;
        }
    }
}