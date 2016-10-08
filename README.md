# EpicU4-VioletteAllahham

# Cheat Sheet

Basic
-----------------
Line break within text - "< br/>" with no spaces

Data Types (CS-ASP_007)
-----------------------
Comments: // Single line..... /* Multiline */

string => alphanumeric (defaults to "")
int => 2 billion to -2 billion (defaults to 0)
double => fractional value (defaults to 0.0)
bool => true or false (defaults to false)

For more data types: http://is.gd/data_types


Data Type Conversion (CS-ASP_008)
---------------------------------
Implicit conversions- smaller type to larger type
witout data loss, "upcasting"

Explicit conversions- require developer intervention, 
possiblility of data loss, "downcasting", either in
the form of cast or using helper method

Casting numbers:
int myInteger - (int)myDouble;

Numbers to strings:
string myString = myInteger.ToString();

String to Numbers: 
int myInteger = int.Parse(myString);

More: http://is.gd/datatype_conversion

Arithmetic Operators (CS-ASP_009)
----------------------------------
= NOT equality, it's assignment

Math Operators: + - * /

Addition Assignment
total = total + 5;
total += 5;

Increment Operator: ++
Decrement Operator: --

Beware of order of precedence (use parenthesis)
Beware of down casting (lose percision)
Beware of overflow (use bigger types)

To make overflow throw an exception:

checked
{
  //some arithmetic operation
  //that could potentially overflow
}

C# Syntax (CS-ASP_010)
------------------------------
Operands - variable names, object / server control names, literals - "Nouns" (you name these)

Operators - "Verbs"..... they act as operands.

http://is.gd/operators

Expressions - One or More operands and zero or more
operators that evaluate to a single value

http://is.gd/expressions

Statements - Acomplete instrucution - assignment of an
expression to a variable, an increments/ decrement, etc.

http:/is.gd/statement

Statements must end in a semi-colon  ;
Whitespace is ignored (used for humans)

http://421-violette.vm.epicservers.com/SimpleCalc/

Conditional if... else if ... else Statement (CS-ASP_011)
-----------------------------------------------------------

= Assignments
== Equality

if(a == b)
{
  // execute when the expression is true
}
else
{
  // execute when the expression is false
}

... or ... evaluate other mutually exclusively options:

