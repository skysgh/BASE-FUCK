using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Modules.Base.Infrastructure.Services
{
    /// <summary>
    /// Contract for multiple Named services.
    /// </summary>
    public interface IBazService
    {

        /// <summary>
        /// Example operation
        /// </summary>
        /// <returns></returns>
        string Do();
    }
}
