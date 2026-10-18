using Extension_Methods;

Console.WriteLine("Hello, World!");

Console.WriteLine("=== Testing Egyptian Phone Numbers ===");
Console.WriteLine($"01012345678    -> {"01012345678".IsValidEgyptianPhone()}"); // Expected: True
Console.WriteLine($"+201112345678  -> {"+201112345678".IsValidEgyptianPhone()}"); // Expected: True
Console.WriteLine($"01912345678    -> {"01912345678".IsValidEgyptianPhone()}"); // Expected: False (invalid prefix)
Console.WriteLine($"0101234567     -> {"0101234567".IsValidEgyptianPhone()}"); // Expected: False (only 10 digits)

Console.WriteLine("\n=== Testing Egyptian National IDs ===");
Console.WriteLine($"29901011234567 -> {"29901011234567".IsValidEgyptianNationalId()}"); // Expected: True (starts with 2)
Console.WriteLine($"30501011234567 -> {"30501011234567".IsValidEgyptianNationalId()}"); // Expected: True (starts with 3)
Console.WriteLine($"40501011234567 -> {"40501011234567".IsValidEgyptianNationalId()}"); // Expected: False (starts with 4)
Console.WriteLine($"2990101123456  -> {"2990101123456".IsValidEgyptianNationalId()}"); // Expected: False (only 13 digits)