using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Lab3
{
    public class Albumy
    {
        [Column("IdAlbumu")]
        public int ID { get; set; }
        public string NazwaAlbumu { get; set; }
        public int IloscUtworow { get; set; }
    }
}
