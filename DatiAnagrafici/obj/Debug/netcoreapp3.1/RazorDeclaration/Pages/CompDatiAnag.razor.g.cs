// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DatiAnagrafici.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ardit\source\repos\DatiAnagrafici\DatiAnagrafici\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ardit\source\repos\DatiAnagrafici\DatiAnagrafici\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ardit\source\repos\DatiAnagrafici\DatiAnagrafici\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ardit\source\repos\DatiAnagrafici\DatiAnagrafici\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ardit\source\repos\DatiAnagrafici\DatiAnagrafici\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ardit\source\repos\DatiAnagrafici\DatiAnagrafici\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ardit\source\repos\DatiAnagrafici\DatiAnagrafici\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ardit\source\repos\DatiAnagrafici\DatiAnagrafici\_Imports.razor"
using DatiAnagrafici;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ardit\source\repos\DatiAnagrafici\DatiAnagrafici\_Imports.razor"
using DatiAnagrafici.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/compdatianag")]
    public partial class CompDatiAnag : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 120 "C:\Users\ardit\source\repos\DatiAnagrafici\DatiAnagrafici\Pages\CompDatiAnag.razor"
       
    public DatiAnagrafici.ClassDatiAnag.DatiAnag nuovoDato;

    private void AggiungiDato()
    {
        nuovoDato = new DatiAnagrafici.ClassDatiAnag.DatiAnag();
    }
    public void ModificaDato(DatiAnagrafici.ClassDatiAnag.DatiAnag datoDaMod)
    {
        nuovoDato = datoDaMod;
    }
    public void CancellaDato(DatiAnagrafici.ClassDatiAnag.DatiAnag datoDaCanc)
    {
        db.dati.Remove(datoDaCanc);
        db.SaveChanges();
    }
    public void SalvaDato()
    {
        if (nuovoDato.Id == 0)
        {
            db.dati.Add(nuovoDato);
        }
        else
        {
            db.dati.Update(nuovoDato);
        }
        db.SaveChanges();
        nuovoDato = null;
    }
    public void AnnullaDato()
    {
        nuovoDato = null;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DatiAnagrafici.ClassDatiAnag.DataBase db { get; set; }
    }
}
#pragma warning restore 1591
