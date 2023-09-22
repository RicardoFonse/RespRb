using SenaiAlimentos.Models;

namespace SenaiAlimentos.ViewModels;
public class ListaNivelViewModel{

    public ICollection<Nivel> Niveis {get;set;} = new List<Nivel>();

}