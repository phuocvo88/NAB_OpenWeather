using NUnit.Framework;


namespace OpenWeather.OpenWeather.UITest
{
    [TestFixture]
    public class HomePageTest : BasePage
    {

        
        [Test]
        public void SearchValidCty()
        {
            
            HomePage hPage = new HomePage();

            hPage.NavigateHomePage();
         
            hPage.ClkSearchBox();
            string kWord = "Ho Chi Minh";
            hPage.InputCtName(kWord);
            
            hPage.PressEnterOnSearchBox();

            //wait for page load

            Assert.IsTrue(hPage.IsResultContainsInputCtName(kWord));

        }

        [Test]
        public void SearchInvalidCty()
        {

            HomePage hPage = new HomePage();

            hPage.NavigateHomePage();
       
            hPage.ClkSearchBox();
            string kWord = "Ho Chi Minh33";
            hPage.InputCtName(kWord);
            
            hPage.PressEnterOnSearchBox();

            //wait for page load
           
            Assert.IsTrue(hPage.IsResultShowNotFound());

        }





    }
}
