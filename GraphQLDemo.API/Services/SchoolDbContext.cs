using GraphQLDemo.API.DTOs;
using Microsoft.EntityFrameworkCore;

namespace GraphQLDemo.API.Services;

public class SchoolDbContext
{
    public DbSet<CourseDTO> Courses { get; set; }
    public DbSet<InstructorDTO> Instructors { get; set; }
    public DbSet<StudentDTO> Students { get; set; }
}
