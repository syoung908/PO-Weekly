using System;

namespace NoKnight {
    public class Program {
        public static void Main(string[] args) {
            Console.WriteLine(CannotCapture(new int[,] {
                { 0, 0, 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 1, 0 },
                { 0, 1, 0, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 0, 0, 0, 0, 1 },
                { 0, 0, 0, 0, 1, 0, 0, 0 }
             }));

            Console.WriteLine(CannotCapture(new int[,] {
                {1, 0, 1, 0, 1, 0, 1, 0},
                {0, 1, 0, 1, 0, 1, 0, 1},
                {1, 0, 1, 0, 1, 0, 1, 0},
                {0, 0, 0, 1, 0, 1, 0, 1},
                {1, 0, 0, 0, 1, 0, 1, 0},
                {0, 0, 0, 0, 0, 1, 0, 1},
                {1, 0, 1, 0, 1, 0, 1, 0},
                {1, 0, 0, 1, 0, 0, 0, 1}
             }));
        }

        public static int[,] moves = new int[8,2] {
            { -2, 1 },
            { -2, -1 },
            { 2, 1 },
            { 2, -1 },
            { -1, 2 },
            { -1, -2 },
            { 1, 2 },
            { 1, -2},
        };

        public static bool CannotCapture(int[,] board) {
            for (int i = 0; i < board.GetLength(0); i++) {
                for (int j = 0; j < board.GetLength(1); j++) {
                    if (board[i, j] == 1) {
                        for (int move = 0; move < board.GetLength(0); move++) {
                            if (CanCapture(i + moves[move, 0], j + moves[move, 1], board)) {
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }

        public static bool CanCapture(int i, int j, int[,] board) {
            if (i < 0 || i >= board.GetLength(0) || j < 0 || j >= board.GetLength(1)) {
                return false;
            }

            return board[i, j] == 1;
              
        }
    }
}
