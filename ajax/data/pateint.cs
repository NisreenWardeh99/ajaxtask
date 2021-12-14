using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ajax.data
{
    [Table("Patients")]
    public class pateint
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public DateTime bd { set; get; }
        public string Phone { set; get; }
        [ForeignKey("count")]
        public int country_id { set; get; }
        public Country count { set; get; }
    }
}
