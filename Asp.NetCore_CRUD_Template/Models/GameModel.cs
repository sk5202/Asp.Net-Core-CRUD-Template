using Asp.NetCore_CRUD_Template.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace Asp.NetCore_CRUD_Template.Models
{
    public class GameModel : BaseEntity
    {
        [Required]
        public string Name { get; set; }    
    }
}
