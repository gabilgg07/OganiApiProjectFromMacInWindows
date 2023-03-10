using System;
using System.ComponentModel.DataAnnotations;
using Ogani.Application.DataAnnotation;

namespace Ogani.Application.Models.Entity
{
	public class ContactPost : BaseEntity
    {
		[Required]
		[MaxLength(100)]
		public string FullName { get; set; }

        [RequiredEmail]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }

        public string Answer { get; set; }

		public DateTime? AnswerDate { get; set; }
    }
}

