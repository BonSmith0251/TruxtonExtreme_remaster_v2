namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x2000632")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct Dimension : IEquatable<Dimension>
{
	[Token(Token = "0x2000633")]
	internal enum Unit : int
	{
		Unitless = 0,
		Pixel = 1,
		Percent = 2,
		Second = 3,
		Millisecond = 4,
		Degree = 5,
		Gradian = 6,
		Radian = 7,
		Turn = 8,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001745")]
	public Unit unit; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4001746")]
	public float value; //Field offset: 0x4

	[Address(RVA = "0x334EE90", Offset = "0x334E290", Length = "0x9")]
	[Token(Token = "0x6002C10")]
	public Dimension(float value, Unit unit) { }

	[Address(RVA = "0x334EC10", Offset = "0x334E010", Length = "0x25")]
	[Token(Token = "0x6002C15")]
	public override bool Equals(Dimension other) { }

	[Address(RVA = "0x334EB50", Offset = "0x334DF50", Length = "0xB3")]
	[Token(Token = "0x6002C16")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x334EC40", Offset = "0x334E040", Length = "0x3B")]
	[Token(Token = "0x6002C17")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x334EC80", Offset = "0x334E080", Length = "0x19")]
	[Token(Token = "0x6002C1B")]
	public bool IsAngle() { }

	[Address(RVA = "0x334ECA0", Offset = "0x334E0A0", Length = "0x11")]
	[Token(Token = "0x6002C19")]
	public bool IsLength() { }

	[Address(RVA = "0x334ECC0", Offset = "0x334E0C0", Length = "0x14")]
	[Token(Token = "0x6002C1A")]
	public bool IsTimeValue() { }

	[Address(RVA = "0x334EEA0", Offset = "0x334E2A0", Length = "0x22")]
	[Token(Token = "0x6002C14")]
	public static bool op_Equality(Dimension lhs, Dimension rhs) { }

	[Address(RVA = "0x334ECE0", Offset = "0x334E0E0", Length = "0x8A")]
	[Token(Token = "0x6002C13")]
	public Angle ToAngle() { }

	[Address(RVA = "0x334ED70", Offset = "0x334E170", Length = "0x2F")]
	[Token(Token = "0x6002C11")]
	public Length ToLength() { }

	[Address(RVA = "0x334EDA0", Offset = "0x334E1A0", Length = "0xBD")]
	[Token(Token = "0x6002C18")]
	public virtual string ToString() { }

	[Address(RVA = "0x334EE60", Offset = "0x334E260", Length = "0x2F")]
	[Token(Token = "0x6002C12")]
	public TimeValue ToTime() { }

}

