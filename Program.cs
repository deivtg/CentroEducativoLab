using CentroEducativoLab.Edu.Kinal.Lab.Entities;
public class Program{
    static List<Persona> listaGeneral = new List<Persona>();
    public static void Main(string[] args){
        Alumno alumno1 = new Alumno("A123456", "Tocay Garcia", "David Antonio", "devitg@gmail.com", "12345678", 5);
        Persona alumno2 = new Alumno("A123457", "Alonzo Pineda", "Gustavo Adolfo", "galonzo@gmail.com", "12345679", 7);
        Profesor profesor1 = new Profesor("P123456", "Tumax", "Edwin", "etumax@gmail.com", "25143218979", "Matematicas");
        Persona profesor2 = new Profesor("P123457", "Granados", "Gricelda", "ggranados@gmail.com", "25143218975", "Fisica Fundamental");
        OperarRegistro(alumno1);
        OperarRegistro(alumno2);
        OperarRegistro(profesor1);
        OperarRegistro(profesor2);

        foreach (var persona in listaGeneral){
            RegistrarAsistencia(persona);
            VerMisDatos(persona);
        }

        QuitarAsignatura(alumno2);
        QuitarAsignatura(profesor1);
    }

    static void OperarRegistro(Persona persona){        
        listaGeneral.Add(persona);
    }

    static void RegistrarAsistencia(Persona persona)
    {
        if(persona is Profesor)
        {
            ((Profesor)persona).TomarAsistencia();
        }else if (persona is Alumno){
            ((Alumno)persona).TomarAsistencia();
        }
    }

    static void VerMisDatos(Persona persona)
    {
        if(persona is Profesor){
            ((Profesor)persona).ListarMisDatos(((Profesor)persona).CUI);
        }else if (persona is Alumno){
            ((Alumno)persona).ListarMisDatos(((Alumno)persona).Carne);
        }
    }

    static void QuitarAsignatura(Persona persona)
    {
        if(persona is Profesor){
            ((Profesor)persona).EliminarAsignatura("Matematicas");
        }else if (persona is Alumno){
            ((Alumno)persona).EliminarAsignatura("Sociales");
        }
    }
}