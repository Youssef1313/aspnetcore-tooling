// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
using AnotherTest;

#line default
#line hidden
#nullable disable
    public class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static System.Object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddAttribute(-1, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
            }
            ));
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = typeof(HeaderComponent);

#line default
#line hidden
#nullable disable
            __builder.AddAttribute(-1, "Footer", (Microsoft.AspNetCore.Components.RenderFragment<System.DateTime>)((context) => (__builder2) => {
#nullable restore
#line 7 "x:\dir\subdir\Test\TestComponent.cshtml"
       __o = context;

#line default
#line hidden
#nullable disable
            }
            ));
#nullable restore
#line 6 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = typeof(FooterComponent);

#line default
#line hidden
#nullable disable
            __builder.AddAttribute(-1, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
            }
            ));
#nullable restore
#line 9 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = typeof(Test.HeaderComponent);

#line default
#line hidden
#nullable disable
            __builder.AddAttribute(-1, "Footer", (Microsoft.AspNetCore.Components.RenderFragment<System.DateTime>)((context) => (__builder2) => {
#nullable restore
#line 13 "x:\dir\subdir\Test\TestComponent.cshtml"
       __o = context;

#line default
#line hidden
#nullable disable
            }
            ));
#nullable restore
#line 12 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = typeof(AnotherTest.FooterComponent);

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
