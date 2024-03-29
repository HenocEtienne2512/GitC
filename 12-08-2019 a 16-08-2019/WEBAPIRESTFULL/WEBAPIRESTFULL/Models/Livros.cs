namespace WEBAPIRESTFULL.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Livros : UserControls
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Livros()
        {
            Locacao = new HashSet<Locacao>();
            Autores = new HashSet<Autores>();
        }

        public int Id { get; set; }

        public int Registro { get; set; }

        [Required]
        [StringLength(1200)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(15)]
        public string Isbn { get; set; }

        public int Genero { get; set; }

        public int Editora { get; set; }

        public string Sinopse { get; set; }

        [StringLength(1000)]
        public string Observacoes { get; set; }

        //public bool Ativo { get; set; }

        //public int UsuInc { get; set; }

        //public int UsuAlt { get; set; }

        //public DateTime DatInc { get; set; }

        //public DateTime DatAlt { get; set; }

        [JsonIgnore]
        public virtual Editoras Editoras { get; set; }

        [JsonIgnore]
        public virtual Generos Generos { get; set; }
        [JsonIgnore]
        public virtual Usuarios Usuarios { get; set; }
        [JsonIgnore]
        public virtual Usuarios Usuarios1 { get; set; }
        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Locacao> Locacao { get; set; }
        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Autores> Autores { get; set; }
    }
}
