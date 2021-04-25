using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoPratico.Models {
    public class Fotografias {
        /// <summary>
        /// Identificador da fotografia
        /// </summary>
        [Key]
        public int IdFotografia { get; set; }

        /// <summary>
        /// Nome do Ficheiro com a fotografia do anime
        /// </summary>
        public string Fotografia { get; set; }

        /// <summary>
        /// FK para a Fotografia do Anime
        /// </summary>
        [ForeignKey(nameof(Anime))]  // esta 'anotação' indica que o atributo 'idAnimeFK' está a executar o mesmo que o atributo 'idAnime',
                                     // e que representa uma FK para a classe Review
        public int idAnimeFK { get; set; }   // atributo para ser usado no SGBD e no C#. Representa a FK para a Fotografia do Anime
        public Anime idAnime { get; set; }   // atributo para ser usado no C#. Representa a FK para a Fotografia do Anime
    }
}
