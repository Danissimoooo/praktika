using System;

public class StudentTests
{
    public void TestAddStudent()
    {
        Student student = new Student();
        student.AddStudent("John", 20);

        // Assert
        if (student.Name != "John" || student.Age != 20)
        {
            Console.WriteLine("AddStudent test failed.");
        }
        else
        {
            Console.WriteLine("AddStudent test passed.");
        }
    }

    public void TestGetStudentInfo()
    {
        Student student = new Student();
        student.AddStudent("Jane", 22);

        // Assert
        if (student.GetStudentInfo() != "Name: Jane, Age: 22")
        {
            Console.WriteLine("GetStudentInfo test failed.");
        }
        else
        {
            Console.WriteLine("GetStudentInfo test passed.");
        }
    }
}
