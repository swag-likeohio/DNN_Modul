using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetNuke.ComponentModel.DataAnnotations;
using System.Web.Caching;
using System.Web.UI.WebControls;

namespace HelloOhio.HelloOhio.Models
{
    public class Lemezek
    {
        [TableName("Lemezek")]
        [PrimaryKey(nameof(LemezID), AutoIncrement = true)]
        [Cacheable("Lemezek", CacheItemPriority.Default, 20)]
        [Scope("ModuleId")]
        public class Lemezek
        {
            public int LemezID { get; set; }

            public string Cim { get; set; }

            public string Eloado { get; set; }

            public int Kiadaseve { get; set; }

            public string Kiadoneve { get; set; }

            public string Allapot { get; set; }

        }
    }
}