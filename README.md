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

