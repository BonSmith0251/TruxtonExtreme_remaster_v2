namespace UnityEngine;

[NativeClass("Rectf", "template<typename T> class RectT; typedef RectT<float> Rectf;")]
[NativeHeader("Runtime/Math/Rect.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x20000C8")]
public struct Rect : IEquatable<Rect>, IFormattable
{
	[Token(Token = "0x4000246")]
	private static readonly Rect kZero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[NativeName("x")]
	[Token(Token = "0x4000242")]
	private float m_XMin; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[NativeName("y")]
	[Token(Token = "0x4000243")]
	private float m_YMin; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[NativeName("width")]
	[Token(Token = "0x4000244")]
	private float m_Width; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[NativeName("height")]
	[Token(Token = "0x4000245")]
	private float m_Height; //Field offset: 0xC

	[Token(Token = "0x170000F3")]
	public Vector2 center
	{
		[Address(RVA = "0x3011390", Offset = "0x3010790", Length = "0x2C")]
		[IsReadOnly]
		[Token(Token = "0x60005A7")]
		 get { } //Length: 44
		[Address(RVA = "0x3011550", Offset = "0x3010950", Length = "0x3D")]
		[Token(Token = "0x60005A8")]
		 set { } //Length: 61
	}

	[Token(Token = "0x170000F7")]
	public float height
	{
		[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
		[IsReadOnly]
		[Token(Token = "0x60005AF")]
		 get { } //Length: 6
		[Address(RVA = "0x29FC910", Offset = "0x29FBD10", Length = "0x6")]
		[Token(Token = "0x60005B0")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170000F5")]
	public Vector2 max
	{
		[Address(RVA = "0x30113C0", Offset = "0x30107C0", Length = "0x5B")]
		[IsReadOnly]
		[Token(Token = "0x60005AB")]
		 get { } //Length: 91
		[Address(RVA = "0x3011590", Offset = "0x3010990", Length = "0x64")]
		[Token(Token = "0x60005AC")]
		 set { } //Length: 100
	}

	[Token(Token = "0x170000F4")]
	public Vector2 min
	{
		[Address(RVA = "0x2ACB370", Offset = "0x2ACA770", Length = "0x12")]
		[IsReadOnly]
		[Token(Token = "0x60005A9")]
		 get { } //Length: 18
		[Address(RVA = "0x3011600", Offset = "0x3010A00", Length = "0xE1")]
		[Token(Token = "0x60005AA")]
		 set { } //Length: 225
	}

	[Token(Token = "0x170000F2")]
	public Vector2 position
	{
		[Address(RVA = "0x2ACB370", Offset = "0x2ACA770", Length = "0x12")]
		[IsReadOnly]
		[Token(Token = "0x60005A5")]
		 get { } //Length: 18
		[Address(RVA = "0x2ACB260", Offset = "0x2ACA660", Length = "0x1B")]
		[Token(Token = "0x60005A6")]
		 set { } //Length: 27
	}

	[Token(Token = "0x170000F8")]
	public Vector2 size
	{
		[Address(RVA = "0x29FC9E0", Offset = "0x29FBDE0", Length = "0x13")]
		[IsReadOnly]
		[Token(Token = "0x60005B1")]
		 get { } //Length: 19
		[Address(RVA = "0x2AE1300", Offset = "0x2AE0700", Length = "0x1C")]
		[Token(Token = "0x60005B2")]
		 set { } //Length: 28
	}

	[Token(Token = "0x170000F6")]
	public float width
	{
		[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
		[IsReadOnly]
		[Token(Token = "0x60005AD")]
		 get { } //Length: 229
		[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
		[Token(Token = "0x60005AE")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170000F0")]
	public float x
	{
		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[IsReadOnly]
		[Token(Token = "0x60005A1")]
		 get { } //Length: 5
		[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
		[Token(Token = "0x60005A2")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170000FB")]
	public float xMax
	{
		[Address(RVA = "0x3011420", Offset = "0x3010820", Length = "0xA")]
		[IsReadOnly]
		[Token(Token = "0x60005B7")]
		 get { } //Length: 10
		[Address(RVA = "0x30116F0", Offset = "0x3010AF0", Length = "0xA")]
		[Token(Token = "0x60005B8")]
		 set { } //Length: 10
	}

	[Token(Token = "0x170000F9")]
	public float xMin
	{
		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[IsReadOnly]
		[Token(Token = "0x60005B3")]
		 get { } //Length: 5
		[Address(RVA = "0x3011700", Offset = "0x3010B00", Length = "0x63")]
		[Token(Token = "0x60005B4")]
		 set { } //Length: 99
	}

	[Token(Token = "0x170000F1")]
	public float y
	{
		[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
		[IsReadOnly]
		[Token(Token = "0x60005A3")]
		 get { } //Length: 388
		[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
		[Token(Token = "0x60005A4")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170000FC")]
	public float yMax
	{
		[Address(RVA = "0x3011430", Offset = "0x3010830", Length = "0xB")]
		[IsReadOnly]
		[Token(Token = "0x60005B9")]
		 get { } //Length: 11
		[Address(RVA = "0x3011770", Offset = "0x3010B70", Length = "0xB")]
		[Token(Token = "0x60005BA")]
		 set { } //Length: 11
	}

	[Token(Token = "0x170000FA")]
	public float yMin
	{
		[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
		[IsReadOnly]
		[Token(Token = "0x60005B5")]
		 get { } //Length: 388
		[Address(RVA = "0x3011780", Offset = "0x3010B80", Length = "0x65")]
		[Token(Token = "0x60005B6")]
		 set { } //Length: 101
	}

	[Token(Token = "0x170000EF")]
	public static Rect zero
	{
		[Address(RVA = "0x3011440", Offset = "0x3010840", Length = "0x5A")]
		[Token(Token = "0x600059F")]
		 get { } //Length: 90
	}

	[Address(RVA = "0x3011350", Offset = "0x3010750", Length = "0x39")]
	[Token(Token = "0x60005C9")]
	private static Rect() { }

	[Address(RVA = "0x2A8B9E0", Offset = "0x2A8ADE0", Length = "0x17")]
	[Token(Token = "0x600059E")]
	public Rect(Rect source) { }

	[Address(RVA = "0x27F69A0", Offset = "0x27F5DA0", Length = "0x1A")]
	[Token(Token = "0x600059C")]
	public Rect(float x, float y, float width, float height) { }

	[Address(RVA = "0x2AE0570", Offset = "0x2ADF970", Length = "0x3C")]
	[Token(Token = "0x600059D")]
	public Rect(Vector2 position, Vector2 size) { }

	[Address(RVA = "0x3010B40", Offset = "0x300FF40", Length = "0xA1")]
	[IsReadOnly]
	[Token(Token = "0x60005BC")]
	public bool Contains(Vector3 point) { }

	[Address(RVA = "0x3010A90", Offset = "0x300FE90", Length = "0xA6")]
	[IsReadOnly]
	[Token(Token = "0x60005BB")]
	public bool Contains(Vector2 point) { }

	[Address(RVA = "0x6BE170", Offset = "0x6BD570", Length = "0x72")]
	[IsReadOnly]
	[Token(Token = "0x60005C6")]
	public bool Equals(in Rect other) { }

	[Address(RVA = "0x3010BF0", Offset = "0x300FFF0", Length = "0x10A")]
	[IsReadOnly]
	[Token(Token = "0x60005C4")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6BE170", Offset = "0x6BD570", Length = "0x72")]
	[IsReadOnly]
	[Token(Token = "0x60005C5")]
	public override bool Equals(Rect other) { }

	[Address(RVA = "0x3011390", Offset = "0x3010790", Length = "0x2C")]
	[IsReadOnly]
	[Token(Token = "0x60005A7")]
	public Vector2 get_center() { }

	[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
	[IsReadOnly]
	[Token(Token = "0x60005AF")]
	public float get_height() { }

	[Address(RVA = "0x30113C0", Offset = "0x30107C0", Length = "0x5B")]
	[IsReadOnly]
	[Token(Token = "0x60005AB")]
	public Vector2 get_max() { }

	[Address(RVA = "0x2ACB370", Offset = "0x2ACA770", Length = "0x12")]
	[IsReadOnly]
	[Token(Token = "0x60005A9")]
	public Vector2 get_min() { }

	[Address(RVA = "0x2ACB370", Offset = "0x2ACA770", Length = "0x12")]
	[IsReadOnly]
	[Token(Token = "0x60005A5")]
	public Vector2 get_position() { }

	[Address(RVA = "0x29FC9E0", Offset = "0x29FBDE0", Length = "0x13")]
	[IsReadOnly]
	[Token(Token = "0x60005B1")]
	public Vector2 get_size() { }

	[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
	[IsReadOnly]
	[Token(Token = "0x60005AD")]
	public float get_width() { }

	[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
	[IsReadOnly]
	[Token(Token = "0x60005A1")]
	public float get_x() { }

	[Address(RVA = "0x3011420", Offset = "0x3010820", Length = "0xA")]
	[IsReadOnly]
	[Token(Token = "0x60005B7")]
	public float get_xMax() { }

	[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
	[IsReadOnly]
	[Token(Token = "0x60005B3")]
	public float get_xMin() { }

	[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
	[IsReadOnly]
	[Token(Token = "0x60005A3")]
	public float get_y() { }

	[Address(RVA = "0x3011430", Offset = "0x3010830", Length = "0xB")]
	[IsReadOnly]
	[Token(Token = "0x60005B9")]
	public float get_yMax() { }

	[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
	[IsReadOnly]
	[Token(Token = "0x60005B5")]
	public float get_yMin() { }

	[Address(RVA = "0x3011440", Offset = "0x3010840", Length = "0x5A")]
	[Token(Token = "0x600059F")]
	public static Rect get_zero() { }

	[Address(RVA = "0x80AF80", Offset = "0x80A380", Length = "0x6B")]
	[IsReadOnly]
	[Token(Token = "0x60005C3")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3010D00", Offset = "0x3010100", Length = "0x25")]
	[Token(Token = "0x60005A0")]
	public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) { }

	[Address(RVA = "0x23DE6F0", Offset = "0x23DDAF0", Length = "0x38")]
	[Token(Token = "0x60005C2")]
	public static bool op_Equality(Rect lhs, Rect rhs) { }

	[Address(RVA = "0x30114A0", Offset = "0x30108A0", Length = "0xAC")]
	[Token(Token = "0x60005C1")]
	public static bool op_Inequality(Rect lhs, Rect rhs) { }

	[Address(RVA = "0x3010D30", Offset = "0x3010130", Length = "0xC1")]
	[Token(Token = "0x60005BD")]
	private static Rect OrderMinMax(in Rect rect) { }

	[Address(RVA = "0x3010FA0", Offset = "0x30103A0", Length = "0xD5")]
	[IsReadOnly]
	[Token(Token = "0x60005BE")]
	public bool Overlaps(Rect other) { }

	[Address(RVA = "0x3010EF0", Offset = "0x30102F0", Length = "0xB0")]
	[IsReadOnly]
	[Token(Token = "0x60005C0")]
	public bool Overlaps(Rect other, bool allowInverse) { }

	[Address(RVA = "0x3010E00", Offset = "0x3010200", Length = "0xEC")]
	[IsReadOnly]
	[Token(Token = "0x60005BF")]
	public bool Overlaps(in Rect other) { }

	[Address(RVA = "0x3011550", Offset = "0x3010950", Length = "0x3D")]
	[Token(Token = "0x60005A8")]
	public void set_center(Vector2 value) { }

	[Address(RVA = "0x29FC910", Offset = "0x29FBD10", Length = "0x6")]
	[Token(Token = "0x60005B0")]
	public void set_height(float value) { }

	[Address(RVA = "0x3011590", Offset = "0x3010990", Length = "0x64")]
	[Token(Token = "0x60005AC")]
	public void set_max(Vector2 value) { }

	[Address(RVA = "0x3011600", Offset = "0x3010A00", Length = "0xE1")]
	[Token(Token = "0x60005AA")]
	public void set_min(Vector2 value) { }

	[Address(RVA = "0x2ACB260", Offset = "0x2ACA660", Length = "0x1B")]
	[Token(Token = "0x60005A6")]
	public void set_position(Vector2 value) { }

	[Address(RVA = "0x2AE1300", Offset = "0x2AE0700", Length = "0x1C")]
	[Token(Token = "0x60005B2")]
	public void set_size(Vector2 value) { }

	[Address(RVA = "0x1DB7910", Offset = "0x1DB6D10", Length = "0x6")]
	[Token(Token = "0x60005AE")]
	public void set_width(float value) { }

	[Address(RVA = "0x17CB470", Offset = "0x17CA870", Length = "0x5")]
	[Token(Token = "0x60005A2")]
	public void set_x(float value) { }

	[Address(RVA = "0x30116F0", Offset = "0x3010AF0", Length = "0xA")]
	[Token(Token = "0x60005B8")]
	public void set_xMax(float value) { }

	[Address(RVA = "0x3011700", Offset = "0x3010B00", Length = "0x63")]
	[Token(Token = "0x60005B4")]
	public void set_xMin(float value) { }

	[Address(RVA = "0x17CB500", Offset = "0x17CA900", Length = "0x6")]
	[Token(Token = "0x60005A4")]
	public void set_y(float value) { }

	[Address(RVA = "0x3011770", Offset = "0x3010B70", Length = "0xB")]
	[Token(Token = "0x60005BA")]
	public void set_yMax(float value) { }

	[Address(RVA = "0x3011780", Offset = "0x3010B80", Length = "0x65")]
	[Token(Token = "0x60005B6")]
	public void set_yMin(float value) { }

	[Address(RVA = "0x30110D0", Offset = "0x30104D0", Length = "0x279")]
	[IsReadOnly]
	[Token(Token = "0x60005C8")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x3011080", Offset = "0x3010480", Length = "0x4F")]
	[IsReadOnly]
	[Token(Token = "0x60005C7")]
	public virtual string ToString() { }

}

