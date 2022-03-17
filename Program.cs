using CentroEducativoLab.Edu.Kinal.Lab.Entities;
using CentroEducativoLab.Edu.Kinal.Lab.Interfaces;

public class Program{
    private static List<Persona> ListaGeneral = new List<Persona>();
    public static void Main(string[] args){
        Alumno alumno1 = new Alumno("A123456", "Tocay Garcia", "David Antonio", "devitg@gmail.com", "12345678", 5);
        Persona alumno2 = new Alumno("A123457", "Alonzo Pineda", "Gustavo Adolfo", "galonzo@gmail.com", "12345679", 7);
        Profesor profesor1 = new Profesor("P123456", "Tumax", "Edwin", "etumax@gmail.com", "25143218979", "Matematicas");
        Persona profesor2 = new Profesor("P123457", "Granados", "Gricelda", "ggranados@gmail.com", "25143218975", "Fisica Fundamental");
        
        Console.WriteLine("Procesando registro de datos");
        OperarRegistro(alumno1);
        OperarRegistro(alumno2);
        OperarRegistro(profesor1);
        OperarRegistro(profesor2);

        Console.WriteLine("Registrar asistencia");
        foreach (Persona registro in ListaGeneral){
            RegistrarAsistencia(registro);
        }

        Console.WriteLine("Mostrando datos");
        foreach (Persona registro in ListaGeneral){
            VerMisDatos(registro);
        }

        Console.WriteLine("Eliminando asignaturas");
        QuitarAsignatura(alumno2, "Matematicas");
        QuitarAsignatura(profesor1, "Matematicas");
    }

    static void OperarRegistro(Persona persona){        
        ListaGeneral.Add(persona);
    }

    static void RegistrarAsistencia(Persona persona)
    {
        foreach (Persona registro in ListaGeneral)
        {
            if (registro.UUID == persona.UUID){
                persona.TomarAsistencia();
            }
        }
    }

    static void VerMisDatos(Persona persona)
    {
        if(persona is Profesor){
            Profesor auxiliar = (Profesor)persona;
            auxiliar.ListarMisDatos(auxiliar.CUI);
        }else if (persona is Alumno){
            Alumno auxiliar = (Alumno)persona;
            auxiliar.ListarMisDatos(auxiliar.Carne);
        }
    }

    static void QuitarAsignatura(Persona persona, string asignatura)
    {
        ((IOperaciones)persona).EliminarAsignatura(asignatura);
    }
}