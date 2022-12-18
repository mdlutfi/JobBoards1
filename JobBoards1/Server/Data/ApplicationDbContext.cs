
using IdentityServer4.EntityFramework.Options;
using JobBoards1.Server.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using JobBoards1.Shared.Domain;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoards1.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<JobPost> JobPosts { get; set; }
        public DbSet<Company> Companys  { get; set; }
        public DbSet<JobSeeker> JobSeekers { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<Request> Requests { get; set; }
    
    }
}
