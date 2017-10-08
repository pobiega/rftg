using RollForTheGalaxy.Game.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollForTheGalaxy.Game.Model
{
    public class DiceBag
    {
        private Dictionary<Color, int> dicePool = new Dictionary<Color, int>
        {
            { Color.White,  25 },
            { Color.Red,    22 },
            { Color.Purple, 9  },
            { Color.Cyan,   20 },
            { Color.Brown,  14 },
            { Color.Green,  12 },
            { Color.Yellow, 9  }
        };

        public Dice Get(Color color)
        {
            var currentCount = dicePool[color];

            if (currentCount == 0)
                return null;

            dicePool[color] = currentCount - 1;
            return new Dice(color, GetDistribution(color));
        }

        public IEnumerable<Dice> Get(Color color, int count)
        {
            for (int i = 0; i < count; i++)
                yield return Get(color);
        }

        private static Face[] GetDistribution(Color color)
        {
            return FaceDistribution[color]
                   .SelectMany(faceCount =>
                   {
                       var faces = new List<Face>();
                       for (int i = 0; i < faceCount.Count; i++)
                       {
                           faces.Add(faceCount.Face);
                       }
                       return faces;
                   })
                   .ToArray();
        }

        private static Dictionary<Color, FaceCount[]> FaceDistribution = new Dictionary<Color, FaceCount[]>
        {
            {
                Color.White,
                new[]
                {
                    new FaceCount(Face.Explore, 2),
                    new FaceCount(Face.Develop, 1),
                    new FaceCount(Face.Settle, 1),
                    new FaceCount(Face.Produce, 1),
                    new FaceCount(Face.Ship, 1),
                }
            },
            {
                Color.Red,
                new[]
                {
                    new FaceCount(Face.Explore, 1),
                    new FaceCount(Face.Develop, 2),
                    new FaceCount(Face.Settle, 2),
                    new FaceCount(Face.Wild, 1),
                }
            },
            {
                Color.Purple,
                new[]
                {
                    new FaceCount(Face.Explore, 1),
                    new FaceCount(Face.Develop, 1),
                    new FaceCount(Face.Produce, 3),
                    new FaceCount(Face.Wild, 1),
                }
            },
            {
                Color.Cyan,
                new[]
                {
                    new FaceCount(Face.Explore, 1),
                    new FaceCount(Face.Produce, 2),
                    new FaceCount(Face.Ship, 2),
                    new FaceCount(Face.Wild, 1),
                }
            },
            {
                Color.Brown,
                new[]
                {
                    new FaceCount(Face.Explore, 1),
                    new FaceCount(Face.Develop, 2),
                    new FaceCount(Face.Produce, 1),
                    new FaceCount(Face.Ship, 1),
                    new FaceCount(Face.Wild, 1),
                }
            },
            {
                Color.Green,
                new[]
                {
                    new FaceCount(Face.Explore, 1),
                    new FaceCount(Face.Settle, 2),
                    new FaceCount(Face.Produce, 1),
                    new FaceCount(Face.Wild, 2),
                }
            },
            {
                Color.Yellow,
                new[]
                {
                    new FaceCount(Face.Develop, 1),
                    new FaceCount(Face.Settle, 1),
                    new FaceCount(Face.Produce, 1),
                    new FaceCount(Face.Wild, 3),
                }
            }
        };

        struct FaceCount
        {
            public Face Face;
            public int Count;

            public FaceCount(Face face, int count)
            {
                this.Face = face;
                this.Count = count;
            }
        }
    }
}
