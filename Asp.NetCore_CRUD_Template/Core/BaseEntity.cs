using System.ComponentModel.DataAnnotations;

namespace Asp.NetCore_CRUD_Template.Core
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
