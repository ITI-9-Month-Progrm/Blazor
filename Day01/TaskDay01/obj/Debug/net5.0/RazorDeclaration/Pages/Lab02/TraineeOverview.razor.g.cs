// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
