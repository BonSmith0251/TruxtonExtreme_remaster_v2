namespace UnityEngine.Splines;

[Token(Token = "0x200004F")]
internal struct SplineModificationData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000138")]
	public readonly Spline Spline; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000139")]
	public readonly SplineModification Modification; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400013A")]
	public readonly int KnotIndex; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400013B")]
	public readonly float PrevCurveLength; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400013C")]
	public readonly float NextCurveLength; //Field offset: 0x14

	[Address(RVA = "0x2E76A10", Offset = "0x2E75E10", Length = "0x4C")]
	[Token(Token = "0x60002CF")]
	public SplineModificationData(Spline spline, SplineModification modification, int knotIndex, float prevCurveLength, float nextCurveLength) { }

}

