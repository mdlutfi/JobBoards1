using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoards1.Shared.Domain
{
    public class JobSeeker :  BaseDomainModel 
    {
        public string Name;
        public int Age;
        public string Email;
        public int ContactNumber;

        public virtual List<Request> Requests { get; set; }
    }
}
