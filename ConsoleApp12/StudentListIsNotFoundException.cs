using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionStudentList

{
    public class StudentListIsNotFoundException : Exception
    {
        public StudentListIsNotFoundException()
        {
            throw new StudentListIsNotFoundException("");
        }
        public StudentListIsNotFoundException(string message)
            : base("List student not found")
        {

        }

        public StudentListIsNotFoundException(string message, Exception inner)
        : base(message, inner)
            {


            }
        
    }
}
  


