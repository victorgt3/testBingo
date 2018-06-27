using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestBingo.Models
{
    [Table("Cartelas")]
    public class Cartela
    {
       
        [Key]
        public int CartelaId { get; set; }
        public int CodigoTabela { get; set; }
        public int Campo1 { get; set; }
        public int Campo2 { get; set; }
        public int Campo3 { get; set; }
        public int Campo4 { get; set; }
        public int Campo5 { get; set; }
        public int Campo6 { get; set; }
        public int Campo7 { get; set; }
        public int Campo8 { get; set; }
        public int Campo9 { get; set; }
        public int Campo10 { get; set; }
        public int Campo11 { get; set; }
        public int Campo12 { get; set; }
        public int Campo13 { get; set; }
        public int Campo14 { get; set; }
        public int Campo15 { get; set; }
        public virtual ICollection<Sorteio> Sorteios { get; set; } 
    }
}