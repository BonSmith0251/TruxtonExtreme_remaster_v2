namespace UnityEngine;

[Token(Token = "0x20000C6")]
[UsedByNativeCode]
public struct Plane : IEquatable<Plane>, IFormattable
{
	[Token(Token = "0x400023D")]
	internal const int size = 16; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400023E")]
	private Vector3 m_Normal; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400023F")]
	private float m_Distance; //Field offset: 0xC

	[Token(Token = "0x170000EC")]
	public float distance
	{
		[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
		[IsReadOnly]
		[Token(Token = "0x6000588")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170000EB")]
	public Vector3 normal
	{
		[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
		[IsReadOnly]
		[Token(Token = "0x6000587")]
		 get { } //Length: 18
	}

	[Address(RVA = "0x300EE30", Offset = "0x300E230", Length = "0x62")]
	[Token(Token = "0x6000589")]
	public Plane(Vector3 inNormal, Vector3 inPoint) { }

	[Address(RVA = "0x300EEA0", Offset = "0x300E2A0", Length = "0x38")]
	[Token(Token = "0x600058A")]
	public Plane(Vector3 inNormal, float d) { }

	[Address(RVA = "0x300EEE0", Offset = "0x300E2E0", Length = "0xEE")]
	[Token(Token = "0x600058B")]
	public Plane(Vector3 a, Vector3 b, Vector3 c) { }

	[Address(RVA = "0x300EA60", Offset = "0x300DE60", Length = "0x103")]
	[IsReadOnly]
	[Token(Token = "0x600058F")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6CBCA0", Offset = "0x6CB0A0", Length = "0x4E4")]
	[IsReadOnly]
	[Token(Token = "0x6000590")]
	public override bool Equals(Plane other) { }

	[Address(RVA = "0x6CBCA0", Offset = "0x6CB0A0", Length = "0x4E4")]
	[IsReadOnly]
	[Token(Token = "0x6000591")]
	public bool Equals(in Plane other) { }

	[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
	[IsReadOnly]
	[Token(Token = "0x6000588")]
	public float get_distance() { }

	[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
	[IsReadOnly]
	[Token(Token = "0x6000587")]
	public Vector3 get_normal() { }

	[Address(RVA = "0x300EB70", Offset = "0x300DF70", Length = "0x2A")]
	[IsReadOnly]
	[Token(Token = "0x600058C")]
	public float GetDistanceToPoint(Vector3 point) { }

	[Address(RVA = "0x300EBA0", Offset = "0x300DFA0", Length = "0x70")]
	[IsReadOnly]
	[Token(Token = "0x6000592")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x300EFD0", Offset = "0x300E3D0", Length = "0x66")]
	[Token(Token = "0x600058E")]
	public static bool op_Equality(Plane lhs, Plane rhs) { }

	[Address(RVA = "0x300EC10", Offset = "0x300E010", Length = "0x10C")]
	[IsReadOnly]
	[Token(Token = "0x600058D")]
	public bool Raycast(Ray ray, out float enter) { }

	[Address(RVA = "0x300EE20", Offset = "0x300E220", Length = "0xD")]
	[IsReadOnly]
	[Token(Token = "0x6000593")]
	public virtual string ToString() { }

	[Address(RVA = "0x300ED20", Offset = "0x300E120", Length = "0xF8")]
	[IsReadOnly]
	[Token(Token = "0x6000594")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

