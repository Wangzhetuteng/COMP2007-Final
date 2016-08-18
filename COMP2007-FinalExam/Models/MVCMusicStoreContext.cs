/* Name: Yandong Wang
 * Number: 200277628
 * Date: 8/18/2016
 * Version: 0.1
 * Description: Provide an Album List page,	an Artist list Page, and a Genre List page.
 */

namespace COMP2007_FinalExam.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MVCMusicStoreContext : DbContext
    {
        public MVCMusicStoreContext()
            : base("name=MVCMusicStoreContext")
        {
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }

    }
}
