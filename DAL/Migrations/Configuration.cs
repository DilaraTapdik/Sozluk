namespace DAL.Migrations
{
    using DomainEntity.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.SozlukContex>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DAL.SozlukContex context)
        {
            if (context.Kelimeler.Count() == 0)
            {
                SozlukKelime k1 = new SozlukKelime();
                k1.KelimeTR = "Merhaba";
                k1.KelimeEN = "Hello";
                k1.KelimeESP = "Hola";

                SozlukKelime k2 = new SozlukKelime();
                k2.KelimeTR = "Öðrenci";
                k2.KelimeEN = "Student";
                k2.KelimeESP = "Estudient";

                SozlukKelime k3 = new SozlukKelime();
                k3.KelimeTR = "Okul";
                k3.KelimeEN = "School";
                k3.KelimeESP = "Escuela";

                context.Kelimeler.Add(k1);
                context.Kelimeler.Add(k2);
                context.Kelimeler.Add(k3);
                context.SaveChanges();

            }
        }
    }
}

