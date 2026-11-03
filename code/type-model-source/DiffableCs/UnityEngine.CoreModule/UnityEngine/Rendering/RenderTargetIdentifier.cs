namespace UnityEngine.Rendering;

[Token(Token = "0x200035B")]
public struct RenderTargetIdentifier : IEquatable<RenderTargetIdentifier>
{
	[Token(Token = "0x40009AA")]
	public static readonly RenderTargetIdentifier Invalid; //Field offset: 0x0
	[Token(Token = "0x40009AB")]
	public const int AllDepthSlices = -1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009AC")]
	private BuiltinRenderTextureType m_Type; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40009AD")]
	private int m_NameID; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009AE")]
	private int m_InstanceID; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009AF")]
	private IntPtr m_BufferPointer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009B0")]
	private int m_MipLevel; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40009B1")]
	private CubemapFace m_CubeFace; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009B2")]
	private int m_DepthSlice; //Field offset: 0x20

	[Address(RVA = "0x3085C70", Offset = "0x3085070", Length = "0x43")]
	[Token(Token = "0x6001A2E")]
	private static RenderTargetIdentifier() { }

	[Address(RVA = "0x3085DA0", Offset = "0x30851A0", Length = "0x10C")]
	[Token(Token = "0x6001A23")]
	public RenderTargetIdentifier(Texture tex) { }

	[Address(RVA = "0x3085D20", Offset = "0x3085120", Length = "0x28")]
	[Token(Token = "0x6001A22")]
	public RenderTargetIdentifier(RenderTargetIdentifier renderTargetIdentifier, int mipLevel, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	[Address(RVA = "0x3085D80", Offset = "0x3085180", Length = "0x20")]
	[Token(Token = "0x6001A1E")]
	public RenderTargetIdentifier(BuiltinRenderTextureType type) { }

	[Address(RVA = "0x3085CC0", Offset = "0x30850C0", Length = "0x20")]
	[Token(Token = "0x6001A20")]
	public RenderTargetIdentifier(int nameID) { }

	[Address(RVA = "0x3085CE0", Offset = "0x30850E0", Length = "0x3B")]
	[Token(Token = "0x6001A1F")]
	public RenderTargetIdentifier(string name) { }

	[Address(RVA = "0x3085D50", Offset = "0x3085150", Length = "0x22")]
	[Token(Token = "0x6001A21")]
	public RenderTargetIdentifier(int nameID, int mipLevel = 0, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	[Address(RVA = "0x3085850", Offset = "0x3084C50", Length = "0x89")]
	[Token(Token = "0x6001A2A")]
	public override bool Equals(RenderTargetIdentifier rhs) { }

	[Address(RVA = "0x3085720", Offset = "0x3084B20", Length = "0x12B")]
	[Token(Token = "0x6001A2B")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30858E0", Offset = "0x3084CE0", Length = "0x4D")]
	[Token(Token = "0x6001A29")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3085EB0", Offset = "0x30852B0", Length = "0xCE")]
	[Token(Token = "0x6001A2C")]
	public static bool op_Equality(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs) { }

	[Address(RVA = "0x3085F80", Offset = "0x3085380", Length = "0x4F")]
	[Token(Token = "0x6001A24")]
	public static RenderTargetIdentifier op_Implicit(BuiltinRenderTextureType type) { }

	[Address(RVA = "0x3086170", Offset = "0x3085570", Length = "0x7D")]
	[Token(Token = "0x6001A25")]
	public static RenderTargetIdentifier op_Implicit(string name) { }

	[Address(RVA = "0x3086020", Offset = "0x3085420", Length = "0x14D")]
	[Token(Token = "0x6001A27")]
	public static RenderTargetIdentifier op_Implicit(Texture tex) { }

	[Address(RVA = "0x3085FD0", Offset = "0x30853D0", Length = "0x4F")]
	[Token(Token = "0x6001A26")]
	public static RenderTargetIdentifier op_Implicit(int nameID) { }

	[Address(RVA = "0x30861F0", Offset = "0x30855F0", Length = "0xCE")]
	[Token(Token = "0x6001A2D")]
	public static bool op_Inequality(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs) { }

	[Address(RVA = "0x3085930", Offset = "0x3084D30", Length = "0x33C")]
	[Token(Token = "0x6001A28")]
	public virtual string ToString() { }

}

