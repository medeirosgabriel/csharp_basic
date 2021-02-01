using System;

class MergeSort {

    static void Main() {
        
        int[] numbers = {45,67,42,431,43187,12,-123, -123, -324,431,-789,
                        -123,431,500,4322,1,-2,-123,5,67,-54,654,500,500};

        mergeSort(numbers, 0, numbers.GetLength(0) - 1);
        foreach(int n in numbers) {
            Console.Write("{0} ", n);
        }
        Console.Write("\n");
    }

    static void mergeSort(int[] array, int start, int end) {

        if (start < end) {

            int middle = (start + end)/2;

            mergeSort(array, start, middle);
            mergeSort(array, middle + 1, end);

            int[] aux = new int[end - start + 1];
            int i = 0, p1 = start, p2 = middle + 1;

            while (p1 <= middle &&  p2 <= end) {
                if (array[p1] <= array[p2]) {
                    aux[i++] = array[p1++];
                } else {
                    aux[i++] = array[p2++];
                }
            }

            while (p1 <= middle) {  
                aux[i++] = array[p1++];
            }

            while (p2 <= end) {
                aux[i++] = array[p2++];
            }

            for (i = 0; i < aux.GetLength(0); i++) {
                array[i + start] = aux[i];
            }
        }
    }
}