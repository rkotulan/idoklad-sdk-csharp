namespace IdokladSdk.ApiFilters
{
    public static class FilterItemExtensions
    {
        public static FilterItem IsEqual(this FilterItem fi, object value)
        {
            fi.Set(FilterOperator.Eq, value);

            return fi;
        }

        public static FilterItem IsNotEqual(this FilterItem fi, object value)
        {
            fi.Set(FilterOperator.Neq, value);

            return fi;
        }

        public static ContainFilterItem Contains(this ContainFilterItem fi, object value)
        {
            fi.Set(FilterOperator.Ct, value);

            return fi;
        }

        public static ContainFilterItem NotContains(this ContainFilterItem fi, object value)
        {
            fi.Set(FilterOperator.Nct, value);

            return fi;
        }

        public static CompareFilterItem IsGreatherThan(this CompareFilterItem fi, object value)
        {
            fi.Set(FilterOperator.Gt, value);

            return fi;
        }

        public static CompareFilterItem IsEqualOrGreatherThan(this CompareFilterItem fi, object value)
        {
            fi.Set(FilterOperator.Gte, value);

            return fi;
        }

        public static CompareFilterItem IsEqualOrLowerThan(this CompareFilterItem fi, object value)
        {
            fi.Set(FilterOperator.Lte, value);

            return fi;
        }

        public static CompareFilterItem IsLowerThan(this CompareFilterItem fi, object value)
        {
            fi.Set(FilterOperator.Lt, value);

            return fi;
        }
    }
}