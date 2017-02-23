using System.Text;

namespace SKBKontur.SeleniumTesting.Assertions.ErrorMessages.Expecations
{
    internal class ArraysEquivalentExpectation : IValueExpectationFormatter
    {
        public ArraysEquivalentExpectation(string[] expectedValues)
        {
            this.expectedValues = expectedValues;
        }

        public void Format(StringBuilder result, ActualContainer actualValues, bool negation)
        {
            result.Append(negation ? "��������� �������� �� �������������" : "��������� �������� �������������");
            result.AppendLine(": ");
            result.Append(Helpers.FormatStringValues(expectedValues, 2));
            result.Append(string.Format(@", �� {0}", Helpers.FormatActualValues(actualValues)));
        }

        private readonly string[] expectedValues;
    }
}