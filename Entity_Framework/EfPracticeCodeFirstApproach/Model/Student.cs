using System;

namespace EfPracticeCodeFirstApproach.Model
{
    public class Student
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
        public int BranchId { get; set; } = 0;
        public string Phone { get; set; }// new column added

    }
}
