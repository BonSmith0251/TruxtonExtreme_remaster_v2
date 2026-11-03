namespace UnityEngine.UIElements;

[Obsolete("BaseUxmlFactory<TCreatedType, TTraits> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x2000510")]
public abstract class BaseUxmlFactory
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40010AA")]
	internal TTraits m_Traits; //Field offset: 0x0

	[Token(Token = "0x170009D1")]
	public override string uxmlName
	{
		[Address(RVA = "0x16B5860", Offset = "0x16B4C60", Length = "0x5A")]
		[Token(Token = "0x6002592")]
		 get { } //Length: 90
	}

	[Token(Token = "0x170009D2")]
	public override string uxmlNamespace
	{
		[Address(RVA = "0x16B58C0", Offset = "0x16B4CC0", Length = "0x71")]
		[Token(Token = "0x6002593")]
		 get { } //Length: 113
	}

	[Token(Token = "0x170009D3")]
	public override string uxmlQualifiedName
	{
		[Address(RVA = "0x16B5940", Offset = "0x16B4D40", Length = "0x5A")]
		[Token(Token = "0x6002594")]
		 get { } //Length: 90
	}

	[Token(Token = "0x170009D4")]
	public override Type uxmlType
	{
		[Address(RVA = "0x16B59A0", Offset = "0x16B4DA0", Length = "0x39")]
		[Token(Token = "0x6002595")]
		 get { } //Length: 57
	}

	[Address(RVA = "0x16B5810", Offset = "0x16B4C10", Length = "0x44")]
	[Token(Token = "0x6002591")]
	protected BaseUxmlFactory`2() { }

	[Address(RVA = "0x13B0EC0", Offset = "0x13B02C0", Length = "0x5")]
	[Token(Token = "0x6002596")]
	public override bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc) { }

	[Address(RVA = "0x16B5860", Offset = "0x16B4C60", Length = "0x5A")]
	[Token(Token = "0x6002592")]
	public override string get_uxmlName() { }

	[Address(RVA = "0x16B58C0", Offset = "0x16B4CC0", Length = "0x71")]
	[Token(Token = "0x6002593")]
	public override string get_uxmlNamespace() { }

	[Address(RVA = "0x16B5940", Offset = "0x16B4D40", Length = "0x5A")]
	[Token(Token = "0x6002594")]
	public override string get_uxmlQualifiedName() { }

	[Address(RVA = "0x16B59A0", Offset = "0x16B4DA0", Length = "0x39")]
	[Token(Token = "0x6002595")]
	public override Type get_uxmlType() { }

}

