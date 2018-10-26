using Microsoft.AspNetCore.Blazor.Components;

namespace BlazorClientSide.Pages
{
    public class DataBindingDemoModel : BlazorComponent
    {
        protected string demostring = "Hello World !!";

        public void ChangeGreeting()
        {
            demostring = "Hello CsharpCorner !!!";
        }


    }
}