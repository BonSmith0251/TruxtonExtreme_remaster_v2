namespace System.Threading;

[Token(Token = "0x200024E")]
public static class Volatile
{
	[Token(Token = "0x200024F")]
	private struct VolatileBoolean
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A9E")]
		public bool Value; //Field offset: 0x0

	}

	[Token(Token = "0x2000250")]
	private struct VolatileInt32
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A9F")]
		public int Value; //Field offset: 0x0

	}

	[Token(Token = "0x2000251")]
	private struct VolatileObject
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AA0")]
		public object Value; //Field offset: 0x0

	}


	[Address(RVA = "0x20C5240", Offset = "0x20C4640", Length = "0x17")]
	[Intrinsic]
	[Token(Token = "0x6001394")]
	public static bool Read(ref bool location) { }

	[Address(RVA = "0x20C5220", Offset = "0x20C4620", Length = "0x15")]
	[Intrinsic]
	[Token(Token = "0x6001396")]
	public static int Read(ref int location) { }

	[Address(RVA = "0x9E5970", Offset = "0x9E4D70", Length = "0x17")]
	[Intrinsic]
	[Token(Token = "0x6001398")]
	public static T Read(ref T location) { }

	[Address(RVA = "0x20C5290", Offset = "0x20C4690", Length = "0x23")]
	[Intrinsic]
	[Token(Token = "0x6001395")]
	public static void Write(ref bool location, bool value) { }

	[Address(RVA = "0x20C5260", Offset = "0x20C4660", Length = "0x21")]
	[Intrinsic]
	[Token(Token = "0x6001397")]
	public static void Write(ref int location, int value) { }

	[Address(RVA = "0x9E5990", Offset = "0x9E4D90", Length = "0x2D")]
	[Intrinsic]
	[Token(Token = "0x6001399")]
	public static void Write(ref T location, T value) { }

}

