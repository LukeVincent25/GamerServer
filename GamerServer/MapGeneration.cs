using System;
using System.Collections.Generic;
using System.Text;

namespace GamerServer
{
    using System.Collections;
    using System.Collections.Generic;

    public class MapGeneration
    {

        public int length;
        public int width;
        public float scale;

        private float[,] noiseMap;
        private float[,] nm;
        private float sampleX;
        private float sampleY;
        private float noise;
        private int mapSeed;
        private int offsetX;
        private int offsetY;

        private void GenerateMap()
        {
            // TODO: Figure out Random integer function
            //offsetX = Random.Range(0, 999999);
            //offsetY = Random.Range(0, 999999);
            nm = GenerateNoiseMap(length, width, scale, mapSeed);

            // TODO: Convert nm into 2D int array

            // TODO: Send to all clients
        }

        public float[,] GenerateNoiseMap(int mapX, int mapY, float scale, int seed)
        {

            noiseMap = new float[mapX, mapY];

            for (int xIndex = 0; xIndex < mapX; xIndex++)
            {
                for (int yIndex = 0; yIndex < mapY; yIndex++)
                {
                    sampleX = yIndex / scale + offsetX;
                    sampleY = xIndex / scale + offsetY;

                    // TODO: Find alternative perlin noise machine
                    noise = Mathf.PerlinNoise(sampleX, sampleY);
                    noiseMap[xIndex, yIndex] = noise;
                }
            }
            return noiseMap;
        }

    }

}
