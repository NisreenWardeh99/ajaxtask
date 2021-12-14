using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ajax.data
{
    [Table("Countries")]
    public class Country
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public List<pateint> pat { set; get; }

    }
}
