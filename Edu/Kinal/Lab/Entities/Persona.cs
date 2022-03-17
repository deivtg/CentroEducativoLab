namespace CentroEducativoLab.Edu.Kinal.Lab.Entities
{
    public abstract class Persona
    {
        public string UUID { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Email { get; set; }
        public abstract void TomarAsistencia();
        public Persona()
        {

        }
        public Persona(string uuid, string apellidos, string nombres, string email){
            this.UUID = uuid;
            this.Apellidos = apellidos;
            this.Nombres = nombres;
            this.Email = email;
        }
    }
}