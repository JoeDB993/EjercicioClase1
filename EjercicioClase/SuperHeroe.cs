namespace EjercicioClase
{
    public class SuperHeroe
    {
        public string nombre { get; set; }
        public string identidadsecreta { get; set; }
        public string ciudad { get; set; }
        public bool puedevolar { get; set; }
        public SuperPoder SuperPoder { get; set; }

        //Constructor
        public SuperHeroe()
        {
            puedevolar = true;
            SuperPoder = new SuperPoder();
        }
        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Identidad Secreta: {identidadsecreta}");
            Console.WriteLine($"Ciudad: {ciudad}");
            Console.WriteLine($"Puede volar: {(puedevolar ? "Si" : "No")}");
            Console.WriteLine($"Superpoder: {SuperPoder.NombrePoder}");
            Console.WriteLine($"Descripción del Poder: {SuperPoder.descripcion}");
            Console.WriteLine($"Nivel: {SuperPoder.nivel}");
            Console.WriteLine();
        }

    }
}