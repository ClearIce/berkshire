using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berkshire.DAL.Models
{
    public class BerkshireReasoning
    {
        public int Id { get; init; }
        public string Reason { get; set; }

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
