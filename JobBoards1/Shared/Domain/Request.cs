using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoards1.Shared.Domain
{
    public class Request : BaseDomainModel
    {
        public string Name;
        public string Qualification;
        public string Email;
        public int JobSeekerId;
        public int JobPostId;
        public virtual JobPost JobPost { get; set; }
        public virtual JobSeeker JobSeeker { get; set; }

    }
}

