using System.ComponentModel.DataAnnotations;

namespace HomeMvc.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}