// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Pages.TimeInOutPage
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
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/time/{selectedClass:int}")]
    public partial class TimeInOutPage : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\Pages\TimeInOutPage\TimeInOutPage.razor"
       
    [Parameter]
    public int selectedClass { get; set; }

    Student student = new Student();
    List<Sections> sectionList = new List<Sections>();
    string theTime;
    Timer aTimer;
    TimeSpan t;
    TimeSpan TimeLeft = new TimeSpan(0, 0, 5);
    ElementReference focusRef;
    MudMessageBox dbox { get; set; }

    protected override void OnInitialized()
    {
        aTimer = new Timer(Tick, null, 0, 1000);
        sectionList = globalService.GetAssignSections(Convert.ToInt64(Global.CurrentUser.UserId));
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await focusRef.FocusAsync();
        }
        await base.OnAfterRenderAsync(firstRender);
    }

    async void GetStudentId(ChangeEventArgs eventArgs)
    {
        student = studentService.GetStudentByIdNumber(Convert.ToInt64(eventArgs.Value));
        if (student == null)
        {
            student = new();
            Common.ShowAlert("Student is not enrolled", Severity.Warning, snackBar);
        }
        else
        {
            var logs = Convert.ToDateTime(theTime).ToString("HH:mm:ss");
            var subjectId = sectionList.First(x => x.ClassId == selectedClass).SubjectId;
            bool checkTimeIn = timelogsService.CheckDate(DateTime.Now.Date, student.StudentId, subjectId);
            var timeInOut = new TimeInOut()
                {
                    IDNumber = student.StudentId,
                    SectionId = student.SectionId,
                    Date = DateTime.Now.Date,
                    TimeIn = TimeSpan.Parse(logs),
                    TimeOut = checkTimeIn == false ? new TimeSpan() : TimeSpan.Parse(logs),
                    SubjectId = sectionList.Count > 0 ? subjectId : 0
                };
            var timeId = timelogsService.AddTimeInOut(timeInOut);
            Start();
            await JsRuntime.InvokeVoidAsync("console.log", timeId);

        }
        await JsRuntime.InvokeVoidAsync("Clear");
    }
    private void Tick(object _)
    {
        theTime = DateTime.Now.ToLongTimeString();
        InvokeAsync(StateHasChanged);
    }

    public void Dispose()
    {
        aTimer?.Dispose();
    }
    void Start()
    {
        Timer();
    }

    async Task Timer()
    {
        while (TimeLeft > new TimeSpan())
        {
            await Task.Delay(1000);
            TimeLeft = TimeLeft.Subtract(new TimeSpan(0, 0, 1));
            StateHasChanged();
        }


        await AfterTime();
        StateHasChanged();
    }

    Task AfterTime()
    {
        TimeLeft = new TimeSpan(0, 0, 5);
        student = new();
        return Task.CompletedTask;
    }
    async void EndClass()
    {
        bool? result = await dbox.Show();
        if(result != null)
        {
            var teacherId = Convert.ToInt64(Global.CurrentUser.UserId);
            var subjectId = sectionList.First(x => x.ClassId == selectedClass).SubjectId;
            var sectionId = sectionList.First(x => x.ClassId == selectedClass).Id;
            var t = teacherService.StudentRecord(teacherId, sectionId, subjectId);
            foreach (var item in t)
            {
                timeService.MarkAbsent(item.StudentId, DateTime.Now.Date, sectionId, subjectId);
            }
            classService.EndClass(selectedClass, DateTime.Now, Enums.ClassStatus.Ended);
            Common.ShowAlert("Class ended successfully", Severity.Success, snackBar);
            Global.isStarted = false;
            nav.NavigateTo(nav.BaseUri + "teacher/attendance");
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITimelogsService timeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar snackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IClassScheduleService classService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGlobalService globalService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITeacherService teacherService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITimelogsService timelogsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService studentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
