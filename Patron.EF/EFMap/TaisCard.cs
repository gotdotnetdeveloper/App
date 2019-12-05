using Prism.Mvvm;

namespace Patron.EF.EFMap
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Card")]
    public partial class TaisCard : BindableBase
    {
        private int _cardId;
        private string _creator;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CardId
        {
            get => _cardId;
            set => SetProperty(ref _cardId, value);
        }
        public Guid Id { get; set; }

        public int? UserId { get; set; }

        public int? InstallId { get; set; }

        public int? Year { get; set; }

        public int? Card { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CardDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EditDate { get; set; }

        public string Creator
        {
            get => _creator;
            set => SetProperty(ref _creator, value);
        }
    }
}
