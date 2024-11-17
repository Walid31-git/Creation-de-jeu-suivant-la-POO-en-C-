using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpMiniJeux
{
    internal class De
    {
        private List<int> faces = new List<int> { 1, 2, 3, 4, 5, 6 };
        public int ResultatDe { get; private set; }

        // Propriété en lecture seule
        public List<int> Faces { get => faces; }

        public void LancerDe()
        {
            Random random = new Random();
            int index = random.Next(faces.Count);
            ResultatDe = faces[index];
        }
    }


}