if (a == b) { //some code}
else if (a == c) { //some code}
else if (a == d) { //some code}
else { //catch all}

CheckBox Server Control = Checked prop is bool

RadioButton Server Control = GropupName prop groups
them together, check prop is bool

** Not Equal - !=


Conditional Ternary Operator (CS-ASP_012)
-----------------------------------------
Shortcut for evaluatating an expression and 
returning a result
result = (a == b) ? "Equal" : "Not Equal";

Comparison and Logical Operator (CS-ASP_013)
--------------------------------------------------
Comparison Operators
used for conditional statements
==
!=
< >
<= >=
!someBooleanValue - means NOT is true

Logical Operators
used to combine multiple expressions / evaluation

&& - AND
|| - OR

Combine with parenthesis ( ) for order of precedence

Working with Dates and Times (CS-ASP_014)
------------------------------------------
Creating new DateTime objects
DateTime myDateTime = DateTime.Now;
DateTime myDateTime = DateTime("12/7/1969");

Formatting .... many options:
myDateTime.To_____()

Retrieving Parts:
myDateTime.Year // int
myDateTime.Hour // int
myDateTime.DayOfWeek // "Monday"
myDateTime.DayOfYear // int 175

DateTime Math:
myDateTime.AddHour(3)
myDateTime.AddMinute(-5)

"Chaining" - using multiple helper methods
together with the dot. operator
myDateTime.AddHour(3).AddMinute(-5).ToString();

Working with Spans of Time (CS-ASP_015)
--------------------------------------------

Create and initialize new TimeSpans

// Days.Hours:Minutes:Seconds.Milliseconds
TimeSpan myTimeSpan = TimeSpan.Parse("1.2:3:30.5");  // rarely used

DateTime myBirthday = DateTime.Parse("07/05/1995");
TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

More info at http:/is.gd/timespan

Get individual parts
myAge.Hours
myAge.Seconds

... or get Total elapsed time 
as a double representing both the
number of days / hours / etc.
AND fractional values representing
"left overs".

myTimeSpan.TotalDays // double
myTimeSpan.TotalHours // double

Formatting Strings (CS-ASP_019)
---------------------------------------
Concatenate Strings
+ +=

Format Strings
String.Format("Hello {0}", You are from {1}", "Bob", "Chicago")

Format Numbers
String.Format("Reference Code: {0:000_000-0}", 1234567)
Output: 123_456-7

Formatting Dates
http://is.gd/formattingdates
String.Format("Reference Date: {0:ddd - d, MM, YYY}", someDate)
Output: Tue - 5, 07, 2014

Formatting Currency
http://is.gd/formattingcurrency

String.Format("Total: {0:C}", totalAmount);
$50,000,.00

http://421-violette.vm.epicservers.com/EpicSpies/

Sinbgle Dimensional Arrays (CS-ASP_021)
-------------------------------------------
Indexes vs. Elements
Accessor vs. Stored Values
Indexes are zero based

Declaring Arrays
string[] myArray = new string[3];

Declaring and Initializing Arrays
string[] myArray = new string[3] {"Moe", "Larry", "Curly", "Shemp"}

Setting / Getting Values
string myString = myArray[1]; // Retrieves second element
myArray[0] = myString; //Sets first element of the array

Multi-Dimensional Arrays (CS-ASP_022)
----------------------------------------------
Same as single dimensional.... just requires
more indexes (in dimensions) to get the element

double[,] myArray = new double[2, 3]; // contains 6 elements
int[,,] rubicsCube = new int[3,3,3] // contains 27 elements

rubicsCube[0,1,2] = 42;
myInteger = rubicsCube[0,1,2];

Changning the Length of an Array (CS-ASP_023)
-------------------------------------------------------
Arrays are Immutable - Cannot be changed in memory
HOWEVER the .NET Framework provides helper methods to
resize and array.... creates a new array and copies
the old values into it.

Array.Resize(ref myArray, myArray.Length + 1);

// Get the highest index:
int highestIndex = myArray.GetUpperBound(0);
// 0 - dimention we want to retrieve the
// upper boundary for

// Arrays have other helper methods
myArray.Sum()
myArray.Min()
myArray.Max()
myArray.Average()
myArray.Sort()
myArray.Reverse()

Array.Sort(myArray)
Array.Reverse(myArray)

Looping With the for Interation Statement (CS-ASP_026)
------------------------------------------------------

Snippet: for [tab] [tab]
Tab through the replacebale bits, hit enter to start
writing code in the code block body

for(int i = 0; i < 10; i++)
{
  //Your code
}

i - any variable name

1st part - counter declaration, can be initialized to any number
2nd part - condition, can be any expression that equates to a bool
3rd part - increment i++ / decrement i--, can step more than 1 using +=

string[] names = new string[] {"Wolverine", "Cyclops", "Professor X", "Pheonix"};

for (int = i; i < names.Length; i++)
{
  //Cna search for a specific value
  if (names[i] == "Professor X")
  {
    // Do something
    //Can break out of additional iterations if you need to
    break;
    }
}

Looping with the while and do... while Iteration Statements (CS-ASP_027)
---------------------------------------------------------------------------
Random random = new Random();
// random.Next(lowerBounds, upperBounds)
random.Next(1, 100); // returns a value between 1 and 100

// If someExpression is already false, this will never execute
while(someExpression)
{
  // Code that would affect whether
  // someExpression is true or false
}

do
{
  //Code that would affect whether someExpression is true or false
} while(someExpression)
  
Creating Overloaded Methods (CS-ASP_031)
-----------------------------------------------
Different METHOD SIGNATURE, but same basic function.
METHOD SIGNATURE... the number and type of parameters
Can have different return types.

Creating Optional Parameters (CS-ASP_032)
--------------------------------------------------
Otional parameters provide default values when you define
the method. So, if you dont supply a value, the default
will be used.

private void myMethod(string myRequiredParam,
                      int myOptionalParam = 1
                      int myOtherOptionalParam = 5);
                      
// Can be called ....
myMethod("Hello Required Param!");

//or...
myMethod("Required Param!", 100);

//or...
myMethod("Required Param!", 100, 500);

//You cannot skip an optional parameter:
myMethod("Required Param!" , , 500);  //ERROR


Passing Named Arguments Into Input Parameters (CS-ASP_033)
--------------------------------------------------------------
Allow us to send in Parameter arguments OUT OF ORDER!
We just prefix the input parameter argument with the name
of the parameter we're passing in, a colon, then the value:

myMethod(myOtherOptionalParam: 500,
        myRequiredParam: "Required aram",
        myOptionalParam: 100);
      
// You still have to pass in REQUIRED parameters.


Creating Methods with Output Parameters (CS-ASP_034)
---------------------------------------------------------
Allows us to return a value the normal way AND return a value
via a method parameter:

private bool myMethod(string myRequiredParam,
                      out int myOptionalParam) {}
                      
int myValue = 0;
if (myMethod("Some required text", out myValue)) return "Hello World!";


**************


Introduction to Classes and Objects (CS-ASP_036)
-----------------------------------------------------
Class is a code block that defines a data type.
An object is an instance of a class.
Metaphors:
Blueprint vs. Houses
Recipe vs. Cupcakes
Pattern vs. ***************

Creating Class Files, Creating Cohesive Classes and Code Navigation (CS-ASP_037)
------------------------------------------------------------------------------------
Prefer more classes w/ narrowly defined responsibilities
Prefer to put each class in it's own file
Prefer high cohesion - similarity/ singleness of purpose of he class members
To achieve high cohesion, a rule of thumb: try to make your classes fit on one
"screen" of your IDE (no scrolling required)

Understanding Object References and Object Lifetime (CS-ASP_038)
-------------------------------------------------------------------
An object reference variable holds a reference to an instantiated object
in the computer's memory.

MyClass my Object;

The new keyword creates an instance of the class and returns the address of
object in memory to the reference variable.

myObject = new MyClass();

More than one object reference variable can hold an address to the object in memory.

MyClass myOtherObjectReference = myObject;

Each time a new reference is added, the reference count increases by one. Each time
and object reference variable goes out of scope or is set to null, the reference
count decreases by one.

If the reference count is zero, the .NET Framework Runtime's Garbage Collector
removes the object from memory at an indeterminate point in the time in the future. You
can take control of the finalization process and even handle events just before the
object is removed. See: "deterministic finalization".

Understanding the .NET Framework and Compilation (CS-ASP_039)
-------------------------------------------------------------------
The .NET Framework consists of:

- Runtime (Common Language Runtimre, CLR) "protective bubble", manages memory,
protects the user's machine, etc.

- .NET Framework Class Library (FCL, Base Class Library, BCL) - thousands
of classes built by Microsoft for every imaginable purpose.

- Compilers (C# compiler, VB compiler) - turns your human readable source code into
Microsoft Intermediate Language (MSIL, IL) and packaged into a .NET assembly
(.exe - executable, or .dll - class library)

- Many other tools and features

Initial compilation to Intermediate Language, the a second compilation
JIT - Just In Time compilation - an optimized version of the assembly for the specific
hardware and softeware. Happens at first request on that computer.

Understanding Namespaces anbd the unsing Directive (CS-ASP_040)
-----------------------------------------------------------------------
Namesspaces organize class names inside of class libraries or applications.

You must reference class names by their full names:
System.Text.Stringbuilder sb = new System.Text.StringBuilder();

.... or, you can employ a unsing directive at the top of the code file to instruct 
the compiler to look in those **********************

StringBuilder sb = new StringBuilder();

You must always do this if the code you're writing is outside of
the namespace of the class you want to use, even if it's in the same
project.

Default namespace defined in Project Properties (right-clicking on
Project name in Solution Explorer, select Properties...)

Creating Class Libraries and Adding Reference to Assemblies (CS-ASP 041)
------------------------------------------------------------------------
Class Library project - creates a .dll that can be referenced in other projects.

Add a Reference - the FCL is split into tiny pieces, and you must reference
the assemblies that contain the parts of the library you want to use.

Right-click project's Reference node in Solution Explorer, select Add Reference

Accessibility Modifiers, Fields and Properties (CS-ASP_042)
---------------------------------------------------------------
http://v.gd/access

Public - Class or member can be accessed by any code
Private - Class or member can only be accessed by parent class
Protected - Class or member can only be accessed by parent class or derived class
Internal - Class or member can only be accessed by code inside the same assembly

Classes are internal by default
Methods and properties are private by default

Encapsulation - hiding implementation behind public interfaces, reduces coupling
increases plug-ability / reusability, maintainability, etc.

private fields have two purposes:
(1) reference to object or variable that used for internal implementation of class
(2) hold the state of an object, backing field for public property

propfull [tab] [tab]

private int myField;
property int MyProperty
{
  get{return myField;}                
  set
  {
     if (value > 100)                   //Do not put business logic in property
        myField = value;
      else
         //Tell the caller that they can't do this
         
   }
}

Full property definition and private fields to control
access to private fields / state of the object.

propg [tab] [tab]

public int MyPropery {get; private set;}

Restricts setting of property to just the class' internal implementation

Creating Constructor Methods (CS-ASP_043)
-------------------------------------------------
Constructors are called at the moment of instantiation.
Used to put the new instnace of the class into a valid state.

public class Foo
{
  public Foo()
  {
  
  }
}

Whether you define it or not, there's a default constructor.
You can override the default (no input perameters) or
overload the constructor to allow the user to set the new instance to a valid state.

Naming Conventions for Identifiers (CS-ASP_044)
----------------------------------------------------
PascalCase - public
camelCase - private, protected

Public classes, methods and properties - PascalCase
Private helper methods, input parameters - camelCase
Locally scooped variables - camelCase
Private field - camelCaswe prefixed w/ underscore: -firstName

Choose long, memorable, undertandable names
that convey meaning / intent

Static vs Instance Members (CS-ASP_045)
-----------------------------------------------
Static Members - no instance of the class required to call the method

Instance member - must create an instance w/ new keyword to call the
methods and properties

Can mix in the same class, but can't reference instance 
members from inside of static members.

Classes can be decorated w/ static keyword - all members
must be static, can't create an instance of the class.

Ex: System.Math

http://v.gd/static

Working With the List Colection (CS-ASP_046)
----------------------------------------------
Use Generic Collections to work with items in a strongly typed fashion.

Better than arrays:
Know the type of the item for a certainty, no casting/ converting
Better performace inserting / removing / updating
Collections provide more flexible options to access items in the collection.
Allows for LINQ extension methods

Many different collections - specialties

"Generic Collections"
List<T>
Dictionary<TKey, TValue>
T = > data type you need
"You make a generic specific by providing a data type."

List<string> - only stores strings in list (strong typed)
List<Car> - only stores Cars in that collection

// Assume I have three objects: car1, car2, car3
List<Car> cars = new List<Car>();
cars.Add(car1);
cars.Add(car2);
cars.Add(car3);

int numberOfCars = cars.Count;
Car myCar = cars.ElementAt(1); // Return 2nd car in the collection

// Terminology: You access a MEMBER of a collection

// LINQ queries

Object Initializers (CS-ASP_047)
------------------------------------
Concise way to initialize a new object (or collection) with vaues.

//. Didn't talk about this form:

Car car1 = new Car() {Make = "BMW", Model = "528i", Year = 2010, Color = "Black"};

//No local variable name for the new Car ninstance needed!
cars.Add(new Car() {Make = "BMW", Model = "528i", Year = 2010, Color = "Black"});

Collection Initializers (CS-ASP_048)
---------------------------------------
Shortcut to create a new instance of a genreic collection AND initialize it by
IMMEDIATELY adding new instances of a given type.

List<Car> cars = new List<CAR>()
{
  new Car {Make = "BMW", Model = "528i", Year = 2010, Color = "Black"},
  new Car {Make = "BMW", Model = "745i", Year = 2005, Color = "White"},
  new Car {Make = "BMW", Model = "528i", Year = 2010, Color = "Black"}
 };
 
 Working with the Dictionary<TKey, TValue> Collection (CS-ASP_049)
 -----------------------------------------------------------------
 Dictionary allows you to use a key to access a member of the collection.
 Think: Webster's dictionary ... the word (key), then the definition (instance of a given type)
 Key is anything meaningful in YOUR system.
 Key must be unique.
 
 TKey = > type of the key
 TValue = > type of the value
 
 Dictionary<string, Car> cars = new Dictionary<string, Car>();
 cars.Add("V123", new Car{Make = "BMW", Model = "528i", Year = 2010, Color = "Black"});
 cars.Add("V234", new Car{Make = "BMW", Model = "745i", Year = 2005, Color = "White"});
 
 cars.ElementAt(1).Key //Return "V234"
 cars.ElementAt(1).Value // Return the Car object in the 2nd position
 
 //Better way to access Dictionary ...
 Car v2;
 if (cars.TryGetValue("V234" , out v2))
 {
  result += v2.Year;
 }
 
 //Remove
 if (cars.Remove("V345"))
 {
  result += "Successfully removed car.";
 }
 
 Looping with the foreach Iteration Statement (CS-ASP_050)
 ------------------------------------------------------------
 More elegant way of iterating through collections.
 
 Code Snippet: foreach[tab] [tab]
 
 foreach (Car car in cars)
 {
  result += car.Make;
 }
 
 Implicitly Typed Local Variables with the var Keyword (CS-ASP_051)
 -------------------------------------------------------------------
 (Applies to locally scoped variable declarions)
 Compiler is smart enought to figure out the data type when you initialize the variable.
 Becomes increasingly important because sometimes it is difficult to know what the data
 type is supposed to be. (LINQ)
 
 int hitPoints = 0;
 .... same as ....
 var hitPoints = 0;
 
 //Can also be applied to complex things
 
 Rules:
 1. Must initialize the variable.
 2. Variable is permanently set to the implicit data type.
 3. Can't be used for a PUBLIC property / variable. (only for locally scoped variables)
 
 
 


