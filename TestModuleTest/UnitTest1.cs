using System;
using TestModule;
using Xunit;

namespace TestModuleTest {
	public class UnitTest1 {
		[Fact]
		public void Test1() {
			var c = new TestClass();
			Assert.Equal(15, c.MagicValue); // Intentionally wrong.
		}
	}
}
