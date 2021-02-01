using System;

class QuickSort {

    static void Main() {

        int[] numbers = {45,67,42,431,43187,12,-123, -123, -324,431,-789,
                        -123,431,500,4322,1,-2,-123,5,67,-54,654,500,500};

        quickSort(numbers, 0, numbers.GetLength(0) - 1);
        
        foreach(int n in numbers) {
            Console.Write("{0} ", n);
        }
        Console.Write("\n");
    }

    static void quickSort(int[] array, int start, int end) {

        if (start < end) {

            int pivot = array[start];
            int p1 = start, p2 = end, pivotPosition;

            while (p1 <= p2) {
                if (array[p1] <= pivot) {
                    p1 ++;
                } else if (array[p2] > pivot) {
                    p2 --;
                } else {
                    int temp = array[p1];
                    array[p1] = array[p2];
                    array[p2] = temp;
                }
            }

            array[start] = array[p2];
            array[p2] = pivot;
            pivotPosition = p2;

            quickSort(array, start, pivotPosition - 1);
            quickSort(array, pivotPosition + 1, end);
            
        }
    }
}