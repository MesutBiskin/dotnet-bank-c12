public class BankAccount { 

   private double Balance = 0;

   public string OwnerName = "";

// Constructor
   public BankAccount(string NewOwnersName,double initialBalance){
    this.OwnerName = NewOwnersName;
    this.Deposit(initialBalance);
    //this.Deposit(100); // for new account
   
    this.Balance = initialBalance ;
    //this.Balance += 100;
   }

    public double Deposit(double amount) {
         if(amount < 0.00)
    {
        throw new Exception("Nope");
    }
        this.Balance += amount;
        return this.Balance;

        
    }

    public double withdraw(double amount) {
        if(amount < 0.00) {
            throw new Exception("No negativity");
        }
        if (amount > this.Balance) {
            throw new Exception(" YOu don't have enough money");
        } 
        //todo send money out atm door
        this.Balance -= amount;
        return this.Balance;
    }

    public double getBalance() {
        return this.Balance;
    }
}