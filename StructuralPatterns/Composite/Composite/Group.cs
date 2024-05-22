using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    /// <summary>
    /// The 'Composite' class
    /// </summary>
    public sealed class Group : IParty
    {
        public Group()
        {
            Members = new List<IParty>();
        }

        public string Name { get; set; }

        public int Gold
        {
            get
            {
                return Members.Sum(member => member.Gold);
            }
            set
            {
                var totalSplit = value / Members.Count;
                var leftOver = value % Members.Count;
                foreach (var member in Members)
                {
                    member.Gold += totalSplit + leftOver;
                    leftOver = 0;
                }
            }
        }

        public List<IParty> Members { get; set; }

        public void Stats()
        {
            foreach (var member in Members)
            {
                member.Stats();
            }
        }
    }
}
