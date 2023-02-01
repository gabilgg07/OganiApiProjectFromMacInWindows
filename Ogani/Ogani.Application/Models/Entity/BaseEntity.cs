using System;
using Ogani.Application.Models.Entity.Membership;

namespace Ogani.Application.Models.Entity
{
	public class BaseEntity
	{
		public int Id { get; set; }

        public DateTime? CreatedDate { get; set; } = DateTime.Now;

        public int? CreatedByUserId { get; set; }

        public virtual OganiUser CreatedByUser { get; set; }

        public DateTime? DeletedDate { get; set; }

        public int? DeletedByUserId { get; set; }

        public virtual OganiUser DeletedByUser { get; set; }
    }
}

