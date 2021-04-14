using CRNProject_CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRNProject_Entities.Abstract
{
    public class BaseEntity2 : IEntity
    {
        public int Id { get; set; }
        public DateTime LastDateTime { get; set; }
        public bool IsActive { get; set; }
    }
}
