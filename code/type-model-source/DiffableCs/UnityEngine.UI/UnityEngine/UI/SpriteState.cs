namespace UnityEngine.UI;

[Token(Token = "0x2000071")]
public struct SpriteState : IEquatable<SpriteState>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400023A")]
	private Sprite m_HighlightedSprite; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x400023B")]
	private Sprite m_PressedSprite; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("m_HighlightedSprite")]
	[SerializeField]
	[Token(Token = "0x400023C")]
	private Sprite m_SelectedSprite; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400023D")]
	private Sprite m_DisabledSprite; //Field offset: 0x18

	[Token(Token = "0x17000136")]
	public Sprite disabledSprite
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60004A1")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x60004A2")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000133")]
	public Sprite highlightedSprite
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x600049B")]
		 get { } //Length: 4
		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x600049C")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000134")]
	public Sprite pressedSprite
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x600049D")]
		 get { } //Length: 5
		[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
		[Token(Token = "0x600049E")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000135")]
	public Sprite selectedSprite
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600049F")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x60004A0")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x345AEC0", Offset = "0x345A2C0", Length = "0x100")]
	[Token(Token = "0x60004A3")]
	public override bool Equals(SpriteState other) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60004A1")]
	public Sprite get_disabledSprite() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x600049B")]
	public Sprite get_highlightedSprite() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[Token(Token = "0x600049D")]
	public Sprite get_pressedSprite() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600049F")]
	public Sprite get_selectedSprite() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x60004A2")]
	public void set_disabledSprite(Sprite value) { }

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x600049C")]
	public void set_highlightedSprite(Sprite value) { }

	[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
	[Token(Token = "0x600049E")]
	public void set_pressedSprite(Sprite value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x60004A0")]
	public void set_selectedSprite(Sprite value) { }

}

