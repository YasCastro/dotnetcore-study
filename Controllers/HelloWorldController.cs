using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MongoDB.Driver;

namespace MyCoffeeShop.Controllers
{
  public class HelloWorldController : Controller
  {

    //GET /HelloWorld/
    public IActionResult Index()
    {
      return  View();  
    }

    //GET /HelloWorld/Welcome
    public IActionResult Welcome(string name, int numTimes = 0)
    {
      MongoClient dbClient = new MongoClient("mongodb+srv://omnistack:omnistack@omnistack-b87wf.mongodb.net/test?retryWrites=true&w=majority");
      
      var dbList = dbClient.ListDatabases().ToList();

      foreach (var db in dbList){
        ViewData["Message"] = db;
        numTimes++;
      }
      ViewData["NumTimes"] = numTimes;
      
     
      return View();
    }

  }

}