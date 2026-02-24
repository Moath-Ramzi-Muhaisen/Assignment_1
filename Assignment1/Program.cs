Console.WriteLine("Please Enter The Invoice");
var invoice = Convert.ToInt32(Console.ReadLine());

double discount = 0;
double finalAmount = invoice;

if (invoice >= 500)
{
    discount = invoice * 0.20;
    finalAmount = invoice - discount;
}
else if (invoice >= 300 && invoice < 500)
{
    discount = invoice * 0.10;
    finalAmount = invoice - discount;
}

Console.WriteLine("Final Amount: " + finalAmount);

Console.WriteLine("Test Changes");