using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjuntos.Entities
{
    internal class Student
    {
        public int Enrollment { get; set; }

        public override int GetHashCode()
        {
            return Enrollment.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Student)
                return false;

            Student student = (Student)obj;
            return Enrollment.Equals(student.Enrollment);
        }
    }
}
