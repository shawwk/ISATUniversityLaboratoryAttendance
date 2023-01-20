using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsSection;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsSubject;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.SectionService
{
    public interface ISectionService
    {
        List<Sections> GetSection(string sectionName);
        Sections AddSection(Sections section);
        Sections UpdateSection(Sections section);
        List<Sections> GetAllSection();
        Sections GetSectionById(Int64 Id);
        bool CheckSection(Sections sections);
        void Deactivate(Sections sections);
    }
}
