using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {

  //test no args
  warehouse retailWarehouse = new warehouse();



  warehouse[] warehouseArray = new warehouse[2];
  warehouse insidearray = new warehouse("inside array name");
  warehouseArray[0] = insidearray; 

  Console.WriteLine("array object test");
  Console.WriteLine(warehouseArray[0].Name);

  warehouseArray[0].Name = "new name";
  Console.WriteLine(warehouseArray[0].Name);
  Console.WriteLine(insidearray.Name);

  insidearray.Name = "2nd new name";
  Console.WriteLine(insidearray.Name);
  Console.WriteLine(warehouseArray[0].Name);

  //reference value based.

  
    
  }
}

public class warehouse{

  public string Name { get; set;}
  
  //no args
  public warehouse(){
    Name = "no Name";
  }

  //args
  public warehouse(string nameparam)
  {
    Name = nameparam;
  }
}