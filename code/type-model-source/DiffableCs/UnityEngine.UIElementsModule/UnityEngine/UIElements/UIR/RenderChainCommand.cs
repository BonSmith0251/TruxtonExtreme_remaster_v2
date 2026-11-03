namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000594")]
internal class RenderChainCommand : LinkedPoolItem<RenderChainCommand>
{
	[Token(Token = "0x4001319")]
	private static ProfilerMarker s_ImmediateOverheadMarker; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400130A")]
	public RenderData owner; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400130B")]
	public RenderChainCommand prev; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400130C")]
	public RenderChainCommand next; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400130D")]
	public CommandType type; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400130E")]
	public CommandFlags flags; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400130F")]
	public Material material; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001310")]
	public MaterialPropertyBlock userProps; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001311")]
	public TextureId texture; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4001312")]
	public int stencilRef; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001313")]
	public float sdfScale; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4001314")]
	public float sharpness; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001315")]
	public MeshHandle mesh; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001316")]
	public int indexOffset; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4001317")]
	public int indexCount; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001318")]
	public Action callback; //Field offset: 0x68

	[Address(RVA = "0x3302500", Offset = "0x3301900", Length = "0x5E")]
	[Token(Token = "0x6002863")]
	private static RenderChainCommand() { }

	[Address(RVA = "0x3302560", Offset = "0x3301960", Length = "0x102")]
	[Token(Token = "0x600285C")]
	public RenderChainCommand() { }

	[Address(RVA = "0x33014D0", Offset = "0x33008D0", Length = "0x154")]
	[Token(Token = "0x6002861")]
	private static Rect CombineScissorRects(Rect r0, Rect r1) { }

	[Address(RVA = "0x3301630", Offset = "0x3300A30", Length = "0x828")]
	[Token(Token = "0x600285E")]
	public void ExecuteNonDrawMesh(DrawParams drawParams, float pixelsPerPoint, ref Exception immediateException) { }

	[Address(RVA = "0x3301E80", Offset = "0x3301280", Length = "0x1B6")]
	[Token(Token = "0x6002860")]
	public static void PopScissor(DrawParams drawParams, float pixelsPerPoint) { }

	[Address(RVA = "0x3302040", Offset = "0x3301440", Length = "0x2A2")]
	[Token(Token = "0x600285F")]
	public static void PushScissor(DrawParams drawParams, Rect scissor, float pixelsPerPoint) { }

	[Address(RVA = "0x33022F0", Offset = "0x33016F0", Length = "0x12A")]
	[Token(Token = "0x6002862")]
	private static RectInt RectPointsToPixelsAndFlipYAxis(Rect rect, float pixelsPerPoint) { }

	[Address(RVA = "0x3302420", Offset = "0x3301820", Length = "0xD7")]
	[Token(Token = "0x600285D")]
	public void Reset() { }

}

