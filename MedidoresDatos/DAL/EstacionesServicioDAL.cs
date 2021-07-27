using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDatos.DAL
{
    public class EstacionesServicioDAL
    {
        public MedidoresBDEntities dbEntities = new MedidoresBDEntities();

        public void Add(EstacionServicio e)
        {
            dbEntities.EstacionServicio.Add(e);
            dbEntities.SaveChanges();
        }

        public void Remove(int id)
        {
            EstacionServicio e = dbEntities.EstacionServicio.Find(id);
            dbEntities.EstacionServicio.Remove(e);
            dbEntities.SaveChanges();
        }

        public EstacionServicio GetEstacion(int id)
        {
            return dbEntities.EstacionServicio.Find(id);
        }

        public List<EstacionServicio> GetAll()
        {
            return dbEntities.EstacionServicio.ToList();
        }
    }
}
