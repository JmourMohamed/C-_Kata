using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {

        [Test]
        public void TestRandomObjectUpdateQualityTest()
        {
            //1- First Quality Update
            //2- Second Quality Update

            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 2, Quality = 8 } };
            GildedRose app = new GildedRose(Items);

            //1- First Quality Update
            app.UpdateQuality();
            Assert.AreEqual("foo", Items[0].Name);
            Assert.AreEqual(1, Items[0].SellIn);
            Assert.AreEqual(7, Items[0].Quality);

            //2- Second Quality Update
            app.UpdateQuality();
            Assert.AreEqual("foo", Items[0].Name);
            Assert.AreEqual(0, Items[0].SellIn);
            Assert.AreEqual(6, Items[0].Quality);
        }
        [Test]
        public void TestAgedBrieUpdateQualityTest()
        {
            //1- First Quality Update
            //2- Second Quality Update
            //3- Quality Update when selling is 0

            IList<Item> Items = new List<Item> { new Item { Name = Constants.AgedBrie, SellIn = 2, Quality = 5 } };
            GildedRose app = new GildedRose(Items);

            //1- First Quality Update
            app.UpdateQuality();
            Assert.AreEqual(Constants.AgedBrie, Items[0].Name);
            Assert.AreEqual(1, Items[0].SellIn);
            Assert.AreEqual(6, Items[0].Quality);

            //2- Second Quality Update
            app.UpdateQuality();
            Assert.AreEqual(Constants.AgedBrie, Items[0].Name);
            Assert.AreEqual(0, Items[0].SellIn);
            Assert.AreEqual(7, Items[0].Quality);

            //3- Quality Update when selling is 0
            app.UpdateQuality();
            Assert.AreEqual(Constants.AgedBrie, Items[0].Name);
            Assert.AreEqual(-1, Items[0].SellIn);
            Assert.AreEqual(9, Items[0].Quality);
        }
        [Test]
        public void TestSulfurasUpdateQualityTest()
        {
            //1- First Quality Update
            //2- Second Quality Update

            IList<Item> Items = new List<Item> { new Item { Name = Constants.Sulfuras, SellIn = 2, Quality = 80 } };
            GildedRose app = new GildedRose(Items);

            //1- First Quality Update
            app.UpdateQuality();
            Assert.AreEqual(Constants.Sulfuras, Items[0].Name);
            Assert.AreEqual(2, Items[0].SellIn);
            Assert.AreEqual(80, Items[0].Quality);

            //2- Second Quality Update
            app.UpdateQuality();
            Assert.AreEqual(Constants.Sulfuras, Items[0].Name);
            Assert.AreEqual(2, Items[0].SellIn);
            Assert.AreEqual(80, Items[0].Quality);
        }
        [Test]
        public void TestBackstageUpdateQualityTest()
        {
            //1- First Quality Update (5 <> SellIn && SellIn <10)
            //2- Second Quality Update  (SellIn <= 5)

            IList<Item> Items = new List<Item> { new Item { Name = Constants.Backstage, SellIn = 6, Quality = 10 } };
            GildedRose app = new GildedRose(Items);

            //1- First Quality Update (SellIn > 5 && SellIn <10)
            app.UpdateQuality();
            Assert.AreEqual(Constants.Backstage, Items[0].Name);
            Assert.AreEqual(5, Items[0].SellIn);
            Assert.AreEqual(12, Items[0].Quality);

            //2- Second Quality Update
            app.UpdateQuality();
            Assert.AreEqual(Constants.Backstage, Items[0].Name);
            Assert.AreEqual(4, Items[0].SellIn);
            Assert.AreEqual(15, Items[0].Quality);
        }
        [Test]
        public void TestBackstageUpdateQualityIfSellinHigherThan10Test()
        {
            //1- Quality Update  (10 < SellIn)

            IList<Item> Items = new List<Item> { new Item { Name = Constants.Backstage, SellIn = 20, Quality = 10 } };
            GildedRose app = new GildedRose(Items);

            //1- Quality Update  (10 < SellIn)
            app.UpdateQuality();
            Assert.AreEqual(Constants.Backstage, Items[0].Name);
            Assert.AreEqual(19, Items[0].SellIn);
            Assert.AreEqual(11, Items[0].Quality);
        }
    }
}
