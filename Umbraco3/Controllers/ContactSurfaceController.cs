using Microsoft.AspNetCore.Mvc;
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
	public ContactSurfaceController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
	{
	}



	[HttpPost]
	public IActionResult HandleContactFormSubmit(ContactFormModel form)
	{


		//om modelstate inte är giltig, gör detta:
		if (!ModelState.IsValid)
		{
			//är modellen ogiltig? sätter temp varables och mappar in värden
			ViewData["name"] = form.Name;
			ViewData["email"] = form.Email;
			ViewData["phone"] = form.Phone;


			ViewData["error_name"] = string.IsNullOrEmpty(form.Name);
			ViewData["error_email"] = string.IsNullOrEmpty(form.Email);
			ViewData["error_phone"] = string.IsNullOrEmpty(form.Phone);


			return CurrentUmbracoPage();
		}

		//annars...
		//om lyckas, returnera till nuvarande sida, uppdaterar sidan. Redirect...
		TempData["success"] = "Contactform was submitted successfully.";
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

		TempData["success"] = "QuestionForm was submitted successfully.";
		return RedirectToCurrentUmbracoPage();
	}
}
