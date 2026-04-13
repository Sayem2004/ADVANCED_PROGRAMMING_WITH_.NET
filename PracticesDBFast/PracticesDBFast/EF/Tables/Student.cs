using System;
using System.Collections.Generic;

namespace PracticesDBFast.EF.Tables;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public int DeptId { get; set; }

    public virtual ICollection<CourseStudent> CourseStudents { get; set; } = new List<CourseStudent>();

    public virtual Department Dept { get; set; } = null!;
}
