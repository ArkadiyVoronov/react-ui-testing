using System;

namespace SKBKontur.SeleniumTesting
{
    public class ElementNotFoundException : Exception
    {
        public ElementNotFoundException(ControlBase control, ISearchContainer container, Type getType, ISelector selector, Exception exception)
            : base(string.Format("������� {0} �� ������� {1} �� ������ ������ �������� {2}", getType, selector, container.GetType().Name), exception)
        {
            Control = control;
            Container = container;
            ControlType = getType;
            ControlSelector = selector;
        }

        public ControlBase Control { get; set; }
        public ISearchContainer Container { get; set; }
        public Type ControlType { get; set; }
        public ISelector ControlSelector { get; set; }
    }
}