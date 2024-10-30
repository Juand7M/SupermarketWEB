using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWEB.Models
{
    public class Product
    {
        // [Key] antacion si la propiedad se llama id, ejemplo productid
        public int Id { get; set; } //sera la llave primaria
        public string Name { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; } //sera la llave foranea
        public Category Category { get; set; } // propiedad de navegacion
    }
}
