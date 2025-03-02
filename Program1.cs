
// Singleton is a creational design pattern that lets you ensure that a class has only one instance, 
// while providing a global access point to this instance.


using System;


LoanManager unsecuredLoan = LoanManager.GetInstance();
unsecuredLoan.ProcessLoan("unsecured");


LoanManager securedLoan = LoanManager.GetInstance();
securedLoan.ProcessLoan("secured");


Console.WriteLine($"Are both loan manager are in the same instance? {unsecuredLoan == securedLoan} ");




// Step 1 create a class
public class LoanManager
{
    // Step 2: create a private static field
    private static LoanManager _instance;

    // Step 3 : lock for thread safety
    private static readonly object _lock = new object();

    // Step 4 : To prevent external instatiation
    public LoanManager()
    {
    }

    // Step 5 : Create the business logic
    public static LoanManager GetInstance()
    {
        lock(_lock)
        {
            if(_instance == null)
            {
                _instance = new LoanManager();
            }

            return _instance;
        }
    }


    public void ProcessLoan(string loanTypes)
    {
        Console.WriteLine($"Process Loan {loanTypes}");

    }


}

