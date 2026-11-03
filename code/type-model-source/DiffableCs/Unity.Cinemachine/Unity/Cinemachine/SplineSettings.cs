namespace Unity.Cinemachine;

[Token(Token = "0x20000EB")]
public struct SplineSettings
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400036F")]
	[Tooltip("The Spline container to which the position will apply.")]
	public SplineContainer Spline; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NoSaveDuringPlay]
	[Token(Token = "0x4000370")]
	[Tooltip("The position along the spline.  The actual value corresponding to a given point on the spline will depend on the unity type.")]
	public float Position; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000371")]
	[Tooltip("How to interpret the Spline Position:\n- <b>Distance</b>: Values range from 0 (start of Spline) to Length of the Spline (end of Spline).\n- <b>Normalized</b>: Values range from 0 (start of Spline) to 1 (end of Spline).\n- <b>Knot</b>: Values are defined by knot indices and a fractional value representing the normalized interpolation between the specific knot index and the next knot.\n")]
	public PathIndexUnit Units; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000372")]
	private CachedScaledSpline m_CachedSpline; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000373")]
	private int m_CachedFrame; //Field offset: 0x18

	[Address(RVA = "0x2864740", Offset = "0x2863B40", Length = "0x7B")]
	[Token(Token = "0x600044E")]
	public void ChangeUnitPreservePosition(PathIndexUnit newUnits) { }

	[Address(RVA = "0x28647C0", Offset = "0x2863BC0", Length = "0x482")]
	[Token(Token = "0x600044F")]
	internal CachedScaledSpline GetCachedSpline() { }

	[Address(RVA = "0x2864C50", Offset = "0x2864050", Length = "0x48")]
	[Token(Token = "0x6000450")]
	public void InvalidateCache() { }

}

