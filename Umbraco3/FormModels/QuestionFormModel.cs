using System.ComponentModel.DataAnnotations;

namespace Umbraco3.FormModels;

public class QuestionFormModel
{
    [Required(ErrorMessage = "You must enter your name!")]
    public string Name { get; set; } = null!;

    [Required(ErrorMessage = "You must enter your email!")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Hey! You forgot to write your question!")]
    public string Message { get; set; } = null!;
}
