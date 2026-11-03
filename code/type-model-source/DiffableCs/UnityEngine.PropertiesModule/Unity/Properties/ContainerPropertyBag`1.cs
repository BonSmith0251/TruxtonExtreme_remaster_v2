namespace Unity.Properties;

[Token(Token = "0x2000026")]
public abstract class ContainerPropertyBag : PropertyBag<TContainer>, INamedProperties<TContainer>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000043")]
	private readonly List<IProperty`1<TContainer>> m_PropertiesList; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000044")]
	private readonly Dictionary<String, IProperty`1<TContainer>> m_PropertiesHash; //Field offset: 0x0

	[Address(RVA = "0xE3A150", Offset = "0xE39550", Length = "0xEE")]
	[Token(Token = "0x600008F")]
	private static ContainerPropertyBag`1() { }

	[Address(RVA = "0x17C64F0", Offset = "0x17C58F0", Length = "0x1FB")]
	[Token(Token = "0x6000094")]
	protected ContainerPropertyBag`1() { }

	[Address(RVA = "0x699960", Offset = "0x698D60", Length = "0xE3")]
	[Token(Token = "0x6000090")]
	protected void AddProperty(Property<TContainer, TValue> property) { }

	[Address(RVA = "0x17C6350", Offset = "0x17C5750", Length = "0x3A")]
	[Token(Token = "0x6000091")]
	public virtual PropertyCollection<TContainer> GetProperties() { }

	[Address(RVA = "0x17C6290", Offset = "0x17C5690", Length = "0x3A")]
	[Token(Token = "0x6000092")]
	public virtual PropertyCollection<TContainer> GetProperties(ref TContainer container) { }

	[Address(RVA = "0x17C64B0", Offset = "0x17C58B0", Length = "0x3B")]
	[Token(Token = "0x6000093")]
	public override bool TryGetProperty(ref TContainer container, string name, out IProperty<TContainer>& property) { }

}

