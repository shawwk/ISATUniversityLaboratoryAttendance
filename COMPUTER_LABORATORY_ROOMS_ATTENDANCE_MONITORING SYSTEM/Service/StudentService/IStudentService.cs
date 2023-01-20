using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsClassSchedule;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsStudent;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsSubject;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsTeacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.StudentService
{
    public interface IStudentService
    {
        Student AddStudent(Student student);
        Student UpdateStudent(Student student);
        List<Student> GetStudent(string name);
        List<Student> GetAllStudent();
        Student GetStudentById(Int64 studentId);
        Student DeactivateStudent(Student student);
        Student GetStudentByIdNumber(Int64 IdNumber);
        List<Schedule> GetSubjects(Int64 studentId);
        bool IsStudentIdExists(Int64 studentId);
    }
}
