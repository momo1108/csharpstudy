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
> <a href="https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators" target="_blank">https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators</a>