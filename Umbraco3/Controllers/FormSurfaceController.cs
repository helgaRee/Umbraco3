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

public class FormSurfaceController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : SurfaceController(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
{


    [HttpPost]
    public IActionResult QuestionForm(QuestionFormModel form)
    {
        //bygg upp och kontrollera modellen
        if (!ModelState.IsValid)
            return CurrentUmbracoPage();
        //valideringen funkar

        var contentService = Services.ContentService;
        //hämta upp nod från umbraco
        var questionNodeGuid = new Guid("b021b6ea-0693-4b01-af67-160dfab3d7b1");
        var nodeId = contentService!.GetById(questionNodeGuid);

        //bygg upp item
        var questionItem = contentService.Create(Guid.NewGuid().ToString(), nodeId, "questionItem");
        //mappa
        questionItem.SetValue("questionAuthor", form.Name);
        questionItem.SetValue("questionEmail", form.Email);
        questionItem.SetValue("questionText", form.Message);

        //spara och publicera
        contentService.Save(questionItem);
        contentService.Publish(questionItem, new string[] { });


        return RedirectToCurrentUmbracoPage();
    }
}
