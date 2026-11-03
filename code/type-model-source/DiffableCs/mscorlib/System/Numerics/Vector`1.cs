namespace System.Numerics;

[DefaultMember("Item")]
[Intrinsic]
[Token(Token = "0x2000539")]
public struct Vector : IEquatable<Vector`1<T>>, IFormattable
{
	[Token(Token = "0x200053A")]
	private struct VectorSizeHelper
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40014EB")]
		internal Vector<T> _placeholder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40014EC")]
		internal byte _byte; //Field offset: 0x0

	}

	[Token(Token = "0x40014E7")]
	private static readonly int s_count; //Field offset: 0x0
	[Token(Token = "0x40014E8")]
	private static readonly Vector<T> s_zero; //Field offset: 0x0
	[Token(Token = "0x40014E9")]
	private static readonly Vector<T> s_one; //Field offset: 0x0
	[Token(Token = "0x40014EA")]
	private static readonly Vector<T> s_allOnes; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40014E6")]
	private Register register; //Field offset: 0x0

	[Token(Token = "0x17000531")]
	public static int Count
	{
		[Address(RVA = "0x13EC590", Offset = "0x13EB990", Length = "0x97")]
		[Intrinsic]
		[Token(Token = "0x60025D5")]
		 get { } //Length: 151
	}

	[Token(Token = "0x17000533")]
	public T Item
	{
		[Address(RVA = "0x13EC630", Offset = "0x13EBA30", Length = "0xA5E")]
		[Intrinsic]
		[Token(Token = "0x60025DC")]
		 get { } //Length: 2654
	}

	[Token(Token = "0x17000532")]
	public static Vector<T> Zero
	{
		[Address(RVA = "0x13ED090", Offset = "0x13EC490", Length = "0x9F")]
		[Intrinsic]
		[Token(Token = "0x60025D6")]
		 get { } //Length: 159
	}

	[Address(RVA = "0x13E8A20", Offset = "0x13E7E20", Length = "0x1FD")]
	[Token(Token = "0x60025E9")]
	private static Vector`1() { }

	[Address(RVA = "0x13E9860", Offset = "0x13E8C60", Length = "0x2D26")]
	[Intrinsic]
	[Token(Token = "0x60025D8")]
	public Vector`1(T value) { }

	[Address(RVA = "0x13E8C20", Offset = "0x13E8020", Length = "0x97")]
	[Token(Token = "0x60025D9")]
	internal Vector`1(Void* dataPointer) { }

	[Address(RVA = "0x13E8CC0", Offset = "0x13E80C0", Length = "0xB97")]
	[Token(Token = "0x60025DA")]
	internal Vector`1(Void* dataPointer, int offset) { }

	[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
	[Token(Token = "0x60025DB")]
	private Vector`1(ref Register existingRegister) { }

	[Address(RVA = "0x13E34A0", Offset = "0x13E28A0", Length = "0x230E")]
	[Intrinsic]
	[Token(Token = "0x60025E5")]
	internal static Vector<T> Equals(Vector<T> left, Vector<T> right) { }

	[Address(RVA = "0x13E57B0", Offset = "0x13E4BB0", Length = "0x7B5")]
	[Intrinsic]
	[Token(Token = "0x60025DE")]
	public override bool Equals(Vector<T> other) { }

	[Address(RVA = "0x13CFED0", Offset = "0x13CF2D0", Length = "0x156")]
	[Token(Token = "0x60025DD")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x13EC590", Offset = "0x13EB990", Length = "0x97")]
	[Intrinsic]
	[Token(Token = "0x60025D5")]
	public static int get_Count() { }

	[Address(RVA = "0x13EC630", Offset = "0x13EBA30", Length = "0xA5E")]
	[Intrinsic]
	[Token(Token = "0x60025DC")]
	public T get_Item(int index) { }

	[Address(RVA = "0x13ED090", Offset = "0x13EC490", Length = "0x9F")]
	[Intrinsic]
	[Token(Token = "0x60025D6")]
	public static Vector<T> get_Zero() { }

	[Address(RVA = "0x13D0030", Offset = "0x13CF430", Length = "0x972")]
	[Token(Token = "0x60025E8")]
	private static T GetAllBitsSetValue() { }

	[Address(RVA = "0x13E5F70", Offset = "0x13E5370", Length = "0x2113")]
	[Token(Token = "0x60025DF")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x13D09B0", Offset = "0x13CFDB0", Length = "0x96A")]
	[Token(Token = "0x60025E7")]
	private static T GetOneValue() { }

	[Address(RVA = "0x13E8090", Offset = "0x13E7490", Length = "0x4A5")]
	[Token(Token = "0x60025D7")]
	private static int InitializeCount() { }

	[Address(RVA = "0x13ED130", Offset = "0x13EC530", Length = "0x9F")]
	[Token(Token = "0x60025E2")]
	public static bool op_Equality(Vector<T> left, Vector<T> right) { }

	[Address(RVA = "0x13ED1D0", Offset = "0x13EC5D0", Length = "0x52")]
	[CLSCompliant(False)]
	[Intrinsic]
	[Token(Token = "0x60025E4")]
	public static Vector<UInt64> op_Explicit(Vector<T> value) { }

	[Address(RVA = "0x13ED230", Offset = "0x13EC630", Length = "0x10D")]
	[Token(Token = "0x60025E3")]
	public static bool op_Inequality(Vector<T> left, Vector<T> right) { }

	[Address(RVA = "0x9DF2C0", Offset = "0x9DE6C0", Length = "0xCA9")]
	[Token(Token = "0x60025E6")]
	private static bool ScalarEquals(T left, T right) { }

	[Address(RVA = "0x13E8540", Offset = "0x13E7940", Length = "0xDF")]
	[Token(Token = "0x60025E0")]
	public virtual string ToString() { }

	[Address(RVA = "0x13E8620", Offset = "0x13E7A20", Length = "0x3FF")]
	[Token(Token = "0x60025E1")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

