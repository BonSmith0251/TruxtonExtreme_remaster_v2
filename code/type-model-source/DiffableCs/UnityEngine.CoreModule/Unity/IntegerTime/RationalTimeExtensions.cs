namespace Unity.IntegerTime;

[Extension]
[Token(Token = "0x2000022")]
public static class RationalTimeExtensions
{

	[Address(RVA = "0x2FE5510", Offset = "0x2FE4910", Length = "0x55")]
	[Extension]
	[FreeFunction("IntegerTime::RationalTime::ConvertRate", IsFreeFunction = True, ThrowsException = True)]
	[Token(Token = "0x600006A")]
	public static RationalTime Convert(RationalTime time, TicksPerSecond rate) { }

	[Address(RVA = "0x2FE54B0", Offset = "0x2FE48B0", Length = "0x52")]
	[Token(Token = "0x600006B")]
	private static void Convert_Injected(in RationalTime time, in TicksPerSecond rate, out RationalTime ret) { }

}

