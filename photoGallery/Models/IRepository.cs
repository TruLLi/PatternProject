using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProject.Models
{
    public interface IRepository<TResult>
    {
        List<TResult> GetAll();
    }
}
