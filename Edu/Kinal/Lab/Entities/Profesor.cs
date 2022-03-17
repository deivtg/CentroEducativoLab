using CentroEducativoLab.Edu.Kinal.Lab.Interfaces;

namespace CentroEducativoLab.Edu.Kinal.Lab.Entities
{
    public class Profesor : Persona, IOperaciones
    {
        public string CUI { get; set; }
        public string Cargo { get; set; }
        public Profesor() : base()
        {

        }
        public Profesor(string uuid, string apellidos, string nombres, string email, string cui, string cargo)
            : base(uuid, apellidos, nombres, email)
        {
            this.CUI = cui;
            this.Cargo = cargo;
        }
        public bool EliminarAsignatura(string asignatura)
        {
            Console.WriteLine($"Se ha eliminado la asignatura {asignatura} del profesor {this.Apellidos} {this.Nombres}");
            return true;
        }

        public void ListarMisDatos(string identificador)
        {
            Console.WriteLine($"{this.UUID} - {this.Apellidos}, {this.Nombres} - {this.Cargo} - {identificador}");
        }

        public override void TomarAsistencia()
        {
            Console.WriteLine($"Profesor: {this.Nombres} - {this.UUID} asistio en la fecha {DateTime.Now}");
        }
    }
}