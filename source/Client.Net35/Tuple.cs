using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thinktecture.IdentityModel.Client
{
    /// <summary>
    /// Mock of two elements tuple
    /// </summary>
    public class Tuple
    {
        public static Tuple<T1, T2> Create<T1, T2>(T1 value1, T2 value2)
        {
            var result = new Tuple<T1, T2>();
            result.Item1 = value1;
            result.Item2 = value2;
            return result;
        }
    }

    public class Tuple<T1, T2>
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
    }
}
