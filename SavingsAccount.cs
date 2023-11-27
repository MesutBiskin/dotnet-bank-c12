public class SavingsAccount :BankAccount {  

    //constructor
    public SavingsAccount(string NewOwnersName, double initialBalance)
    : base(NewOwnersName, initialBalance)
     {
        this.Deposit(100); 
    }
}

public class CheckingAccount :BankAccount {  

    //constructor
    public CheckingAccount(string NewOwnersName, double initialBalance)
    : base(NewOwnersName, initialBalance)
     {
      
    }
}
