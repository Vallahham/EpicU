# EpicU4-VioletteAllahham

# Cheat Sheet

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
