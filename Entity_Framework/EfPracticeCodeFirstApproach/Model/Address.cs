using System;

namespace EfPracticeCodeFirstApproach.Model
{
    public class Address
    {
        public int Id { get; set; } = 0;
        public int StudentId { get; set; } = 0;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Pin { get; set; } = string.Empty;
    }
}
