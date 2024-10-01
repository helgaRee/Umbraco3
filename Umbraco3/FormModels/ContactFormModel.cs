namespace Umbraco3.FormModels;

public class ContactFormModel
{
	public string Name { get; set; } = null!;
	public string Email { get; set; } = null!;
	public string Phone { get; set; } = null!;

	public string optionsField { get; set; } = null!;

}
