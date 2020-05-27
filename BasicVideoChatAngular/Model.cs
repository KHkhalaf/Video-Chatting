using Microsoft.EntityFrameworkCore;

namespace BasicVideoChatAngular
{
    public class OpentokContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("server=DESKTOP-FKTABFC; database=VideoChatting; integrated security = true");
    }

    public class Room
    {
        public int RoomId { get; set; }
        public string SessionId { get; set; }
        public string RoomName { get; set; }
        public string Token { get; set; }
    }
}
