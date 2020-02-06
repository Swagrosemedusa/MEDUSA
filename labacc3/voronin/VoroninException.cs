using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voronin
{
    class VoroninException : Exception
    {
        public VoroninException(string message)
            : base(message)
        {
        }
    }
}
