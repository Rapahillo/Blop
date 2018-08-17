using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Blop.Models
{
    public class StorageUser
    {
        [DisplayName("Etunimi")]
        public string FirstName { get; set; }
        [DisplayName("Sukunimi")]
        public string LastName { get; set; }
        [DisplayName("Sukupuoli")]
        public string Gender { get; set; }
        [DisplayName("Ikä")]
        public int Age { get; set; }
        public string PictureUrl { get; set; }
        public string ThumbUrl { get; set; }
    }
}
