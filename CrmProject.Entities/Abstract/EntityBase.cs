using System.ComponentModel.DataAnnotations;

namespace CrmProject.Entities.Abstract

{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}