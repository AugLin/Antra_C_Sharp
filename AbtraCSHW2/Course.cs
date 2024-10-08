namespace AbtraCSHW2;

public class Course
{
    public string CourseName { get; set; }
    private List<Student> _Students = new List<Student>();

    public void AddStudent(Student student)
    {
        _Students.Add(student);
    }

    public int GetStudents()
    {
        return _Students.Count;
    }
}