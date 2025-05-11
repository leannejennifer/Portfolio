using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunit;
using Portfolio.Helpers;
using Portfolio.UI.Components.Pages;

namespace Portfolio.Tests.BlazorTests
{
    [TestFixture]
    public class CounterTests : Bunit.TestContext
    {
        [Test]
        [Ignore("This method cannot be faked so for now it won't pass unless we wrap it in an interface.")]
		public void CounterPage_DateChanged_ChangeButtonColor()
		{
            //Arrange

            //Act
            var cut = RenderComponent<Counter>();

            var dateInput = cut.Find("input[type='date']");
            dateInput.Change("12/10/1210");
            //Asserter

            var button = cut.Find("button");
            var randColor = ColorHelper.GetRandomColor();

            button.Attributes["style"]?.Value.MarkupMatches($"background-color:{randColor}");
        }
        [Test]

		public void CounterPage_BeforeDateChanged_ChangeButtonColor()
		{
            //Arrange

            //Act
            var cut = RenderComponent<Counter>();
            //Asserter
            var button = cut.Find("button");
            button.Attributes["style"]?.Value.MarkupMatches("background-color:00f");
        }


	}
}
