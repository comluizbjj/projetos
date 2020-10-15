using System;
using System.Collections.Generic;
using System.Text;

namespace ModuloXV.Entities
{
    class Students
    {
        public int IdStudents { get; set; }
        public string Course { get; set; }

       

        public override int GetHashCode()
        {
            return IdStudents.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Students))
            {
                return false;
            }
            Students other = obj as Students;
            return IdStudents.Equals(other.IdStudents);
        }
    }
}
