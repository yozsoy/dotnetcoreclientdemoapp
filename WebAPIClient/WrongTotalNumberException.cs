using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIClient
{
    public class WrongTotalNumberException : Exception
    {
        public WrongTotalNumberException(): base("infinite loop")
        {
        }
    }
}
