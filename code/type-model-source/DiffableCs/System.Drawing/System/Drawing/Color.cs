namespace System.Drawing;

[DebuggerDisplay("{NameAndARGBValue}")]
[IsReadOnly]
[Token(Token = "0x2000005")]
public struct Color : IEquatable<Color>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B3")]
	private readonly string name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000B4")]
	private readonly long value; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000B5")]
	private readonly short knownColor; //Field offset: 0x10
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x40000B6")]
	private readonly short state; //Field offset: 0x12

	[Token(Token = "0x17000004")]
	public byte A
	{
		[Address(RVA = "0x23DA8E0", Offset = "0x23D9CE0", Length = "0x14")]
		[Token(Token = "0x600000D")]
		 get { } //Length: 20
	}

	[Token(Token = "0x17000003")]
	public byte B
	{
		[Address(RVA = "0x23DA900", Offset = "0x23D9D00", Length = "0x7")]
		[Token(Token = "0x600000C")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000002")]
	public byte G
	{
		[Address(RVA = "0x23DA910", Offset = "0x23D9D10", Length = "0x14")]
		[Token(Token = "0x600000B")]
		 get { } //Length: 20
	}

	[Token(Token = "0x17000005")]
	public bool IsKnownColor
	{
		[Address(RVA = "0x23DA930", Offset = "0x23D9D30", Length = "0x7")]
		[Token(Token = "0x600000E")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000006")]
	public string Name
	{
		[Address(RVA = "0x23DA940", Offset = "0x23D9D40", Length = "0xF7")]
		[Token(Token = "0x600000F")]
		 get { } //Length: 247
	}

	[Token(Token = "0x17000001")]
	public byte R
	{
		[Address(RVA = "0x23DAA40", Offset = "0x23D9E40", Length = "0x14")]
		[Token(Token = "0x600000A")]
		 get { } //Length: 20
	}

	[Token(Token = "0x17000007")]
	private long Value
	{
		[Address(RVA = "0x23DAA60", Offset = "0x23D9E60", Length = "0xB6")]
		[Token(Token = "0x6000010")]
		private get { } //Length: 182
	}

	[Address(RVA = "0x23DA3E0", Offset = "0x23D97E0", Length = "0xF9")]
	[Token(Token = "0x6000013")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x23DA4E0", Offset = "0x23D98E0", Length = "0x9B")]
	[Token(Token = "0x6000014")]
	public override bool Equals(Color other) { }

	[Address(RVA = "0x23DA8E0", Offset = "0x23D9CE0", Length = "0x14")]
	[Token(Token = "0x600000D")]
	public byte get_A() { }

	[Address(RVA = "0x23DA900", Offset = "0x23D9D00", Length = "0x7")]
	[Token(Token = "0x600000C")]
	public byte get_B() { }

	[Address(RVA = "0x23DA910", Offset = "0x23D9D10", Length = "0x14")]
	[Token(Token = "0x600000B")]
	public byte get_G() { }

	[Address(RVA = "0x23DA930", Offset = "0x23D9D30", Length = "0x7")]
	[Token(Token = "0x600000E")]
	public bool get_IsKnownColor() { }

	[Address(RVA = "0x23DA940", Offset = "0x23D9D40", Length = "0xF7")]
	[Token(Token = "0x600000F")]
	public string get_Name() { }

	[Address(RVA = "0x23DAA40", Offset = "0x23D9E40", Length = "0x14")]
	[Token(Token = "0x600000A")]
	public byte get_R() { }

	[Address(RVA = "0x23DAA60", Offset = "0x23D9E60", Length = "0xB6")]
	[Token(Token = "0x6000010")]
	private long get_Value() { }

	[Address(RVA = "0x23DA580", Offset = "0x23D9980", Length = "0xDB")]
	[Token(Token = "0x6000015")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x23DAB20", Offset = "0x23D9F20", Length = "0x80")]
	[Token(Token = "0x6000012")]
	public static bool op_Equality(Color left, Color right) { }

	[Address(RVA = "0x23DA660", Offset = "0x23D9A60", Length = "0x270")]
	[Token(Token = "0x6000011")]
	public virtual string ToString() { }

}

