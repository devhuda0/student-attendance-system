using System;

namespace StudentAttendanceSystem
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public string Schedule { get; set; } = string.Empty;
        public int AbsenceLimit { get; set; }
        public int InstructorId { get; set; }

        public override string ToString() => CourseName;
    }

    public class Lecture
    {
        public int LectureId { get; set; }
        public int CourseId { get; set; }
        public string Date { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;

        public override string ToString() => $"{Date} ({Time})";
    }

    public class StudentAttendanceRow
    {
        public int RecordId { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Status { get; set; } = "Present";
        public int TotalAbsences { get; set; }
        public double AttendancePercentage { get; set; }
    }
}
