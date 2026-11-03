namespace UnityEngine.TextCore.LowLevel;

[Token(Token = "0x2000014")]
[UsedByNativeCode]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
internal struct GlyphAnchorPoint
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("xPositionAdjustment")]
	[SerializeField]
	[Token(Token = "0x400008D")]
	private float m_XCoordinate; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[NativeName("yPositionAdjustment")]
	[SerializeField]
	[Token(Token = "0x400008E")]
	private float m_YCoordinate; //Field offset: 0x4

	[Token(Token = "0x1700002D")]
	public float xCoordinate
	{
		[Address(RVA = "0x2FE30A0", Offset = "0x2FE24A0", Length = "0x7")]
		[Token(Token = "0x60000A0")]
		 get { } //Length: 7
		[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
		[Token(Token = "0x60000A1")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700002E")]
	public float yCoordinate
	{
		[Address(RVA = "0x2FB47B0", Offset = "0x2FB3BB0", Length = "0x8")]
		[Token(Token = "0x60000A2")]
		 get { } //Length: 8
		[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
		[Token(Token = "0x60000A3")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x2FE30A0", Offset = "0x2FE24A0", Length = "0x7")]
	[Token(Token = "0x60000A0")]
	public float get_xCoordinate() { }

	[Address(RVA = "0x2FB47B0", Offset = "0x2FB3BB0", Length = "0x8")]
	[Token(Token = "0x60000A2")]
	public float get_yCoordinate() { }

	[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
	[Token(Token = "0x60000A1")]
	public void set_xCoordinate(float value) { }

	[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
	[Token(Token = "0x60000A3")]
	public void set_yCoordinate(float value) { }

}

