Console.WriteLine("Put amount of pizzas ");
int amout = Int32.Parse(Console.ReadLine());
Console.WriteLine("Amount slices per pizza? ");
int slices = Int32.Parse(Console.ReadLine());
Console.WriteLine("Amount of people that will eat it? ");
int persons = Int32.Parse(Console.ReadLine());

int totalSlices = amout * slices;

int slicePerson = totalSlices / persons;

int sobrante = totalSlices % persons;
Console.WriteLine("Total amount of slices ");
Console.WriteLine(totalSlices);
Console.WriteLine("Slices per person ");
Console.WriteLine(slicePerson);
Console.WriteLine("Spare slices ");
Console.WriteLine(sobrante);