using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    interface IDAL
    {
        EntitiesLayer.Character GetCharacters(Character c);
        List<EntitiesLayer.Character> GetCharacters();
        void AddCharacter(EntitiesLayer.Character c);
        void UpdateCharacter(EntitiesLayer.Character c);
        
    }
}
