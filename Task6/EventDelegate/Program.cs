using System;

class BankAccount{
    private int balance;

    public delegate void LowBalanceNotify(int balance);
    public event LowBalanceNotify LowBalance;

    public BankAccount(int balance){
        this.balance=balance;
    }

    public void Withdraw(int amount){
        if(balance-amount<=0){
            Console.WriteLine("Insufficient Balance. Withdrawal Failed.");
            return;
        }
        balance -= amount;
        Console.WriteLine("Withdrawn: ₹" + amount);
        Console.WriteLine("Current Balance: ₹" + balance);

        if (balance < 1000){
            OnLowBalance(balance);
        }
    }
      
    protected void OnLowBalance(int balance){
        LowBalance?.Invoke(balance);
    }
}

class Program{
    static void SendSMS(int balance){
        Console.WriteLine("SMS Alert: Your balance is low: ₹" + balance);
    }

    static void SendEmail(int balance){
        Console.WriteLine("Email Alert: Please maintain minimum balance. Current: ₹" + balance);
    }

    static void ShowMobileNotification(int balance){
        Console.WriteLine("App Notification: Low balance warning!");
    }

    static void Main(){
        BankAccount account= new BankAccount(3000);

        account.LowBalance+=SendSMS;
        account.LowBalance+=SendEmail;
        account.LowBalance+=ShowMobileNotification;

        account.Withdraw(700);
        account.Withdraw(600);
        account.Withdraw(800);
    }
}