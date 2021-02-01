using System;

class ThreeWayQuickSort {

    static void Main() {

        int[] numbers = {45,67,42,431,43187,12,-123, -123, -324,431,-789,
                        -123,431,500,4322,1,-2,-123,5,67,-54,654,500,500};

        threeWayQuickSort(numbers, 0, numbers.GetLength(0) - 1);

        foreach(int n in numbers) {
            Console.Write("{0} ", n);
        }
        Console.Write("\n");

    }

    static void threeWayQuickSort(int[] array, int start, int end) {

        if (start < end) {

            int pivot = array[start], p1 = start, p2 = start + 1, p3 = end;

            while (p2 <= p3) {
                if (array[p2] == pivot) {
                    p2 ++;
                } else if (array[p2] < pivot) {
                    int temp = array[p2];
                    array[p2] = array[p1];
                    array[p1] = temp;
                    p1 ++; p2 ++;
                } else {
                    int temp = array[p3];
                    array[p3] = array[p2];
                    array[p2] = temp;
                    p3 --;
                }
            }

            threeWayQuickSort(array, start, p1 - 1);
            threeWayQuickSort(array, p2, end);
        }
    }
}