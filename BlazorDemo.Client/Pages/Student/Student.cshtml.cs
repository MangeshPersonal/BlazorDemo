
using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.JSInterop;

namespace BlazorDemo.Client
{
    public class StudentModel : BlazorComponent
    {
        protected static bool AllowEditdelete;

        [JSInvokable]
        public static void SetConfirmation()
        {
            AllowEditdelete = true;
        }
        [JSInvokable]
        protected void Denyconfirmation()
        {
            AllowEditdelete = false;
        }
    }
}