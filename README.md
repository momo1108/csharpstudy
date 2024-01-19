# C sharp
## Dotnet이란?
Command Lang Tool use to create project, run applications, do anything you wanna do with dotnet.
You get this one entry point CLI, one entry point application for running, testing, making new application.

## C sharp 프로젝트 생성
```shell
dotnet new # 생성가능 프로젝트 확인
dotnet new console # 출력용 샘플 프로젝트
```

### 구성요소
- obj 폴더
- helloworld.csproj
- Program.cs : entry point. actual code.

## 프로젝트 실행
### With Dotnet
```shell
dotnet start
```

명령어 실행 시 Program.cs 가 실행될 수 있는 무언가로 컴파일된 후 실행된다.(bin 폴더가 생성됨)

### With VSCode
```shell
code .
```

Run > Run without Debugging (ctrl + F5)
(C# Dev Kit extension 필요)

VSCode 내에서도 `dotnet run` 사용 가능

## String
Character들의 열(문자열)

double quot(")로 감싸짐.

### String Interpolation(문자열 보간)
String Literal안의 내용을 대체할 수 있는 방법

```cs
string testName = "Hyechan";
string testString = $"My name is {testName}";

Console.WriteLine(testString);
Console.WriteLine("My name is " + testName);
```

### Attributes
첫 문자가 대문자로 시작한다

Trim()
: Removes all leading and trailing white-space characters from the current string.

```cs
string test = "   fewaniof  ";
Console.WriteLine(test.Trim());
```

Replace(old, new)
: Returns a new string in which all occurrences of a specified Unicode character in this instance are replaced with another specified Unicode character.

Contain(value) : bool
: Returns a value indicating whether a specified substring occurs within this string.

ToUpper()
: Returns a copy of this string converted to uppercase.

Length
: Gets the number of characters in the current string object.

StartsWith(value) : bool
: Determines whether this string instance starts with the specified character.

## Numbers
### int
Represents a 32-bit signed integer.(첫번째 비트는 부호, 나머지 31비트가 크기. `2^31` 즉 `-2,147,483,648 ~ 2,147,483,647`)

```cs
int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine($"The answer is {c}");
```

> 라떼참조) 위처럼 바로 코드를 작성할 수 있는 기능을 `Top-Level Statement` 라고 한다. C sharp 에는 불과 몇년 전에 출시된 기능이다. 이 기능이 있기 전에는 main function 내부에서 이런것들을 해야만 했다.

### long
Represents a 64-bit signed integer.

잘못된 예시(a+b 연산 자체는 int 로서 이루어진다)

```cs
int a = 2100000000;
int b = 2100000000;
long c = a + b;
Console.WriteLine($"The answer is {c}");
```

정정 예시(Type Casting)

```cs
int a = 2100000000;
int b = 2100000000;
long c = (long)a + (long)b;
Console.WriteLine($"The answer is {c}");
```

checked 함수(Overflow 발생 시 Exception 발생)

```cs
int a = 2100000000;
int b = 2100000000;
long c = checked(a + b);
Console.WriteLine($"The answer is {c}");
```

### double
Represents a double-precision floating-point number.

C sharp 에서 소수 중에서는 double 타입이 `natural type` 이다.

```cs
double a = 42.1; // natural type
double b = 38.2;
double c = a + b;
Console.WriteLine($"The answer is {c}");
```

```cs
int a = (int)42.8;
int b = (int)38.2;
long c = checked(a + b);
Console.WriteLine($"The answer is {c}");
```

### float
Represents a single-precision floating-point number.
`F` 라는 Suffix(접미사)가 필요하다.

```cs
double a = 42.1;
float b = 38.2F;
double c = a + b;
Console.WriteLine($"The answer is {c}");
```

위 코드의 실행 결과 : `80.30000076293945`

80.3 뒤의 값들은 어디서 나온걸까?

위 같은 연산에서 우리가 원하는 결과를 보기 위해서는 어떤 타입을 사용해야 할까?

### decimal
Represents a decimal floating-point number.

`M` 이라는 Suffix가 필요하다.

```cs
decimal a = 42.1M; // explicit type
decimal b = 38.2M;
decimal c = a + b;
Console.WriteLine($"The answer is {c}");
```

### What is Precision?
float는 single precision을 사용한다고 적혀있고, double은 double precision을 사용한다고 적혀있다.

이를 알아보고 정리하자.

## Branching, Ifs, Conditional logic
```cs
if(조건:bool) statement // 하나의 실행문은 bracket없이 attach 가능
if(조건:bool) {
    statement1
    statement2
    statement3
    ...
}
```

bool
: Represents a Boolean (true or false) value.

```cs
int a = 5;
int b = 5;

bool myTest = (a + b) > 10;

if (myTest || ((a + b) == 10)) {
    Console.WriteLine("The answer is greater equal than 10.");
} else {
    Console.WriteLine("The answer is less than 10.");
}
```

> C sharp의 논리 연산자는 어떤게 있을까?
> 
> https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators

## Branching and Loops
### while
```cs
int counter = 0;

while (counter < 5) {
    Console.WriteLine(++counter);
}

counter = 0;

do {
    Console.WriteLine(++counter);
} while (counter < 5);
```

### for
```cs
for (int i = 0; i < 5; i++) {
    Console.WriteLine(i);
}
```

## List of T and Collections of Data
### List
```cs
var names = new List<string>(["Hyechan", "Ana", "Felipe"]);

names.Add("David");
names.Add("Damian");
names.Add("Maria");

Console.WriteLine(names[0]);
Console.WriteLine(names[2]);
Console.WriteLine(names[names.Count - 1]);
Console.WriteLine(names[^1]);

foreach (var name in names[1..^1]) {
    Console.WriteLine($"Hello {name.ToUpper()}!");
}
```

인스턴스 생성법들
- `var names = new List<string>{"Hyechan", "Ana", "Felipe"};`
- `var names = new List<string>(["Hyechan", "Ana", "Felipe"]);`
- `List<string> names = ["Hyechan", "Ana", "Felipe"];`
- 이것도 돼? `var names = new List<string>(["Hyechan", "Ana", "Felipe"]){ "David", "Damian", "Maria" };`

var
: Local Variable Type Inference. `var` 를 사용하고 반대편의 내용을 C# 이 무엇인지 알 수 있으면 infer 해준다.(타입추론)

foreach
: 리스트의 요소들은 하나씩 사용한다.

### Array
대부분의 언어에서 사용되는 primitive type. 어떤 요소 리스트를 저장하기 위해 사용.

```cs
var names = new string[] { "Hyechan", "Ana", "Felipe" };

foreach (var name in names) {
    Console.WriteLine($"Hello {name.ToUpper()}!");
}
```

**Arrays are fixed in length!**

Array의 길이는 고정이기 때문에, 크기 확장을 위해선 확장된 크기의 새로운 Array를 만들고 기존 값들을 넣어야 한다.

**C# 12버전(2023.11.18)부터 훨씬 간단한 방법을 사용 가능하다.**

```cs
var names = new string[] { "Hyechan", "Ana", "Felipe" };

names = [..names, "Damian"];

foreach (var name in names) {
    Console.WriteLine($"Hello {name.ToUpper()}!");
}
```

### Sorting, Searching
```cs
var numbers = new List<int>{ 45, 56, 99, 48, 67, 78 };

Console.WriteLine($"I found 99 at index {numbers.IndexOf(99)}");
numbers.Sort();
Console.WriteLine($"I found 99 at index {numbers.IndexOf(99)}");

foreach (var number in numbers) {
    Console.WriteLine($"{number}");
}
```

## LINQ
C# 내부적으로 query 기능 구현. 자세한 내용은 [ms 도큐먼트](https://learn.microsoft.com/en-us/dotnet/csharp/linq/) 참조

```cs
// Specify the data source.
List<int> scores = [97, 92, 81, 60];

// Define the query expression.
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    select score;

// Execute the query.
foreach (var i in scoreQuery) {
    Console.Write(i + " ");
}
```

`scoreQuery` 자체는 정답이 아니라 query 이다. query의 실행은 `foreach` 구문에서 이루어진다.

Syntax Highlighting을 보면 알겠지만, 단순히 SQL 등의 query를 문자열로 쓰는게 아니라, 내부적으로 구현이 되어있다.

### Query Expressions
다양한 작업을 체인시켜서 한번에 사용할 수 있다. (ex. 기존의 Sort를 orderby로 체이닝)

```cs
// Specify the data source.
List<int> scores = [90, 88, 97, 92, 81, 60];

// Define the query expression.
IEnumerable<string> scoreQuery =
    from score in scores
    where score > 80
    orderby score descending
    select $"The score is {score}";

Console.WriteLine(scoreQuery.Count());

// Execute the query.
foreach (string s in scoreQuery) {
    Console.WriteLine(s);
}
```

### Method Syntax
```cs
// Specify the data source.
List<int> scores = [90, 88, 97, 92, 81, 60];

// Define the query expression.
var scoreQuery = scores.Where(s => s > 80).OrderByDescending(s => s);

// Execute the query.
foreach (int score in scoreQuery) {
    Console.WriteLine(score);
}

var result = scoreQuery.ToList();
```

## OOP
Object-oriented Programming

older version of C#(현재는 이런 폼을 자동 생성해주는 것)

```cs
using System;

namespace MyNamespace {
    public class MyApp {
        public static void Main() {
            Console.WriteLine("Hello");
        }
    }
}
```

namespace 와 class 명이 구분되기 위한 식별자같은 역할

class를 선언할 때 보편적인 방법으로 멤버 필드를 설정할 수 있지만, primary constructor를 사용하면 더 깔끔한 코드를 작성할 수 있다.

**보편적인 방법**

```cs
var p1 = new Person("Hyechan", "Bang", new DateOnly(1993, 11, 8));
var p2 = new Person("Peter", "Parker", new DateOnly(1970, 5, 12));

List<Person> people = [p1, p2];

Console.WriteLine(people[0].First);

public class Person {
    public Person(string firstname, string lastname, DateOnly birthday){
        this.firstname = firstname;
        this.lastname = lastname;
        this.birthday = birthday;
    }

    private string firstname;
    private string lastname;
    private DateOnly birthday; // 새로운 타입(DateTime에서 Date만)

    public string First { get { return firstname; } }
    public string Last { get { return lastname; } }
    public DateOnly Birthday { get { return birthday; } }
}
```

**primary constructor를 사용한 방법**

```cs
var p1 = new Person("Hyechan", "Bang", new DateOnly(1993, 11, 8));
var p2 = new Person("Peter", "Parker", new DateOnly(1970, 5, 12));

List<Person> people = [p1, p2];

Console.WriteLine(people[0].First);

public class Person(string firstname, string lastname, DateOnly birthday)
{
    public string First {get;} = firstname; // 이건 한번 정하고 고정하기 위해서 get에서 return 안하고 대입한건가?
    public string Last {get;} = lastname;
    public DateOnly Birthday {get;} = birthday;
}
```

### Derived or Abstract Classes, Overrides
```cs
var p1 = new Person("Hyechan", "Bang", new DateOnly(1993, 11, 8));
var p2 = new Person("Peter", "Parker", new DateOnly(1970, 5, 12));

p1.Pets.Add(new Dog("Fred"));
p1.Pets.Add(new Dog("Barney"));

p2.Pets.Add(new Cat("Beyonce"));

List<Person> people = [p1, p2];

foreach (var person in people) {
    Console.WriteLine($"{person}");
    foreach (Pet pet in person.Pets) {
        Console.WriteLine($"{pet}");
    }
}

public class Person(string firstname, string lastname, DateOnly birthday)
{
    public string First {get {return firstname;}}
    public string Last {get {return lastname;}}
    public DateOnly Birthday {get {return birthday;}}

    public List<Pet> Pets {get;} = [];

    public override string ToString()
    {
        return $"{First} {Last}";
    }
}

public abstract class Pet(string firstname) {
    public string First {get;} = firstname;

    public abstract string MakeNoise();

    public override string ToString()
    {
        return $"└ My name is {First} and I'm a {GetType().Name}. I {MakeNoise()}!";
    }
}

// 상속 시 콜론(:) 사용 후 부모 constructor에 바로 넘겨주기 가능.(C# 12버전부터 지원)
public class Cat(string firstname) : Pet {
    public override string MakeNoise(){return "meow";}
}

public class Dog(string firstname) : Pet {
    public override string MakeNoise() => "bark";
}
```

<br>

---

<br>

# .NET
What is .NET?

> .NET is a free, open-source & cross-platform development platform.

- Free
- Works & runs on Linux, Mac, Windows
- Programming languages & libraries

Languages
- C# (OOP)
- F# (Functional Programming) and more

Tools
- Visual Studio
- Visual Studio Code

거의 모든 서비스를 개발할 수 있다.

- Web, Mobile and desktop Application
- Cloud
- Microservices

## .NET vs .NET Framework
|.NET|.NET Framework|
|:---:|:---:|
|Runs on Linux, macOS, Windows|Only runs on Windows|
|Open-source & accepts contributions from community|Source code available but does not accept contributions|
|All the innovation happens here! Supports more application types and delivers higher performance|Security & reliability bug fixes only|
|Not shipped with operating system|Included in Windwos & updated by Windows updates|
|**Recommended for new development**||

.NET framework 는 MS 초기의 상품이고, .NET은 현대화된 버전이다.

버전 정보를 봤을 때 4.8.1 버전 이하이면 .NET Framekwork 이고, 5 버전 이상이면 .NET 이다

간단한 코드

```cs
Console.WriteLine("What is your name?");
var name = Console.ReadLine();
var currentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Hello, {name}, it's {currentDate:d}!");
Console.Write($"{Environment.NewLine}Press any key to exit...");
Console.ReadKey(true); // true 사용 시 누른 키는 출력되지 않음
```

## 프로젝트에 패키지 추가하기
.NET의 패키지 매니져인 Nuget(누겟)을 사용한다.

공식 홈페이지(https://www.nuget.org/)

npm과 같이 인스톨 코드를 제공한다.

예시) `dotnet add package PasswordGenerator --version 2.1.0`

코드를 복사한 후 터미널을 켜고 프로젝트 폴더 경로에서 실행한다.

설치한 패키지를 사용해보자.

```cs
using PasswordGenerator;

var pwd = new Password();
var password = pwd.Next();
Console.WriteLine(password);

var passwords = pwd.NextGroup(10);
foreach (var p in passwords) {
    Console.WriteLine(p.ToString());
}
```

<br>

---

<br>

# ASP.NET
What is ASP.NET?

> Open-source Web Framework for building fast and secure web apps and services within .NET
>
> Cross-platform service. You can build ASP.NET web apps on any operating system.
>
> 써드파티 앱(MS, Google, Twitter, ...)을 사용해 사이트 인증을 구현할 수도 있다.
>
> You can make your web pages with a language called razor(Just HTML and C#). ASP.NET and Visual Studio, .NET is all Free.


Visual Studio를 이용해 프로젝트를 생성해보자.

## 프로젝트 생성
비쥬얼 스튜디오 실행

새 프로젝트 만들기

템플릿은 ASP.NET Core 웹앱

Visual Studio 같은 단어 선택은 `Shift + Alt + .`
