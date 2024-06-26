﻿namespace StarSecurityServices.DTOs.Departments
{
    public class UpdateDepartmentDTO
    {
        public string Id { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public IEnumerable<string> EmployeeIds { get; set; } = [];
    }
}
