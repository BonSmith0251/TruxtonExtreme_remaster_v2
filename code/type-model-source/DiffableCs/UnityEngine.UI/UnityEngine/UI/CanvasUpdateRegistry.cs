namespace UnityEngine.UI;

[Token(Token = "0x200000A")]
public class CanvasUpdateRegistry
{
	[Token(Token = "0x400001D")]
	private static CanvasUpdateRegistry s_Instance; //Field offset: 0x0
	[Token(Token = "0x4000021")]
	private const string m_CullingUpdateProfilerString = "ClipperRegistry.Cull"; //Field offset: 0x0
	[Token(Token = "0x4000024")]
	private static readonly Comparison<ICanvasElement> s_SortLayoutFunction; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400001E")]
	private bool m_PerformingLayoutUpdate; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x400001F")]
	private bool m_PerformingGraphicUpdate; //Field offset: 0x11
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000020")]
	private String[] m_CanvasUpdateProfilerStrings; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000022")]
	private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000023")]
	private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue; //Field offset: 0x28

	[Token(Token = "0x1700000A")]
	public static CanvasUpdateRegistry instance
	{
		[Address(RVA = "0x31D2BF0", Offset = "0x31D1FF0", Length = "0xDB")]
		[Token(Token = "0x6000022")]
		 get { } //Length: 219
	}

	[Address(RVA = "0x31D2950", Offset = "0x31D1D50", Length = "0x8E")]
	[Token(Token = "0x6000036")]
	private static CanvasUpdateRegistry() { }

	[Address(RVA = "0x31D29E0", Offset = "0x31D1DE0", Length = "0x201")]
	[Token(Token = "0x6000021")]
	protected CanvasUpdateRegistry() { }

	[Address(RVA = "0x31D1270", Offset = "0x31D0670", Length = "0x1BD")]
	[Token(Token = "0x6000024")]
	private void CleanInvalidItems() { }

	[Address(RVA = "0x31D1430", Offset = "0x31D0830", Length = "0x23F")]
	[Token(Token = "0x600002F")]
	public static void DisableCanvasElementForRebuild(ICanvasElement element) { }

	[Address(RVA = "0x31D2BF0", Offset = "0x31D1FF0", Length = "0xDB")]
	[Token(Token = "0x6000022")]
	public static CanvasUpdateRegistry get_instance() { }

	[Address(RVA = "0x31D1670", Offset = "0x31D0A70", Length = "0x105")]
	[Token(Token = "0x6000033")]
	private void InternalDisableCanvasElementForGraphicRebuild(ICanvasElement element) { }

	[Address(RVA = "0x31D1780", Offset = "0x31D0B80", Length = "0x105")]
	[Token(Token = "0x6000032")]
	private void InternalDisableCanvasElementForLayoutRebuild(ICanvasElement element) { }

	[Address(RVA = "0x31D1890", Offset = "0x31D0C90", Length = "0xB5")]
	[Token(Token = "0x600002D")]
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	[Address(RVA = "0x31D1950", Offset = "0x31D0D50", Length = "0x8B")]
	[Token(Token = "0x600002A")]
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	[Address(RVA = "0x31D19E0", Offset = "0x31D0DE0", Length = "0x105")]
	[Token(Token = "0x6000031")]
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	[Address(RVA = "0x31D1AF0", Offset = "0x31D0EF0", Length = "0x105")]
	[Token(Token = "0x6000030")]
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	[Address(RVA = "0x31D1C00", Offset = "0x31D1000", Length = "0x4F")]
	[Token(Token = "0x6000035")]
	public static bool IsRebuildingGraphics() { }

	[Address(RVA = "0x31D1C50", Offset = "0x31D1050", Length = "0x4F")]
	[Token(Token = "0x6000034")]
	public static bool IsRebuildingLayout() { }

	[Address(RVA = "0x31D1CA0", Offset = "0x31D10A0", Length = "0xC9")]
	[Token(Token = "0x6000023")]
	private bool ObjectValidForUpdate(ICanvasElement element) { }

	[Address(RVA = "0x31D1D70", Offset = "0x31D1170", Length = "0xC3")]
	[Token(Token = "0x6000026")]
	private static int ParentCount(Transform child) { }

	[Address(RVA = "0x31D1E40", Offset = "0x31D1240", Length = "0x692")]
	[Token(Token = "0x6000025")]
	private void PerformUpdate() { }

	[Address(RVA = "0x31D24E0", Offset = "0x31D18E0", Length = "0x5E")]
	[Token(Token = "0x600002B")]
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	[Address(RVA = "0x31D2540", Offset = "0x31D1940", Length = "0x5E")]
	[Token(Token = "0x6000028")]
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	[Address(RVA = "0x31D25A0", Offset = "0x31D19A0", Length = "0xAF")]
	[Token(Token = "0x6000027")]
	private static int SortLayoutList(ICanvasElement x, ICanvasElement y) { }

	[Address(RVA = "0x31D2650", Offset = "0x31D1A50", Length = "0x5E")]
	[Token(Token = "0x600002C")]
	public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	[Address(RVA = "0x31D26B0", Offset = "0x31D1AB0", Length = "0x5E")]
	[Token(Token = "0x6000029")]
	public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	[Address(RVA = "0x31D2710", Offset = "0x31D1B10", Length = "0x23F")]
	[Token(Token = "0x600002E")]
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

}

