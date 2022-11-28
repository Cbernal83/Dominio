using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dominio
{
    // Los datos que voy a empezar a traer de SQL para moldear la CLASE BASE de los Objetos Pokemons
    public class Pokemons

    {
        public int id { get; set; } 
        
        [DisplayName("Número")]
        public int Numero { get; set; }

        public string Nombre { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        public string UrlImg { get; set; }

        public bool Activo { get; set; } 

        public Elemento Tipo { get; set; }

        public Elemento Debilidad { get; set; }



    }
}
