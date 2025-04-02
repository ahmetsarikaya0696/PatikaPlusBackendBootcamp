using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik44
{
    public class Classroom
    {
        public ITeacher Teacher { get; set; }

        public Classroom(ITeacher teacher)
        {
            Teacher = teacher;
        }

        public string GetTeacherInfo()
        {
            return Teacher.GetInfo();
        }
    }
}
