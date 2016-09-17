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



