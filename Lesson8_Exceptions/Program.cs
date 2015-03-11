using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 10 / 150
 * -----------
 * 160
 * 
 *       ) ] )
 * 
 * [
 * (
 * (
 * throw new Exception("неверная посл. скоб")
 * 
 */



namespace Lesson8_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Work work = new Work();
                work.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Приложение не может выполнить поставленную задачу. \nОбратитесь к системному администратору.");
                SaveErrorInfo(ex);
            }
            

            Console.ReadLine();
        }

        //метод для сохранения полной информации об ошибке
        private static void SaveErrorInfo(Exception ex)
        {
            FileStream stream = new FileStream("error.log", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(DateTime.Now);
            writer.WriteLine(ex.Message);
            writer.WriteLine(ex.StackTrace);
            writer.WriteLine("--------------------------");
            writer.Close();
        }
    }

    class Work
    {
        //в этом методе выполняются все действия
        //вызывается в методе мэйн
        public void Start()
        {
            //throw new Exception("А мне захотелось!");
            //int x = GetNumber();
            //Console.WriteLine(1000/x);
            try
            {
                int a = 2000000000;
                int b = 2000000000;
                checked
                {
                    int c = a + b;
                    Console.WriteLine(c);
                }

            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            { 
            }
            

            /*int x = 1;
            int y = int.MaxValue;
            Console.WriteLine(x+y);
            Console.WriteLine(int.MinValue);*/

        }

        private static int GetNumber()
        {
            Console.WriteLine("Введите чило:");
            while (true)
            {
                try
                {
                    int number;
                    number = int.Parse(Console.ReadLine());
                    //Console.WriteLine(number * number);
                    return number*number;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Вводить надо было число!");
                    Console.WriteLine("Попробуйте еще раз:");
                    Console.WriteLine();
                }
                catch(OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Необходимо ввести число из диапазона [{0}, {1}]", int.MinValue, int.MaxValue);
                    Console.WriteLine("Попробуйте еще раз:");
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Что-то пошло не так");
                    Console.WriteLine("Попробуйте еще раз:");
                    Console.WriteLine();
                }
            }
        }
    }
}
