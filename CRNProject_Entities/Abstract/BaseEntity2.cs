using CRNProject_CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRNProject_Entities.Abstract
{
    public class BaseEntity2 : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime LastDateTime { get; set; }
        [DefaultValue("true")]
        public bool IsActive { get; set; }
    }
}
