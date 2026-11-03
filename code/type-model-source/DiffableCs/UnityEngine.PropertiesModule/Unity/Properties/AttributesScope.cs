namespace Unity.Properties;

[IsReadOnly]
[Token(Token = "0x200000F")]
public struct AttributesScope : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001E")]
	private readonly IAttributes m_Target; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400001F")]
	private readonly List<Attribute> m_Previous; //Field offset: 0x8

	[Address(RVA = "0x3141390", Offset = "0x3140790", Length = "0xF3")]
	[Token(Token = "0x6000020")]
	public AttributesScope(IProperty target, IProperty source) { }

	[Address(RVA = "0x31412F0", Offset = "0x31406F0", Length = "0x93")]
	[Token(Token = "0x6000021")]
	internal AttributesScope(IAttributes target, List<Attribute> attributes) { }

	[Address(RVA = "0x31412A0", Offset = "0x31406A0", Length = "0x4E")]
	[Token(Token = "0x6000022")]
	public override void Dispose() { }

}

