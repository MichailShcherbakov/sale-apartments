using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentsSales
{
    class InitializerDB : DropCreateDatabaseIfModelChanges<LocalContext>
        //DropCreateDatabaseAlways<EsoftContext>
    {
        protected override void Seed(LocalContext db)
        {
            /*var skillTypes = new SkillType[]
            {
                new SkillType() { Description = "Работа с возражениями" },
                new SkillType() { Description = "Овладение навыками продаж" },
                new SkillType() { Description = "Знание продуктов компании" },
            };

            foreach (var skillType in skillTypes)
                db.SkillTypes.Add(skillType);

            db.SaveChanges();*/
        }
    }
}
