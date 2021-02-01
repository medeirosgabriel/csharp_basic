using System;

class RecursiveBubbleSort {

    static void Main() {

        int[] numbers = {45,67,42,431,43187,12,-123, -123, -324,431,-789,
                        -123,431,500,4322,1,-2,-123,5,67,-54,654,500,500};

        bubbleSort(numbers, 0, numbers.GetLength(0) - 1);

        foreach(int n in numbers) {
            Console.Write("{0} ", n);
        }
        Console.Write("\n");
    }

    static void bubbleSort(int[] array, int index, int final) {
        if (final != 0) {
            if (index == final) {
                bubbleSort(array, 0, final - 1);
            } else {
                if (array[index] > array[index + 1]) {
                    int temp = array[index];
                    array[index] = array[index + 1];
                    array[index + 1] = temp;
                }
                bubbleSort(array, index + 1, final);
            }
        }
    }
}