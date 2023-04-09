using Microsoft.EntityFrameworkCore;
using UserApi.Data.Map;
using UserApi.Models;

namespace UserApi.Data
{
    public class TaskSystemDBContext: DbContext {
        public TaskSystemDBContext(DbContextOptions<TaskSystemDBContext> options) : base(options) {

        }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new TaskMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
