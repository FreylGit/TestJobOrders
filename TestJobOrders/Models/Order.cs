using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestJobOrders.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите город отправителя")]
        [MaxLength(100)]
        [Display(Name = "Город отправителя")]
        
        public string SenderCity { get; set; }
        [Required(ErrorMessage = "Введите адрес отправителя")]
        [MaxLength(200)]
        [Display(Name = "Адрес отправителя")]
        public string SenderAddress { get; set; }
        [Required(ErrorMessage = "Введите город получателя")]
        [MaxLength(100)]
        [Display(Name = "Город получателя")]

        public string RecipientCity { get; set; }
        [Required(ErrorMessage = "Введите адрес получателя")]
        [MaxLength(200)]
        [Display(Name = "Адрес получателя")]
        public string RecipientAddress { get; set; }
        [Required(ErrorMessage = "Введите вес груза")]
        [Display(Name = "Вес груза")]
        [Range(1,50000,ErrorMessage ="Недопустимый вес груза")]
        public double Weight { get; set; }
        [Required(ErrorMessage = "Введите дату забора груза")]
        [Display(Name = "Дата забора груза")]
        public DateTime CollectionDate { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Номер заказа")]
        public Guid Number { get; set; }
    }
}
