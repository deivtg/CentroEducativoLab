using CentroEducativoLab.Edu.Kinal.Lab.Interfaces;

namespace CentroEducativoLab.Edu.Kinal.Lab.Entities
{
    public class Alumno : Persona, IOperaciones
    {
        public string Carne { get; set; }
        public int NumeroCreditos { get; set; }
        public Alumno() : base()
        {

        }
        public Alumno(string uuid, string apellidos, string nombres, string email, string carne, int numeroCreditos)
            : base(uuid, apellidos, nombres, email)
        {
            this.Carne = carne;
            this.NumeroCreditos = numeroCreditos;
        }
        public bool EliminarAsignatura(string asignatura)
        {
            Console.WriteLine($"Se ha eliminado la asignatura {asignatura} de {this.Apellidos} {this.Nombres}, pedera la cantidad de créditos de {this.NumeroCreditos}");
            return true;
        }

        public void ListarMisDatos(string identificador)
        {
            Console.WriteLine($"{this.UUID} - {this.Apellidos}, {this.Nombres} - {this.NumeroCreditos} - {identificador}");
        }

        public override void TomarAsistencia()
        {
            Console.WriteLine($"Alumno: {this.Nombres} asistio en la fecha {DateTime.Now}.");
        }
    }
}