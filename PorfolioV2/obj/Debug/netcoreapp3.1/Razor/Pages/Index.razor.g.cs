#pragma checksum "C:\Users\PC_01\Documents\PorfolioV2\PorfolioV2\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70842ee2d3c7b807a7f69e78211d2ebcd483466b"
// <auto-generated/>
#pragma warning disable 1591
namespace PorfolioV2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\PC_01\Documents\PorfolioV2\PorfolioV2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC_01\Documents\PorfolioV2\PorfolioV2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PC_01\Documents\PorfolioV2\PorfolioV2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PC_01\Documents\PorfolioV2\PorfolioV2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PC_01\Documents\PorfolioV2\PorfolioV2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PC_01\Documents\PorfolioV2\PorfolioV2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PC_01\Documents\PorfolioV2\PorfolioV2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PC_01\Documents\PorfolioV2\PorfolioV2\_Imports.razor"
using PorfolioV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PC_01\Documents\PorfolioV2\PorfolioV2\_Imports.razor"
using PorfolioV2.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"container\"><div class=\"center\"><a href=\"Smarttechnology\" class=\"btn homeknop btn-sep icon-info\">Smart Technology</a></div></div>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"container\"><div class=\"center\"><a href=\"/Smartstart\" class=\"btn homeknop btn-sep icon-theatre\">Smart Start</a></div></div>\r\n\r\n");
            __builder.AddMarkupContent(2, "<div class=\"container\"><div class=\"center\"><a href=\"/Smartconnection\" class=\"btn homeknop btn-sep icon-music\">Smart Connection</a></div></div>\r\n\r\n");
            __builder.AddMarkupContent(3, "<div class=\"container\"><div class=\"center\"><a href=\"/Smartbusiness\" class=\"btn homeknop btn-sep icon-music\">Smart Business</a></div></div>\r\n\r\n");
            __builder.AddMarkupContent(4, "<div class=\"container\"><div class=\"center\"><a href=\"/Smartconnectionhw\" class=\"btn homeknop btn-sep icon-music\">Smart Business</a></div></div>\r\n\r\n\r\n\r\n");
            __builder.OpenComponent<PorfolioV2.Shared.SurveyPrompt>(5);
            __builder.AddAttribute(6, "Title", "Do you like my portfolio? Let me know!");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
