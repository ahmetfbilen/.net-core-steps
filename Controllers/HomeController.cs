using Microsoft.AspNetCore.Mvc;//farklı namespacedeki bir controlleri bir öğeyi bir eleman kullanmak için using "namespace" kullancan


namespace dotnet_first.Controllers;//altına tanımladığımız controllerları bir grup içine alıyoruz namespace ile, tanımlıyoruz

public class HomeController : Controller
{
    public string About()
    {
        return "about";
    }
    public ActionResult Index()
    {
        return View();
    }

}
