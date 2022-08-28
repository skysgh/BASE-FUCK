using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Modules.Base.Infrastructure.Services
{
    public interface IBarService<T>
    {
        string Do(string text);
    }
}
