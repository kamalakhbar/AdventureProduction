﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Production.Entities.Models
{
    public partial class WorkOrder
    {
        public WorkOrder()
        {
            WorkOrderRoutings = new HashSet<WorkOrderRouting>();
        }

        public int WorkOrderID { get; set; }
        public int ProductID { get; set; }
        public int OrderQty { get; set; }
        public int StockedQty { get; set; }
        public short ScrappedQty { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime DueDate { get; set; }
        public short? ScrapReasonID { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }
        public virtual ScrapReason ScrapReason { get; set; }
        public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }
    }
}
