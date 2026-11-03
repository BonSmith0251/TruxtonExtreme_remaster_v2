namespace Unity.Mathematics;

[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000005")]
public struct AffineTransform : IEquatable<AffineTransform>, IFormattable
{
	[Token(Token = "0x4000008")]
	public static readonly AffineTransform identity; //Field offset: 0x0
	[Token(Token = "0x4000009")]
	public static readonly AffineTransform zero; //Field offset: 0x30
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000006")]
	public float3x3 rs; //Field offset: 0x0
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000007")]
	public float3 t; //Field offset: 0x24

	[Address(RVA = "0x2A74270", Offset = "0x2A73670", Length = "0xBB")]
	[Token(Token = "0x6000012")]
	private static AffineTransform() { }

	[Address(RVA = "0x2A746D0", Offset = "0x2A73AD0", Length = "0x70")]
	[Token(Token = "0x6000004")]
	public AffineTransform(float3 translation, quaternion rotation) { }

	[Address(RVA = "0x2A74480", Offset = "0x2A73880", Length = "0x156")]
	[Token(Token = "0x6000005")]
	public AffineTransform(float3 translation, quaternion rotation, float3 scale) { }

	[Address(RVA = "0x2A746A0", Offset = "0x2A73AA0", Length = "0x27")]
	[Token(Token = "0x6000006")]
	public AffineTransform(float3 translation, float3x3 rotationScale) { }

	[Address(RVA = "0x2A743A0", Offset = "0x2A737A0", Length = "0x68")]
	[Token(Token = "0x6000007")]
	public AffineTransform(float3x3 rotationScale) { }

	[Address(RVA = "0x2A74330", Offset = "0x2A73730", Length = "0x70")]
	[Token(Token = "0x6000008")]
	public AffineTransform(RigidTransform rigid) { }

	[Address(RVA = "0x2A74410", Offset = "0x2A73810", Length = "0x65")]
	[Token(Token = "0x6000009")]
	public AffineTransform(float3x4 m) { }

	[Address(RVA = "0x2A745E0", Offset = "0x2A739E0", Length = "0xBE")]
	[Token(Token = "0x600000A")]
	public AffineTransform(float4x4 m) { }

	[Address(RVA = "0x2A713D0", Offset = "0x2A707D0", Length = "0x1A5F")]
	[Token(Token = "0x600000D")]
	public override bool Equals(AffineTransform rhs) { }

	[Address(RVA = "0x2A736A0", Offset = "0x2A72AA0", Length = "0xA2")]
	[Token(Token = "0x600000E")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2A73750", Offset = "0x2A72B50", Length = "0xE3")]
	[Token(Token = "0x600000F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2A367A0", Offset = "0x2A35BA0", Length = "0x79")]
	[Token(Token = "0x600000B")]
	public static float3x4 op_Implicit(AffineTransform m) { }

	[Address(RVA = "0x2A38850", Offset = "0x2A37C50", Length = "0x159")]
	[Token(Token = "0x600000C")]
	public static float4x4 op_Implicit(AffineTransform m) { }

	[Address(RVA = "0x2A73D30", Offset = "0x2A73130", Length = "0x530")]
	[Token(Token = "0x6000010")]
	public virtual string ToString() { }

	[Address(RVA = "0x2A73840", Offset = "0x2A72C40", Length = "0x4EE")]
	[Token(Token = "0x6000011")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

