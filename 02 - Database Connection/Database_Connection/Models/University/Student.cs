using System.ComponentModel.DataAnnotations;

namespace Database_Connection.Models.University;

public class Student
{
    [Key]
    public int Stu_id { get; set; }         // -- student id

    public string Stu_name { get; set; }    // --student name

    public string Stu_place { get; set; } 	// --student address(the place part of it)

    public DateTime Stu_bdate { get; set; } // --student date of enrollment

    public string Stu_gender { get; set; }  // --student gender

    public string Stu_email { get; set; }   // --student email

    public int Stu_Cour_id { get; set; }    // -- foreign key
}