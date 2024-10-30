namespace SupermarketWEB.Models
{
    public class Category
    {
        public int Id { get; set; } //SERA LA LLAVE PRIMARIA
        public string Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Product> Products { get; set; } // propiedad de navegacion
    }
}
