using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace formsGeneratorWS.Data.Models
{
    public class FormDefinition
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public string FormCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int VersionNumber { get; set; }
    }
}