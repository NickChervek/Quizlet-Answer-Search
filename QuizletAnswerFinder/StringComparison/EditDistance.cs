using System;
namespace StringComparion
{
    //This was used in eariler stages of development but JaccardDistance proved alot better because it operates on individual tokens instead of edit distance
    public class EditDistance
    {
        public int Distance(String one,String two)
        {

            int lengthOne = one.Length;
            int lengthTwo = two.Length;

            if (lengthOne == 0)
                return lengthTwo;
            if (lengthTwo == 0)
                return lengthOne;


            int row = lengthOne + 1;
            int column = lengthTwo + 1;
            int[,] distance = new int[row, column];

            for (int c = 0; c < column; c++)
            {
                distance[0, c] = c;
            }

            for (int r = 0; r < row; r++)
            {
                distance[r, 0] = r;
            }


            //Fill in the rest of the matrix

            for(int loopRow = 1; loopRow <= lengthOne; loopRow++)
            {
                for(int loopColumn = 1; loopColumn <= lengthTwo; loopColumn++)
                {

                    int cost = one[loopRow - 1] == two[loopColumn - 1] ? 0 : 1;

                    distance[loopRow, loopColumn] = Math.Min(Math.Min(distance[loopRow - 1, loopColumn] + 1, distance[loopRow, loopColumn - 1] + 1), distance[loopRow - 1, loopColumn - 1] + cost);

                }
            }


            return distance[row-1, column-1];


        }


    }
}
