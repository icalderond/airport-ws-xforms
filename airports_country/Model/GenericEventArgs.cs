using System;
using System.Collections.Generic;

namespace airports_country.Model
{
    public class GenericEventArgs<T> : EventArgs
    {
        public IList<T> Result;
        public GenericEventArgs(IList<T> _result)
        {
            Result = _result;
        }
    }
}