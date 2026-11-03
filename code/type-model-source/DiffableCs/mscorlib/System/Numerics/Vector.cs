namespace System.Numerics;

[Intrinsic]
[Token(Token = "0x200053B")]
public static class Vector
{

	[Token(Token = "0x17000534")]
	public static bool IsHardwareAccelerated
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Intrinsic]
		[Token(Token = "0x60025EB")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x9E4310", Offset = "0x9E3710", Length = "0x8B")]
	[CLSCompliant(False)]
	[Token(Token = "0x60025EC")]
	public static Vector<UInt64> AsVectorUInt64(Vector<T> value) { }

	[Address(RVA = "0x9E4450", Offset = "0x9E3850", Length = "0xA6")]
	[Token(Token = "0x60025EA")]
	public static Vector<T> Equals(Vector<T> left, Vector<T> right) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Intrinsic]
	[Token(Token = "0x60025EB")]
	public static bool get_IsHardwareAccelerated() { }

}

