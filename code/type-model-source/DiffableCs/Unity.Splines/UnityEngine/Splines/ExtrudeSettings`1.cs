namespace UnityEngine.Splines;

[Token(Token = "0x2000049")]
public struct ExtrudeSettings
{
	[Token(Token = "0x400011C")]
	private const int k_SegmentsMin = 2; //Field offset: 0x0
	[Token(Token = "0x400011D")]
	private const int k_SegmentsMax = 4096; //Field offset: 0x0
	[Token(Token = "0x400011E")]
	private const float k_RadiusMin = 1E-05; //Field offset: 0x0
	[Token(Token = "0x400011F")]
	private const float k_RadiusMax = 10000; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000120")]
	private T m_Shape; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000121")]
	private bool m_CapEnds; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000122")]
	private bool m_FlipNormals; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000123")]
	private int m_SegmentCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000124")]
	private float m_Radius; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000125")]
	private Vector2 m_Range; //Field offset: 0x0

	[Token(Token = "0x170000A2")]
	public bool CapEnds
	{
		[Address(RVA = "0xAEF450", Offset = "0xAEE850", Length = "0x5")]
		[Token(Token = "0x60002A1")]
		 get { } //Length: 5
		[Address(RVA = "0x1BB2EC0", Offset = "0x1BB22C0", Length = "0x4")]
		[Token(Token = "0x60002A2")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000A3")]
	public bool FlipNormals
	{
		[Address(RVA = "0x1BB2060", Offset = "0x1BB1460", Length = "0x5")]
		[Token(Token = "0x60002A3")]
		 get { } //Length: 5
		[Address(RVA = "0x1BB2F50", Offset = "0x1BB2350", Length = "0x4")]
		[Token(Token = "0x60002A4")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000A5")]
	public float Radius
	{
		[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
		[Token(Token = "0x60002A7")]
		 get { } //Length: 6
		[Address(RVA = "0x1BB3020", Offset = "0x1BB2420", Length = "0x47")]
		[Token(Token = "0x60002A8")]
		 set { } //Length: 71
	}

	[Token(Token = "0x170000A4")]
	public float2 Range
	{
		[Address(RVA = "0x1BB20C0", Offset = "0x1BB14C0", Length = "0x19")]
		[Token(Token = "0x60002A5")]
		 get { } //Length: 25
		[Address(RVA = "0x1BB3070", Offset = "0x1BB2470", Length = "0xA9")]
		[Token(Token = "0x60002A6")]
		 set { } //Length: 169
	}

	[Token(Token = "0x170000A1")]
	public int SegmentCount
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[Token(Token = "0x600029F")]
		 get { } //Length: 4
		[Address(RVA = "0x1BB32C0", Offset = "0x1BB26C0", Length = "0x1A")]
		[Token(Token = "0x60002A0")]
		 set { } //Length: 26
	}

	[Token(Token = "0x170000A6")]
	public T Shape
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x60002A9")]
		 get { } //Length: 4
		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x60002AA")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170000A7")]
	internal int sides
	{
		[Address(RVA = "0x1BB2270", Offset = "0x1BB1670", Length = "0x16C")]
		[Token(Token = "0x60002AD")]
		internal get { } //Length: 364
	}

	[Token(Token = "0x170000A8")]
	internal bool wrapped
	{
		[Address(RVA = "0x1BB2D30", Offset = "0x1BB2130", Length = "0x10B")]
		[Token(Token = "0x60002AE")]
		internal get { } //Length: 267
	}

	[Address(RVA = "0x1BB1E90", Offset = "0x1BB1290", Length = "0x12D")]
	[Token(Token = "0x60002B0")]
	public ExtrudeSettings`1(int segments, bool capped, float2 range, float radius, T shape) { }

	[Address(RVA = "0x1BB18A0", Offset = "0x1BB0CA0", Length = "0x80")]
	[Token(Token = "0x60002AF")]
	public ExtrudeSettings`1(T shape) { }

	[Address(RVA = "0x699E00", Offset = "0x699200", Length = "0x67")]
	[Token(Token = "0x60002AB")]
	internal bool DoCapEnds(K spline) { }

	[Address(RVA = "0x69A010", Offset = "0x699410", Length = "0xFB")]
	[Token(Token = "0x60002AC")]
	internal bool DoCloseSpline(K spline) { }

	[Address(RVA = "0xAEF450", Offset = "0xAEE850", Length = "0x5")]
	[Token(Token = "0x60002A1")]
	public bool get_CapEnds() { }

	[Address(RVA = "0x1BB2060", Offset = "0x1BB1460", Length = "0x5")]
	[Token(Token = "0x60002A3")]
	public bool get_FlipNormals() { }

	[Address(RVA = "0x661840", Offset = "0x660C40", Length = "0x6")]
	[Token(Token = "0x60002A7")]
	public float get_Radius() { }

	[Address(RVA = "0x1BB20C0", Offset = "0x1BB14C0", Length = "0x19")]
	[Token(Token = "0x60002A5")]
	public float2 get_Range() { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[Token(Token = "0x600029F")]
	public int get_SegmentCount() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x60002A9")]
	public T get_Shape() { }

	[Address(RVA = "0x1BB2270", Offset = "0x1BB1670", Length = "0x16C")]
	[Token(Token = "0x60002AD")]
	internal int get_sides() { }

	[Address(RVA = "0x1BB2D30", Offset = "0x1BB2130", Length = "0x10B")]
	[Token(Token = "0x60002AE")]
	internal bool get_wrapped() { }

	[Address(RVA = "0x1BB2EC0", Offset = "0x1BB22C0", Length = "0x4")]
	[Token(Token = "0x60002A2")]
	public void set_CapEnds(bool value) { }

	[Address(RVA = "0x1BB2F50", Offset = "0x1BB2350", Length = "0x4")]
	[Token(Token = "0x60002A4")]
	public void set_FlipNormals(bool value) { }

	[Address(RVA = "0x1BB3020", Offset = "0x1BB2420", Length = "0x47")]
	[Token(Token = "0x60002A8")]
	public void set_Radius(float value) { }

	[Address(RVA = "0x1BB3070", Offset = "0x1BB2470", Length = "0xA9")]
	[Token(Token = "0x60002A6")]
	public void set_Range(float2 value) { }

	[Address(RVA = "0x1BB32C0", Offset = "0x1BB26C0", Length = "0x1A")]
	[Token(Token = "0x60002A0")]
	public void set_SegmentCount(int value) { }

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x60002AA")]
	public void set_Shape(T value) { }

}

