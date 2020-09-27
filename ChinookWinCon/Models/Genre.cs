using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChinookWinCon.Models
{
    
    public class Genre
    {
        [Column(TypeName = "Int")]
        //[DisplayColumn]

        public int GenreId { get; set; }

        /// <summary>
        /// Name 
        /// </summary>
        [Column(TypeName = "varchar(160)")]
        public string Name { get; set; }
    }
}
