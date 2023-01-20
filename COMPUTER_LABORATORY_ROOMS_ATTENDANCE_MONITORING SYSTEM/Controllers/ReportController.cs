using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsEnums;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsTeacher;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.common;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.GlobalService;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.SubjectService;
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.TeacherService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Reporting.NETCore;
using System.Reflection;
using System.Text;

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ITeacherService _teacherService;
        private readonly IGlobalService _globalService;
        private readonly ISubjectService _subjectService;
        public ReportController(IWebHostEnvironment webHostEnvironment,
            ITeacherService teacherService, IGlobalService globalService, ISubjectService subjectService)
        {
            this._webHostEnvironment = webHostEnvironment;
            this._teacherService = teacherService;
            this._globalService = globalService;
            this._subjectService = subjectService;
            System.Text.Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }
        [HttpGet]
        [Route("GetStudentRecord/{teacherId}/{sectionId}/{subjectId}/{room}/{date}")]
        public IActionResult GetStudentRecord(int teacherId, int sectionId, int subjectId, Enums.Rooms room, DateTime date)
        {
            using var rs = Assembly.GetExecutingAssembly().GetManifestResourceStream("COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Reports.StudentRecord.rdlc");
            LocalReport report = new LocalReport();
            var studentRecord = _globalService.GetStudentReport(teacherId, sectionId, subjectId, date);
            var teacher = _teacherService.GetTeacherById(teacherId);
            var subject = _subjectService.GetSubjectById(subjectId);
            var teacherName = teacher.FirstName.ToUpper() + " " + teacher.LastName.ToUpper();
            var section = studentRecord.FirstOrDefault().Course.ToUpper() + " " + studentRecord.FirstOrDefault().Section.ToUpper();
            report.LoadReportDefinition(rs);
            report.DataSources.Add(new ReportDataSource("student", studentRecord.ToList()));
            report.SetParameters(new[] {
                new ReportParameter("teacherName", teacherName),
                new ReportParameter("subject", subject.Subject.ToUpper()),
                new ReportParameter("Date", DateTime.Now.ToLongDateString()),
                new ReportParameter("Room", Common.GetEnumDescription(room)),
                new ReportParameter("ClassDate", date.Date.ToLongDateString()),
                new ReportParameter("semester", Common.GetEnumDescription(subject.Semester).ToUpper()),
                new ReportParameter("section", section)
            });
            return File(report.Render("PDF"), "application/pdf", section.Replace("-", "_") + "_ATTENDANCE." + "pdf");
        }
    }
}
