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
    public class BaseEntity1 : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime LastDateTime { get; set; }
        [DefaultValue("true")]
        public bool IsActive { get; set; }
        public string SeoTitle { get; set; }
        public string SeoKeywords { get; set; }
        public string SeoDesc { get; set; }
        public string SeoAuthor { get; set; }
        public string SeoCopyr { get; set; }
        public string SeoDesign { get; set; }
        public string SeoReply { get; set; }
        public string SeoSubject { get; set; }
        public string SeoTwitterTitle { get; set; }
        public string SeoTwitterDesc { get; set; }
        public string SeoTwitterUrl { get; set; }
        public string SeoFacebookTitle { get; set; }
        public string SeoFacebookDesc { get; set; }
        public string SeoFacebookUrl { get; set; }
    }
}
