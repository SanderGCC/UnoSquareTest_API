﻿namespace UnoSquareTest.DTOs.Tasks
{
    public class AddTaskRequestDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public bool Complete { get; set; }
    }
}