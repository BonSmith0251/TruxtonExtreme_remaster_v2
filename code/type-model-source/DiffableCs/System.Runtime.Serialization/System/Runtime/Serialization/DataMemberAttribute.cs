namespace System.Runtime.Serialization;

[AttributeUsage(384, Inherited = False, AllowMultiple = False)]
[Token(Token = "0x2000003")]
public sealed class DataMemberAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000002")]
	private string name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000003")]
	private int order; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000004")]
	private bool isRequired; //Field offset: 0x1C
	[FieldOffset(Offset = "0x1D")]
	[Token(Token = "0x4000005")]
	private bool emitDefaultValue; //Field offset: 0x1D

	[Token(Token = "0x17000005")]
	public bool EmitDefaultValue
	{
		[Address(RVA = "0x23ED910", Offset = "0x23ECD10", Length = "0x5")]
		[Token(Token = "0x6000005")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000004")]
	public bool IsRequired
	{
		[Address(RVA = "0xB0B7A0", Offset = "0xB0ABA0", Length = "0x5")]
		[Token(Token = "0x6000004")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000002")]
	public string Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000002")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000003")]
	public int Order
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000003")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x23ED910", Offset = "0x23ECD10", Length = "0x5")]
	[Token(Token = "0x6000005")]
	public bool get_EmitDefaultValue() { }

	[Address(RVA = "0xB0B7A0", Offset = "0xB0ABA0", Length = "0x5")]
	[Token(Token = "0x6000004")]
	public bool get_IsRequired() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000002")]
	public string get_Name() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000003")]
	public int get_Order() { }

}

