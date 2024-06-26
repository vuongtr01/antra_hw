// See https://aka.ms/new-console-template for more information


////// q1
// string[] typeNames = {"sbyte"," byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal" };
// int[] bytesInMemory = {1, 1, 2, 2, 4, 4, 8, 8, 4, 8, 16};
// string[] minValues =
// {
//     sbyte.MinValue.ToString(), byte.MinValue.ToString(), short.MinValue.ToString(), ushort.MinValue.ToString(), int.MinValue.ToString(),
//     uint.MinValue.ToString(), long.MinValue.ToString(), ulong.MinValue.ToString(), float.MinValue.ToString(), double.MinValue.ToString(),
//     decimal.MinValue.ToString()
// };
// string[] maxValues =
// {
//     sbyte.MaxValue.ToString(), byte.MaxValue.ToString(), short.MaxValue.ToString(), ushort.MaxValue.ToString(),
//     int.MaxValue.ToString(), uint.MaxValue.ToString(), long.MaxValue.ToString(), ulong.MaxValue.ToString(), float.MaxValue.ToString(),
//     double.MaxValue.ToString(), decimal.MaxValue.ToString()
// };
//
// Console.WriteLine("{0,-10} {1,5} {2, 35} {3, 35}\n", "Type", "BIM", "min Value", "max Value" );
//
// for (int i = 0; i < typeNames.Length; i++)
// {
//     Console.WriteLine("{0,-10} {1,5} {2, 35} {3, 35}\n", typeNames[i], bytesInMemory[i], minValues[i], maxValues[i] );
// }




/////q2
Console.Write("Enter number of centuries: ");
byte centuries = byte.Parse(Console.ReadLine());
ushort years = (ushort) (centuries * 100);
uint days = (uint)(centuries * 36524);
uint hours = (uint)(centuries * 876576);
uint minutes = (uint) (centuries * 52594560);
long seconds = centuries * 3155673600;
long miliseconds = centuries * 3155673600000;
long microseconds = centuries * 3155673600000000;
ulong nanoseconds = (ulong)(centuries * 3155673600000000000);

Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} = microseconds = {nanoseconds} nanoseconds");