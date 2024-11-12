using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersices.mock_sample
{
    public interface IMockRepository
    {
        // CRUD operations
        string Get(int id);
        void Delete(int id);
        void Add(int id);
    }
}
