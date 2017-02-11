namespace IdokladSdk.ApiFilters
{
    public class FilterItem
    {
        public FilterItem(string name)
        {
            _name = name;
        }

        private readonly string _name;
        private FilterOperator _operator;
        private object _value;
        private bool _active;

        public void Set(FilterOperator @operator, object value)
        {
            _operator = @operator;
            _value = value;
            _active = true;
        }

        public bool IsActive()
        {
            return _active;
        }

        public override string ToString()
        {
            return _name + "~" + _operator.ToString().ToLowerInvariant().Replace("n", "!") + "~" + _value;
        }
    }
}