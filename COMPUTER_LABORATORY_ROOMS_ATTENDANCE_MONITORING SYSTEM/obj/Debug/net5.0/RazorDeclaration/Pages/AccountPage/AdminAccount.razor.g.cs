// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING_SYSTEM.Pages.AccountPage
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class AdminAccount : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "E:\Software Engineer files\Projects\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\COMPUTER_LABORATORY_ROOMS_ATTENDANCE_MONITORING SYSTEM\Pages\AccountPage\AdminAccount.razor"
       

    Sections section = new Sections();
    Users user = new Users();
    List<Users> userslist = new();
    List<Sections> sections = new List<Sections>();

    MudMessageBox dbox { get; set; }

    string searchString = "";
    bool open = false;

    protected override void OnInitialized()
    {
        LoadAllSections();
        base.OnInitialized();
    }

    public List<Users> LoadAllSections()
    {
        var list = userService.GetAllUser();
        userslist = list.Where(x => x.UserRole == Enums.UserRole.Admin).ToList();
        return userslist;
    }
    private void Add()
    {
        try
        {
            if (user.Id == 0)
            {
                if (!Validation())
                {
                    user.UserRole = Enums.UserRole.Admin;
                    var admin = userService.RegisterUser(user);
                    if(admin != null)
                    {
                        user.UserId = admin.Id.ToString().Trim();
                        userService.RegisterAdmin(user);
                    }
                    Common.ShowAlert("Added successfully", Severity.Success, SnackBar);
                    user = new();
                    open = false;
                }
                else
                {
                    
                    Common.ShowAlert("Complete all the details", Severity.Warning, SnackBar);
                }
            }
            else
            {
                userService.UpdateUsers(user);
                Common.ShowAlert("Updated successfully", Severity.Success, SnackBar);
                open = false;
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    private bool FilterFunc1(Sections sec) => FilterFunc(sec, searchString);
    private bool FilterFunc(Sections sec, string searchString)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (sec.Course.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (sec.Section.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }
    private void ToggleAdd()
    {
        section = new();

        open = !open;
        StateHasChanged();
    }
    private void GetAdmin(Int64 Id)
    {
        var u = userService.GetAllUser();
        user = u.FirstOrDefault(x => x.Id == Id);
        StateHasChanged();
        open = true;
    }

    private async void DeactivateSection(Users users)
    {
        bool? result = await dbox.Show();
        if (result != null)
        {
            try
            {
                users.Active = false;
                userService.DeactivateUser(users);
                userslist.RemoveAll(x => x.Id == users.Id);
                StateHasChanged();
                Common.ShowAlert("Admin removed successfully!", Severity.Success, SnackBar);
            }
            catch (Exception ex)
            {
                Common.ShowAlert(ex.ToString(), Severity.Error, SnackBar);
            }
        }
    }
    private bool Validation()
    {
        return user.IDNumber == 0 || user.FullName == "" || user.UserName == "" || user.Password == "";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar SnackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISectionService sectionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISubjectService subjectService { get; set; }
    }
}
#pragma warning restore 1591
