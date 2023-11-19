using System;
using System.Collections.Generic;

namespace Course;

public partial class StudentsCoursesXref
{
    public string StudentPin { get; set; } = null!;

    public int CourseId { get; set; }

    public DateTime? CompletionDate { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual Student StudentPinNavigation { get; set; } = null!;
}
