using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ProcessDefectRelation
    {
        public string ScrapProcessCode { get; set; } = null!;
        public string ScrapDefectCode { get; set; } = null!;
        public string UnScrapProcessCode { get; set; } = null!;
        public string UnScrapDefectCode { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
