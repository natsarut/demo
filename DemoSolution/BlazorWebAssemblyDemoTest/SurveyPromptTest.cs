using System;
using BlazorWebAssemblyDemo.Client.Shared;
using Bunit;
using Xunit;

namespace BlazorWebAssemblyDemoTest
{
    public class SurveyPromptTest:TestContext
    {
        [Fact]
        public void TestSurveyPromptComponentRenderCorrectly()
        {
            // Act
            var cut = RenderComponent<SurveyPrompt>();
            var a = cut.Find("a");

            // Assert
            a.MarkupMatches(@"<a target=""_blank"" class=""font-weight-bold"" href=""https://go.microsoft.com/fwlink/?linkid=2137916"">brief survey</a>");
        }
    }
}
