using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter Integer:");
    int integer = Int32.Parse(Console.ReadLine());

    bool prime = true;

    for (int i = 1; i < integer; i++) {

      if (integer % i == 0 && i != 1) {
        Console.WriteLine ("This is not a prime number.");
        prime = false;
        break;
      }

      if (integer % i == Math.Abs(1) && i != 1) {
        continue;
      }

    }


    if (prime) {
      Console.WriteLine ("This is a prime number.");
    }

  }
}