namespace UnityEngine;

[Token(Token = "0x2000023")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal class GUILayoutEntry
{
	[Token(Token = "0x40000D8")]
	internal static Rect kDummyRect; //Field offset: 0x0
	[Token(Token = "0x40000D9")]
	protected static int indent; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000CF")]
	public float minWidth; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000D0")]
	public float maxWidth; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000D1")]
	public float minHeight; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000D2")]
	public float maxHeight; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000D3")]
	public Rect rect; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000D4")]
	public int stretchWidth; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40000D5")]
	public int stretchHeight; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000D6")]
	public bool consideredForMargin; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000D7")]
	private GUIStyle m_Style; //Field offset: 0x40

	[Token(Token = "0x17000074")]
	public override int marginBottom
	{
		[Address(RVA = "0x30E1480", Offset = "0x30E0880", Length = "0x2C")]
		[Token(Token = "0x60001CB")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000075")]
	public int marginHorizontal
	{
		[Address(RVA = "0x30E14B0", Offset = "0x30E08B0", Length = "0x46")]
		[Token(Token = "0x60001CC")]
		 get { } //Length: 70
	}

	[Token(Token = "0x17000071")]
	public override int marginLeft
	{
		[Address(RVA = "0x30E1500", Offset = "0x30E0900", Length = "0x2C")]
		[Token(Token = "0x60001C8")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000072")]
	public override int marginRight
	{
		[Address(RVA = "0x30E1530", Offset = "0x30E0930", Length = "0x2C")]
		[Token(Token = "0x60001C9")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000073")]
	public override int marginTop
	{
		[Address(RVA = "0x30E1560", Offset = "0x30E0960", Length = "0x2C")]
		[Token(Token = "0x60001CA")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000076")]
	public int marginVertical
	{
		[Address(RVA = "0x30E1590", Offset = "0x30E0990", Length = "0x46")]
		[Token(Token = "0x60001CD")]
		 get { } //Length: 70
	}

	[Token(Token = "0x17000070")]
	public GUIStyle style
	{
		[Address(RVA = "0x2F944C0", Offset = "0x2F938C0", Length = "0x7")]
		[Token(Token = "0x60001C6")]
		 get { } //Length: 7
		[Address(RVA = "0x30E15E0", Offset = "0x30E09E0", Length = "0x41")]
		[Token(Token = "0x60001C7")]
		 set { } //Length: 65
	}

	[Address(RVA = "0x30E11F0", Offset = "0x30E05F0", Length = "0x53")]
	[Token(Token = "0x60001D7")]
	private static GUILayoutEntry() { }

	[Address(RVA = "0x30E1370", Offset = "0x30E0770", Length = "0x10C")]
	[Token(Token = "0x60001CF")]
	public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) { }

	[Address(RVA = "0x30E1250", Offset = "0x30E0650", Length = "0x111")]
	[Token(Token = "0x60001CE")]
	public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	[Address(RVA = "0x30E0580", Offset = "0x30DF980", Length = "0x380")]
	[Token(Token = "0x60001D5")]
	public override void ApplyOptions(GUILayoutOption[] options) { }

	[Address(RVA = "0x30E0920", Offset = "0x30DFD20", Length = "0x22B")]
	[Token(Token = "0x60001D4")]
	protected override void ApplyStyleSettings(GUIStyle style) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001D1")]
	public override void CalcHeight() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001D0")]
	public override void CalcWidth() { }

	[Address(RVA = "0x30E1480", Offset = "0x30E0880", Length = "0x2C")]
	[Token(Token = "0x60001CB")]
	public override int get_marginBottom() { }

	[Address(RVA = "0x30E14B0", Offset = "0x30E08B0", Length = "0x46")]
	[Token(Token = "0x60001CC")]
	public int get_marginHorizontal() { }

	[Address(RVA = "0x30E1500", Offset = "0x30E0900", Length = "0x2C")]
	[Token(Token = "0x60001C8")]
	public override int get_marginLeft() { }

	[Address(RVA = "0x30E1530", Offset = "0x30E0930", Length = "0x2C")]
	[Token(Token = "0x60001C9")]
	public override int get_marginRight() { }

	[Address(RVA = "0x30E1560", Offset = "0x30E0960", Length = "0x2C")]
	[Token(Token = "0x60001CA")]
	public override int get_marginTop() { }

	[Address(RVA = "0x30E1590", Offset = "0x30E0990", Length = "0x46")]
	[Token(Token = "0x60001CD")]
	public int get_marginVertical() { }

	[Address(RVA = "0x2F944C0", Offset = "0x2F938C0", Length = "0x7")]
	[Token(Token = "0x60001C6")]
	public GUIStyle get_style() { }

	[Address(RVA = "0x30E15E0", Offset = "0x30E09E0", Length = "0x41")]
	[Token(Token = "0x60001C7")]
	public void set_style(GUIStyle value) { }

	[Address(RVA = "0x30E0B50", Offset = "0x30DFF50", Length = "0x64")]
	[Token(Token = "0x60001D2")]
	public override void SetHorizontal(float x, float width) { }

	[Address(RVA = "0x30E0BC0", Offset = "0x30DFFC0", Length = "0x64")]
	[Token(Token = "0x60001D3")]
	public override void SetVertical(float y, float height) { }

	[Address(RVA = "0x30E0C30", Offset = "0x30E0030", Length = "0x5B9")]
	[Token(Token = "0x60001D6")]
	public virtual string ToString() { }

}

