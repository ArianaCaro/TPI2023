using Data.DataBase;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class S_Materia
    {
        MateriasDAO MateriaData = new MateriasDAO();
        public string ObtenerDescripcionMateria(int id_materia)
        {
            return MateriaData.ObtenerDescripcionMateria(id_materia);
        }

        public DataTable ObtenerTodasLasMaterias()
        {
            return MateriaData.ObtenerTodasLasMaterias();
        }

        public bool AgregarMateria(Materia materia)
        {
            return MateriaData.AgregarMateria(materia);
        }
        public bool ModificarMateria(Materia materia)
        {
            return MateriaData.ModificarMateria(materia);
        }

        public bool EliminarMateria(Materia materia)
        {
            return MateriaData.EliminarMateria(materia);
        }
    }
}
