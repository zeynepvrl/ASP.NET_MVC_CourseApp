﻿namespace basics.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Img { get; set; }
        public string? Descrip { get; set; }
        public string[]? Tags { get; set; }
        public bool isActive { get; set; }
        public bool isHome { get; set; }

    }
}
