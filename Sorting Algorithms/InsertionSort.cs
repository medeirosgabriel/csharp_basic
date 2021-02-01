using System;

class InsertionSort {

    static void Main() {

        int[] numbers = {45,67,42,431,43187,12,-123, -123, -324,431,-789,
                        -123,431,500,4322,1,-2,-123,5,67,-54,654,500,500};

        insertionSort(numbers);

        foreach(int n in numbers) {
            Console.Write("{0} ", n);
        }

        Console.Write("\n");
    }

    static void insertionSort(int[] array) {
        for (int i = 1; i < array.GetLength(0); i++) {
            int n = array[i];
            int j = i - 1;
            while (j >= 0 && n < array[j]) {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = n;
        }
    }
}