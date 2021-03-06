#pragma checksum "D:\Blazor\Day01\TaskDay01\Pages\Lab02\TraineeOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c66b5fc2fe99ee5951f019e705109607584f694b"
// <auto-generated/>
#pragma warning disable 1591
namespace TaskDay01.Pages.Lab02
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Blazor\Day01\TaskDay01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Blazor\Day01\TaskDay01\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Blazor\Day01\TaskDay01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Blazor\Day01\TaskDay01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Blazor\Day01\TaskDay01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Blazor\Day01\TaskDay01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Blazor\Day01\TaskDay01\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Blazor\Day01\TaskDay01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Blazor\Day01\TaskDay01\_Imports.razor"
using TaskDay01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Blazor\Day01\TaskDay01\_Imports.razor"
using TaskDay01.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Blazor\Day01\TaskDay01\_Imports.razor"
using Model_Libraries;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Blazor\Day01\TaskDay01\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/TraineesDB")]
    public partial class TraineeOverview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>TraineesOverview</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.OpenElement(2, "a");
            __builder.AddAttribute(3, "class", "btn btn-dark btn-outline-light");
            __builder.AddAttribute(4, "href", 
#nullable restore
#line 4 "D:\Blazor\Day01\TaskDay01\Pages\Lab02\TraineeOverview.razor"
                                                      $"AddTraineeDB"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, "Create");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 6 "D:\Blazor\Day01\TaskDay01\Pages\Lab02\TraineeOverview.razor"
 if (trainees != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table");
            __builder.AddMarkupContent(8, @"<thead><tr><th>Name</th>
                <th>Email</th>
                <th>Mobile_Number</th>
                <th>Gender</th>
                <th>Graduated</th>
                <th>Birthday</th>
                <th></th>
                <th></th>
                <th></th></tr></thead>
        ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 23 "D:\Blazor\Day01\TaskDay01\Pages\Lab02\TraineeOverview.razor"
             foreach (var trainee in trainees)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 27 "D:\Blazor\Day01\TaskDay01\Pages\Lab02\TraineeOverview.razor"
                         trainee.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 28 "D:\Blazor\Day01\TaskDay01\Pages\Lab02\TraineeOverview.razor"
                         trainee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 29 "D:\Blazor\Day01\TaskDay01\Pages\Lab02\TraineeOverview.razor"
                         trainee.MobileNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 30 "D:\Blazor\Day01\TaskDay01\Pages\Lab02\TraineeOverview.razor"
                         trainee.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 31 "D:\Blazor\Day01\TaskDay01\Pages\Lab02\TraineeOverview.razor"
                         trainee.IsGraduated

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 32 "D:\Blazor\Day01\TaskDay01\Pages\Lab02\TraineeOverview.razor"
                         trainee.Birthdate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "href", 
#nullable restore
#line 33 "D:\Blazor\Day01\TaskDay01\Pages\Lab02\TraineeOverview.razor"
                                   $"TraineeDetailsDB/{trainee.Trainee_ID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "class", "btn btn-info");
            __builder.AddContent(33, "Details");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "td");
            __builder.OpenElement(36, "a");
            __builder.AddAttribute(37, "href", 
#nullable restore
#line 34 "D:\Blazor\Day01\TaskDay01\Pages\Lab02\TraineeOverview.razor"
                                   $"TraineeUpdateDB/{trainee.Trainee_ID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(38, "class", "btn btn-warning");
            __builder.AddContent(39, "Update");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "td");
            __builder.OpenElement(42, "a");
            __builder.AddAttribute(43, "href", 
#nullable restore
#line 35 "D:\Blazor\Day01\TaskDay01\Pages\Lab02\TraineeOverview.razor"
                                   $"TraineeDeleteDB/{trainee.Trainee_ID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(44, "class", "btn btn-danger");
            __builder.AddContent(45, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "D:\Blazor\Day01\TaskDay01\Pages\Lab02\TraineeOverview.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "D:\Blazor\Day01\TaskDay01\Pages\Lab02\TraineeOverview.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(46, "<div> Wait until loading finish............... </div>");
#nullable restore
#line 45 "D:\Blazor\Day01\TaskDay01\Pages\Lab02\TraineeOverview.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "D:\Blazor\Day01\TaskDay01\Pages\Lab02\TraineeOverview.razor"
       

    public List<Trainee> trainees;

    [Inject]
    public ITraineeDataService _TraineeDataService { get; set; }
    protected async override Task OnInitializedAsync()
    {
        trainees = await _TraineeDataService.GetTrainees();



        //return base.OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
