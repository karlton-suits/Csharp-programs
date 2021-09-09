/*

update c# with some of the stuff to learn about in sections such as getter and setter faster framework/shortcuts

6 warehouses
*/

using System;

public class MainClass {
  public static int Fibonacci(int n) {
    int a = 0;
    int b = 1;
    for (int i = 0; i < n; i++) {
      int temp = a;
      a = b;
      b = temp + b;
    }
    return a;
  }

  static void Main() {
    Console.WriteLine("Hello.");

    var AtlantaOne = new Atlanta();
    Console.WriteLine(AtlantaOne.Status); //unknown status

    var AtlantaTwo = new Atlanta("Morning Status is open");
    Console.WriteLine(AtlantaTwo.Status);

  }
}

/*
fields:
initial status
inventory
final end of day status
*/


public class Atlanta {
  //fields

  //no args constructor
  public Atlanta() {
    Status = "unknown status";
  }

  public Atlanta(String status){
    Status = status;
  }

  // Auto-implemented readonly property:
    public string Status { get; }
  
  //base class override for system.object
  public override string ToString(){
    return Status;
  }
}