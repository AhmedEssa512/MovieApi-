using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Dtos
{
    public class GenreDto
    {
        [MaxLength(50)]
        public string Name { get; set; }
    }
}