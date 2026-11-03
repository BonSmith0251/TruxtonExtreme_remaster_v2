namespace UnityEngine.Rendering;

[DefaultMember("Item")]
[Token(Token = "0x200022F")]
public class VrsLut
{
	[Token(Token = "0x40009C5")]
	private const uint Rate1x = 0; //Field offset: 0x0
	[Token(Token = "0x40009C6")]
	private const uint Rate2x = 1; //Field offset: 0x0
	[Token(Token = "0x40009C7")]
	private const uint Rate4x = 2; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40009C4")]
	private Color[] m_Data; //Field offset: 0x10

	[Token(Token = "0x170001FE")]
	public Color Item
	{
		[Address(RVA = "0x1C1A320", Offset = "0x1C19720", Length = "0x38")]
		[Token(Token = "0x6000FA7")]
		 get { } //Length: 56
		[Address(RVA = "0x1C1A400", Offset = "0x1C19800", Length = "0x36")]
		[Token(Token = "0x6000FA8")]
		 set { } //Length: 54
	}

	[Address(RVA = "0x2C89290", Offset = "0x2C88690", Length = "0x84")]
	[Token(Token = "0x6000FAC")]
	public VrsLut() { }

	[Address(RVA = "0x2C88C60", Offset = "0x2C88060", Length = "0x3BE")]
	[Token(Token = "0x6000FA9")]
	public GraphicsBuffer CreateBuffer(bool forVisualization = false) { }

	[Address(RVA = "0x2C89020", Offset = "0x2C88420", Length = "0x1DF")]
	[Token(Token = "0x6000FA6")]
	public static VrsLut CreateDefault() { }

	[Address(RVA = "0x2C89200", Offset = "0x2C88600", Length = "0xB")]
	[Token(Token = "0x6000FAB")]
	private uint EncodeShadingRate(uint x, uint y) { }

	[Address(RVA = "0x1C1A320", Offset = "0x1C19720", Length = "0x38")]
	[Token(Token = "0x6000FA7")]
	public Color get_Item(ShadingRateFragmentSize fragmentSize) { }

	[Address(RVA = "0x2C89210", Offset = "0x2C88610", Length = "0x50")]
	[Token(Token = "0x6000FAA")]
	private uint MapFragmentShadingRateToBinary(ShadingRateFragmentSize fs) { }

	[Address(RVA = "0x1C1A400", Offset = "0x1C19800", Length = "0x36")]
	[Token(Token = "0x6000FA8")]
	public void set_Item(ShadingRateFragmentSize fragmentSize, Color value) { }

}

