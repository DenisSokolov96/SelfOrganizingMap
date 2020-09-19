﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1SOM
{
    class Recognition
    {      
        private double[,,] VectorW;
        public int znI = -1;
        public int znJ = -1;


        public Recognition(int sizeX, int sizeY, double[,,] Matr, string vector)
        {
            VectorW = Matr;

            double dist = Double.MaxValue;
            for (int j = 0; j < sizeY; j++)
                for (int i = 0; i < sizeX; i++)
                {
                    double a = step1(ref j, ref i, ref vector);
                    if (a < dist)
                    {
                        dist = a;
                        znI = i;
                        znJ = j;
                    }
                }        

        }

        //поиск близких значений
        private double step1(ref int y, ref int x, ref string vector)
        {
            List<int> list = masToList(ref vector);

            double distance = 0;
            for (int i = 0; i < list.Count; i++)
                distance += (list[i] - VectorW[y, x, i]) * (list[i] - VectorW[y, x, i]);

            return Math.Sqrt(distance);
        }

        //переобразовать входную строку в список целых значений
        private List<int> masToList(ref string vector)
        {
            List<int> list = new List<int>();
            list.Add(0);
            int ki = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (!vector[i].Equals(' '))
                    list[ki] = list[ki] * 10 + Convert.ToInt32(vector[i].ToString());
                else
                {
                    ki++;
                    list.Add(0);
                }
            }

            return list;
        }
    }
}
