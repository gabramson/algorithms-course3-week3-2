using System;
using System.Collections.Generic;

namespace MWISMakerLib
{
    public class MWISMaker
    {
        private List<int> vertices = new List<int>();

        public List<int> MWIS { private set; get; } = new List<int>();

        public void AddVertex(int weight)
        {
            vertices.Add(weight);
        }

        public void Execute()
        {
            var maxWeights = new List<int>();
            int i = 0;

            maxWeights.Add(vertices[0]);
            maxWeights.Add(vertices[1]);
            for (i = 2; i < vertices.Count; i += 1)
            {
                if (maxWeights[i-2] + vertices[i]> maxWeights[i - 1])
                {
                    maxWeights.Add(maxWeights[i - 2] + vertices[i]);
                }
                else
                {
                    maxWeights.Add( maxWeights[i - 1]);
                }
            }
            i = vertices.Count-1;
            while (i >= 0)
            {
                if (maxWeights[i] != maxWeights[i - 1]){
                    MWIS.Add(i);
                    if (i > 2)
                    {
                        i -= 2;
                    }
                    else if (i == 2)
                    {
                        MWIS.Add(0);
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    i -= 1;
                }
            }
            MWIS.Reverse();
        }
    }
}
