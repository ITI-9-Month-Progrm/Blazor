#pragma checksum "D:\Blazor\Day01\TaskDay01\Pages\Lab01\TraineeDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df07c1e97d1185cec25d4ba41f2693495dd80a01"
// <auto-generated/>
#pragma warning disable 1591
namespace TaskDay01.Pages.Lab01
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/TraineeDetails/{Trainee_ID:int}")]
    public partial class TraineeDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Trainee Details</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "<label>Name : </label>\r\n    ");
            __builder.OpenElement(3, "p");
            __builder.AddContent(4, 
#nullable restore
#line 5 "D:\Blazor\Day01\TaskDay01\Pages\Lab01\TraineeDetails.razor"
         traineeDetails.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(6, "<label>Email : </label>\r\n    ");
            __builder.OpenElement(7, "p");
            __builder.AddContent(8, 
#nullable restore
#line 8 "D:\Blazor\Day01\TaskDay01\Pages\Lab01\TraineeDetails.razor"
         traineeDetails.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(10, "<label>MobileNumber : </label>\r\n    ");
            __builder.OpenElement(11, "p");
            __builder.AddContent(12, 
#nullable restore
#line 11 "D:\Blazor\Day01\TaskDay01\Pages\Lab01\TraineeDetails.razor"
         traineeDetails.MobileNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(14, "<label>Gender : </label>\r\n    ");
            __builder.OpenElement(15, "p");
            __builder.AddContent(16, 
#nullable restore
#line 14 "D:\Blazor\Day01\TaskDay01\Pages\Lab01\TraineeDetails.razor"
         traineeDetails.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(18, "<label>Birthdate : </label>\r\n    ");
            __builder.OpenElement(19, "p");
            __builder.AddContent(20, 
#nullable restore
#line 17 "D:\Blazor\Day01\TaskDay01\Pages\Lab01\TraineeDetails.razor"
         traineeDetails.Birthdate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(22, "<label>Graduated : </label>\r\n    ");
            __builder.OpenElement(23, "p");
            __builder.AddContent(24, 
#nullable restore
#line 20 "D:\Blazor\Day01\TaskDay01\Pages\Lab01\TraineeDetails.razor"
         traineeDetails.IsGraduated

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    <br>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "D:\Blazor\Day01\TaskDay01\Pages\Lab01\TraineeDetails.razor"
       
    [Parameter]
    public int Trainee_ID { get; set; }

    List<Trainee> trainees;
    public Trainee traineeDetails;

    protected override Task OnInitializedAsync()
    {
        
        trainees = MyMocaData.trainees;

        traineeDetails = trainees.FirstOrDefault(T => T.Trainee_ID == Trainee_ID);


        return base.OnInitializedAsync();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591