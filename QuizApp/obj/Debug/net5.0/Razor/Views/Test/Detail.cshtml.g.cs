#pragma checksum "C:\Users\adria\source\repos\vs2019\QuizApp\QuizApp\Views\Test\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fd899a26ab7ce0b3f3380a97548953c187017ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Detail), @"mvc.1.0.view", @"/Views/Test/Detail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\adria\source\repos\vs2019\QuizApp\QuizApp\Views\_ViewImports.cshtml"
using QuizApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adria\source\repos\vs2019\QuizApp\QuizApp\Views\_ViewImports.cshtml"
using QuizApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fd899a26ab7ce0b3f3380a97548953c187017ad", @"/Views/Test/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"495b3e5508629aa143e9e1ec6a1e09971db5088c", @"/Views/_ViewImports.cshtml")]
    public class Views_Test_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuizApp.Models.TestDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\adria\source\repos\vs2019\QuizApp\QuizApp\Views\Test\Detail.cshtml"
   
    int count = 1, countR = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h4 style=\"margin-top: 4%;\"> <span class=\"label label-info\">Questions :</span> </h4>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\adria\source\repos\vs2019\QuizApp\QuizApp\Views\Test\Detail.cshtml"
     foreach(var question in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div  class=\"BlockQ\" style=\"border: 1px solid #bdbdbd; width: 75%; border-radius: 4px; margin-top: 40px; padding: 8px;\">\r\n\r\n            <div class=\"question\" style=\"padding: 2%\">\r\n                <p>");
#nullable restore
#line 15 "C:\Users\adria\source\repos\vs2019\QuizApp\QuizApp\Views\Test\Detail.cshtml"
              Write(question.QuestionText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n\r\n            \r\n");
#nullable restore
#line 19 "C:\Users\adria\source\repos\vs2019\QuizApp\QuizApp\Views\Test\Detail.cshtml"
             foreach(var choice in question.AnswerOptions)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-check\">\r\n                    <input class=\"form-check-input\" type=\"radio\" name=\"flexRadioDefault\"");
            BeginWriteAttribute("id", " id=\"", 725, "\"", 740, 1);
#nullable restore
#line 22 "C:\Users\adria\source\repos\vs2019\QuizApp\QuizApp\Views\Test\Detail.cshtml"
WriteAttributeValue("", 730, choice.Id, 730, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 741, "\"", 759, 1);
#nullable restore
#line 22 "C:\Users\adria\source\repos\vs2019\QuizApp\QuizApp\Views\Test\Detail.cshtml"
WriteAttributeValue("", 749, choice.Id, 749, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 816, "\"", 832, 1);
#nullable restore
#line 23 "C:\Users\adria\source\repos\vs2019\QuizApp\QuizApp\Views\Test\Detail.cshtml"
WriteAttributeValue("", 822, choice.Id, 822, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 24 "C:\Users\adria\source\repos\vs2019\QuizApp\QuizApp\Views\Test\Detail.cshtml"
                   Write(choice.AnswerText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </label>\r\n                    <br /> <br />\r\n                </div>\r\n");
#nullable restore
#line 28 "C:\Users\adria\source\repos\vs2019\QuizApp\QuizApp\Views\Test\Detail.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <br/>\r\n");
#nullable restore
#line 32 "C:\Users\adria\source\repos\vs2019\QuizApp\QuizApp\Views\Test\Detail.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"button\" class=\"btn btn-info\" >Submit</button>\r\n\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuizApp.Models.TestDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
