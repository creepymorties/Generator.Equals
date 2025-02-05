namespace Generator.Equals.Tests.Classes
{
    public partial class IgnoreInheritedMembers
    {
        public class EqualsTest : EqualityTestCase
        {
            public override object Factory1() => new Sample("Dave", 35);
            public override object Factory2() => new Sample("John", 35);
            public override bool EqualsOperator(object value1, object value2) => (Sample) value1 == (Sample) value2;
            public override bool NotEqualsOperator(object value1, object value2) => (Sample) value1 != (Sample) value2;
        }
        
        public class NotEqualsTest : EqualityTestCase
        {
            public override bool Expected => false;
            public override object Factory1() => new Sample("Dave", 35);
            public override object Factory2() => new Sample("John", 40);
            public override bool EqualsOperator(object value1, object value2) => (Sample) value1 == (Sample) value2;
            public override bool NotEqualsOperator(object value1, object value2) => (Sample) value1 != (Sample) value2;
        }
    }
}