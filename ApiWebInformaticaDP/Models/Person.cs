namespace ApiWebInformaticaDP.Models
{
    public class Person
    {
        // Get -> Permite obtener acceso a la propiedad desde fuera de la clase.
        // Set -> Permite establecer el valor de la propiedad desde fuera de la clase.
        public int Id { get; set; }

        public required string Name { get; set; }

        public required int Age { get; set; }
    }
}
