using System;

namespace work05
{
  interface IHomework05
  {
    string DisplayLEDOnScreen(string ledNo);
  }

  class LEDSetting : IHomework05
  {
    string[] array1 = new string[] { "1","2","3","4","5","6","7","8","9","A" };
    string[] array3 = new string[] { "[ ]","[ ]","[ ]","[ ]","[ ]","[ ]","[ ]","[ ]","[ ]","[ ]" };

    public LEDSetting() {}

    public void Fix(String ledNo) 
    {
        for (int i = 0; i < 10; i++) {
            if ( array1[i] == ledNo & array3[i] == "[!]" ){
                array3[i] = "[ ]";
            }
            else if ( array1[i] == ledNo & array3[i] == "[ ]" ){
                array3[i] = "[!]";
            }
        }
    }
    public string Display() 
    { 
        string display = "";
        for (int i = 0; i < 10; i++) {
            if ( array3[i] == "[!]" ){
                display += array3[i] + " ";
            }
            else if ( array3[i] == "[ ]" ){
                display += array3[i] + " ";
            }
        }
        return display;
    }
    public String DisplayLEDOnScreen(string ledNo){
        Fix(ledNo);
        return Display();
    }
    public void Output1(){
        Console.WriteLine(string.Join(" ", array3));
        Console.WriteLine(string.Join("   ", array1));

    }
    public void Output2(){
        Console.Write("Please choose LED to turn On/Off: ");
        string ledNo = Console.ReadLine();
        Console.WriteLine(DisplayLEDOnScreen(ledNo));
        Console.WriteLine(string.Join("   ", array1));

    }
  }

  class App {
    static void Main(string[] args)
    {
      LEDSetting panel = new LEDSetting();
      int count = 1;
      panel.Output1();
        while ( count <= 100 ) {
            panel.Output2();
            count++;
        }
    }
  }
}