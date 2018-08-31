﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pal.Entities.Models
{
	public partial class AspNetUserClaim
	{
		public int Id { get; set; }

		[Required]
		[StringLength(128)]
		public string UserId { get; set; }

		public string ClaimType { get; set; }

		public string ClaimValue { get; set; }

		public virtual AspNetUser AspNetUser { get; set; }
	}
}
