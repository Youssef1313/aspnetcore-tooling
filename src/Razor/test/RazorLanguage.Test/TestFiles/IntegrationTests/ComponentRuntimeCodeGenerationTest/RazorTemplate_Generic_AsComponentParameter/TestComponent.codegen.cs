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
    public class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
   RenderFragment<Person> template = (person) => 

#line default
#line hidden
#nullable disable
            (__builder2) => {
                __builder2.OpenElement(0, "div");
                __builder2.AddContent(1, 
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                        person.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                                         ; 

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Test.MyComponent>(2);
            __builder.AddAttribute(3, "PersonTemplate", new Microsoft.AspNetCore.Components.RenderFragment<Test.Person>(
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                              template

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
