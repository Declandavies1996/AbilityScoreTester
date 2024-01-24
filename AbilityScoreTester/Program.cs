using AbilityScoreTester;

AbilityScoreCalculator calculator = new AbilityScoreCalculator();
while (true)
{
    calculator.RollResult = ReadResponses.ReadInt(calculator.RollResult, "Starting 4d6 roll");
    calculator.DivideBy = ReadResponses.ReadDouble(calculator.DivideBy, "Divide by");
    calculator.AddAmount = ReadResponses.ReadInt(calculator.AddAmount, "Add amount");
    calculator.Minimum = ReadResponses.ReadInt(calculator.Minimum, "Minimum");
    calculator.CalculateAbilityScore();
    Console.WriteLine("Calculated ability score: " + calculator.Score);
    Console.WriteLine("Press Q to quit, any other key to continue");
    char keyChar = Console.ReadKey(true).KeyChar;
    if ((keyChar == 'Q') || (keyChar == 'q')) return;
}

