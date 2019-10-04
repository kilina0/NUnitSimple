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

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
