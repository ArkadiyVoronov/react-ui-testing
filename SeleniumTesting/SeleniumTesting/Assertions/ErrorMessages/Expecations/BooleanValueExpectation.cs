using System.Text;

namespace SKBKontur.SeleniumTesting.Assertions.ErrorMessages.Expecations
{
    internal class BooleanValueExpectation : IValueExpectationFormatter
    {
        public BooleanValueExpectation(bool value)
        {
            this.value = value;
        }

        public void Format(StringBuilder result, ActualContainer actualValues, bool negation)
        {
            if(value)
                result.Append(negation ? "��������� ������" : "��������� �������");
            else
                result.Append(negation ? "��������� �������" : "��������� ������");
            result.Append(string.Format(@", �� {0}", Helpers.FormatActualValues(actualValues)));
        }

        private readonly bool value;
    }
}