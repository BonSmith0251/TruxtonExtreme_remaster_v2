namespace UnityEngine;

[NativeClass("AABB")]
[NativeHeader("Runtime/Geometry/AABB.h")]
[NativeHeader("Runtime/Geometry/Intersection.h")]
[NativeHeader("Runtime/Geometry/Ray.h")]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeType(Header = "Runtime/Geometry/AABB.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x20000C3")]
public struct Bounds : IEquatable<Bounds>, IFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000239")]
	private Vector3 m_Center; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[NativeName("m_Extent")]
	[Token(Token = "0x400023A")]
	private Vector3 m_Extents; //Field offset: 0xC

	[Token(Token = "0x170000E4")]
	public Vector3 center
	{
		[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
		[IsReadOnly]
		[Token(Token = "0x600055C")]
		 get { } //Length: 18
		[Address(RVA = "0x28A7D50", Offset = "0x28A7150", Length = "0xF")]
		[Token(Token = "0x600055D")]
		 set { } //Length: 15
	}

	[Token(Token = "0x170000E6")]
	public Vector3 extents
	{
		[Address(RVA = "0x2C646C0", Offset = "0x2C63AC0", Length = "0x13")]
		[IsReadOnly]
		[Token(Token = "0x6000560")]
		 get { } //Length: 19
		[Address(RVA = "0x2E7FCE0", Offset = "0x2E7F0E0", Length = "0x6A")]
		[Token(Token = "0x6000561")]
		 set { } //Length: 106
	}

	[Token(Token = "0x170000E8")]
	public Vector3 max
	{
		[Address(RVA = "0x2FCF4E0", Offset = "0x2FCE8E0", Length = "0x2F")]
		[IsReadOnly]
		[Token(Token = "0x6000564")]
		 get { } //Length: 47
		[Address(RVA = "0x2FCF6E0", Offset = "0x2FCEAE0", Length = "0x76")]
		[Token(Token = "0x6000565")]
		 set { } //Length: 118
	}

	[Token(Token = "0x170000E7")]
	public Vector3 min
	{
		[Address(RVA = "0x2FCF510", Offset = "0x2FCE910", Length = "0x2F")]
		[IsReadOnly]
		[Token(Token = "0x6000562")]
		 get { } //Length: 47
		[Address(RVA = "0x2FCF760", Offset = "0x2FCEB60", Length = "0x70")]
		[Token(Token = "0x6000563")]
		 set { } //Length: 112
	}

	[Token(Token = "0x170000E5")]
	public Vector3 size
	{
		[Address(RVA = "0x2FCF540", Offset = "0x2FCE940", Length = "0x2D")]
		[IsReadOnly]
		[Token(Token = "0x600055E")]
		 get { } //Length: 45
		[Address(RVA = "0x2FCF7D0", Offset = "0x2FCEBD0", Length = "0x32")]
		[Token(Token = "0x600055F")]
		 set { } //Length: 50
	}

	[Address(RVA = "0x2FCF490", Offset = "0x2FCE890", Length = "0x45")]
	[Token(Token = "0x6000557")]
	public Bounds(Vector3 center, Vector3 size) { }

	[Address(RVA = "0x2FCEFF0", Offset = "0x2FCE3F0", Length = "0x42")]
	[IsReadOnly]
	[Token(Token = "0x6000572")]
	public bool Contains(Vector3 point) { }

	[Address(RVA = "0x2818B10", Offset = "0x2817F10", Length = "0x649")]
	[Token(Token = "0x600056C")]
	public void Encapsulate(Bounds bounds) { }

	[Address(RVA = "0x8FD370", Offset = "0x8FC770", Length = "0x65E")]
	[Token(Token = "0x600056B")]
	public void Encapsulate(in Vector3 point) { }

	[Address(RVA = "0x8FD370", Offset = "0x8FC770", Length = "0x65E")]
	[Token(Token = "0x600056A")]
	public void Encapsulate(Vector3 point) { }

	[Address(RVA = "0x2FCF0A0", Offset = "0x2FCE4A0", Length = "0x10B")]
	[IsReadOnly]
	[Token(Token = "0x6000559")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x2FCF040", Offset = "0x2FCE440", Length = "0x55")]
	[IsReadOnly]
	[Token(Token = "0x600055A")]
	public override bool Equals(Bounds other) { }

	[Address(RVA = "0x2FCF040", Offset = "0x2FCE440", Length = "0x55")]
	[IsReadOnly]
	[Token(Token = "0x600055B")]
	public bool Equals(in Bounds other) { }

	[Address(RVA = "0xAEF0B0", Offset = "0xAEE4B0", Length = "0x12")]
	[IsReadOnly]
	[Token(Token = "0x600055C")]
	public Vector3 get_center() { }

	[Address(RVA = "0x2C646C0", Offset = "0x2C63AC0", Length = "0x13")]
	[IsReadOnly]
	[Token(Token = "0x6000560")]
	public Vector3 get_extents() { }

	[Address(RVA = "0x2FCF4E0", Offset = "0x2FCE8E0", Length = "0x2F")]
	[IsReadOnly]
	[Token(Token = "0x6000564")]
	public Vector3 get_max() { }

	[Address(RVA = "0x2FCF510", Offset = "0x2FCE910", Length = "0x2F")]
	[IsReadOnly]
	[Token(Token = "0x6000562")]
	public Vector3 get_min() { }

	[Address(RVA = "0x2FCF540", Offset = "0x2FCE940", Length = "0x2D")]
	[IsReadOnly]
	[Token(Token = "0x600055E")]
	public Vector3 get_size() { }

	[Address(RVA = "0xDEB0B0", Offset = "0xDEA4B0", Length = "0x99")]
	[IsReadOnly]
	[Token(Token = "0x6000558")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2FCF1B0", Offset = "0x2FCE5B0", Length = "0x42")]
	[IsReadOnly]
	[NativeMethod("IsInside", IsThreadSafe = True)]
	[Token(Token = "0x6000571")]
	private bool Internal_Contains(in Vector3 point) { }

	[Address(RVA = "0x2FCF260", Offset = "0x2FCE660", Length = "0x4F")]
	[IsReadOnly]
	[Token(Token = "0x600056E")]
	public bool IntersectRay(Ray ray) { }

	[Address(RVA = "0x2FCF200", Offset = "0x2FCE600", Length = "0x52")]
	[FreeFunction("IntersectRayAABB", IsThreadSafe = True)]
	[Token(Token = "0x6000573")]
	private static bool IntersectRayAABB(in Ray ray, in Bounds bounds, out float dist) { }

	[Address(RVA = "0x1DD9B20", Offset = "0x1DD8F20", Length = "0xEC")]
	[IsReadOnly]
	[Token(Token = "0x600056D")]
	public bool Intersects(Bounds bounds) { }

	[Address(RVA = "0x2FCF570", Offset = "0x2FCE970", Length = "0xAD")]
	[Token(Token = "0x6000566")]
	public static bool op_Equality(Bounds lhs, Bounds rhs) { }

	[Address(RVA = "0x2FCF620", Offset = "0x2FCEA20", Length = "0xB1")]
	[Token(Token = "0x6000567")]
	public static bool op_Inequality(Bounds lhs, Bounds rhs) { }

	[Address(RVA = "0x28A7D50", Offset = "0x28A7150", Length = "0xF")]
	[Token(Token = "0x600055D")]
	public void set_center(Vector3 value) { }

	[Address(RVA = "0x2E7FCE0", Offset = "0x2E7F0E0", Length = "0x6A")]
	[Token(Token = "0x6000561")]
	public void set_extents(Vector3 value) { }

	[Address(RVA = "0x2FCF6E0", Offset = "0x2FCEAE0", Length = "0x76")]
	[Token(Token = "0x6000565")]
	public void set_max(Vector3 value) { }

	[Address(RVA = "0x2FCF760", Offset = "0x2FCEB60", Length = "0x70")]
	[Token(Token = "0x6000563")]
	public void set_min(Vector3 value) { }

	[Address(RVA = "0x2FCF7D0", Offset = "0x2FCEBD0", Length = "0x32")]
	[Token(Token = "0x600055F")]
	public void set_size(Vector3 value) { }

	[Address(RVA = "0x2FCF310", Offset = "0x2FCE710", Length = "0x6E")]
	[Token(Token = "0x6000568")]
	public void SetMinMax(Vector3 min, Vector3 max) { }

	[Address(RVA = "0x2FCF2B0", Offset = "0x2FCE6B0", Length = "0x5F")]
	[Token(Token = "0x6000569")]
	public void SetMinMax(in Vector3 min, in Vector3 max) { }

	[Address(RVA = "0x2FCF480", Offset = "0x2FCE880", Length = "0xD")]
	[IsReadOnly]
	[Token(Token = "0x600056F")]
	public virtual string ToString() { }

	[Address(RVA = "0x2FCF380", Offset = "0x2FCE780", Length = "0xF8")]
	[IsReadOnly]
	[Token(Token = "0x6000570")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

