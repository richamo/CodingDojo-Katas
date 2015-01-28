using Mazes.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetclicMazeBuilder
{
    public class BetclicMazeBuilder : IMazeBuilder
    {
        public int Height
        {
            get { return 7; }
        }

        public int Width
        {
            get { return 20; }
        }

        public void Build(IBuildableMaze maze)
        {
            // first line
            maze.AddHorizontalWall(0, 0);
            maze.AddHorizontalWall(1, 0);
            maze.AddHorizontalWall(2, 0);
            maze.AddHorizontalWall(3, 0);
            maze.AddHorizontalWall(4, 0);
            maze.AddHorizontalWall(5, 0);
            maze.AddHorizontalWall(6, 0);
            maze.AddHorizontalWall(7, 0);
            maze.AddHorizontalWall(8, 0);
            maze.AddHorizontalWall(9, 0);
            maze.AddHorizontalWall(10, 0);
            maze.AddHorizontalWall(11, 0);
            maze.AddHorizontalWall(12, 0);
            maze.AddHorizontalWall(13, 0);
            maze.AddHorizontalWall(14, 0);
            maze.AddHorizontalWall(15, 0);
            maze.AddHorizontalWall(16, 0);
            maze.AddHorizontalWall(17, 0);
            maze.AddHorizontalWall(18, 0);
            maze.AddHorizontalWall(19, 0);
            // last line
            maze.AddHorizontalWall(0,7);
            maze.AddHorizontalWall(1,7);
            maze.AddHorizontalWall(2,7);
            maze.AddHorizontalWall(3,7);
            maze.AddHorizontalWall(4,7);
            maze.AddHorizontalWall(5,7);
            maze.AddHorizontalWall(6,7);
            maze.AddHorizontalWall(7,7);
            maze.AddHorizontalWall(8,7);
            maze.AddHorizontalWall(9,7);
            maze.AddHorizontalWall(10,7);
            maze.AddHorizontalWall(11,7);
            maze.AddHorizontalWall(12,7);
            maze.AddHorizontalWall(13,7);
            maze.AddHorizontalWall(14,7);
            maze.AddHorizontalWall(15,7);
            maze.AddHorizontalWall(16,7);
            maze.AddHorizontalWall(17,7);
            maze.AddHorizontalWall(18,7);
            maze.AddHorizontalWall(19, 7);
            // 2nd line
            maze.AddHorizontalWall(1, 1);
            maze.AddHorizontalWall(5, 1);
            maze.AddHorizontalWall(6, 1);
            maze.AddHorizontalWall(7, 1);
            maze.AddHorizontalWall(9, 1);
            maze.AddHorizontalWall(11, 1);
            maze.AddHorizontalWall(12, 1);
            maze.AddHorizontalWall(16, 1);
            maze.AddHorizontalWall(18, 1);
            maze.AddHorizontalWall(19, 1);
            // 3rd line
            maze.AddHorizontalWall(1, 2);
            // 4th line
            maze.AddHorizontalWall(2, 3);
            maze.AddHorizontalWall(5, 3);
            // 5th line
            maze.AddHorizontalWall(2, 4);
            maze.AddHorizontalWall(5, 4);
            // 6th line
            maze.AddHorizontalWall(1, 5);
            // 7th
            maze.AddHorizontalWall(1, 6);
            maze.AddHorizontalWall(5, 6);
            maze.AddHorizontalWall(6, 6);
            maze.AddHorizontalWall(11, 6);
            maze.AddHorizontalWall(12, 6);
            maze.AddHorizontalWall(14, 6);
            maze.AddHorizontalWall(15, 6);
            maze.AddHorizontalWall(18, 6);
            maze.AddHorizontalWall(19, 6);
            
            

            // first column
            maze.AddVerticalWall(0, 0);
            maze.AddVerticalWall(0, 1);
            maze.AddVerticalWall(0, 2);
            maze.AddVerticalWall(0, 3);
            maze.AddVerticalWall(0, 4);
            maze.AddVerticalWall(0, 5);
            maze.AddVerticalWall(0, 6);
            // 2nd column
            maze.AddVerticalWall(1, 1);
            maze.AddVerticalWall(1, 5);
            // 3rd column
            maze.AddVerticalWall(2, 1);
            maze.AddVerticalWall(2, 5);
            // 4th column
            maze.AddVerticalWall(3, 0);
            maze.AddVerticalWall(3, 1);
            maze.AddVerticalWall(3, 2);
            maze.AddVerticalWall(3, 4);
            maze.AddVerticalWall(3, 5);
            maze.AddVerticalWall(3, 6);
            // 5th column
            maze.AddVerticalWall(4, 0);
            maze.AddVerticalWall(4, 1);
            maze.AddVerticalWall(4, 2);
            maze.AddVerticalWall(4, 3);
            maze.AddVerticalWall(4, 4);
            maze.AddVerticalWall(4, 6);
            // 6th column
            maze.AddVerticalWall(5, 1);
            maze.AddVerticalWall(5, 2);
            maze.AddVerticalWall(5, 4);
            maze.AddVerticalWall(5, 5);
            // 7th column
            maze.AddVerticalWall(6, 3);
            // 8th column
            maze.AddVerticalWall(7, 0);
            // 9th column
            maze.AddVerticalWall(8, 2);
            maze.AddVerticalWall(8, 3);
            maze.AddVerticalWall(8, 4);
            maze.AddVerticalWall(8, 5);
            maze.AddVerticalWall(8, 6);
            // 10th column
            maze.AddVerticalWall(9, 1);
            maze.AddVerticalWall(9, 2);
            maze.AddVerticalWall(9, 4);
            maze.AddVerticalWall(9, 5);
            maze.AddVerticalWall(9, 6);
            // 11th column
            maze.AddVerticalWall(10, 0);
            maze.AddVerticalWall(10, 1);
            maze.AddVerticalWall(10, 3);
            maze.AddVerticalWall(10, 4);
            maze.AddVerticalWall(10, 5);
            maze.AddVerticalWall(10, 6);
            // 12nd column
            maze.AddVerticalWall(11, 2);
            maze.AddVerticalWall(11, 3);
            maze.AddVerticalWall(11, 4);
            maze.AddVerticalWall(11, 5);
            // 13rd column
            // 14th column
            maze.AddVerticalWall(13, 1);
            maze.AddVerticalWall(13, 2);
            maze.AddVerticalWall(13, 3);
            maze.AddVerticalWall(13, 4);
            maze.AddVerticalWall(13, 5);
            maze.AddVerticalWall(13, 6);
            // 15th column
            maze.AddVerticalWall(14, 0);
            maze.AddVerticalWall(14, 1);
            maze.AddVerticalWall(14, 2);
            maze.AddVerticalWall(14, 4);
            maze.AddVerticalWall(14, 5);
            // 16th column
            // 17th column
            maze.AddVerticalWall(16, 0);
            maze.AddVerticalWall(16, 1);
            maze.AddVerticalWall(16, 2);
            maze.AddVerticalWall(16, 3);
            maze.AddVerticalWall(16, 4);
            maze.AddVerticalWall(16, 6);
            // 18th column
            maze.AddVerticalWall(17, 0);
            maze.AddVerticalWall(17, 2);
            maze.AddVerticalWall(17, 3);
            maze.AddVerticalWall(17, 4);
            maze.AddVerticalWall(17, 5);
            maze.AddVerticalWall(17, 6);
            // 19th column
            
            maze.AddVerticalWall(18, 1);
            maze.AddVerticalWall(18, 2);
            maze.AddVerticalWall(18, 3);
            maze.AddVerticalWall(18, 4);
            maze.AddVerticalWall(18, 5);

            // last column
            maze.AddVerticalWall(20, 0);
            maze.AddVerticalWall(20, 1);
            maze.AddVerticalWall(20, 2);
            maze.AddVerticalWall(20, 3);
            maze.AddVerticalWall(20, 4);
            maze.AddVerticalWall(20, 5);
            
            
        }

        public Position MazeStartPosition
        {
            get { return new Position(0, 0); }
        }
    }
}
