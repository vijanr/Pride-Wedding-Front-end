using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrideWeddingPlanners.Models
{
    public class Packages
    {
		[Key]
		public int ID { get; set; }

		[DataType(DataType.Currency)]
		public string price { get; set; }
		public string detail { get; set; }

		[DataType(DataType.Date)]
		public string start_date { get; set; }

		[DataType(DataType.Url)]
		public string imageurl { get; set; }

		[DataType(DataType.Date)]
		public string end_date { get; set; }
		public int package_no { get; set; }
	}
}
