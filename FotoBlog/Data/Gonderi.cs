﻿using System.ComponentModel.DataAnnotations;

namespace FotoBlog.Data
{
	public class Gonderi
	{
        public int Id { get; set; }
		[Display(Name = "Başlık")]
		[Required(ErrorMessage ="{0} girilmesi zorunludur")]
        public string Baslik { get; set; } = null!;


		[Display(Name = "Resim")]
		[Required(ErrorMessage ="{0} koyulması zorunludur.")]
		[MaxLength(255)]
		public string ResimYolu { get; set; } = null!;
	}
}
