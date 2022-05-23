using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Laborator5.Models
{
    public class Carte
    {
        public int CarteId { get; set; }
        public string Titlu { get; set; }
        public string Autor { get; set; }
        public string Editura { get; set; }

        [Range(1901, 2021), Display(Name = "Anul aparitiei")]
        public int AnAparitie { get; set; }
    }
}