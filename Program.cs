﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int age = 50;
//age = "fifty"; // can't do this 

string name = "Mesut";
//Console.WriteLine($"your name is  {name} and you're {age} years old. ");
try {
SavingsAccount newAccount = new SavingsAccount("Bobby",100.99);

//  newAccount.Balance = -100.99;
// newAccount.Balance = newAccount.Balance + 100;
    newAccount.Deposit(50.00);
    newAccount.withdraw(40);

Console.WriteLine($"{newAccount.OwnerName} balance is {newAccount.getBalance()}");
}catch(Exception err){
    Console.WriteLine($" you got an error: {err.Message}");
}

