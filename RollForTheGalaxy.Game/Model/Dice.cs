using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollForTheGalaxy.Game.Model
{
    public enum Face
    {
        Explore,
        Develop,
        Settle,
        Produce,
        Ship,
        Wild
    }

    public enum Color
    {
        White,
        Red,
        Purple,
        Cyan,
        Brown,
        Green,
        Yellow
    }

    public class Dice
    {
        public Color Color { get; }
        public Face[] Faces { get; }
        public Face CurrentFace { get; private set; }

        public Dice(Color color, IEnumerable<Face> faces)
        {
            Color = color;
            Faces = faces.ToArray();
        }

        public bool Assign(Face face)
        {
            if(Faces.Contains(face))
            {
                CurrentFace = face;
                return true;               
            }
            return false;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Dice;

            if (other == null)
                return false;

            return Faces.SequenceEqual(other.Faces) &&
                   Color == other.Color &&
                   CurrentFace == other.CurrentFace;
        }

        public override int GetHashCode()
        {
            return Faces.GetHashCode() ^ Color.GetHashCode() ^ CurrentFace.GetHashCode();
        }
    }
}
