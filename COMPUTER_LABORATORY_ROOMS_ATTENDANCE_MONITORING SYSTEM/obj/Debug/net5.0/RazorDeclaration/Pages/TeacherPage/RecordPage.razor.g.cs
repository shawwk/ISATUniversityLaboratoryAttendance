// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Pages.TeacherPage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using MudBlazor.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsUser;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsEnums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsTeacher;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsClassSchedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsSection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsSubject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsStudent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsTimInOut;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsTimelogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Data.clsFilter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.ScheduleService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.UserService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.TeacherService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.SectionService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.SubjectService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.StudentService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.TimelogsService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\_Imports.razor"
using COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Service.GlobalService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\Pages\TeacherPage\RecordPage.razor"
using System.Transactions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/teacher/record")]
    public partial class RecordPage : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 128 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\Pages\TeacherPage\RecordPage.razor"
       
    List<Student> students = new List<Student>();
    List<Student> totalStudent = new List<Student>();
    List<Sections> sectionList = new List<Sections>();
    DateTime? bday = DateTime.Today;
    DateTime? dateToday = DateTime.Today;
    private DateRange _dateRange = new DateRange(DateTime.Now.Date, DateTime.Now.Date);

    Enums.Gender gender { get; set; }
    MudMessageBox mbox { get; set; }
    MudMessageBox dbox { get; set; }
    string searchString;
    long selectedClass;

    long teacherID = Convert.ToInt64(Global.CurrentUser.UserId);
    protected override void OnInitialized()
    {
        //LoadStudentRecord();
        LoadSections();
        base.OnInitialized();
    }
    string GetStatus(Student status)
    {
        var timeIn = DateTime.Today.Add(status.TimeIn).TimeOfDay;
        var timeFrom = DateTime.Today.Add(status.TimeFrom).TimeOfDay;
        var time = TimeSpan.Compare(timeIn, timeFrom);
        if (time == 1)
            return "Late";
        else if (timeIn == TimeSpan.Zero)
            return "Absent";
        else
            return "Present";
    }
    void LoadStudentAttendanceRecord(ChangeEventArgs e)
    {
        selectedClass = Convert.ToInt64(e.Value);
        var filterParam = new FilterParameter()
            {
                TeacherId = teacherID,
                SectionId = sectionList.Count > 0 ? sectionList.First(x => x.ClassId == selectedClass).Id : 0,
                DateFrom = DateTime.Now.Date,
                DateTo = DateTime.Now.Date,
                TimeFrom = sectionList.Count > 0 ? sectionList.First(x => x.ClassId == selectedClass).TimeFrom : TimeSpan.Zero,
                TimeTo = sectionList.Count > 0 ? sectionList.First(x => x.ClassId == selectedClass).TimeTo : TimeSpan.Zero,
                Day = sectionList.Count > 0 ? sectionList.First(x => x.ClassId == selectedClass).Day : Enums.Days.Monday,
                SubjectId = sectionList.Count > 0 ? sectionList.First(x => x.ClassId == selectedClass).SubjectId : 0,
            };
        students = globalService.GetAllStudentRecord(filterParam);
        StateHasChanged();
    }
    void LoadStudentAttendance()
    {
        var filterParam = new FilterParameter()
            {
                TeacherId = teacherID,
                SectionId = sectionList.First(x => x.ClassId == selectedClass).Id,
                DateFrom = _dateRange.Start.GetValueOrDefault().Date,
                DateTo = _dateRange.End.GetValueOrDefault().Date,
                SubjectId = sectionList.Count > 0 ? sectionList.First(x => x.ClassId == selectedClass).SubjectId : 0
            };
        students = globalService.GetStudentByDate(filterParam);
        StateHasChanged();
    }
    void LoadSections()
    {
        sectionList = globalService.GetAssignSections(teacherID);
        Task.Delay(2000);

        var filterParam = new FilterParameter()
            {
                TeacherId = teacherID,
                SectionId = sectionList.Count > 0 ? sectionList.First().Id : 0,
                SubjectId = sectionList.Count > 0 ? sectionList.First().SubjectId : 0,
                TimeFrom = sectionList.Count > 0 ? sectionList.First().TimeFrom : TimeSpan.Zero,
                TimeTo = sectionList.Count > 0 ? sectionList.First().TimeTo : TimeSpan.Zero,
                Day = sectionList.Count > 0 ? sectionList.First().Day : Enums.Days.Monday
            };
        if (sectionList.Count > 0)
        {
            selectedClass = sectionList.First().ClassId;
            students = globalService.GetAllStudentRecord(filterParam);
        }

        StateHasChanged();
    }
    private bool FilterFunc1(Student stud) => FilterFunc(stud, searchString);
    private bool FilterFunc(Student stud, string searchString)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (stud.FirstName.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (stud.MiddleName.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (stud.LastName.Contains(searchString))
            return true;
        if (stud.Date.ToShortDateString().Contains(searchString))
            return true;
        return false;
    }
    private string GetDateTime(string dateTime)
    {
        if (dateTime == "1/1/0001" || dateTime == "12:00 AM")
        {
            return "";
        }
        else
        {
            return dateTime;
        }
    }
    private void CountPresentAbsent()
    {
        students.Where(x => DateTime.Today.Add(x.TimeIn).TimeOfDay == TimeSpan.Zero).Count();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar SnackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISectionService sectionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGlobalService globalService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITeacherService teacherService { get; set; }
    }
}
#pragma warning restore 1591
