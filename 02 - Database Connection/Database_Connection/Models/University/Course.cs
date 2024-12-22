using System.ComponentModel.DataAnnotations;

namespace Database_Connection.Models.University;

public class Course
{
    [Key]
    public int Cour_id { get; set; }
    public string Cour_name { get; set; }	// --course name
}