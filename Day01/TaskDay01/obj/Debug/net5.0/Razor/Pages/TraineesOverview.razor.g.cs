#pragma checksum "D:\Blazor\Day01\TaskDay01\Pages\TraineesOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaed7d1217cad702cd2b65fcf8bcce7396ed28a2"
// <auto-generated/>
#pragma warning disable 1591
namespace TaskDay01.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Trainees")]
    public partial class TraineesOverview : Microsoft.AspNetCore.Components.ComponentBase
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
#line 4 "D:\Blazor\Day01\TaskDay01\Pages\TraineesOverview.razor"
                                                      $"AddTrainee"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, "Create");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, @"<thead><tr><th>Name</th>
                <th>Email</th>
                <th>Mobile_Number</th>
                <th>Gender</th>
                <th>Graduated</th>
                <th>Birthday</th>
                <th></th>
                <th></th>
                <th></th></tr></thead>
        ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 21 "D:\Blazor\Day01\TaskDay01\Pages\TraineesOverview.razor"
             foreach(var trainee in trainees)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 25 "D:\Blazor\Day01\TaskDay01\Pages\TraineesOverview.razor"
                     trainee.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 26 "D:\Blazor\Day01\TaskDay01\Pages\TraineesOverview.razor"
                     trainee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 27 "D:\Blazor\Day01\TaskDay01\Pages\TraineesOverview.razor"
                     trainee.MobileNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 28 "D:\Blazor\Day01\TaskDay01\Pages\TraineesOverview.razor"
                     trainee.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 29 "D:\Blazor\Day01\TaskDay01\Pages\TraineesOverview.razor"
                     trainee.IsGraduated

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 30 "D:\Blazor\Day01\TaskDay01\Pages\TraineesOverview.razor"
                     trainee.Birthdate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "td");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "href", 
#nullable restore
#line 31 "D:\Blazor\Day01\TaskDay01\Pages\TraineesOverview.razor"
                               $"TraineeDetails/{trainee.Trainee_ID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(33, "class", "btn btn-info");
            __builder.AddContent(34, "Details");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "td");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "href", 
#nullable restore
#line 32 "D:\Blazor\Day01\TaskDay01\Pages\TraineesOverview.razor"
                               $"TraineeUpdate/{trainee.Trainee_ID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(39, "class", "btn btn-warning");
            __builder.AddContent(40, "Update");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "td");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "href", 
#nullable restore
#line 33 "D:\Blazor\Day01\TaskDay01\Pages\TraineesOverview.razor"
                               $"TraineeDelete/{trainee.Trainee_ID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(45, "class", "btn btn-danger");
            __builder.AddContent(46, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "D:\Blazor\Day01\TaskDay01\Pages\TraineesOverview.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "D:\Blazor\Day01\TaskDay01\Pages\TraineesOverview.razor"
       

    public List<Trainee> trainees;

    protected override Task OnInitializedAsync()
    {

       
        trainees = MyMocaData.trainees;

        return base.OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591