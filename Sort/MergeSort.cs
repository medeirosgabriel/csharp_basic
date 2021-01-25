using System;

class MergeSort {

    static void Main() {
        int[] array = {45,67,8,-12,33,45,76,100,32,43,
                       76,98,76,-435,65,42,1,-1,3,2,2};

        mergeSort(array, 0, array.Length - 1);

        foreach(int n in array){Console.Write("{0} ", n);}
    }

    static void mergeSort(int[] array, int p1, int p2) {
       if (p1 < p2) {

           int middle = (p1 + p2)/2;

           mergeSort(array, p1, middle);
           mergeSort(array, middle + 1, p2);

           int[] aux = new int[p2 - p1 + 1];
           int i = 0, left = p1, right = middle + 1;

           while (left <= middle & right <= p2) {
               if (array[left] <= array[right]) {
                   aux[i++] = array[left++];
               } else {
                   aux[i++] = array[right++];
               }
           }

           while (left <= middle) {
                aux[i++] = array[left++];
           }

           while (right <= p2) {
                aux[i++] = array[right++];
           }

           for (i = p1; i <= p2; i++) {
               array[i] = aux[i - p1];
           }
       }
    }
}