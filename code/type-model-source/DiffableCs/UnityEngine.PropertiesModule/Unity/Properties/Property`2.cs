namespace Unity.Properties;

[Token(Token = "0x2000018")]
public abstract class Property : IProperty<TContainer>, IProperty, IPropertyAccept<TContainer>, IAttributes
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000023")]
	private List<Attribute> m_Attributes; //Field offset: 0x0

	[Token(Token = "0x1700000B")]
	public abstract bool IsReadOnly
	{
		[Token(Token = "0x6000034")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700000A")]
	public abstract string Name
	{
		[Token(Token = "0x6000033")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000009")]
	private override List<Attribute> Unity.Properties.Internal.IAttributes.Attributes
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000031")]
		private get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000032")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000040")]
	protected Property`2() { }

	[Address(RVA = "0xE42180", Offset = "0xE41580", Length = "0xD8")]
	[Token(Token = "0x6000036")]
	public override void Accept(IPropertyVisitor visitor, ref TContainer container) { }

	[Address(RVA = "0xE42500", Offset = "0xE41900", Length = "0x57")]
	[Token(Token = "0x6000039")]
	protected void AddAttribute(Attribute attribute) { }

	[Address(RVA = "0xE425C0", Offset = "0xE419C0", Length = "0x57")]
	[Token(Token = "0x600003A")]
	protected void AddAttributes(IEnumerable<Attribute> attributes) { }

	[Address(RVA = "0xE42860", Offset = "0xE41C60", Length = "0x39")]
	[Token(Token = "0x6000035")]
	public override Type DeclaredValueType() { }

	[Token(Token = "0x6000034")]
	public abstract bool get_IsReadOnly() { }

	[Token(Token = "0x6000033")]
	public abstract string get_Name() { }

	[Address(RVA = "0x6A0650", Offset = "0x69FA50", Length = "0x110")]
	[Token(Token = "0x600003E")]
	public override TAttribute GetAttribute() { }

	[Token(Token = "0x6000037")]
	public abstract TValue GetValue(ref TContainer container) { }

	[Address(RVA = "0x6A0770", Offset = "0x69FB70", Length = "0x113")]
	[Token(Token = "0x600003D")]
	public override bool HasAttribute() { }

	[Token(Token = "0x6000038")]
	public abstract void SetValue(ref TContainer container, TValue value) { }

	[Address(RVA = "0xE429B0", Offset = "0xE41DB0", Length = "0x10F")]
	[Token(Token = "0x600003B")]
	private override void Unity.Properties.Internal.IAttributes.AddAttribute(Attribute attribute) { }

	[Address(RVA = "0xE435A0", Offset = "0xE429A0", Length = "0x237")]
	[Token(Token = "0x600003C")]
	private override void Unity.Properties.Internal.IAttributes.AddAttributes(IEnumerable<Attribute> attributes) { }

	[Address(RVA = "0xE443A0", Offset = "0xE437A0", Length = "0x78")]
	[Token(Token = "0x600003F")]
	private override AttributesScope Unity.Properties.Internal.IAttributes.CreateAttributesScope(IAttributes attributes) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000031")]
	private override List<Attribute> Unity.Properties.Internal.IAttributes.get_Attributes() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000032")]
	private override void Unity.Properties.Internal.IAttributes.set_Attributes(List<Attribute> value) { }

}

