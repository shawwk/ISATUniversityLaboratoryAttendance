using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsStudent;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsTeacher;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.TeacherService
{
    public interface ITeacherService
    {
        Teacher AddTeacher(Teacher teacher);
        Teacher UpdateTeacher(Teacher teacher);
        List<Teacher> GetTeacher(string name);
        List<Teacher> GetAllTeacher();
        Teacher GetTeacherById(Int64 teacherId);
        Teacher DeactivateTeacher(Teacher teacher);
        List<Student> StudentRecord(Int64 teacherId, Int64 sectionId, Int64 subjectId);
        bool IsEmployeeIDExist(Int64 empId);
        Teacher GetTeacherByIdNumber(Int64 teacherId);
    }
}
