namespace AbtraCSHW2;

public class Student : Person, IStudentService
{
    private List<Course> _Courses = new List<Course>();
    private Dictionary<Course, string> _Grades = new Dictionary<Course, string>();

    public void EnrollCourse(Course course)
    {
        _Courses.Add(course);
        course.AddStudent(this);
    }

    public void SetGrade(Course course, String Grade)
    {
        _Grades[course] = Grade;
    }

    public double CalculateGPA()
    {
        double totalPoints = 0;
        foreach (var grade in _Grades)
        {
            switch (grade.Value)
            {
                case "A": totalPoints += 4.0; break;
                case "B": totalPoints += 3.0; break;
                case "C": totalPoints += 2.0; break;
                case "D": totalPoints += 1.0; break;
                case "F": totalPoints += 0.0; break;
            }
        }
        return totalPoints / _Grades.Count;
    }
}