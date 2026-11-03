namespace Mono;

[Token(Token = "0x2000032")]
internal struct RuntimeGenericParamInfoHandle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000109")]
	private GenericParamInfo* value; //Field offset: 0x0

	[Token(Token = "0x17000008")]
	internal GenericParameterAttributes Attributes
	{
		[Address(RVA = "0x1E644B0", Offset = "0x1E638B0", Length = "0x1A")]
		[Token(Token = "0x6000053")]
		internal get { } //Length: 26
	}

	[Token(Token = "0x17000007")]
	internal Type[] Constraints
	{
		[Address(RVA = "0x1E644D0", Offset = "0x1E638D0", Length = "0x7")]
		[Token(Token = "0x6000052")]
		internal get { } //Length: 7
	}

	[Address(RVA = "0x1E64150", Offset = "0x1E63550", Length = "0x1F")]
	[Token(Token = "0x6000051")]
	internal RuntimeGenericParamInfoHandle(IntPtr ptr) { }

	[Address(RVA = "0x1E644B0", Offset = "0x1E638B0", Length = "0x1A")]
	[Token(Token = "0x6000053")]
	internal GenericParameterAttributes get_Attributes() { }

	[Address(RVA = "0x1E644D0", Offset = "0x1E638D0", Length = "0x7")]
	[Token(Token = "0x6000052")]
	internal Type[] get_Constraints() { }

	[Address(RVA = "0x1E64370", Offset = "0x1E63770", Length = "0x13D")]
	[Token(Token = "0x6000054")]
	private Type[] GetConstraints() { }

	[Address(RVA = "0x1E64340", Offset = "0x1E63740", Length = "0x2F")]
	[Token(Token = "0x6000055")]
	private int GetConstraintsCount() { }

}

