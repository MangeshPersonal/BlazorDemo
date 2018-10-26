using Microsoft.AspNetCore.Blazor.Components;

namespace BlazorClientSide.Pages
{
    public class ChildModel : BlazorComponent
    {
       [Parameter]
       protected string TitleFromparent { get; set; }
    }
}