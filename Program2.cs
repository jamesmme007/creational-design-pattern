
// Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, 
// but allows subclasses to alter the type of objects that will be created.


LoanFactory loanFactory = new ConcreteLoanFactory();

Loan personalLoan = loanFactory.CreateLoan("personal");
Loan autoLoan = loanFactory.CreateLoan("Auto");

personalLoan.ProcessLoan();
autoLoan.ProcessLoan();


// CLASS
public abstract class Loan
{
    public string LoanType { get; set; }
    public abstract void ProcessLoan();
}


// CONCRETE LOAN CLASS

public class PersonalLoan : Loan
{
    public PersonalLoan()
    {
        LoanType = "Personal Loan";
    }

    public override void ProcessLoan()
    {
        Console.WriteLine($"Process {LoanType}");
    }
}


public class AutoLoan : Loan
{
    public AutoLoan()
    {
        LoanType = "Auto Loan";
    }

    public override void ProcessLoan()
    {
        Console.WriteLine($"Process {LoanType}");
    }
}


// CLASS Factory
public abstract class LoanFactory
{
    public abstract Loan CreateLoan(string loanType);
}


// Concrete Class Factory
public class ConcreteLoanFactory : LoanFactory
{
    public override Loan CreateLoan(string loanType)
    {
       
       switch(loanType.ToLower())
       {
            case "personal":
                return new PersonalLoan();
            case "auto":
                 return new AutoLoan();
            default:
                throw new ArgumentException("Loan is not there");
       }


    }
}