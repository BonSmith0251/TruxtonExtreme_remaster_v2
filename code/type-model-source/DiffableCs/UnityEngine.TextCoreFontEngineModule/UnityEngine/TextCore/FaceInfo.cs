namespace UnityEngine.TextCore;

[Token(Token = "0x2000002")]
[UsedByNativeCode]
public struct FaceInfo
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("faceIndex")]
	[SerializeField]
	[Token(Token = "0x4000001")]
	private int m_FaceIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeName("familyName")]
	[SerializeField]
	[Token(Token = "0x4000002")]
	private string m_FamilyName; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[NativeName("styleName")]
	[SerializeField]
	[Token(Token = "0x4000003")]
	private string m_StyleName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[NativeName("pointSize")]
	[SerializeField]
	[Token(Token = "0x4000004")]
	private float m_PointSize; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[NativeName("scale")]
	[SerializeField]
	[Token(Token = "0x4000005")]
	private float m_Scale; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[NativeName("unitsPerEM")]
	[SerializeField]
	[Token(Token = "0x4000006")]
	private int m_UnitsPerEM; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[NativeName("lineHeight")]
	[SerializeField]
	[Token(Token = "0x4000007")]
	private float m_LineHeight; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[NativeName("ascentLine")]
	[SerializeField]
	[Token(Token = "0x4000008")]
	private float m_AscentLine; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[NativeName("capLine")]
	[SerializeField]
	[Token(Token = "0x4000009")]
	private float m_CapLine; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[NativeName("meanLine")]
	[SerializeField]
	[Token(Token = "0x400000A")]
	private float m_MeanLine; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[NativeName("baseline")]
	[SerializeField]
	[Token(Token = "0x400000B")]
	private float m_Baseline; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[NativeName("descentLine")]
	[SerializeField]
	[Token(Token = "0x400000C")]
	private float m_DescentLine; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[NativeName("superscriptOffset")]
	[SerializeField]
	[Token(Token = "0x400000D")]
	private float m_SuperscriptOffset; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[NativeName("superscriptSize")]
	[SerializeField]
	[Token(Token = "0x400000E")]
	private float m_SuperscriptSize; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[NativeName("subscriptOffset")]
	[SerializeField]
	[Token(Token = "0x400000F")]
	private float m_SubscriptOffset; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[NativeName("subscriptSize")]
	[SerializeField]
	[Token(Token = "0x4000010")]
	private float m_SubscriptSize; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[NativeName("underlineOffset")]
	[SerializeField]
	[Token(Token = "0x4000011")]
	private float m_UnderlineOffset; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[NativeName("underlineThickness")]
	[SerializeField]
	[Token(Token = "0x4000012")]
	private float m_UnderlineThickness; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[NativeName("strikethroughOffset")]
	[SerializeField]
	[Token(Token = "0x4000013")]
	private float m_StrikethroughOffset; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[NativeName("strikethroughThickness")]
	[SerializeField]
	[Token(Token = "0x4000014")]
	private float m_StrikethroughThickness; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[NativeName("tabWidth")]
	[SerializeField]
	[Token(Token = "0x4000015")]
	private float m_TabWidth; //Field offset: 0x5C

	[Token(Token = "0x17000008")]
	public float ascentLine
	{
		[Address(RVA = "0x316C2E0", Offset = "0x316B6E0", Length = "0x8")]
		[Token(Token = "0x600000A")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700000B")]
	public float baseline
	{
		[Address(RVA = "0x31132F0", Offset = "0x31126F0", Length = "0x8")]
		[Token(Token = "0x600000F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000009")]
	public float capLine
	{
		[Address(RVA = "0x2F92DB0", Offset = "0x2F921B0", Length = "0x8")]
		[Token(Token = "0x600000B")]
		 get { } //Length: 8
		[Address(RVA = "0x2EAE500", Offset = "0x2EAD900", Length = "0x6")]
		[Token(Token = "0x600000C")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700000C")]
	public float descentLine
	{
		[Address(RVA = "0x31132E0", Offset = "0x31126E0", Length = "0x8")]
		[Token(Token = "0x6000010")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000001")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal int faceIndex
	{
		[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
		[Token(Token = "0x6000001")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000002")]
	public string familyName
	{
		[Address(RVA = "0x20939E0", Offset = "0x2092DE0", Length = "0x7")]
		[Token(Token = "0x6000002")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000007")]
	public float lineHeight
	{
		[Address(RVA = "0x3076950", Offset = "0x3075D50", Length = "0x8")]
		[Token(Token = "0x6000009")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700000A")]
	public float meanLine
	{
		[Address(RVA = "0x2F92DA0", Offset = "0x2F921A0", Length = "0x8")]
		[Token(Token = "0x600000D")]
		 get { } //Length: 8
		[Address(RVA = "0x2828CF0", Offset = "0x28280F0", Length = "0x6")]
		[Token(Token = "0x600000E")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000004")]
	public float pointSize
	{
		[Address(RVA = "0x2F896F0", Offset = "0x2F88AF0", Length = "0x8")]
		[Token(Token = "0x6000004")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000005")]
	public float scale
	{
		[Address(RVA = "0x2F92DC0", Offset = "0x2F921C0", Length = "0x8")]
		[Token(Token = "0x6000005")]
		 get { } //Length: 8
		[Address(RVA = "0x1E18720", Offset = "0x1E17B20", Length = "0x6")]
		[Token(Token = "0x6000006")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000013")]
	public float strikethroughOffset
	{
		[Address(RVA = "0x316C2F0", Offset = "0x316B6F0", Length = "0x8")]
		[Token(Token = "0x6000017")]
		 get { } //Length: 8
		[Address(RVA = "0x1D1D150", Offset = "0x1D1C550", Length = "0x6")]
		[Token(Token = "0x6000018")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000003")]
	public string styleName
	{
		[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
		[Token(Token = "0x6000003")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700000F")]
	public float subscriptOffset
	{
		[Address(RVA = "0x316C300", Offset = "0x316B700", Length = "0x8")]
		[Token(Token = "0x6000013")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000010")]
	public float subscriptSize
	{
		[Address(RVA = "0x316C310", Offset = "0x316B710", Length = "0x8")]
		[Token(Token = "0x6000014")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700000D")]
	public float superscriptOffset
	{
		[Address(RVA = "0x31132A0", Offset = "0x31126A0", Length = "0x8")]
		[Token(Token = "0x6000011")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700000E")]
	public float superscriptSize
	{
		[Address(RVA = "0x31132B0", Offset = "0x31126B0", Length = "0x8")]
		[Token(Token = "0x6000012")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000014")]
	public float tabWidth
	{
		[Address(RVA = "0x316C320", Offset = "0x316B720", Length = "0x8")]
		[Token(Token = "0x6000019")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000011")]
	public float underlineOffset
	{
		[Address(RVA = "0x316C330", Offset = "0x316B730", Length = "0x8")]
		[Token(Token = "0x6000015")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000012")]
	public float underlineThickness
	{
		[Address(RVA = "0x316C340", Offset = "0x316B740", Length = "0x8")]
		[Token(Token = "0x6000016")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000006")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal int unitsPerEM
	{
		[Address(RVA = "0x1073710", Offset = "0x1072B10", Length = "0x6")]
		[Token(Token = "0x6000007")]
		internal get { } //Length: 6
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[Token(Token = "0x6000008")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x316C2E0", Offset = "0x316B6E0", Length = "0x8")]
	[Token(Token = "0x600000A")]
	public float get_ascentLine() { }

	[Address(RVA = "0x31132F0", Offset = "0x31126F0", Length = "0x8")]
	[Token(Token = "0x600000F")]
	public float get_baseline() { }

	[Address(RVA = "0x2F92DB0", Offset = "0x2F921B0", Length = "0x8")]
	[Token(Token = "0x600000B")]
	public float get_capLine() { }

	[Address(RVA = "0x31132E0", Offset = "0x31126E0", Length = "0x8")]
	[Token(Token = "0x6000010")]
	public float get_descentLine() { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x6000001")]
	internal int get_faceIndex() { }

	[Address(RVA = "0x20939E0", Offset = "0x2092DE0", Length = "0x7")]
	[Token(Token = "0x6000002")]
	public string get_familyName() { }

	[Address(RVA = "0x3076950", Offset = "0x3075D50", Length = "0x8")]
	[Token(Token = "0x6000009")]
	public float get_lineHeight() { }

	[Address(RVA = "0x2F92DA0", Offset = "0x2F921A0", Length = "0x8")]
	[Token(Token = "0x600000D")]
	public float get_meanLine() { }

	[Address(RVA = "0x2F896F0", Offset = "0x2F88AF0", Length = "0x8")]
	[Token(Token = "0x6000004")]
	public float get_pointSize() { }

	[Address(RVA = "0x2F92DC0", Offset = "0x2F921C0", Length = "0x8")]
	[Token(Token = "0x6000005")]
	public float get_scale() { }

	[Address(RVA = "0x316C2F0", Offset = "0x316B6F0", Length = "0x8")]
	[Token(Token = "0x6000017")]
	public float get_strikethroughOffset() { }

	[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
	[Token(Token = "0x6000003")]
	public string get_styleName() { }

	[Address(RVA = "0x316C300", Offset = "0x316B700", Length = "0x8")]
	[Token(Token = "0x6000013")]
	public float get_subscriptOffset() { }

	[Address(RVA = "0x316C310", Offset = "0x316B710", Length = "0x8")]
	[Token(Token = "0x6000014")]
	public float get_subscriptSize() { }

	[Address(RVA = "0x31132A0", Offset = "0x31126A0", Length = "0x8")]
	[Token(Token = "0x6000011")]
	public float get_superscriptOffset() { }

	[Address(RVA = "0x31132B0", Offset = "0x31126B0", Length = "0x8")]
	[Token(Token = "0x6000012")]
	public float get_superscriptSize() { }

	[Address(RVA = "0x316C320", Offset = "0x316B720", Length = "0x8")]
	[Token(Token = "0x6000019")]
	public float get_tabWidth() { }

	[Address(RVA = "0x316C330", Offset = "0x316B730", Length = "0x8")]
	[Token(Token = "0x6000015")]
	public float get_underlineOffset() { }

	[Address(RVA = "0x316C340", Offset = "0x316B740", Length = "0x8")]
	[Token(Token = "0x6000016")]
	public float get_underlineThickness() { }

	[Address(RVA = "0x1073710", Offset = "0x1072B10", Length = "0x6")]
	[Token(Token = "0x6000007")]
	internal int get_unitsPerEM() { }

	[Address(RVA = "0x2EAE500", Offset = "0x2EAD900", Length = "0x6")]
	[Token(Token = "0x600000C")]
	public void set_capLine(float value) { }

	[Address(RVA = "0x2828CF0", Offset = "0x28280F0", Length = "0x6")]
	[Token(Token = "0x600000E")]
	public void set_meanLine(float value) { }

	[Address(RVA = "0x1E18720", Offset = "0x1E17B20", Length = "0x6")]
	[Token(Token = "0x6000006")]
	public void set_scale(float value) { }

	[Address(RVA = "0x1D1D150", Offset = "0x1D1C550", Length = "0x6")]
	[Token(Token = "0x6000018")]
	public void set_strikethroughOffset(float value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[Token(Token = "0x6000008")]
	internal void set_unitsPerEM(int value) { }

}

