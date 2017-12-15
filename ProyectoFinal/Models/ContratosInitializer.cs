using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/
namespace ProyectoFinal.Models
{
    
        public class ContratosInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ContratsContext>
        {
        protected override void Seed(ContratsContext context)
        {
            var locadores = new List<Locador>
            {
            new Locador{IDLod=1, Name="Monica",LastName="Ascheri", PhoneNumber="011-15-62456998"  },

            };

            locadores.ForEach(s => context.Locadores.Add(s));
            context.SaveChanges();
            var locatarios = new List<Locatario>
            {
            new Locatario{IDLot=1, Name="Mariano",LastName="Cordoba",PhoneNumber="011-15-48795523",},
 
            };
            locatarios.ForEach(s => context.Locatarios.Add(s));
            context.SaveChanges();
            var garantes = new List<Garante>
            {
            new Garante{IDGr=1, Name="Susana",LastName= "Lazo",PhoneNumber="011-46547896"},
          
            };
            garantes.ForEach(s => context.Garantes.Add(s));
            context.SaveChanges();

            var propiedades = new List<Propiedades>
            {
            new Propiedades{IDPropiedad=1,Address="Juncal 860"},

            };
            propiedades.ForEach(s => context.Propiedades.Add(s));
            context.SaveChanges();

            var contratos = new List<Contratos>
            {
                new Contratos{ IDContrat=1,Ff="04/12/2016",Fi="04/12/2018"},

            };
            contratos.ForEach(s => context.Contratos.Add(s));
        }

    }
}
