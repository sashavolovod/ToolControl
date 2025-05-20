using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolControl
{
    public class ToolEntity
    {
        public int orderNumber { get; set; }
        public string  toolTitle { get; set; }
        public string employeeName { get; set; }
        public string workerName { get; set; }
        public int status { get; set; }
        public int weight { get; set; }
        public string detailNumber { get; set; }
        public DateTime date { get; set; }
    }
}
