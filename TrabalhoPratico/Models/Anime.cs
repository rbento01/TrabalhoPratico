using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoPratico.Models {
    public class Anime {

        public Anime() {
            // inicializar a lista de Animes
            ListaDeAnimes = new HashSet<Anime>();
            // inicializar a lista de Users dos Animes
            ListaDeUsers = new HashSet<UsersAnimes>();
            // inicalizar a lista de Fotografias
            ListasDeFotografias = new HashSet<Fotografias>();
            // inicaliazar a lista de Links do Animes
            ListaDeLinks = new HashSet<AnimeLinks>();
        }

        /// <summary>
        /// Identificador de cada Anime
        /// </summary>
        [Key]
        public int IdAnime { get; set; }

        /// <summary>
        /// Possui o Nome do anime
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Possui o Rating do Anime
        /// </summary>
        public float Rating { get; set; }

        /// <summary>
        /// Possui a Sinopse do Anime
        /// </summary>
        public string Sinopse { get; set; }

        /// <summary>
        /// Possui o Nome do Autor
        /// </summary>
        public string Autor { get; set; }

        /// <summary>
        /// Possui o Nome do Estudio
        /// </summary>
        public string Estudio { get; set; }

        /// <summary>
        /// Possui o Valor do Ano
        /// </summary>
        public int Ano { get; set; }

        /// <summary>
        /// Lista dos Animes
        /// </summary>
        public ICollection<Anime> ListaDeAnimes { get; set; }

        /// <summary>
        /// Lista de Fotografias
        /// </summary>
        public ICollection<Fotografias> ListasDeFotografias { get; set; }

        /// <summary>
        /// Lista de Users associados aos Animes
        /// </summary>
        public ICollection<UsersAnimes> ListaDeUsers { get; set; }

        /// <summary>
        /// Lista de Links associados aos Animes
        /// </summary>
        public ICollection<AnimeLinks> ListaDeLinks { get; set; }
    }
}
