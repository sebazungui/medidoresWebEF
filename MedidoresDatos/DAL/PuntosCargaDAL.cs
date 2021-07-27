using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDatos.DAL
{
    public class PuntosCargaDAL
    {
        public MedidoresBDEntities dbEntities = new MedidoresBDEntities();

        public void Add(PuntoCarga p)
        {
            dbEntities.PuntoCarga.Add(p);
            dbEntities.SaveChanges();
        }

        public void Remove(int id)
        {
            PuntoCarga p = dbEntities.PuntoCarga.Find(id);
            dbEntities.PuntoCarga.Remove(p);
            dbEntities.SaveChanges();
        }

        public List<PuntoCarga> GetAll()
        {
            return dbEntities.PuntoCarga.ToList();
        }

        public PuntoCarga GetPunto(int id)
        {
            return dbEntities.PuntoCarga.Find(id);
        }

        public List<PuntoCarga> GetAll(int tipo)
        {
            var query = from p in dbEntities.PuntoCarga
                        where p.Tipo == tipo
                        select p;

            return query.ToList();
        }

        public void Update(PuntoCarga p)
        {
            PuntoCarga pto = dbEntities.PuntoCarga.Find(p.Id);
            pto.CapacidadMaxima = p.CapacidadMaxima;
            pto.Tipo = p.Tipo;
            pto.FechaVencimiento = p.FechaVencimiento;
            dbEntities.SaveChanges();

        }

    }
}
