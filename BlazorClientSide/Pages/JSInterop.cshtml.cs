using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorClientSide.Pages
{
    public class JSInteropModel : BlazorComponent
    {
        protected static string callingfromJavascript;

        [JSInvokable]
        public static void CSCallBackMethod ()
        {
            callingfromJavascript = "From, Csharpcorner";
        }

        protected void CallCSMethod()
        {
            JSRuntime.Current.InvokeAsync<bool>("CSMethod");
        }
    }
}