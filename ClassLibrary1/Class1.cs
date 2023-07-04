using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assert = Xunit.Assert;

namespace ClassLibrary1
{
    public class Class1
    {

        [Test]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Test]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }
	
	[Test]
        public void FailingTest4()
        {
            Assert.Equal(5, Add(2, 4));
        }
	    
	[Test]
        public void FailingTest2()
        {
            Assert.Equal(5, Add(7, 2));
        }

        [Test]
        public void FailingTest3()
        {
            Console.WriteLine("123456");
            Assert.Equal("test", "test2");
        }

        [Test]
        public void 有永定河流经老城西南()
        {
            Console.Error.WriteLine("北京位於華北平原的西北边缘，背靠燕山，有永定河流经老城西南，毗邻天津市、河北省，是一座有三千余年建城历史、八百六十余年建都史的历史文化名城，历史上有金、元、明、清、中华民国（北洋政府时期）等五个朝代在此定都，以及数个政权建政于此，荟萃了自元明清以来的中华文化，拥有众多历史名胜古迹和人文景观。《不列颠百科全书》将北京形容为全球最伟大的城市之一，而且断言，“这座城市是中国历史上最重要的组成部分。在中国过去的八个世纪里，不论历史是否悠久，几乎北京所有主要建筑都拥有着不可磨灭的民族和历史意义”。北京古迹众多，著名的有故宫、天坛、颐和园、圆明园、北海公园等。");
            Console.WriteLine("123456");
            Assert.Equal("有永定河流经老城西南", "有永定河流经老城");
        }

        [Test]
        public void КонстантинВеликий()
        {
            Console.Error.WriteLine("Римский император Константин I Великий по достоинству оценил выгодное местоположение приморского Византия, расположенного на стыке Европы и Азии. Кроме того, на решение Константина повлияла неспокойная обстановка в самом Риме: недовольство знати и постоянные распри в борьбе за трон. Император хотел увенчать свою реформаторскую деятельность созданием нового административного центра огромной державы. Закладка города состоялась осенью 324 года, и Константин лично решил обозначить его границы.");
            Console.WriteLine("123456");
            Assert.Equal("Великий по достоинству оценил", "Великий по достоинству оценил местоположение");
        }

        [Test]
        public void ين()
        {
            Console.Error.WriteLine("وضع ابن الهيثم تصور واضح للعلاقة بين النموذج الرياضي المثالي ومنظومة الظواهر الملحوظة.");
            Console.WriteLine("123456");
            Assert.Equal("ومنظومة الظواهر الملحوظة", "ومنظومة الظواهر ال");
        }

        [Test]
        public void Римский的西北边缘()
        {
            Console.Error.WriteLine("Lorem ipsum dolor sit amet, Римский император Константин I Великий, 北京位於華北平原的西北边缘");
            Console.WriteLine("123456");
            Assert.Equal("Lorem ipsum dolor sit amet, Римский император Константин I Великий, Lorem ipsum dolor sit amet, Римский император Константин I Великий, 北京位於華北平原的", "有永定河流经老城");
        }

        [Test]
        public void Přílišžluťoučký()
        {
            Console.Error.WriteLine("Příliš žluťoučký kůň úpěl ďábelské ódy");
            Console.WriteLine("123456");
            Assert.Equal("Příliš žluťoučký kůň úpěl ďábelské ódy", "Příliš žluťoučký kůň úpěl  ódy");
        }

        [Test]
        public void ทดสอบนะจ๊ะ()
        {
            Console.Error.WriteLine("ทดสอบนะจ๊ะ");
            Console.WriteLine("123456");
            Assert.Equal("ทดสอบนะจ๊ะ", "ทดสอบนะจ๊ะ3");
        }

        [Test]
        public void भूरी()
        {
            Console.Error.WriteLine("एक जल्दी भूरी लोमड़ी");
            Console.WriteLine("123456");
            Assert.Equal("एक जल्दी भूरी लोमड़ी आलसी कुत्ते पर कूदता", "एक जल्दी भूरी लोमड़ी आलसी कुत्ते पर कूदता32");
        }

        [Test]
        public void Iñtërnâtiônàlizætiøn()
        {
            Console.Error.WriteLine("Iñtërnâtiônàlizætiøn☃💪");
            Console.WriteLine("123456");
            Assert.Equal("Iñtërnâtiônàlizætiøn☃💪", "Iñtërnâtiônàlizætiøn☃💪32");
        }

        [TestMethod]
        [DataRow(1, "1")]
        [DataRow(2, "2")]
        [DataRow(3, "Fizz", DisplayName = "Multiple of 3: 3 ")]
        [DataRow(4, "4")]
        [DataRow(5, "Buzz", DisplayName = "Multiple of 5: 5 ")]
        [DataRow(6, "Fizz", DisplayName = "Multiple of 3: 3 ")]
        [DataRow(10, "Buzz", DisplayName = "Multiple of 5: 10 ")]
        [DataRow(11, "11")]
        [DataRow(15, "FizzBuzz", DisplayName = "Multiple of 3 & 5: 15 ")]
        public void FizzBuzz(int input, string expected)
        {
            Assert.AreEqual(expected, UnderTest.FizzBuzz(input));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
