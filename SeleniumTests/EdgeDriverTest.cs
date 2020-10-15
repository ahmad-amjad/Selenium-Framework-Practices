using NUnit.Framework;
using TestFramework;
using TestFramework.POM_Classes;

namespace SeleniumTests
{
    [TestFixture]
    public class EdgeDriverTest : TestBase
    {
        [Test]
        public void ExtractTabletInfoAndSaveLocally()
        {
            Assert.IsTrue(Pages.Home.IsAt());
            Pages.TabletsAndWatches.Goto();
            Assert.IsTrue(Pages.TabletsAndWatches.IsAt());
            Pages.TabletsAndWatches.ExportTabletInfoToExcel();
            Pages.TabletsAndWatches.SaveTabletImagesToDisk();
        }
    }
}
