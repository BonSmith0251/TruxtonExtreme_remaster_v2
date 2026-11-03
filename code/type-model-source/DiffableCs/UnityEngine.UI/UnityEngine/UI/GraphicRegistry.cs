namespace UnityEngine.UI;

[Token(Token = "0x2000022")]
public class GraphicRegistry
{
	[Token(Token = "0x4000092")]
	private static GraphicRegistry s_Instance; //Field offset: 0x0
	[Token(Token = "0x4000095")]
	private static readonly List<Graphic> s_EmptyList; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000093")]
	private readonly Dictionary<Canvas, IndexedSet`1<Graphic>> m_Graphics; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000094")]
	private readonly Dictionary<Canvas, IndexedSet`1<Graphic>> m_RaycastableGraphics; //Field offset: 0x18

	[Token(Token = "0x1700004A")]
	public static GraphicRegistry instance
	{
		[Address(RVA = "0x31DFD00", Offset = "0x31DF100", Length = "0x251")]
		[Token(Token = "0x6000133")]
		 get { } //Length: 593
	}

	[Address(RVA = "0x31DFAE0", Offset = "0x31DEEE0", Length = "0x89")]
	[Token(Token = "0x600013C")]
	private static GraphicRegistry() { }

	[Address(RVA = "0x31DFB70", Offset = "0x31DEF70", Length = "0x186")]
	[Token(Token = "0x6000132")]
	protected GraphicRegistry() { }

	[Address(RVA = "0x31DED60", Offset = "0x31DE160", Length = "0x2F6")]
	[Token(Token = "0x6000138")]
	public static void DisableGraphicForCanvas(Canvas c, Graphic graphic) { }

	[Address(RVA = "0x31DF060", Offset = "0x31DE460", Length = "0x187")]
	[Token(Token = "0x6000139")]
	public static void DisableRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	[Address(RVA = "0x31DFD00", Offset = "0x31DF100", Length = "0x251")]
	[Token(Token = "0x6000133")]
	public static GraphicRegistry get_instance() { }

	[Address(RVA = "0x31DF1F0", Offset = "0x31DE5F0", Length = "0xBC")]
	[Token(Token = "0x600013A")]
	public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas) { }

	[Address(RVA = "0x31DF2B0", Offset = "0x31DE6B0", Length = "0xBC")]
	[Token(Token = "0x600013B")]
	public static IList<Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas) { }

	[Address(RVA = "0x31DF370", Offset = "0x31DE770", Length = "0x1FE")]
	[Token(Token = "0x6000134")]
	public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	[Address(RVA = "0x31DF570", Offset = "0x31DE970", Length = "0x210")]
	[Token(Token = "0x6000135")]
	public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	[Address(RVA = "0x31DF790", Offset = "0x31DEB90", Length = "0x1B5")]
	[Token(Token = "0x6000136")]
	public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	[Address(RVA = "0x31DF950", Offset = "0x31DED50", Length = "0x181")]
	[Token(Token = "0x6000137")]
	public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

}

