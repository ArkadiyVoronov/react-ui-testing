using System.Text;

namespace SKBKontur.SeleniumTesting.Assertions.ErrorMessages.Expecations
{
    internal class MatchValueExpectation : IValueExpectationFormatter
    {
        public MatchValueExpectation(string expected)
        {
            this.expected = expected;
        }

        public void Format(StringBuilder result, ActualContainer actualValues, bool negation)
        {
            result.AppendLine(negation ? "��������� �� �������������� regex-�:" : "��������� �������������� regex-�:");
            result.Append(string.Format(@"  '{0}', �� {1}", expected, Helpers.FormatActualValues(actualValues)));
        }

        private readonly string expected;
    }
}