using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClient.Model.Models;

namespace WebClient.Data
{
    public class WebClientDbContext : DbContext
    {
        public WebClientDbContext() : base("WebClientConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Administration> Administration { set; get; }
        public DbSet<Answer> Answer { set; get; }
        public DbSet<AnswerSheet> AnswerSheet { set; get; }
        public DbSet<DECHUAN> DECHUAN { set; get; }
        public DbSet<DECHUAN_QUESTION> DECHUAN_QUESTION { set; get; }
        public DbSet<DETRON> DETRON { set; get; }
        public DbSet<DETRON_QUESTION> DETRON_QUESTION     { set; get; }
        public DbSet<FOOTER> FOOTER { set; get; }
        public DbSet<HoanVi> HoanVi { set; get; }
        public DbSet<LOG_IN> LOG_IN { set; get; }
        public DbSet<MENU> MENU { set; get; }
        public DbSet<MENUGROUP> MENUGROUP { set; get; }
        public DbSet<PAGE> PAGE { set; get; }
        public DbSet<PHANQUYEN> PHANQUYEN { set; get; }
        public DbSet<POST> POST { set; get; }
        public DbSet<POSTTAG> POSTTAG { set; get; }
        public DbSet<QClass> QClass { set; get; }
        public DbSet<Question> Question { set; get; }
        public DbSet<SLIDE> SLIDE { set; get; }
        public DbSet<Subject> Subject { set; get; }
        public DbSet<SUPPORT_ONLINE> SUPPORT_ONLINE { set; get; }
        public DbSet<SYSTEMCONFIG> SYSTEMCONFIG { set; get; }
        public DbSet<TAG> TAG { set; get; }
        public DbSet<User> User { set; get; }
        public DbSet<VISITOR_STATISTIC> VISITOR_STATISTIC { set; get; }
        public DbSet<Error> Error { set; get; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
    }
}
