using Azure.Messaging.ServiceBus;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;
using Umbraco3.FormModels;

namespace Umbraco3.Controllers;

public class ContactSurfaceController : SurfaceController
{
	private readonly ILogger<ContactSurfaceController> _logger;
	private readonly HttpClient _httpClient;

	//Dependency injection och initialisering av controller
	//konstruktor som tar in beroenden genom DI som ILogger för loggning och en HttpClient för att
	//skicka HTTP-förfrågningar
	public ContactSurfaceController(
		IUmbracoContextAccessor umbracoContextAccessor,
		IUmbracoDatabaseFactory databaseFactory,
		ServiceContext services,
		AppCaches appCaches,
		IProfilingLogger profilingLogger,
		IPublishedUrlProvider publishedUrlProvider,
		ILogger<ContactSurfaceController> logger) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
	{
		_logger = logger; // Injektera loggern
		_httpClient = new HttpClient();

	}


	private async Task SendEmailToUser(ContactFormModel form)
	{
		var emailRequest = new
		{
			To = form.Email,
			Name = form.Name,
			Phone = form.Phone,
			OptionsField = form.optionsField
		};

		var content = new StringContent(JsonConvert.SerializeObject(emailRequest), Encoding.UTF8, "application/json");

		var response = await _httpClient.PostAsync("https://emailprovider-umbraco-onatrix.azurewebsites.net", content);

		if (!response.IsSuccessStatusCode)
		{
			_logger.LogError($"Failed to send email: {response.StatusCode}");
		}
	}





	/// <summary>
	/// 
	/// </summary>
	/// <param name="form"></param>
	/// <returns></returns>
	[HttpPost]
	public async Task<IActionResult> HandleContactFormSubmit(ContactFormModel form)
	{


		//Validerar om data i formuläret är korrekt
		if (!ModelState.IsValid)
		{
			//Kontroll om fält är tomma och visa felmeddelanden,
			//sätter temp/view varables och mappar in värden
			ViewData["name"] = form.Name;
			ViewData["email"] = form.Email;
			ViewData["phone"] = form.Phone;
			ViewData["optionsField"] = form.optionsField;


			ViewData["error_name"] = string.IsNullOrEmpty(form.Name);
			ViewData["error_email"] = string.IsNullOrEmpty(form.Email);
			ViewData["error_phone"] = string.IsNullOrEmpty(form.Phone);
			ViewData["error_optionsField"] = string.IsNullOrEmpty(form.optionsField);

			//Markera att formuläret har skickats in
			ViewData["form_submitted"] = true;

			//Returnerar användaren till den aktuella sidan om fel uppstod
			return CurrentUmbracoPage();
		}

		//skicka formulärdata till azure service bus om det är giltigt
		try
		{
			//skapa en service Bus-client (för att skicka formulärdata som ett JSON-med. till min azure service bus kö)
			string connectionString = "Endpoint=sb://servicebus-umbraco-onatrix.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=fRQGrTZch4h3aYXVGc+pOmgWq4jx5kRKs+ASbMJvNxM=";
			string queueName = "email_request";
			var client = new ServiceBusClient(connectionString);
			ServiceBusSender sender = client.CreateSender(queueName);

			//serialisera formulärdata till ett JSON-meddelande
			string messageBody = JsonConvert.SerializeObject(form);
			ServiceBusMessage message = new ServiceBusMessage(messageBody);

			_logger.LogInformation($"Sending message: {messageBody}");

			//skicka meddelandet till Azure Service Bus-queue
			await sender.SendMessageAsync(message);


			//om inskickning lyckas, sätt ett success-meddelande
			TempData["success"] = "Contactform was submitted successfully. We've sent you an email.";

			// Skicka bekräftelsemeddelande/epost till användaren (anropar metoden ovan)
			await SendEmailToUser(form);

		}
		catch (Exception ex)
		{
			//hantera ev fel
			TempData["error"] = $"An error occurred: {ex.Message}";
		}



		//anv omdirigeras till aktuell sida
		return RedirectToCurrentUmbracoPage();
	}








	[HttpPost]
	public IActionResult HandleQuestionFormSubmit(QuestionFormModel form)
	{


		if (!ModelState.IsValid)
		{
			ViewData["name"] = form.Name;
			ViewData["email"] = form.Email;
			ViewData["message"] = form.Message;

			ViewData["error_name"] = string.IsNullOrEmpty(form.Name);
			ViewData["error_email"] = string.IsNullOrEmpty(form.Email);
			ViewData["error_message"] = string.IsNullOrEmpty(form.Message);

			ViewData["form_submitted"] = true;

			return CurrentUmbracoPage();
		}

		TempData["success"] = "Your question was submitted successfully.";
		return RedirectToCurrentUmbracoPage();
	}





	[HttpPost]
	public IActionResult HandleHomePageFormSubmit(HomepageFormModel form)
	{
		if (!ModelState.IsValid)
		{
			ViewData["name"] = form.Name;
			ViewData["phone"] = form.Phone;
			ViewData["email"] = form.Email;



			if (string.IsNullOrEmpty(form.Name))
			{
				ViewData["error_name"] = ModelState["name"]?.Errors.FirstOrDefault()?.ErrorMessage ?? "You have to enter your name!";
			}
			if (string.IsNullOrEmpty(form.Phone))
			{
				ViewData["error_phone"] = ModelState["phone"]?.Errors.FirstOrDefault()?.ErrorMessage ?? "You have to enter your number!";
			}
			if (string.IsNullOrEmpty(form.Email))
			{
				ViewData["error_email"] = ModelState["email"]?.Errors.FirstOrDefault()?.ErrorMessage ?? "You have to enter your Email!";
			}


			ViewData["form_submitted"] = true;

			return CurrentUmbracoPage();

		}

		TempData["success"] = "ContactForm was submitted successfully.";
		return RedirectToCurrentUmbracoPage();
	}
}
