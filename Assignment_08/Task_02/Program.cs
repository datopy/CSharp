using BankingSystem;

BankAccount acc1 = new BankAccount("123", "Dato", "USD");
acc1.Deposit(300);
BankAccount acc2 = new BankAccount("321", "Gio", "USD");

Currency currency = new Currency("USD", 100);


acc1.TransferFunds(acc2, currency);

acc2.BalanceCheck();


