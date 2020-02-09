using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore_CRUD_Template.Core
{
    [Table("Game")]
    public class Game : BaseEntity
    {
        public string name { get; set; }
    }
}
