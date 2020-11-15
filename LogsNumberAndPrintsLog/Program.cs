using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogsNumberAndPrintsLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi There!!! Please Enter A Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\LaurieSue\source\repos\LogsNumberAndPrintsLog\LogsNumberAndPrintsLog\Log\log.txt", true))
            {
                file.WriteLine(num);
            }
            if (File.Exists(@"C:\Users\LaurieSue\source\repos\LogsNumberAndPrintsLog\LogsNumberAndPrintsLog\Log\log.txt"))
            {
                StreamReader TextFile = new StreamReader(@"C:\Users\LaurieSue\source\repos\LogsNumberAndPrintsLog\LogsNumberAndPrintsLog\Log\log.txt");
                string line;

                while ((line = TextFile.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                TextFile.Close();
                Console.ReadKey();
            }
       
            Console.WriteLine();
        }

    }
}
