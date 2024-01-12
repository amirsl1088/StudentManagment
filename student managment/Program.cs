using student_managment;

while (true)
{
    Console.WriteLine("choose option:\n1.add student\n2.show students with details");
    var input = int.Parse(Console.ReadLine()!);
    switch (input)
    {
        case 1:
            {
                Console.WriteLine("enter student name");
                var studentName = Console.ReadLine()!;
                Console.WriteLine("1.persian    2.foriegn");
                var type = int.Parse(Console.ReadLine()!);
                Console.WriteLine("enter student id");
                var studentId = int.Parse(Console.ReadLine()!);
                Console.WriteLine("enter total score");
                var totalScore = double.Parse(Console.ReadLine()!);
                Console.WriteLine("enter student course");
                var studentCourse = int.Parse(Console.ReadLine()!);
                Managment.AddStudent(studentName, type, totalScore, studentCourse, studentId);
                break;
            }
        case 2:
            {
                foreach(var student in Managment.GetStudent())
                {
                    Console.WriteLine($"name={student.Name}, id={student.Id},average={student.Average()}" +
                        $",course={student.Course}, situation={student.situation}");
                }
                break;
            }
    }
}
