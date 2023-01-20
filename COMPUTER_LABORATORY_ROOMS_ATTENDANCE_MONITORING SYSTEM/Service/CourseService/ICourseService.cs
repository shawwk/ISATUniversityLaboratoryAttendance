using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsCourse;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsSection;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.CourseService
{
    public interface ICourseService
    {
        List<Course> GetCourse(string sectionName);
        Course AddCourse(Course section);
        bool CheckCourse(Course course);
        Course UpdateCourse(Course section);
        List<Course> GetAllCourse();
        Course GetCourseById(Int64 Id);
        void Deactivate(Course sections);
    }
}
