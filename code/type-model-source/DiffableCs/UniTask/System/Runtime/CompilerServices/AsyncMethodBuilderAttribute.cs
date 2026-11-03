namespace System.Runtime.CompilerServices;

[Token(Token = "0x2000004")]
internal sealed class AsyncMethodBuilderAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000006")]
	private readonly Type <BuilderType>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000001")]
	public Type BuilderType
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000003")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000004")]
	public AsyncMethodBuilderAttribute(Type builderType) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000003")]
	public Type get_BuilderType() { }

}

