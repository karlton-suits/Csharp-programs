using System;

class MainClass {
  public static void Main (string[] args) {
    
    //array of strings
    string[] stringArray = new String[] { "1", "2", "3", "4","5"};

     
    int[] partInventory = Array.ConvertAll(stringArray, int.Parse);

    //Console.WriteLine(partInventory[0] + partInventory[1]); //3
    
    
    




  }
}