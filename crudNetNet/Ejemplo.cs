 using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crudNetNet
{
    [Table("ejemplos")]
    public class Ejemplo
    {
        [Key]   //Clave primaria de la bd
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   //El valor se genera auto en la bd
        [Column("Id")]  //nombre de la columna en la bd
        public int Id { get; set; } //se puede leer y modificar

        [Column("Nombre")]
        [StringLength(100)]     //Como no es la clave primaria, se establece otras propiedades como la longitud
        public string? Nombre { get; set; } //la variable puede ser nula

        [Column("Valor")]
        public double? Valor { get; set; }
    }

}
