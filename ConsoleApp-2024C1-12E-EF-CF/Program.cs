namespace ConsoleApp_2024C1_12E_EF_CF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio");

            var miContexto = new EscuelaContext();

            var miConsulta = from estu in miContexto.Estudiantes where estu.Edad >= 13 && estu.Edad <= 18 select estu;

            foreach (var item in miConsulta)
            {
                Console.WriteLine("Nombre " + item.Nombre + " " + "Edad " + item.Edad);
            }

            var nuevoEstudiante = new Estudiante()
            {
                Nombre = "Ezequiel",
                Edad = 18
            };
            miContexto.Estudiantes.Add(nuevoEstudiante);
            miContexto.SaveChanges();

            Console.WriteLine("Fin");
        }
    }
}
