using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_ConstVsReadOnly
{
    class Program
    {
        public const int ConstVariable = 4;
        static void Main(string[] args)
        {
            const int ConstVariableInMethod = 4;
            var val = new TestClassReadOnly().ReadOnlyVariable;
            // not allowed
            // ConstVariable = 5;
            // ConstVariableInMethod = 6;
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
            MyProperty = 3;
        }
        // There are no ReadOnly Properties
        public int MyProperty
        { get; set; }
    }
}
