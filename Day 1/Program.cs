﻿namespace day_1
{
    class day_1{
        static void Main(){
            double current_balance=0.0;
            double amount=0.0;
            for(int i=0;i<5;i++){
                Console.WriteLine("w:Withdraw Balance");
                Console.WriteLine("d:Deposit Balance");
                Console.WriteLine("c:Check Balance");
                char choice=Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch(choice){
                    case 'w':
                        Console.WriteLine("Enter amount to withdraw.");
                        amount=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        if(amount<0){
                            Console.WriteLine("Amount must be greater than 0");
                        }
                        else if(current_balance<amount){
                            Console.WriteLine("Available balance is less than the desired amount.");
                        }
                        else{
                            current_balance=current_balance-amount;
                            Console.WriteLine($"{amount} is successfully withdrawn remaining balance is {current_balance}");
                     }
                        break;
                    case 'd':
                        Console.WriteLine("Enter amount to deposit.");
                        amount=Convert.ToDouble(Console.ReadLine());
                        if(amount<0){
                            Console.WriteLine("Deposit amount can't be a negative number.");    
                        }
                        else{
                            current_balance=current_balance+amount;
                            Console.WriteLine($"{amount} deposited successfully. Current balance is {current_balance}.");
                        }
                        break;
                    case 'c':
                        Console.WriteLine($"Current balance is {current_balance}.");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }
    }
}