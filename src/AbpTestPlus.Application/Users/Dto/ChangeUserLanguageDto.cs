using System.ComponentModel.DataAnnotations;

namespace AbpTestPlus.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}