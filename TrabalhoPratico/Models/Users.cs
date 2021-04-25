using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoPratico.Models {
    public class Users {

        /// <summary>
        /// Possui o Identificador do User
        /// </summary>
        [Key]
        public int IdUsers { get; set; }

        /// <summary>
        /// Possui o Email do User
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Possui a Password do User
        /// </summary>
        public string Password { get; set; }
    }
}
