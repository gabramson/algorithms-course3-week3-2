using System;
using System.Collections.Generic;

namespace MWISMakerLib
{
    public class MWISMaker
    {
        private List<int> vertices = new List<int>();

        public List<int> MWIS { private set; get; }

        public void AddVertex(int weight)
        {
            vertices.Add(weight);
        }

        public void Execute()
        {
            var maxWeights = new List<T>;

            maxWeights[0] = vertices[0];
            maxWeights[1] = vertices[1];
            for (int i = 2; i < vertices.Count; i += 1)
            {
                if (maxWeights[i-2] + vertices[i]> maxWeights[i - 1])
                {
                    maxWeights[i] = maxWeights[i - 2] + vertices[i];
                }
                else
                {
                    maxWeights[i] = vertices[i - 1];
                }
            }
        }
    }
}
