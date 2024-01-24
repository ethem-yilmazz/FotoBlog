using System.ComponentModel.DataAnnotations;

namespace FotoBlog.Attributes
{
	public class GecerliResimAttribute : ValidationAttribute
	{
		public double MaksimumDosyaBoyutuMb { get; set; } = 1;

		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			var dosya = (IFormFile?)value;
			if (dosya == null) return ValidationResult.Success;

			if (!dosya.ContentType.StartsWith("image/"))
			{
				return new ValidationResult("Sadece resim dosyaları kabul edilir.");
			}
			else if (dosya.Length > MaksimumDosyaBoyutuMb * 1024 * 1024)
			{
				return new ValidationResult($"Dosya boyutu en fazla {MaksimumDosyaBoyutuMb}MB olmalıdır.");
			}


				return ValidationResult.Success;
		}
	}
}
