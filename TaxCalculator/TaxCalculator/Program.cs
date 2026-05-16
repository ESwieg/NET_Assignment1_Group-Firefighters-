//Reviewed and tested by Vito Visagie
double annualSalary;
double taxAmount;
double netIncome;
string taxBracket;
string continueChoice;

do
{
    Console.WriteLine("==========================================");
    Console.WriteLine("   NAMIBIAN MINISTRY OF FINANCE");
    Console.WriteLine("   Payroll Tax Calculator");
    Console.WriteLine("==========================================");

    Console.Write("\nEnter annual salary in NAD: N$ ");
    annualSalary = double.Parse(Console.ReadLine());

    if (annualSalary <= 50000)
    {
        taxBracket = "0% - No tax payable";
        taxAmount = 0;
    }
    else if (annualSalary <= 100000)
    {
        taxBracket = "18% on amount over N$50,000";
        taxAmount = (annualSalary - 50000) * 0.18;
    }
    else
    {
        taxBracket = "25% on amount over N$100,000 + N$9,000";
        taxAmount = ((annualSalary - 100000) * 0.25) + 9000;
    }

    netIncome = annualSalary - taxAmount;

    Console.WriteLine("\n------------------------------------------");
    Console.WriteLine($"  Annual Salary : N$ {annualSalary:F2}");
    Console.WriteLine($"  Tax Bracket   : {taxBracket}");
    Console.WriteLine($"  Tax Amount    : N$ {taxAmount:F2}");
    Console.WriteLine($"  Net Income    : N$ {netIncome:F2}");
    Console.WriteLine("------------------------------------------");

    Console.Write("\nCalculate another salary? (yes/no): ");
    continueChoice = Console.ReadLine().ToLower();

} while (continueChoice == "yes");

Console.WriteLine("\nThank you for using the Namibian Tax Calculator. Goodbye!");
