using System;

class MainClass {
  public static void Main (string[] args) {
    int[] arrayOne = new int[] {1,2,3,4,5};

    int[] arrayTwo = new int[] {0,0,0,0,0};

    Array.Copy(arrayOne, arrayTwo, arrayOne.Length);

    Console.WriteLine(arrayTwo[2]);
  }
}