using System;
using System.Collections.Generic;
namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To The ATM! \nType the menu number for waht you need\n1) Login\n2) Append CreditCard");
        string answerATM = Console.ReadLine();
        
        if(answerATM == "1"){
            Login();
        }

    } //static void main

    static void Menu(int creditCardNUmber){
        Console.WriteLine($"Welcome \nYour Creditcard number is {creditCardNUmber}");
    }

    static void Login(){
        bool i = true;
        while(i == true){
            IDictionary<int, int> creditCards = new Dictionary<int, int>(){
            {09876, 1234},
            {12345, 4321}
        };
            int creditCardPassword = 0;
            Console.WriteLine("Type your Credit Card Number");
            int creditCardNUmber = Convert.ToInt32(Console.ReadLine());



            if(creditCards.ContainsKey(creditCardNUmber)){
                Console.WriteLine("Type your Credit Card Password");
                creditCardPassword = Convert.ToInt32(Console.ReadLine());
            } else{
                Console.WriteLine("CreditCard number does not exist. Please try again!");
                continue;
            }

            if(creditCards[creditCardNUmber] == creditCardPassword){
                Console.WriteLine("Succeed!");
                Menu(creditCardNUmber);
                i = false;
            }
        }
    }

  } //class program

}