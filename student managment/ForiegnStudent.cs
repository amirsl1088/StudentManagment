using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_managment
{
    public class ForiegnStudent:Student
    {

        public ForiegnStudent(string name, int id, double score, int course) : base(name, id, score, course)
        {

        }

        public override void SetCourse(int course)
        {
            if (course > 20)
            {
                throw new Exception("you cannot use more than 20 courses");
            }
            base.SetCourse(course);
        }
    }
}

