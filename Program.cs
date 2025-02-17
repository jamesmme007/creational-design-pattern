
// Builder is a creational design pattern that lets you construct complex objects step by step. 
// The pattern allows you to produce different types and representations of an object using the 
// same construction code.


LoanApplication loanApplication = new LoanApplicationBuilder()
                                        .AddApplicantName("Boss Andrew")
                                        .AddLoanAmount(25000)
                                        .AddTerm(6)
                                        .AddInterestRate(3.5)
                                        .AddLoanType("personal")
                                        .Build();

Console.WriteLine(loanApplication);



public class LoanApplication 
{
    public string ApplicantName { get; set; }

    public double LoanAmount { get; set; }

    public int Term { get; set; }

    public double InterestRate { get; set; }

    public string LoanType { get; set; }

    public override string ToString()
    {
        return $"Name : {ApplicantName} \n Loan Amount : {LoanAmount} \n Term : {Term} \n Interest Rate {InterestRate} \n Loan Type : {LoanType} ";
    }

}


public class LoanApplicationBuilder
{
    private LoanApplication _loanApp;

    public LoanApplicationBuilder()
    {
        _loanApp = new LoanApplication();
    }

    public LoanApplicationBuilder AddApplicantName(string name)
    {
        _loanApp.ApplicantName = name;
        return this;
    }

    public LoanApplicationBuilder AddLoanAmount(double amount)
    {
        _loanApp.LoanAmount = amount;
        return this;
    }

     public LoanApplicationBuilder AddTerm(int term)
    {
        _loanApp.Term = term;
        return this;
    }

     public LoanApplicationBuilder AddInterestRate(double interestRate)
    {
        _loanApp.InterestRate = interestRate;
        return this;
    }

    public LoanApplicationBuilder AddLoanType(string loanType)
    {
        _loanApp.LoanType = loanType;
        return this;
    }

    public LoanApplication Build()
    {
        return _loanApp;
    }
}