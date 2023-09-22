using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {

  //ask for user input
    Console.WriteLine ("Enter wind speed in mph: ");
  //assign user input to string
    string windSpeed = Console.ReadLine();
  //use regex to get numeric part of string
    Match match = Regex.Match(windSpeed, @"\d+");
    float windSpeedNum = 0;
    
  //parse string into float
    if (match.Success) {
      float.TryParse(match.Value, out windSpeedNum);
  }
        
  if (windSpeedNum >= 157 ) {
    Console.WriteLine ("Category Five Hurricane");
  }

    else if (windSpeedNum < 157 && windSpeedNum >=130) {
    Console.WriteLine ("Category Four Hurricane");
  }

    else if (windSpeedNum < 130 && windSpeedNum >=111) {
    Console.WriteLine ("Category Three Hurricane");
  }

    else if (windSpeedNum < 111 && windSpeedNum >= 96) {
    Console.WriteLine ("Category Two Hurricane");
  }

    else if (windSpeedNum < 96 && windSpeedNum >=74) {
    Console.WriteLine ("Category One Hurricane");
  }

    else if (windSpeedNum < 74) {
    Console.WriteLine ("Not a Hurricane");
      
  } else {
    Console.WriteLine ("Not a valid number.");
  
    }

    
  }
  
}