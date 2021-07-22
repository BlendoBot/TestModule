using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCore;

namespace TestModule {
	public class TestClass : ITestInterface {
		public int MagicValue => 15;
		public float MagicFloat => 120.0f;
	}
}
