#pragma checksum "D:\Blazor\Day01\TaskDay01\Pages\TracksOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a04d4a99d74ef734508f492201597f6290f575c5"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tracks")]
    public partial class TracksOverview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>TracksOverview</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.OpenElement(2, "a");
            __builder.AddAttribute(3, "class", "btn btn-dark btn-outline-light");
            __builder.AddAttribute(4, "href", 
#nullable restore
#line 4 "D:\Blazor\Day01\TaskDay01\Pages\TracksOverview.razor"
                                                      $"AddTrack"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, "Create");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "<thead><tr><th>Name</th>\r\n            <th>Description</th>\r\n            <th></th>\r\n            <th></th>\r\n            <th></th></tr></thead>\r\n    ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 18 "D:\Blazor\Day01\TaskDay01\Pages\TracksOverview.razor"
         foreach (var track in tracks)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 21 "D:\Blazor\Day01\TaskDay01\Pages\TracksOverview.razor"
                 track.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 22 "D:\Blazor\Day01\TaskDay01\Pages\TracksOverview.razor"
                 track.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "td");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "href", 
#nullable restore
#line 23 "D:\Blazor\Day01\TaskDay01\Pages\TracksOverview.razor"
                           $"TrackDetails/{track.Track_ID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "class", "btn btn-info");
            __builder.AddContent(22, "Details");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "td");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "href", 
#nullable restore
#line 24 "D:\Blazor\Day01\TaskDay01\Pages\TracksOverview.razor"
                           $"TraineeUpdate/{track.Track_ID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "class", "btn btn-warning");
            __builder.AddContent(28, "Update");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "td");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "href", 
#nullable restore
#line 25 "D:\Blazor\Day01\TaskDay01\Pages\TracksOverview.razor"
                           $"TraineeDelete/{track.Track_ID}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(33, "class", "btn btn-danger");
            __builder.AddContent(34, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "D:\Blazor\Day01\TaskDay01\Pages\TracksOverview.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "D:\Blazor\Day01\TaskDay01\Pages\TracksOverview.razor"
       

    List<Track> tracks;
    protected override Task OnInitializedAsync()
    {
       
        tracks = MyMocaData.tracks;

        return base.OnInitializedAsync();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591