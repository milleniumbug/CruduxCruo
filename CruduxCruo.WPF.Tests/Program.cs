using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CruduxCruo.WPF.Tests
{
    [TestFixture]
    class Program
    {
        [Test]
        public void Test()
        {
            
        }

        class A
        {
            public int F(IEnumerable<int> a) { return 0; }
            public int F(int a) { return 1; }
            public int F(IList<int> a) { return 2; }
        }

        [Test]
        public void T()
        {
            dynamic a = new A();
            Assert.AreEqual(2, a.F((dynamic)FormatterServices.GetUninitializedObject(typeof(List<int>))));
        }

        static void Main(string[] args)
        {

        }
    }
}
