using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Basket.Storage.Model
{
    [Table("BasketHistory")]
    public class BasketHistoryModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        public string UserId { get; set; }

        public string CatalogId { get; set; }

        public DateTime DayAndTime { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
