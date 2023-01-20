using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsSubject;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.SubjectService
{
    public interface ISubjectService
    {
        List<Subjects> GetSubjects(string subj);
        Subjects AddSubject(Subjects subject);
        Subjects UpdateSubject(Subjects subject);
        List<Subjects> GetAllSubject();
        Subjects GetSubjectById(Int64 Id);
        List<Subjects> GetSubjectByStudent(Int64 studentId);
        bool CheckSubject(Subjects subjects);
        void Deactivate(Subjects subjects);
    }
}
