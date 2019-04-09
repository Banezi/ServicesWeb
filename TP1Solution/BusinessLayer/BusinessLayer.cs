using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;

namespace BusinessLayer
{
    public class UnrealTournament
    {
        private StubDataAccessLayer.DalManager DM;

        //private List<EntitiesLayer.Character> m_charList;
        //private List<EntitiesLayer.House> m_houseList;
        //private List<EntitiesLayer.Territory> m_terrList;

        public UnrealTournament()
        {
            DM = new StubDataAccessLayer.DalManager();

            //CharList = DM.getAllCharacters();
            //HouseList = DM.getHouses();
            //TerrList = DM.getTerritory();
        }

        public List<Character> getCharList()
        {
            return DM.getAllCharacters();
        }

        public IEnumerable<Character> getStrongChar()
        {
            List<Character> temp = DM.getAllCharacters();
            IEnumerable<Character> res = from x in temp where (x.Bravoury > 3 && x.Pv > 50) select x;

            return res;
        }

        public List<House> getHouseList()
        {
            return DM.getHouses();
        }
        public IEnumerable<House> getBigHouseList()
        {
            return DM.getBigHouses();
        }

        public List<Territory> getTerrList()
        {
            return DM.getTerritory();
        }
    }
}
