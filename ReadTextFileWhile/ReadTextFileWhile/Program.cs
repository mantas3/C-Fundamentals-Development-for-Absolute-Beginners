using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTextFileWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader myReader = new StreamReader("Values1.txt");
                string line = "";

                while (line != null)
                {
                    line = myReader.ReadLine();
                    if (line != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                myReader.Close();                
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found. Are you sure file exists?");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Directory not found. Are you sure directory exists?");
            }
            catch (Exception e)
            {
                //Console.WriteLine("We experienced a problem! Sorry.");
                Console.WriteLine("We experienced a problem: {0}", e.Message);
            }
            finally
            {
                //Final touches
            }
            Console.ReadLine();
        }
    }
}
