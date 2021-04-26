using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoPratico.Models {
    public class Links {

        public Links() {
            // inicializar a lista de Animes ao Link
            ListaDeAnimes = new HashSet<AnimeLinks>();
            // inicializar a lista de links
            ListaDeLinks = new HashSet<Links>();
        }
        /// <summary>
        /// Possui o Identificador do Link
        /// </summary>
        [Key]
        public string IdLinks { get; set; }

        /// <summary>
        /// Possui o Caminho Direcionado para Sites com o Anime em Questão
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// lista dos Animes associados aos Links
        /// </summary>
        public ICollection<AnimeLinks> ListaDeAnimes { get; set; }

        /// <summary>
        /// lista dos Links
        /// </summary>
        public ICollection<Links> ListaDeLinks { get; set; }

    }
}
