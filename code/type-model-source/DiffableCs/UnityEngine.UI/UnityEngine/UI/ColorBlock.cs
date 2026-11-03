namespace UnityEngine.UI;

[Token(Token = "0x200000B")]
public struct ColorBlock : IEquatable<ColorBlock>
{
	[Token(Token = "0x400002C")]
	public static ColorBlock defaultColorBlock; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[FormerlySerializedAs("normalColor")]
	[SerializeField]
	[Token(Token = "0x4000025")]
	private Color m_NormalColor; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("highlightedColor")]
	[SerializeField]
	[Token(Token = "0x4000026")]
	private Color m_HighlightedColor; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("pressedColor")]
	[SerializeField]
	[Token(Token = "0x4000027")]
	private Color m_PressedColor; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_HighlightedColor")]
	[SerializeField]
	[Token(Token = "0x4000028")]
	private Color m_SelectedColor; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("disabledColor")]
	[SerializeField]
	[Token(Token = "0x4000029")]
	private Color m_DisabledColor; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[Range(1, 5)]
	[SerializeField]
	[Token(Token = "0x400002A")]
	private float m_ColorMultiplier; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[FormerlySerializedAs("fadeDuration")]
	[SerializeField]
	[Token(Token = "0x400002B")]
	private float m_FadeDuration; //Field offset: 0x54

	[Token(Token = "0x17000010")]
	public float colorMultiplier
	{
		[Address(RVA = "0x5B3800", Offset = "0x5B2C00", Length = "0x6")]
		[Token(Token = "0x6000041")]
		 get { } //Length: 6
		[Address(RVA = "0x26DEAE0", Offset = "0x26DDEE0", Length = "0x6")]
		[Token(Token = "0x6000042")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700000F")]
	public Color disabledColor
	{
		[Address(RVA = "0x1116930", Offset = "0x1115D30", Length = "0xB")]
		[Token(Token = "0x600003F")]
		 get { } //Length: 11
		[Address(RVA = "0x1116980", Offset = "0x1115D80", Length = "0x8")]
		[Token(Token = "0x6000040")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000011")]
	public float fadeDuration
	{
		[Address(RVA = "0x5B3830", Offset = "0x5B2C30", Length = "0x6")]
		[Token(Token = "0x6000043")]
		 get { } //Length: 6
		[Address(RVA = "0x1D1D150", Offset = "0x1D1C550", Length = "0x6")]
		[Token(Token = "0x6000044")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700000C")]
	public Color highlightedColor
	{
		[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
		[Token(Token = "0x6000039")]
		 get { } //Length: 11
		[Address(RVA = "0x6622B0", Offset = "0x6616B0", Length = "0x8")]
		[Token(Token = "0x600003A")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700000B")]
	public Color normalColor
	{
		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[Token(Token = "0x6000037")]
		 get { } //Length: 10
		[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
		[Token(Token = "0x6000038")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700000D")]
	public Color pressedColor
	{
		[Address(RVA = "0xF53F00", Offset = "0xF53300", Length = "0xB")]
		[Token(Token = "0x600003B")]
		 get { } //Length: 11
		[Address(RVA = "0x1E523A0", Offset = "0x1E517A0", Length = "0x8")]
		[Token(Token = "0x600003C")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700000E")]
	public Color selectedColor
	{
		[Address(RVA = "0x1CC6CF0", Offset = "0x1CC60F0", Length = "0xB")]
		[Token(Token = "0x600003D")]
		 get { } //Length: 11
		[Address(RVA = "0x2C0B510", Offset = "0x2C0A910", Length = "0x8")]
		[Token(Token = "0x600003E")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x31D3920", Offset = "0x31D2D20", Length = "0x321")]
	[Token(Token = "0x6000045")]
	private static ColorBlock() { }

	[Address(RVA = "0x31D3590", Offset = "0x31D2990", Length = "0x2F8")]
	[Token(Token = "0x6000047")]
	public override bool Equals(ColorBlock other) { }

	[Address(RVA = "0x31D34A0", Offset = "0x31D28A0", Length = "0xEE")]
	[Token(Token = "0x6000046")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x5B3800", Offset = "0x5B2C00", Length = "0x6")]
	[Token(Token = "0x6000041")]
	public float get_colorMultiplier() { }

	[Address(RVA = "0x1116930", Offset = "0x1115D30", Length = "0xB")]
	[Token(Token = "0x600003F")]
	public Color get_disabledColor() { }

	[Address(RVA = "0x5B3830", Offset = "0x5B2C30", Length = "0x6")]
	[Token(Token = "0x6000043")]
	public float get_fadeDuration() { }

	[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
	[Token(Token = "0x6000039")]
	public Color get_highlightedColor() { }

	[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
	[Token(Token = "0x6000037")]
	public Color get_normalColor() { }

	[Address(RVA = "0xF53F00", Offset = "0xF53300", Length = "0xB")]
	[Token(Token = "0x600003B")]
	public Color get_pressedColor() { }

	[Address(RVA = "0x1CC6CF0", Offset = "0x1CC60F0", Length = "0xB")]
	[Token(Token = "0x600003D")]
	public Color get_selectedColor() { }

	[Address(RVA = "0x31D3890", Offset = "0x31D2C90", Length = "0x83")]
	[Token(Token = "0x600004A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x31D3C50", Offset = "0x31D3050", Length = "0x9C")]
	[Token(Token = "0x6000048")]
	public static bool op_Equality(ColorBlock point1, ColorBlock point2) { }

	[Address(RVA = "0x31D3CF0", Offset = "0x31D30F0", Length = "0x9E")]
	[Token(Token = "0x6000049")]
	public static bool op_Inequality(ColorBlock point1, ColorBlock point2) { }

	[Address(RVA = "0x26DEAE0", Offset = "0x26DDEE0", Length = "0x6")]
	[Token(Token = "0x6000042")]
	public void set_colorMultiplier(float value) { }

	[Address(RVA = "0x1116980", Offset = "0x1115D80", Length = "0x8")]
	[Token(Token = "0x6000040")]
	public void set_disabledColor(Color value) { }

	[Address(RVA = "0x1D1D150", Offset = "0x1D1C550", Length = "0x6")]
	[Token(Token = "0x6000044")]
	public void set_fadeDuration(float value) { }

	[Address(RVA = "0x6622B0", Offset = "0x6616B0", Length = "0x8")]
	[Token(Token = "0x600003A")]
	public void set_highlightedColor(Color value) { }

	[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
	[Token(Token = "0x6000038")]
	public void set_normalColor(Color value) { }

	[Address(RVA = "0x1E523A0", Offset = "0x1E517A0", Length = "0x8")]
	[Token(Token = "0x600003C")]
	public void set_pressedColor(Color value) { }

	[Address(RVA = "0x2C0B510", Offset = "0x2C0A910", Length = "0x8")]
	[Token(Token = "0x600003E")]
	public void set_selectedColor(Color value) { }

}

