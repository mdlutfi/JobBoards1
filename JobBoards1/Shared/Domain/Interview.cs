using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoards1.Shared.Domain
{
    public class Interview : BaseDomainModel
    {
        public DateTime DateandTime;
        public string Location;
        public int RequestId;
        

        public virtual Request Requests { get; set; }
    }
}