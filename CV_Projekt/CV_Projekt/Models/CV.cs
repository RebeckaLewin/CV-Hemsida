﻿using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Projekt.Models
{
	public class CV
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "CV måste tillhöra en användare.")]
		public string OwnerId { get; set; }
		public List<string> Skills { get; set; } = new List<string>();
		public int Views { get; set; }

		[ForeignKey(nameof(OwnerId))]
		public virtual User? Owner { get; set; }

		public CV() { Views = 0; }
	}
}
