using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoards1.Shared.Domain
{
    public class JobPost : BaseDomainModel
    {
        public string JobPosition;
        public string MinimumQualification;
        public int Salary;
        public int CompanyId;

        public virtual Company Company { get; set; }
        public virtual List<Request> Requests { get; set; }
    }
}