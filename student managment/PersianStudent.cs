using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_managment
{
    public class PersianStudent:Student
    {
        public PersianStudent(string name, int id, double score, int course) : base(name, id, score, course)
        {

        }

        public override void SetCourse(int course)
        {
            if (course > 24)
            {
                throw new Exception("you cannot use more than 24 courses");
            }
            base.SetCourse(course);
        }
    }
}
