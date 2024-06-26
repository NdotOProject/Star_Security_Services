﻿using StarSecurityServices.Models;

namespace StarSecurityServices.DTOs.Grades
{
    public class GradeDTO
    {
        public string Id { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public class Mapper
            : AbstractMapper<Grade, GradeDTO>
        {
            public override GradeDTO Map(Grade grade)
            {
                return new GradeDTO
                {
                    Id = grade.Id,
                    Description = grade.Description,
                    Name = grade.Name,
                };
            }
        }
    }
}
