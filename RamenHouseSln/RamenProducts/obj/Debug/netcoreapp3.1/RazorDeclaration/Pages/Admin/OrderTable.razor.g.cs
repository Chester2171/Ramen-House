#pragma checksum "C:\Users\Chest\Documents\GitHub\Ramen-House\RamenHouseSln\RamenProducts\Pages\Admin\OrderTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c98b8022bf86025437c541e5a596227d8459af16"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RamenProducts.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Chest\Documents\GitHub\Ramen-House\RamenHouseSln\RamenProducts\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Chest\Documents\GitHub\Ramen-House\RamenHouseSln\RamenProducts\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Chest\Documents\GitHub\Ramen-House\RamenHouseSln\RamenProducts\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Chest\Documents\GitHub\Ramen-House\RamenHouseSln\RamenProducts\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Chest\Documents\GitHub\Ramen-House\RamenHouseSln\RamenProducts\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Chest\Documents\GitHub\Ramen-House\RamenHouseSln\RamenProducts\Pages\Admin\_Imports.razor"
using RamenProducts.Models;

#line default
#line hidden
#nullable disable
    public partial class OrderTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\Chest\Documents\GitHub\Ramen-House\RamenHouseSln\RamenProducts\Pages\Admin\OrderTable.razor"
       
    [Parameter]
    public string TableTitle { get; set; } = "Orders";
    [Parameter]
    public IEnumerable<Order> Orders { get; set; }
    [Parameter]
    public string ButtonLabel { get; set; } = "Ship";
    [Parameter]
    public EventCallback<int> OrderSelected { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
