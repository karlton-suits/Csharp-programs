using System;

class MainClass {
  public static void Main (string[] args) {
    

    int[] i = new int[5]{1,2,3,4,5};


    
    //Console.WriteLine(testObj.ToString());
    //Console.WriteLine(testObj.inventory[])

    //string[] s = new string[5];

    

    test testObject = new test(i);

    Console.WriteLine(testObject.inventory[0]);
    Console.WriteLine(testObject.inventory[1]);
    Console.WriteLine(testObject.inventory[2]);
    Console.WriteLine(testObject.inventory[3]);
    Console.WriteLine(testObject.inventory[4]);
    


  }
}

public class test {
  //int[] inventory = new int[] {0,0,0,0,0};
  public int[] inventory { get; set; }

  public test()
  {
    inventory = new int[] {5,0,0,0,0};
  }

  //args constructor
  public test(int[] Inventory)
  {
    inventory = new int[] {5,0,0,0,0};
    Array.Copy(Inventory, inventory, Inventory.Length);
  }

  //overload method for array
  
  public override string ToString()
	{
		
    string s = "";

    for (int i = 0; i < inventory.Length; i++) 
    {
       s += inventory[i].ToString() + ", ";
    }

    return s;
	}



  

  

}