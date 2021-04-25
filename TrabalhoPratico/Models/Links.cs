using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoPratico.Models {
    public class Links {
        /// <summary>
        /// Possui o Identificador do Link
        /// </summary>
        [Key]
        public string IdLinks { get; set; }

        /// <summary>
        /// Possui o Caminho Direcionado para Sites com o Anime em Questão
        /// </summary>
        public string Link { get; set; }

    }
}
