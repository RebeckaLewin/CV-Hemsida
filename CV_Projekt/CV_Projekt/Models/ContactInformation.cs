﻿using System.ComponentModel.DataAnnotations;

namespace CV_Projekt.Models
{
	public class ContactInformation
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Eposten måste anges.")]
		[RegularExpression("^[a-z0-9._%+-]+@[a-z0-9.-]+.[a-z]{2,}$", ErrorMessage = "Eposten är inte giltig.")]
		public string Email { get; set; }
		[Range(7, 20, ErrorMessage = "Telefonnummer måste vara mellan 7 till 20 siffror.")]
		[RegularExpression("^[0-9_-]+$", ErrorMessage = "Telefonnumret får endast innehålla siffror samt bindestreck eller mellanslag.")]
		public string Phone {  get; set; }
		[RegularExpression("^[A-Za-zÅÄÖåäö_-]+$", ErrorMessage = "Adressen får inte innehålla några specialtecken.")]
		public string Address { get; set; }
	}
}
