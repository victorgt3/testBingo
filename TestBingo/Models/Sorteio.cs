using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestBingo.Models
{
    [Table("Sorteios")]
    public class Sorteio
    {
       
        [Key]
        public int SorteioId { get; set; }
        public int Numero { get; set; }
        public virtual Cartela Cartela { get; set; }
        public virtual ICollection<Cartela> Cartelas { get; set; }

    }
}