#pragma checksum "D:\Blazor\Day03\lab03Task\Pages\InterOp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2524ba06ab11011897f4b31569db4a027c8dee67"
// <auto-generated/>
#pragma warning disable 1591
namespace Task02.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Blazor\Day03\lab03Task\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Blazor\Day03\lab03Task\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Blazor\Day03\lab03Task\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Blazor\Day03\lab03Task\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Blazor\Day03\lab03Task\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Blazor\Day03\lab03Task\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Blazor\Day03\lab03Task\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Blazor\Day03\lab03Task\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Blazor\Day03\lab03Task\_Imports.razor"
using Task02;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Blazor\Day03\lab03Task\_Imports.razor"
using Task02.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Blazor\Day03\lab03Task\_Imports.razor"
using Task01;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/InterOp")]
    public partial class InterOp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>InterOp</h3>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "D:\Blazor\Day03\lab03Task\Pages\InterOp.razor"
                  ConvertFromJSToCSharp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "Js_To_C#");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, 
#nullable restore
#line 5 "D:\Blazor\Day03\lab03Task\Pages\InterOp.razor"
    movie

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.AddMarkupContent(8, "<button onclick=\"GenerateRandumInt()\">C#_To_Js</button>");
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "D:\Blazor\Day03\lab03Task\Pages\InterOp.razor"
       
    //InterOp From Js To C#
    //Call Js From C#
    string movie;
    async Task ConvertFromJSToCSharp()
    {
        await JsRuntime.InvokeVoidAsync("console.log", "C# Say Hello ^^");
        await JsRuntime.InvokeVoidAsync("alert", "Javascript Say Hello To C# ");
        movie = await JsRuntime.InvokeAsync<string>("prompt", "What is your favorite Movie ?");
        await JsRuntime.InvokeVoidAsync("alert", movie);

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Blazor\Day03\lab03Task\Pages\InterOp.razor"
      
    //InterOp From C# To Js
    //Call C# From Js
    [JSInvokable]
    public static Task<int> getRandumNum()
    {
        return Task.FromResult(new Random().Next());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
