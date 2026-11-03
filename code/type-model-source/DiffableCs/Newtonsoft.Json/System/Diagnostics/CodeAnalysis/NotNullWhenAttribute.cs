namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets::Parameter (2048), AllowMultiple = False)]
[Token(Token = "0x2000007")]
internal sealed class NotNullWhenAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000003")]
	private readonly bool <ReturnValue>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000001")]
	public bool ReturnValue
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000008")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1F31920", Offset = "0x1F30D20", Length = "0x26")]
	[Token(Token = "0x6000007")]
	public NotNullWhenAttribute(bool returnValue) { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000008")]
	public bool get_ReturnValue() { }

}

