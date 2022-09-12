using proyectoMVC.Models;
using proyectoMVC.Data;

namespace proyectoMVC.Services
{
    public class TallerServices
    {
        private readonly IRepositorio repositorio;

        public TallerServices(IRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public async Task Crear(Taller taller)
        {
            await this.repositorio.Save(taller);
            await this.repositorio.Comit();
        }

        public async Task<List<Taller>> GetAllTaller()
        {
            return await this.repositorio.GetAll<Taller>();
        }
        
        public  void Actualizar(Taller taller)
        {
            if (taller is  null)
            {
                throw new Exception("No Existe Taller");
            }

            this.repositorio.Update(taller);
            this.repositorio.Comit();
        }

        public void Eliminar(Taller taller)
        {
            this.repositorio.Delete(taller);
            this.repositorio.Comit();
        }
    }
}
