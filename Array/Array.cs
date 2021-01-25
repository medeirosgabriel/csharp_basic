using System;

class Array {
    static void Main() {
        int[] a1 = new int[5]; // 0 - 4
        a1[0] = 11;
        a1[1] = 22;
        a1[2] = 33;
        a1[3] = 44;
        a1[4] = 55;

        int[] a2 = new int[3]{11,22,33};
        int[] a3 = {11,22,33,44};

        for (int i = 0; i < 5; i++) {
            verification(a1, "a1", i);
            verification(a2, "a2", i);
            verification(a3, "a3", i);
        }
    }

    static void verification(int[] array, string name, int index) {
        if (index < array.Length) {
            Console.Write("{0}[{1}] = {2} ", name, index, array[index]);
        }
        if (name == "a3") {
            Console.WriteLine("");
        }
    }
}

