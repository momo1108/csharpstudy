int a = 5;
int b = 5;

bool myTest = (a + b) > 10;

if (myTest || ((a + b) == 10)) {
    Console.WriteLine("The answer is greater equal than 10.");
} else {
    Console.WriteLine("The answer is less than 10.");
}