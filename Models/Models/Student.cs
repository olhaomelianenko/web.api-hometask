﻿namespace Models.Models
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public Nullable<DateTime> BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string GitHubLink { get; set; }

        public string Notes { get; set; }

        public virtual List<HomeTaskAssessment> HomeTaskAssessments { get; set; } = new List<HomeTaskAssessment>();

        public virtual List<Course> Courses { get; set; } = new List<Course>();

    }
}