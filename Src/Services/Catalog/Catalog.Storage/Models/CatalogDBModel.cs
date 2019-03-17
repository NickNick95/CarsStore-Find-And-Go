using Catalog.Storage.Interfaces.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catalog.Storage.Models
{
    [Table("Catalog")]
    public class CatalogDBModel : ICatalogDBModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
