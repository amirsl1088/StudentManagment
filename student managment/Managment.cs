using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_managment
{
    public static class Managment
    {
        private static List<Student> _students = new();
        public static void AddStudent(string name,int type,double totalscore,int course,int id)
        {
            if (type == 1)
            {
                var student = new PersianStudent(name, id, totalscore, course);
                var studentAverage=student.Average();
                if (studentAverage < 12)
                {
                    student.situation = Situation.conditionalluy;
                }
                else
                {
                    student.situation = Situation.pass;
                }
                _students.Add(student);
            }
            if (type == 2)
            {
                var student = new ForiegnStudent(name, id, totalscore, course);
                var studentAverage = student.Average();
                if (studentAverage < 12)
                {
                    student.situation = Situation.conditionalluy;
                }
                else
                {
                    student.situation = Situation.pass;
                }
                _students.Add(student);
            }
        }
        public static List<Student> GetStudent()
        {
            return _students;
        } 
    }
}
