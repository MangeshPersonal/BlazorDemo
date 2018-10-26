
using Microsoft.AspNetCore.Blazor.Components;


namespace BlazorClientSide.Pages
{
    public class SampleComponentModel : BlazorComponent
    {
        [Parameter]
        protected string Name { get; set; }

        protected override void OnInit()
        {
            Name = "Mangesh";
        }

       
    }
}