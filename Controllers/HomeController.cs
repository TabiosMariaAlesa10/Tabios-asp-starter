using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Tabios Alesa", StudentId = "21-2097", StudentAge = "20" },
            new StudentInfoModel { Name = "Pecoro Kathleen", StudentId = "21-2143", StudentAge = "21" },
            new StudentInfoModel { Name = "Lagleva Ashley", StudentId = "21-2248", StudentAge = "22" }
        };

        return View(studentInfoArray);
    }
}
