namespace TMPro;

[Token(Token = "0x20000BA")]
public class TMP_UpdateRegistry
{
	[Token(Token = "0x4000696")]
	private static TMP_UpdateRegistry s_Instance; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000697")]
	private readonly List<ICanvasElement> m_LayoutRebuildQueue; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000698")]
	private HashSet<Int32> m_LayoutQueueLookup; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000699")]
	private readonly List<ICanvasElement> m_GraphicRebuildQueue; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400069A")]
	private HashSet<Int32> m_GraphicQueueLookup; //Field offset: 0x28

	[Token(Token = "0x170001A8")]
	public static TMP_UpdateRegistry instance
	{
		[Address(RVA = "0x2F20D10", Offset = "0x2F20110", Length = "0x1D9")]
		[Token(Token = "0x6000710")]
		 get { } //Length: 473
	}

	[Address(RVA = "0x2F20BB0", Offset = "0x2F1FFB0", Length = "0x15F")]
	[Token(Token = "0x6000711")]
	protected TMP_UpdateRegistry() { }

	[Address(RVA = "0x2F20D10", Offset = "0x2F20110", Length = "0x1D9")]
	[Token(Token = "0x6000710")]
	public static TMP_UpdateRegistry get_instance() { }

	[Address(RVA = "0x2F1FFD0", Offset = "0x2F1F3D0", Length = "0x12A")]
	[Token(Token = "0x6000715")]
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	[Address(RVA = "0x2F20100", Offset = "0x2F1F500", Length = "0x12A")]
	[Token(Token = "0x6000713")]
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	[Address(RVA = "0x2F20230", Offset = "0x2F1F630", Length = "0xF6")]
	[Token(Token = "0x600071A")]
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	[Address(RVA = "0x2F20330", Offset = "0x2F1F730", Length = "0xF6")]
	[Token(Token = "0x6000719")]
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	[Address(RVA = "0x2F20430", Offset = "0x2F1F830", Length = "0x2BC")]
	[Token(Token = "0x6000716")]
	private void PerformUpdateForCanvasRendererObjects() { }

	[Address(RVA = "0x2F206F0", Offset = "0x2F1FAF0", Length = "0x53")]
	[Token(Token = "0x6000717")]
	private void PerformUpdateForMeshRendererObjects() { }

	[Address(RVA = "0x2F20750", Offset = "0x2F1FB50", Length = "0x126")]
	[Token(Token = "0x6000714")]
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	[Address(RVA = "0x2F20880", Offset = "0x2F1FC80", Length = "0x126")]
	[Token(Token = "0x6000712")]
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	[Address(RVA = "0x2F209B0", Offset = "0x2F1FDB0", Length = "0x1FE")]
	[Token(Token = "0x6000718")]
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

}

