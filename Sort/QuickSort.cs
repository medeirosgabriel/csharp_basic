using System;

class QuickSort {

    static void Main() {

        int[] array = {45,67,8,-12,33,45,76,100,32,43,
                       76,98,76,-435,65,42,1,-1,3,2,2};

        quickSort(array, 0, array.Length - 1);

        foreach(int n in array){Console.Write("{0} ", n);}
    }


    static private void quickSort(int[] array, int p1, int p2) {
        if (p1 < p2) {
            int pivotPosition = partition(array, p1, p2);
            quickSort(array, p1, pivotPosition - 1);
            quickSort(array, pivotPosition + 1, p2);
        }
    }

    static private int partition(int[] array, int p1, int p2) {
        int pivot = array[p1];
        int left = p1, right = p2;
        while (left <= right) {
            if (array[left] <= pivot) {
                left ++;
            } else if (array[right] > pivot) {
                right --;
            } else {
                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;
            }
        }
        array[p1] = array[right];
        array[right] = pivot;
        return right;
    }
}