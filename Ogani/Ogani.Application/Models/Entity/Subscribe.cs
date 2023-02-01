using System;
using System.ComponentModel.DataAnnotations;

namespace Ogani.Application.Models.Entity
{
	public class Subscribe : BaseEntity
    {
		[Required]
		public string Email { get; set; }

		public DateTime? ConfirmedDate { get; set; }
    }
}