using System;
using System.Collections.Generic;
namespace Review
{
  class Program
  {
    static void Main()
    {
        
        Console.WriteLine("Welcome To The ATM! \nType the menu number for waht you need\n1) Login\n2) Append CreditCard");
        string answerATM = Console.ReadLine();
        IDictionary<int, int> creditCards = new Dictionary<int, int>(){
            {09876, 1234},
            {12345, 4321}
        };
        Console.WriteLine(creditCards);
        if(answerATM == "1"){
            Login(creditCards);
        }
        if(answerATM == "2"){
            AppendCreditCard(creditCards);
        }

    } //static void main

    static void AppendCreditCard(IDictionary<int, int> creditCards){
        Console.WriteLine("Type your CreditCard Number: ");
        int newCreditCardNUmber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Type your CreditCard Password: ");
        int newCreditCardPassword = Convert.ToInt32(Console.ReadLine());
        creditCards.Add(new KeyValuePair<int, int>(newCreditCardNUmber, newCreditCardPassword));
        Console.WriteLine(creditCards);
        Main();

    }
    static void MenuIN(int creditCardNUmber){
        Console.WriteLine($"Welcome \nYour Creditcard number is {creditCardNUmber}");
    }

    static void Login(IDictionary<int, int> creditCards){
        bool i = true;
        while(i == true){

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
                MenuIN(creditCardNUmber);
                i = false;
            }
        }
    }

  } //class program

}