namespace UnityEngine.Splines;

[Token(Token = "0x2000006")]
public struct BezierKnot : ISerializationCallbackReceiver, IEquatable<BezierKnot>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000A")]
	public float3 Position; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400000B")]
	public float3 TangentIn; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400000C")]
	public float3 TangentOut; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400000D")]
	public quaternion Rotation; //Field offset: 0x24

	[Address(RVA = "0x2E55E10", Offset = "0x2E55210", Length = "0x7E")]
	[Token(Token = "0x6000018")]
	public BezierKnot(float3 position) { }

	[Address(RVA = "0x2E55E90", Offset = "0x2E55290", Length = "0x94")]
	[Token(Token = "0x6000019")]
	public BezierKnot(float3 position, float3 tangentIn, float3 tangentOut) { }

	[Address(RVA = "0x2E55DD0", Offset = "0x2E551D0", Length = "0x3D")]
	[Token(Token = "0x600001A")]
	public BezierKnot(float3 position, float3 tangentIn, float3 tangentOut, quaternion rotation) { }

	[Address(RVA = "0x2E54A20", Offset = "0x2E53E20", Length = "0x68C")]
	[Token(Token = "0x600001E")]
	internal BezierKnot BakeTangentDirectionToRotation(bool mirrored, BezierTangent main = 1) { }

	[Address(RVA = "0x2E550B0", Offset = "0x2E544B0", Length = "0x11B")]
	[Token(Token = "0x6000022")]
	public override bool Equals(BezierKnot other) { }

	[Address(RVA = "0x2E551D0", Offset = "0x2E545D0", Length = "0xA9")]
	[Token(Token = "0x6000023")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2E55280", Offset = "0x2E54680", Length = "0xFE")]
	[Token(Token = "0x6000024")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2E55380", Offset = "0x2E54780", Length = "0x94")]
	[Token(Token = "0x6000020")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600001F")]
	public override void OnBeforeSerialize() { }

	[Address(RVA = "0x2E55F30", Offset = "0x2E55330", Length = "0x69")]
	[Token(Token = "0x600001C")]
	public static BezierKnot op_Addition(BezierKnot knot, float3 rhs) { }

	[Address(RVA = "0x2E55FA0", Offset = "0x2E553A0", Length = "0x68")]
	[Token(Token = "0x600001D")]
	public static BezierKnot op_Subtraction(BezierKnot knot, float3 rhs) { }

	[Address(RVA = "0x2E55420", Offset = "0x2E54820", Length = "0x23E")]
	[Token(Token = "0x6000021")]
	public virtual string ToString() { }

	[Address(RVA = "0x2E55660", Offset = "0x2E54A60", Length = "0x762")]
	[Token(Token = "0x600001B")]
	public BezierKnot Transform(float4x4 matrix) { }

}

