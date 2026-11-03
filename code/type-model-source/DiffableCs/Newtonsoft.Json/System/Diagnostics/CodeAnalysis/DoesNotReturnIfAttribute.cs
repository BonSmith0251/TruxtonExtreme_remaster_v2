namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets::Parameter (2048), Inherited = False)]
[Token(Token = "0x200000A")]
internal class DoesNotReturnIfAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000004")]
	private readonly bool <ParameterValue>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000002")]
	public bool ParameterValue
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600000C")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1F31920", Offset = "0x1F30D20", Length = "0x26")]
	[Token(Token = "0x600000B")]
	public DoesNotReturnIfAttribute(bool parameterValue) { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600000C")]
	public bool get_ParameterValue() { }

}

