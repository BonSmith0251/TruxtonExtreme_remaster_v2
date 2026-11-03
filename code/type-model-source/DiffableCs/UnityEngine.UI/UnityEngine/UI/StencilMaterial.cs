namespace UnityEngine.UI;

[Token(Token = "0x2000072")]
public static class StencilMaterial
{
	[Token(Token = "0x2000073")]
	private class MatEntry
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400023F")]
		public Material baseMat; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000240")]
		public Material customMat; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000241")]
		public int count; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000242")]
		public int stencilId; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000243")]
		public StencilOp operation; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000244")]
		public CompareFunction compareFunction; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000245")]
		public int readMask; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000246")]
		public int writeMask; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000247")]
		public bool useAlphaClip; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000248")]
		public ColorWriteMask colorMask; //Field offset: 0x3C

		[Address(RVA = "0x344AFA0", Offset = "0x344A3A0", Length = "0xE")]
		[Token(Token = "0x60004AB")]
		public MatEntry() { }

	}

	[Token(Token = "0x400023E")]
	private static List<MatEntry> m_List; //Field offset: 0x0

	[Address(RVA = "0x345BEA0", Offset = "0x345B2A0", Length = "0x84")]
	[Token(Token = "0x60004AA")]
	private static StencilMaterial() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use Material.Add instead.", True)]
	[Token(Token = "0x60004A4")]
	public static Material Add(Material baseMat, int stencilID) { }

	[Address(RVA = "0x345AFC0", Offset = "0x345A3C0", Length = "0x96")]
	[Token(Token = "0x60004A5")]
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask) { }

	[Address(RVA = "0x345B060", Offset = "0x345A460", Length = "0xA65")]
	[Token(Token = "0x60004A7")]
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask) { }

	[Address(RVA = "0x345BAD0", Offset = "0x345AED0", Length = "0x161")]
	[Token(Token = "0x60004A9")]
	public static void ClearAll() { }

	[Address(RVA = "0x345BC40", Offset = "0x345B040", Length = "0x86")]
	[Token(Token = "0x60004A6")]
	private static void LogWarningWhenNotInBatchmode(string warning, object context) { }

	[Address(RVA = "0x345BCD0", Offset = "0x345B0D0", Length = "0x1CC")]
	[Token(Token = "0x60004A8")]
	public static void Remove(Material customMat) { }

}

