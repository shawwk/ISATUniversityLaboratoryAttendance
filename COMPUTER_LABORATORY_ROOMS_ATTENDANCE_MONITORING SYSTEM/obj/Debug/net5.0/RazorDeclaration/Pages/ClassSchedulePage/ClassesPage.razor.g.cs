// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Pages.ClassSchedulePage
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/classes")]
    public partial class ClassesPage : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 204 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\Pages\ClassSchedulePage\ClassesPage.razor"
       
    private DateRange _dateRange = new DateRange(DateTime.Now.Date, DateTime.Now.Date);
    Schedule classSchedule = new Schedule();
    Teacher selectedTeacher = new Teacher();
    Subjects selectedSubject = new Subjects();
    Sections selectedSection = new Sections();
    List<Schedule> listOfSchedule = new List<Schedule>();
    TimeSpan? timeFrom = new TimeSpan(8, 0, 0);
    TimeSpan? timeTo = new TimeSpan(12, 0, 0);

    Enums.Days days { get; set; }
    MudMessageBox mbox { get; set; }


    string searchString = "";
    bool open = false;
    bool enable = false;
    int classScheduleId;
    protected override void OnInitialized()
    {
        LoadAllSchedules();
        base.OnInitialized();
    }

    public List<Schedule> LoadAllSchedules()
    {
        listOfSchedule = classService.TeacherClasses();
        return listOfSchedule;
    }
    public void FilterByDate()
    {
        listOfSchedule.Where(x => x.Date >= _dateRange.Start.GetValueOrDefault() && x.Date <= _dateRange.End.GetValueOrDefault());
    }
    private bool FilterFunc1(Schedule schedule) => FilterFunc(schedule, searchString);
    private bool FilterFunc(Schedule schedule, string searchString)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (schedule.TeacherName.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (schedule.SubjectName.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if ($"{schedule.Course} {schedule.SectionName}".Contains(searchString))
            return true;
        return false;
    }
    private void ToggleAdd()
    {
        selectedTeacher = new();
        selectedSection = new();
        selectedSubject = new();
        classSchedule = new();
        timeFrom = new TimeSpan(8, 0, 0);
        timeTo = new TimeSpan(12, 0, 0);

        open = !open;
        StateHasChanged();
    }
    private async Task<IEnumerable<Teacher>> SearchTeacher(string search)
    {
        var listOfTeacher = await Task.Run(() => teacherService.GetTeacher(search.Trim()));
        return listOfTeacher.ToList();
    }
    private async Task<IEnumerable<Sections>> SearchSection(string search)
    {
        var listOfSection = await Task.Run(() => sectionService.GetSection(search.Trim()));
        return listOfSection.ToList();
    }
    private async Task<IEnumerable<Subjects>> SearchSubject(string search)
    {
        var listOfSubject = await Task.Run(() => subjectService.GetSubjects(search.Trim()));
        return listOfSubject.ToList();
    }
    private Schedule MapProperties()
    {
        classSchedule.TeacherId = selectedTeacher.Id;
        classSchedule.SectionId = selectedSection.Id;
        classSchedule.SubjectId = selectedSubject.Id;
        classSchedule.Day = days;
        classSchedule.TimeFrom = timeFrom.Value;
        classSchedule.TimeTo = timeTo.Value;
        classSchedule.Day = days;
        return classSchedule;
    }
    private Schedule AddNewSchedule()
    {
        try
        {
            if (classSchedule.Id <= 0)
            {
                var schedule = new Schedule();
                if (!Validation())
                {
                    schedule = classService.AddSchedule(MapProperties());

                    if (schedule != null)
                    {
                        var t = teacherService.StudentRecord(schedule.TeacherId, schedule.SectionId, schedule.SubjectId);
                        listOfSchedule.Insert(0, schedule);
                        open = false;
                        StateHasChanged();
                        Common.ShowAlert("Save success", Severity.Success, SnackBar);
                        foreach (var item in t)
                        {
                            schedule.StudentId = item.StudentId;
                            classService.SaveStudentSubject(schedule);
                        }
                        return schedule;
                    }
                    else
                    {
                        Common.ShowAlert("Schedule Already Exists", Severity.Error, SnackBar);
                        return new Schedule();
                    }

                }
                else
                {
                    Common.ShowAlert("Complete all the detail of schedule", Severity.Warning, SnackBar);
                    return schedule;
                }


            }
            else
            {
                var schedule = classService.UpdateSchedule(MapProperties());
                listOfSchedule.RemoveAll(x => x.Id == classSchedule.Id);
                listOfSchedule.Insert(0, schedule);
                open = false;
                StateHasChanged();
                Common.ShowAlert("Update success", Severity.Success, SnackBar);
                return schedule;
            }
        }
        catch (Exception)
        {

            throw;
        }
    }
    private void GetSchedule(Schedule schedule)
    {
        classSchedule = classService.GetClassScheduleById(schedule.Id);
        selectedTeacher.Id = classSchedule.TeacherId;
        selectedTeacher.FirstName = classSchedule.TeacherName;
        selectedSubject.Id = classSchedule.SubjectId;
        selectedSubject.Subject = classSchedule.SubjectName;
        selectedSection.Id = classSchedule.SectionId;
        selectedSection.Section = classSchedule.Course + " " + classSchedule.SectionName;
        timeFrom = classSchedule.TimeFrom;
        timeTo = classSchedule.TimeTo;
        days = classSchedule.Day;
        open = true;
        StateHasChanged();
    }
    private bool Validation()
    {
        return selectedTeacher.Id == 0
        || selectedSubject.Id == 0 || selectedSection.Id == 0;
    }
    private void RemoveSchedule(Int64 Id)
    {

    }
    private async void ShowMessageBox(Int64 Id)
    {
        bool? result = await mbox.Show();
        if (result != null)
        {
            classService.DeactivateSchedule(Id);
            listOfSchedule.RemoveAll(x => x.Id == Id);
        }
        StateHasChanged();
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

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar SnackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISubjectService subjectService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISectionService sectionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITeacherService teacherService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClassScheduleService classService { get; set; }
    }
}
#pragma warning restore 1591