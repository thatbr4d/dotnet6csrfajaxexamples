using Microsoft.AspNetCore.Mvc;

namespace examples.Controllers;

public class ExamplesController : Controller
{

    [HttpPost]
    [IgnoreAntiforgeryToken]
    public IActionResult ChangeEmail(string newEmail)
    {
        // Example of a vulnerable method

        // pretend email change code here
        return Json(true);
    }

    #region "Basic Page Action Results"
    public IActionResult NoToken()
    {
        return View();
    }
    public IActionResult InjectToken()
    {
        return View();
    }
    public IActionResult FormToken()
    {
        return View();
    }
    public IActionResult TokenHelper()
    {
        return View();
    }
    public IActionResult FormSerialize()
    {
        return View();
    }
    public IActionResult ComplexData()
    {
        return View();
    }
    #endregion


    // No Token Methods
    public JsonResult NoTokenGet()
    {
        return Json("No Token GET Request Works");
    }

    [HttpPost]
    public JsonResult NoTokenPost(string name)
    {
        return Json("No Token POST Request doesn't work");
    }


    // Inject Token Methods
    [HttpPost]
    public JsonResult InjectTokenPostHeader(string name)
    {
        return Json("Injected Token Via Header Works");
    }

    [HttpPost]
    public JsonResult InjectTokenPostData(string name)
    {
        return Json("Injected Token Via Data Works");
    }


    // Helper Token Methods
    [HttpPost]
    public JsonResult HelperTokenPostHeader(string name)
    {
        return Json("Helper Token Via Header Works");
    }

    [HttpPost]
    public JsonResult HelperTokenPostData(string name)
    {
        return Json("Helper Token Via Data Works");
    }

    // Form Token Methods
    [HttpPost]
    public JsonResult FormTokenPostHeader(string name)
    {
        return Json("Form Token Via Header Works");
    }

    [HttpPost]
    public JsonResult FormTokenPostData(string name)
    {
        return Json("Form Token Via Data Works");
    }

    // Form Serialize Methods
    [HttpPost]
    public JsonResult FormSerializePost(string field1, string field2, string field3)
    {
        return Json($"Form Serialize POST Works with values {field1}, {field2}, and {field3}");
    }

    // Form Complex Data Methods
    [HttpPost]
    public JsonResult ComplexDataPost(ComplexObject complexdata)
    {
        return Json(complexdata);
    }
}