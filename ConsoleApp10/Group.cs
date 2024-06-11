namespace ConsoleApp10;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime Birthday { get; set; }

    public Student()
    {

    }
    public Student(int id, string name, string surname, DateTime birthday)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Birthday = birthday;
    }
    public override string ToString()
     => $"Id:{Id}\nName:{Name}\nSurname:{Surname}\nBirthday:{Birthday.ToShortDateString()}";


}


public class Group
{

    public int Id { get; set; }
    public string GroupName { get; set; }
    public List<Student> Students { get; set; }
    public Group(int id, string groupName, List<Student> students)
    {
        Id = id;
        GroupName = groupName;
        Students = students;
    }
    public Student this[int index]
    {
        get
        {
            if (index >= 0 || index < Students.Count)
            {
                return Students[index];
            }
            throw new IndexOutOfRangeException();
        }
        set
        {
            Students[index] = value;
        }
    }
}
