using CleanArch.Application.ViewModels;
using System.Collections.Generic;

namespace CleanArch.Application.Services
{
    public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
    }
}
