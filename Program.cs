using PasswordGenerator;

var pwd = new Password();
var password = pwd.Next();
Console.WriteLine(password);

var passwords = pwd.NextGroup(10);
foreach (var p in passwords) {
    Console.WriteLine(p.ToString());
}