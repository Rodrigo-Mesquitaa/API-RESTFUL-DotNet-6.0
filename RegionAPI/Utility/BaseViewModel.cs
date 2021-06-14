using System;

namespace RegionAPI.Utility
{
    public class BaseViewModel
    {
        public virtual Int64 Id { get; set; }

        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
