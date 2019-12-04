namespace Pidev.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }
        static Context()
        {
            Database.SetInitializer<Context>(null);
        }
        public virtual DbSet<collaborator> collaborators { get; set; }
        public virtual DbSet<expenseform> expenseforms { get; set; }
        public virtual DbSet<expform> expforms { get; set; }
        public virtual DbSet<fixedfee> fixedfees { get; set; }
        public virtual DbSet<manager> managers { get; set; }
        public virtual DbSet<mission> missions { get; set; }
        public virtual DbSet<mission1> mission1 { get; set; }
        public virtual DbSet<missionrequest> missionrequests { get; set; }
        public virtual DbSet<test> tests { get; set; }
        public virtual DbSet<waitingQueue> waitingQueues { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Database.SetInitializer<Context>(null);

            modelBuilder.Entity<collaborator>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<collaborator>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<collaborator>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<collaborator>()
                .Property(e => e.lastname)
                .IsUnicode(false);

            modelBuilder.Entity<collaborator>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<collaborator>()
                .Property(e => e.DTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<collaborator>()
                .Property(e => e.team)
                .IsUnicode(false);

            modelBuilder.Entity<collaborator>()
                .HasMany(e => e.missionrequests)
                .WithOptional(e => e.collaborator)
                .HasForeignKey(e => e.man_id);

            modelBuilder.Entity<collaborator>()
                .HasMany(e => e.expforms)
                .WithOptional(e => e.collaborator)
                .HasForeignKey(e => e.man_id);

            modelBuilder.Entity<collaborator>()
                .HasMany(e => e.missionrequests1)
                .WithRequired(e => e.collaborator1)
                .HasForeignKey(e => e.idCollab)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<collaborator>()
                .HasMany(e => e.collaborator1)
                .WithOptional(e => e.collaborator2)
                .HasForeignKey(e => e.manager_id);

            modelBuilder.Entity<collaborator>()
                .HasMany(e => e.fixedfees)
                .WithOptional(e => e.collaborator)
                .HasForeignKey(e => e.man_id);

            modelBuilder.Entity<collaborator>()
                .HasMany(e => e.expforms1)
                .WithOptional(e => e.collaborator1)
                .HasForeignKey(e => e.collab_id);

            modelBuilder.Entity<expenseform>()
                .Property(e => e.Collab)
                .IsUnicode(false);

            modelBuilder.Entity<expenseform>()
                .Property(e => e.Justification)
                .IsUnicode(false);

            modelBuilder.Entity<expenseform>()
                .Property(e => e.amount)
                .IsUnicode(false);

            modelBuilder.Entity<expenseform>()
                .Property(e => e.date)
                .IsUnicode(false);

            modelBuilder.Entity<expenseform>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<expform>()
                .Property(e => e.Justification)
                .IsUnicode(false);

            modelBuilder.Entity<expform>()
                .Property(e => e.amount)
                .IsUnicode(false);

            modelBuilder.Entity<expform>()
                .Property(e => e.date)
                .IsUnicode(false);

            modelBuilder.Entity<expform>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<expform>()
                .HasMany(e => e.collaborators)
                .WithMany(e => e.expforms2)
                .Map(m => m.ToTable("collaborator_expform").MapLeftKey("Eform_EF_Id").MapRightKey("Collaborator_id"));

            modelBuilder.Entity<fixedfee>()
                .HasMany(e => e.mission1)
                .WithOptional(e => e.fixedfee)
                .HasForeignKey(e => e.ffee_id);

            modelBuilder.Entity<manager>()
                .Property(e => e.team)
                .IsUnicode(false);

            modelBuilder.Entity<manager>()
                .HasMany(e => e.expforms)
                .WithOptional(e => e.manager)
                .HasForeignKey(e => e.man_id);

            modelBuilder.Entity<manager>()
                .HasMany(e => e.fixedfees)
                .WithOptional(e => e.manager)
                .HasForeignKey(e => e.man_id);

            modelBuilder.Entity<manager>()
                .HasMany(e => e.missionrequests)
                .WithOptional(e => e.manager)
                .HasForeignKey(e => e.man_id);

            modelBuilder.Entity<mission>()
                .Property(e => e.emplacement)
                .IsUnicode(false);

            modelBuilder.Entity<mission>()
                .Property(e => e.endDate)
                .IsUnicode(false);

            modelBuilder.Entity<mission>()
                .Property(e => e.startDate)
                .IsUnicode(false);

            modelBuilder.Entity<mission1>()
                .Property(e => e.emplacement)
                .IsUnicode(false);

            modelBuilder.Entity<mission1>()
                .Property(e => e.endDate)
                .IsUnicode(false);

            modelBuilder.Entity<mission1>()
                .Property(e => e.startDate)
                .IsUnicode(false);

            modelBuilder.Entity<mission1>()
                .HasMany(e => e.expforms)
                .WithOptional(e => e.mission1)
                .HasForeignKey(e => e.miss_id);

            modelBuilder.Entity<mission1>()
                .HasMany(e => e.fixedfees)
                .WithOptional(e => e.mission11)
                .HasForeignKey(e => e.miss_id);

            modelBuilder.Entity<mission1>()
                .HasMany(e => e.missionrequests)
                .WithRequired(e => e.mission1)
                .HasForeignKey(e => e.idMission)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<missionrequest>()
                .Property(e => e.date)
                .IsUnicode(false);

            modelBuilder.Entity<missionrequest>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<missionrequest>()
                .Property(e => e.lastname)
                .IsUnicode(false);

          
        }
    }
}
