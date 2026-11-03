namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Field (256), Inherited = False)]
[Token(Token = "0x200047D")]
public sealed class FixedBufferAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001255")]
	private readonly Type <ElementType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001256")]
	private readonly int <Length>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170003FD")]
	public Type ElementType
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60020DA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003FE")]
	public int Length
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60020DB")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x5D2830", Offset = "0x5D1C30", Length = "0x42")]
	[Token(Token = "0x60020D9")]
	public FixedBufferAttribute(Type elementType, int length) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60020DA")]
	public Type get_ElementType() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60020DB")]
	public int get_Length() { }

}

