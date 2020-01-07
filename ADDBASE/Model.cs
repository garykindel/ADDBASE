using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ADDBASE
{
    //Step 1 - Add-Migration InitialCreate
    //Step 2 - update-database
    



    public class AddContext : DbContext
    {
        public DbSet<Weapon> Weapons { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=addbase.db");
    }

    public class Weapon
    {
        [Key]
        public Int64 Key { get; set; }
        public string Item { get; set; }
        public string Cost { get; set; }
        public string Weight { get; set; }
        public string Size { get; set; }
        public string WeaponType { get; set; }
        public string SpeedFactor { get; set; }
        public string DamageXSmall { get; set; }
        public string DamageXLarge { get; set; }
        public string Source { get; set; }

    }

}
