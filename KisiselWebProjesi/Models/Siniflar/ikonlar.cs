using System.ComponentModel.DataAnnotations;

namespace KisiselWebProjesi.Models.Siniflar
{
    public class ikonlar
    {
        [Key]
        public int id { get; set; }
        public string ikon { get; set; }
        public string link { get; set; }
    }
}