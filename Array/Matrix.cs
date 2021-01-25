using System;

class Matrix {
    static void Main() {
        int[,] m1 = new int[3,4];
        m1[0,0] = 11; m1[0,1] = 22; m1[0,2] = 33; m1[0,3] = 44;
        m1[1,0] = 55; m1[1,1] = 66; m1[1,2] = 77; m1[1,3] = 88;
        m1[2,0] = 99; m1[2,1] = 11; m1[2,2] = 22; m1[2,3] = 33;

        int[,] m2 = new int[,]{{11,22},{33,44}};
        int[,] m3 = {{11,22},{33,44}};

        printMatrix(m1);
        printMatrix(m2);
        printMatrix(m3);
    }

    static void printMatrix(int[,] matrix) {
        for (int i = 0; i < matrix.GetLength(0); i++) { // matrix.GetLength(0) -> First Dimension
            for (int j = 0; j < matrix.GetLength(1); j++) {
                Console.Write("{0} ", matrix[i,j]);
            }
            Console.WriteLine("");
        }
        Console.WriteLine("");
    }
}
