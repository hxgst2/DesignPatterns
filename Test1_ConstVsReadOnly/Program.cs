using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_ConstVsReadOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            var val = new TestClassReadOnly().ReadOnlyVariable;

        }
    }

    public class TestClassReadOnly
    {
        public  readonly int ReadOnlyVariable=2;
        public TestClassReadOnly()
        {
            // Value assignment is allowed in Ctr only
            ReadOnlyVariable = 4;
        }

        public void TestReadOnlyVariableMethod()
        {
            // Value assignment not allowed in Methods
            // ReadOnlyVariable = 4;
        }
    }
}
