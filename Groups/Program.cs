namespace Groups
{
    public class Student
    {
        // Поля класу
        public string Name { get; set; }
        public int Age { get; set; }
        
        // Метод додавання студента
        public void AddStudent(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Метод отримання інформації про студента
        public string GetStudentInfo()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
