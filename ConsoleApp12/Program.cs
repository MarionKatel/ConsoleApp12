using ExceptionStudentList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StudentListIsNotFoundException ret = new StudentListIsNotFoundException();
                    throw  ret;
           
            }
       /* {
            short y = 1;


            try
            {
                int u = Convert.ToInt32(y);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (StudentListIsNotFoundException str) { }
            

            try
            {
                
              int z = 8;
             }*/


                catch (StudentListIsNotFoundException stuEx)
                {
                Console.WriteLine( stuEx.Message);

                }
            finally
            {
                Console.ReadLine();
              
            }
            }
        }

    }

