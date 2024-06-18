﻿using StarSecurityServices.Models.Common;

namespace StarSecurityServices.Models
{
    public class Department : IStringId
    {
        public string? Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public ICollection<Employee> Employees { get; set; } = [];
    }
}