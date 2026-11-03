namespace UnityEngine;

[RequiredByNativeCode]
[Token(Token = "0x2000090")]
public struct Keyframe
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000142")]
	private float m_Time; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000143")]
	private float m_Value; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000144")]
	private float m_InTangent; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000145")]
	private float m_OutTangent; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000146")]
	private int m_WeightedMode; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000147")]
	private float m_InWeight; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000148")]
	private float m_OutWeight; //Field offset: 0x18

	[Token(Token = "0x1700004D")]
	public float inTangent
	{
		[Address(RVA = "0x2FE3090", Offset = "0x2FE2490", Length = "0x8")]
		[Token(Token = "0x6000248")]
		 get { } //Length: 8
		[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
		[Token(Token = "0x6000249")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700004F")]
	public float inWeight
	{
		[Address(RVA = "0x199AC40", Offset = "0x199A040", Length = "0x8")]
		[Token(Token = "0x600024C")]
		 get { } //Length: 8
		[Address(RVA = "0xFC02D0", Offset = "0xFBF6D0", Length = "0x6")]
		[Token(Token = "0x600024D")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700004E")]
	public float outTangent
	{
		[Address(RVA = "0x2FB4CA0", Offset = "0x2FB40A0", Length = "0x8")]
		[Token(Token = "0x600024A")]
		 get { } //Length: 8
		[Address(RVA = "0x29FC910", Offset = "0x29FBD10", Length = "0x6")]
		[Token(Token = "0x600024B")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000050")]
	public float outWeight
	{
		[Address(RVA = "0x2F896F0", Offset = "0x2F88AF0", Length = "0x8")]
		[Token(Token = "0x600024E")]
		 get { } //Length: 8
		[Address(RVA = "0x1412590", Offset = "0x1411990", Length = "0x6")]
		[Token(Token = "0x600024F")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700004B")]
	public float time
	{
		[Address(RVA = "0x2FE30A0", Offset = "0x2FE24A0", Length = "0x7")]
		[Token(Token = "0x6000244")]
		 get { } //Length: 7
		[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
		[Token(Token = "0x6000245")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700004C")]
	public float value
	{
		[Address(RVA = "0x2FB47B0", Offset = "0x2FB3BB0", Length = "0x8")]
		[Token(Token = "0x6000246")]
		 get { } //Length: 8
		[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
		[Token(Token = "0x6000247")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000051")]
	public WeightedMode weightedMode
	{
		[Address(RVA = "0x2FE30B0", Offset = "0x2FE24B0", Length = "0x6")]
		[Token(Token = "0x6000250")]
		 get { } //Length: 6
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x6000251")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2FE3070", Offset = "0x2FE2470", Length = "0x17")]
	[Token(Token = "0x6000242")]
	public Keyframe(float time, float value) { }

	[Address(RVA = "0x2FE3040", Offset = "0x2FE2440", Length = "0x23")]
	[Token(Token = "0x6000243")]
	public Keyframe(float time, float value, float inTangent, float outTangent) { }

	[Address(RVA = "0x2FE3090", Offset = "0x2FE2490", Length = "0x8")]
	[Token(Token = "0x6000248")]
	public float get_inTangent() { }

	[Address(RVA = "0x199AC40", Offset = "0x199A040", Length = "0x8")]
	[Token(Token = "0x600024C")]
	public float get_inWeight() { }

	[Address(RVA = "0x2FB4CA0", Offset = "0x2FB40A0", Length = "0x8")]
	[Token(Token = "0x600024A")]
	public float get_outTangent() { }

	[Address(RVA = "0x2F896F0", Offset = "0x2F88AF0", Length = "0x8")]
	[Token(Token = "0x600024E")]
	public float get_outWeight() { }

	[Address(RVA = "0x2FE30A0", Offset = "0x2FE24A0", Length = "0x7")]
	[Token(Token = "0x6000244")]
	public float get_time() { }

	[Address(RVA = "0x2FB47B0", Offset = "0x2FB3BB0", Length = "0x8")]
	[Token(Token = "0x6000246")]
	public float get_value() { }

	[Address(RVA = "0x2FE30B0", Offset = "0x2FE24B0", Length = "0x6")]
	[Token(Token = "0x6000250")]
	public WeightedMode get_weightedMode() { }

	[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
	[Token(Token = "0x6000249")]
	public void set_inTangent(float value) { }

	[Address(RVA = "0xFC02D0", Offset = "0xFBF6D0", Length = "0x6")]
	[Token(Token = "0x600024D")]
	public void set_inWeight(float value) { }

	[Address(RVA = "0x29FC910", Offset = "0x29FBD10", Length = "0x6")]
	[Token(Token = "0x600024B")]
	public void set_outTangent(float value) { }

	[Address(RVA = "0x1412590", Offset = "0x1411990", Length = "0x6")]
	[Token(Token = "0x600024F")]
	public void set_outWeight(float value) { }

	[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
	[Token(Token = "0x6000245")]
	public void set_time(float value) { }

	[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
	[Token(Token = "0x6000247")]
	public void set_value(float value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x6000251")]
	public void set_weightedMode(WeightedMode value) { }

}

