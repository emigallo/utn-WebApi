// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Clase8.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/emilianogallo/Stuffs/git/UTN/utn-WebApi/Clase8/Clase8/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/emilianogallo/Stuffs/git/UTN/utn-WebApi/Clase8/Clase8/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/emilianogallo/Stuffs/git/UTN/utn-WebApi/Clase8/Clase8/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/emilianogallo/Stuffs/git/UTN/utn-WebApi/Clase8/Clase8/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/emilianogallo/Stuffs/git/UTN/utn-WebApi/Clase8/Clase8/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/emilianogallo/Stuffs/git/UTN/utn-WebApi/Clase8/Clase8/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/emilianogallo/Stuffs/git/UTN/utn-WebApi/Clase8/Clase8/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/emilianogallo/Stuffs/git/UTN/utn-WebApi/Clase8/Clase8/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/emilianogallo/Stuffs/git/UTN/utn-WebApi/Clase8/Clase8/_Imports.razor"
using Clase8;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/emilianogallo/Stuffs/git/UTN/utn-WebApi/Clase8/Clase8/_Imports.razor"
using Clase8.Shared;

#line default
#line hidden
#nullable disable
    public partial class LoginCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "/Users/emilianogallo/Stuffs/git/UTN/utn-WebApi/Clase8/Clase8/Pages/LoginCard.razor"
      
    private string name,
        mail;

    private int id;
    private DateTime date;

    [Parameter]
    public Business.Models.LoginModel Model { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();

        this.name = this.Model.Name;
        this.mail = this.Model.Email;
        this.id = this.Model.Id;
        this.date = this.Model.Date;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591