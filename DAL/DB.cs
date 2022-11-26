﻿using Model;

namespace DAL
{
    /// <summary>
    /// The class is a singeltone MoockData contains Boxes array sorted  by date
    /// </summary>
    public class DB
    {
        private static DB? _instance;
        private static Box[]? _boxes;
        public static Box[] Boxes { get => _boxes!; set => _boxes = value; }
        public static DB Instance
        //SingleTone
        {
            get
            {
                _instance ??= new DB();
                return _instance;
            }
        }

        private DB()
        {
            Boxes = new Box[21];
            Boxes[0] = new Box(25, 20, 76, new DateTime(2022, 1, 23));
            Boxes[1] = new Box(5, 6, 45, new DateTime(2022, 8, 5));
            Boxes[2] = new Box(6, 6.5, 45, new DateTime(2022, 8, 7));
            Boxes[3] = new Box(6, 9.5, 45, new DateTime(2022, 6, 8));
            Boxes[4] = new Box(8, 8.5, 54, new DateTime(2022, 6, 8));
            Boxes[5] = new Box(8, 2.5, 45, new DateTime(2022, 6, 9));
            Boxes[6] = new Box(8, 5.5, 45, new DateTime(2022, 5, 10));
            Boxes[7] = new Box(10, 6, 50, new DateTime(2022, 8, 11));
            Boxes[8] = new Box(11, 6.5, 50, new DateTime(2022, 6, 12));
            Boxes[9] = new Box(10, 7, 25, new DateTime(2022, 4, 13));
            Boxes[10] = new Box(12, 7, 66, new DateTime(2022, 7, 14));
            Boxes[11] = new Box(12, 6, 66, new DateTime(2022, 7, 15));
            Boxes[12] = new Box(15, 8, 78, new DateTime(2022, 7, 16));
            Boxes[13] = new Box(20.12, 10, 10, new DateTime(2022, 7, 17));
            Boxes[14] = new Box(20.12, 12, 80, new DateTime(2022, 7, 18));
            Boxes[15] = new Box(14, 15, 80, new DateTime(2022, 8, 1));
            Boxes[16] = new Box(15, 15, 80, new DateTime(2022, 7, 20));
            Boxes[17] = new Box(17, 17, 76, new DateTime(2022, 7, 21));
            Boxes[18] = new Box(20, 20, 76, new DateTime(2022, 7, 23));
            Array.Sort(Boxes);
        }
    }
}
