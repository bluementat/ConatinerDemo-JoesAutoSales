// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace JoesAutoSalesApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Dev\Demo-JoesAutoSales\JoesAutoContainers\JoesAutoSalesApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\Demo-JoesAutoSales\JoesAutoContainers\JoesAutoSalesApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Dev\Demo-JoesAutoSales\JoesAutoContainers\JoesAutoSalesApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Dev\Demo-JoesAutoSales\JoesAutoContainers\JoesAutoSalesApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Dev\Demo-JoesAutoSales\JoesAutoContainers\JoesAutoSalesApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Dev\Demo-JoesAutoSales\JoesAutoContainers\JoesAutoSalesApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Dev\Demo-JoesAutoSales\JoesAutoContainers\JoesAutoSalesApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Dev\Demo-JoesAutoSales\JoesAutoContainers\JoesAutoSalesApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Dev\Demo-JoesAutoSales\JoesAutoContainers\JoesAutoSalesApp\_Imports.razor"
using JoesAutoSalesApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Dev\Demo-JoesAutoSales\JoesAutoContainers\JoesAutoSalesApp\_Imports.razor"
using JoesAutoSalesApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Dev\Demo-JoesAutoSales\JoesAutoContainers\JoesAutoSalesApp\_Imports.razor"
using JoesAutoSalesApp.Models;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Dev\Demo-JoesAutoSales\JoesAutoContainers\JoesAutoSalesApp\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
