namespace System.Runtime.Serialization;

[AttributeUsage(28, Inherited = False, AllowMultiple = False)]
[Token(Token = "0x2000002")]
public sealed class DataContractAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000001")]
	private bool isReference; //Field offset: 0x10

	[Token(Token = "0x17000001")]
	public bool IsReference
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x6000001")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x6000001")]
	public bool get_IsReference() { }

}

