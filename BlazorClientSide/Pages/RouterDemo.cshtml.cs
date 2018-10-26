using Microsoft.AspNetCore.Blazor.Components;

namespace BlazorClientSide.Pages
{
    public class RouterDemoModel : BlazorComponent
    {
        [Parameter]
        protected int Id { get; set; }
    }
}