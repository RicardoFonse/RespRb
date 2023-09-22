using Microsoft.AspNetCore.Mvc;

namespace SenaiAlimentos.Controllers;

public class AuthenticationController:Controller{
     
    //Controller é o papai
    //Técnica de herança

    public IActionResult Index(){
        return View();
    } 

}




