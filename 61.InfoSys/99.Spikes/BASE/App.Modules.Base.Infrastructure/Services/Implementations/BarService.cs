using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Modules.Base.Infrastructure.Services.Implementations
{
    /// <summary>
    /// Implementation of the <see cref="IBarService{T}"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BarService<T> : IBarService<T>
    {
        string _t;

     /// <summary>
     /// Constructor
     /// </summary>
        public BarService()
        {
            _t = typeof(T).Name;
        }
        /// <summary>
        /// Example action.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string Do(string text)
        {
            return $"{_t}: Blah {text}";
        }
    }
}
