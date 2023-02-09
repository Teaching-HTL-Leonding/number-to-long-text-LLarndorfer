//Selection
System.Console.WriteLine("Pick your selection: (0) DigitIntoLongText, (2) NumberIntoLongText");
int selection = int.Parse(Console.ReadLine()!);

#region level0
int leftDigit = 0;
string DigitIntoLongText(int number)
{
    switch (number)
    {
        case 0: return "zero";
        case 1: return "one";
        case 2: return "two";
        case 3: return "three";
        case 4: return "four";
        case 5: return "five";
        case 6: return "six";
        case 7: return "seven";
        case 8: return "eight";
        case 9: return "nine";
        default: return "not a digit";
    }
}
#endregion


#region Level1
string NumberIntoLongText(int number)
{
    if (number < 10) { return DigitIntoLongText(number); }
    if (number < 20)
{    switch (number)
    {
        case 10: return "ten";
        case 11: return "eleven";
        case 12: return "twelve";
        case 13: return "thirteen";
        case 14: return $"{DigitIntoLongText(4)}";
        case 15: return "fifteen";
        case 16: return $"{DigitIntoLongText(6)}teen";
        case 17: return $"{DigitIntoLongText(7)}teen";
        case 18: return "eighteen";
        case 19: return $"{DigitIntoLongText(9)}teen";
        case 20: return "twenty";
        default: return $"{DigitIntoLongText(number % 10)}teen";
    }}

int leftDigit = number / 10;
int rightDigit = number % 10;
string result;
result = leftDigit switch
    {
        2 => "twenty",
        3 => "thirty",
        4 => "forty",
        5 => "fifty",
        6 => "sixty",
        7 => "seventy",
        8 => "eighty",
        9 => "ninety",
        _ => "not a number"
    };
    if (rightDigit != 0)
    {
        result += DigitIntoLongText(rightDigit);
    }


return result;
}





#region Main progam
    // Helper variable so store the user's input
string input;
do 
{
    System.Console.WriteLine("Please enter a number: ");
    input = Console.ReadLine()!;
    if (input == "quit")
    {
        return; // or just break;
    }

    int value = int.Parse(input);
    string result = DigitIntoLongText(value);
    System.Console.WriteLine(result);


System.Console.WriteLine(NumberIntoLongText(int.Parse(input)));}
while (true);
#endregion

#endregion

