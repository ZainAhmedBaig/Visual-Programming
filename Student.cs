using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace form3
{
     public class Student
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public float Cgpa { get; set; }
        public String Gender { get; set; }

        public override String ToString()
        {
            return Name;
        }
        public override bool Equals(object obj)
        {
            
            return this.Name.Equals(obj.ToString());
        }
    }

    
}
