namespace SenaiAlimentos.Models;

public class Nivel{

    public int Id { get; set; }

     public string? Nome { get; set; }

     public Nivel(string? nome){
        Nome = nome;
     }
     public Nivel(){
        
     }
}