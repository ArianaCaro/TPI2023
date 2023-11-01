namespace Entidades
{
    public class Inscripcion
    {
         int id_inscripcion, id_alumno, id_curso,nota;
         string condicion;

        public int IdInscripcion
        {
            get { return id_inscripcion; }
            set { id_inscripcion = value; }
        }

        public int IdAlumno
        {
            get { return id_alumno; }
            set { id_alumno = value; }
        }
        public int IdCurso
        {
            get { return id_curso; }
            set { id_curso = value; }
        }
        public string Condicion
        {
            get { return condicion; }
            set { condicion = value; }
        }
        public int Nota
        {
            get { return nota; }
            set { nota = value; }
        }
    }
}