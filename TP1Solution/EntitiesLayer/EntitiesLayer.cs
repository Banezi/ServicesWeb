using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class EntityObj
    {
        protected int m_id;
        public int id
        {
            get
            {
                return m_id;
            }

            set
            {
                m_id = value;
            }
        }

        public EntityObj(int id)
        {
            m_id = id;
        }
    }

    public class Character : EntityObj
    {
        private int m_bravoury;
        private int m_crazyness;
        private int m_pv;
        private String m_FirstName;
        private String m_LastName;

        private int m_type;
        private List<Character> m_relatives;

        public int Bravoury
        {
            get
            {
                return m_bravoury;
            }

            set
            {
                m_bravoury = value;
            }
        }

        public int Crazyness
        {
            get
            {
                return m_crazyness;
            }

            set
            {
                m_crazyness = value;
            }
        }

        public int Pv
        {
            get
            {
                return m_pv;
            }

            set
            {
                m_pv = value;
            }
        }

        public string FirstName
        {
            get
            {
                return m_FirstName;
            }

            set
            {
                m_FirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return m_LastName;
            }

            set
            {
                m_LastName = value;
            }
        }

        public int Type
        {
            get
            {
                return m_type;
            }

            set
            {
                m_type = value;
            }
        }

        public List<Character> Relatives
        {
            get
            {
                return m_relatives;
            }

            set
            {
                m_relatives = value;
            }
        }


        public enum Relationships
        {
            FRIENDSHIP,
            LOVE,
            HATRED,
            RIVALRY
        }

        public enum CharacterType
        {
            WARRIOR = 0,
            WITCH,
            TACTICIAN,
            LEADER,
            LOSER
        }

        public void AddRelatives(Character c)
        {
            Relatives.Add(c);
        }

        public String ToString()
        {
            return (m_FirstName + " " + m_LastName.ToUpper());
        }

        public Character(int id = -1, String fn = "", String ln = "", int brvr = 0, int crzn = 0) : base(id)
        {
            m_FirstName = fn;
            m_LastName = ln;
            m_bravoury = brvr;
            m_crazyness = crzn;
            m_pv = 100;
        }
    }

    public class House : EntityObj
    {
        private String m_name;
        private int m_nbOfUnitiedChar;
        private List<Character> m_housers;

        public string Name
        {
            get
            {
                return m_name;
            }

            set
            {
                m_name = value;
            }
        }

        public int NbOfUnitiedChar
        {
            get
            {
                return m_nbOfUnitiedChar;
            }

            set
            {
                m_nbOfUnitiedChar = value;
            }
        }

        public List<Character> Housers
        {
            get
            {
                return m_housers;
            }

            set
            {
                m_housers = value;
            }
        }

        public void AddHousers(Character c)
        {
            Housers.Add(c);
        }

        public House(int id, String name, int nbUnit) : base(id)
        {
            Name = name;
            NbOfUnitiedChar = nbUnit;
        }

        public String ToString()
        {
            return (Name + " " + NbOfUnitiedChar.ToString() );
        }
    }

    public class Fight : EntityObj
    {
        public Fight(int id) : base(id)
        { }
    }

    public class Territory : EntityObj
    {
        private House m_owner;

        public House Owner
        {
            get
            {
                return m_owner;
            }

            set
            {
                m_owner = value;
            }
        }

        public Territory(int id, House h) : base(id)
        {
            m_owner = h;
        }
    }

    public class War : EntityObj
    {
        public War(int id) : base(id)
        { }
    }
}
