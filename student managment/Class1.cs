using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_managment
{
    public abstract class Student : IMyinterface
    {
        public Student(string name, int id, double score, int course)

        {
            Name = name;
            Id = id;
            TotalScore = score;
            Course = course;
        }
        public string Name { get; set; }
        public int Id { get; set; }
        public double TotalScore { get; set; }
        public int Course { get; set; }
        public Situation situation { get; set; }
        public virtual void SetCourse(int course)
        {
            if (course <= 0)
            {
                throw new Exception("you cannot use less than 0 course");
            }
        }

        public double Average()
        {
            var studentAverage = TotalScore / Course;
           
            return studentAverage;
        }
    }
    
    
   
    public enum Situation
    {
        pass,conditionalluy
    }

}
