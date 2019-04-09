using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public interface IDal
    {
        EntitiesLayer.Character GetCharacters(Character c);
        List<EntitiesLayer.Character> GetCharacters();
        void AddCharacter(EntitiesLayer.Character c);
        void UpdateCharacter(EntitiesLayer.Character c);

        //List<EntitiesLayer.House> ListeMaisonsExistantes();
        //IEnumerable<EntitiesLayer.House> ListeMaisonsExistantesPlus200Unites();
        //List<EntitiesLayer.Territory> ListeTerrainsExistants();
        //List<string> ListePersonnagesExistants();
        //List<EntitiesLayer.Character> ListeCaracteristiquesPersonnagesExistants();
    }
}