using Database_Connection.Database;
using Database_Connection.Models.University;
using Microsoft.AspNetCore.Mvc;

namespace Database_Connection.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UniversityController : Controller
{
    private readonly DatabaseContext _dbContext;

    public UniversityController(DatabaseContext context) {
        _dbContext = context;
    }

    #region COURSES

    [HttpGet("GetCourses")]
    public IEnumerable<Course> GetCourses() {
        return _dbContext.Course.ToList();
    }

    [HttpGet("GetCourseById/{id}")]
    public Course GetCourseById(int id) {
        return _dbContext.Course.FirstOrDefault(x => x.Cour_id == id);
    }

    [HttpGet("GetCourseByName/{name}")]
    public Course GetCourseByName(string name)
    {
        return _dbContext.Course.FirstOrDefault(x => x.Cour_name == name);
    }

    [HttpPost("InsertCourse")]
    public IActionResult InsertCourse([FromBody] Course course) {
        _dbContext.Course.Add(course);
        _dbContext.SaveChanges();
        return StatusCode(200, course);
    }

    [HttpPut("UpdateCourse")]
    public IActionResult UpdateCourse([FromBody] Course course)
    {
        if (course != null)
        {
            if (course.Cour_id > 0)
            {
                Course cour = _dbContext.Course.FirstOrDefault(x => x.Cour_id == course.Cour_id);

                if (cour != null)
                {
                    cour.Cour_name = course.Cour_name;

                    _dbContext.Update(cour);
                    _dbContext.SaveChanges();

                    return StatusCode(200, "Course Successfully updated!");
                }
                else
                {
                    return StatusCode(200, "Course not updated!");
                }
            }
            else
            {
                return StatusCode(200, "Course not updated!");
            }
        }
        else
        {
            return StatusCode(200, "Course not updated!");
        }
    }

    [HttpDelete("DeleteCourse/{id}")]
    public IActionResult DeleteCourse(int id) {

        var course = new Course { Cour_id = id };

        _dbContext.Course.Remove(course);
        _dbContext.SaveChanges();

        return StatusCode(200, "Course Successfully deleted!");
    }

    #endregion

    #region STUDENTS

    [HttpGet("GetStudents")]
    public IEnumerable<Student> GetStudents()
    {
        return _dbContext.Student.ToList();
    }

    [HttpGet("GetStudentById/{id}")]
    public Student GetStudentById(int id)
    {
        return _dbContext.Student.FirstOrDefault(x => x.Stu_id == id);
    }

    [HttpPost("InsertStudent")]
    public IActionResult InsertStudent([FromBody] Student student)
    {
        _dbContext.Student.Add(student);
        _dbContext.SaveChanges();
        return StatusCode(200, student);
    }

    [HttpPut("UpdateStudent")]
    public IActionResult UpdateStudent([FromBody] Student student) {
        if (student != null)
        {
            if (student.Stu_id > 0)
            {
                Student stu = _dbContext.Student.FirstOrDefault(x => x.Stu_id == student.Stu_id);

                if (stu != null)
                {
                    stu.Stu_name = student.Stu_name;
                    stu.Stu_place = student.Stu_place;
                    stu.Stu_email = student.Stu_email;
                    stu.Stu_bdate = student.Stu_bdate;
                    stu.Stu_gender = student.Stu_gender;
                    stu.Stu_Cour_id = student.Stu_Cour_id;

                    _dbContext.Update(stu);
                    _dbContext.SaveChanges();

                    return StatusCode(200, "Student Successfully updated!");
                }
                else
                {
                    return StatusCode(200, "Student not updated!");
                }
            }
            else
            {
                return StatusCode(200, "Student not updated!");
            }
        }
        else
        {
            return StatusCode(200, "Student not updated!");
        }
    }

    [HttpDelete("DeleteStudent/{id}")]
    public IActionResult DeleteStudent(int id)
    {

        var student = new Student { Stu_id = id };

        _dbContext.Student.Remove(student);
        _dbContext.SaveChanges();

        return StatusCode(200, "Student Successfully deleted!");
    }

    #endregion

}