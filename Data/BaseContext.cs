using BackNoteWorksTech.Models;
using Microsoft.EntityFrameworkCore;

namespace BackNoteWorksTech.Data
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options){

        }
        
        public DbSet<NoteWork> NoteWorks { get; set; }
        public DbSet<Category> Categories { get; set; }
    }

}