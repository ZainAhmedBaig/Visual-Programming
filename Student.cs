using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Student
    {
        public string name { get; set; }
        public int age { get; set; }
        public float cgpa { get; set; }
        public string gender { get; set; }

        public override String ToString()
        {
            return name;
        }

        public override bool Equals(object obj)
        {
            if (!Convert.IsDBNull(obj))
            {
                Student s = (Student)obj;
                return this.name.Equals(s.name);
            }

            return false;
        }

    }
}
