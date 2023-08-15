using Humanizer;
using MessagePack;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Razor.Hosting;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace TP2.Models
{
    public class Enfant
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("NameParent")]
        [ForeignKey("Parent")]
        public int IdParent { get; set; }

        [DisplayName("NameMovie")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} doit être rempli.")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Le champ {0} demande un minimum de {1} et maximum de {2}.")]
        public string Nom { get; set; }

        [DisplayName("Image")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} doit être rempli.")]
        public string ImageURL { get; set; }


        [DisplayName("TypeMovie")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} doit être rempli.")]
        public string GenreDeFilm { get; set; }


        [DisplayName("Date")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} doit être rempli.")]
        public int Date { get; set; }

        [DisplayName("View")] 
        public int Vus { get; set; }

        [DisplayName("Description")]
        [StringLength(1000)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} doit être rempli.")]
        public string Description { get; set; }



        [ValidateNever]
        public virtual Parent? Parent { get; set; }
        //public List<ParentEnfant> ParentEnfants { get; set; }
        //public Enfant()
        //{
        //    ParentEnfants = new List<ParentEnfant>();
        //}

    }
}
