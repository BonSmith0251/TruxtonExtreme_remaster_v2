namespace TMPro;

[Token(Token = "0x20000B9")]
public class TMP_UpdateManager
{
	[Token(Token = "0x4000688")]
	private static TMP_UpdateManager s_Instance; //Field offset: 0x0
	[Token(Token = "0x4000691")]
	private static ProfilerMarker k_RegisterTextObjectForUpdateMarker; //Field offset: 0x8
	[Token(Token = "0x4000692")]
	private static ProfilerMarker k_RegisterTextElementForGraphicRebuildMarker; //Field offset: 0x10
	[Token(Token = "0x4000693")]
	private static ProfilerMarker k_RegisterTextElementForCullingUpdateMarker; //Field offset: 0x18
	[Token(Token = "0x4000694")]
	private static ProfilerMarker k_UnregisterTextObjectForUpdateMarker; //Field offset: 0x20
	[Token(Token = "0x4000695")]
	private static ProfilerMarker k_UnregisterTextElementForGraphicRebuildMarker; //Field offset: 0x28
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000689")]
	private readonly HashSet<Int32> m_LayoutQueueLookup; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400068A")]
	private readonly List<TMP_Text> m_LayoutRebuildQueue; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400068B")]
	private readonly HashSet<Int32> m_GraphicQueueLookup; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400068C")]
	private readonly List<TMP_Text> m_GraphicRebuildQueue; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400068D")]
	private readonly HashSet<Int32> m_InternalUpdateLookup; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400068E")]
	private readonly List<TMP_Text> m_InternalUpdateQueue; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400068F")]
	private readonly HashSet<Int32> m_CullingUpdateLookup; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000690")]
	private readonly List<TMP_Text> m_CullingUpdateQueue; //Field offset: 0x48

	[Token(Token = "0x170001A7")]
	private static TMP_UpdateManager instance
	{
		[Address(RVA = "0x2F1FEF0", Offset = "0x2F1F2F0", Length = "0xDB")]
		[Token(Token = "0x60006FE")]
		private get { } //Length: 219
	}

	[Address(RVA = "0x2F1FB80", Offset = "0x2F1EF80", Length = "0x14C")]
	[Token(Token = "0x600070F")]
	private static TMP_UpdateManager() { }

	[Address(RVA = "0x2F1FCD0", Offset = "0x2F1F0D0", Length = "0x217")]
	[Token(Token = "0x60006FF")]
	private TMP_UpdateManager() { }

	[Address(RVA = "0x2F1ED00", Offset = "0x2F1E100", Length = "0x2E4")]
	[Token(Token = "0x6000709")]
	private void DoRebuilds() { }

	[Address(RVA = "0x2F1FEF0", Offset = "0x2F1F2F0", Length = "0xDB")]
	[Token(Token = "0x60006FE")]
	private static TMP_UpdateManager get_instance() { }

	[Address(RVA = "0x2F1EFF0", Offset = "0x2F1E3F0", Length = "0xB9")]
	[Token(Token = "0x6000707")]
	private void InternalRegisterTextElementForCullingUpdate(TMP_Text element) { }

	[Address(RVA = "0x2F1F0B0", Offset = "0x2F1E4B0", Length = "0xB9")]
	[Token(Token = "0x6000705")]
	private void InternalRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	[Address(RVA = "0x2F1F170", Offset = "0x2F1E570", Length = "0xB9")]
	[Token(Token = "0x6000703")]
	private void InternalRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	[Address(RVA = "0x2F1F230", Offset = "0x2F1E630", Length = "0xB9")]
	[Token(Token = "0x6000701")]
	private void InternalRegisterTextObjectForUpdate(TMP_Text textObject) { }

	[Address(RVA = "0x2F1F2F0", Offset = "0x2F1E6F0", Length = "0x91")]
	[Token(Token = "0x600070C")]
	private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	[Address(RVA = "0x2F1F390", Offset = "0x2F1E790", Length = "0x91")]
	[Token(Token = "0x600070D")]
	private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	[Address(RVA = "0x2F1F430", Offset = "0x2F1E830", Length = "0x91")]
	[Token(Token = "0x600070E")]
	private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject) { }

	[Address(RVA = "0x2F1F4D0", Offset = "0x2F1E8D0", Length = "0x7")]
	[Token(Token = "0x6000708")]
	private void OnCameraPreCull() { }

	[Address(RVA = "0x2F1F4E0", Offset = "0x2F1E8E0", Length = "0xFA")]
	[Token(Token = "0x6000706")]
	public static void RegisterTextElementForCullingUpdate(TMP_Text element) { }

	[Address(RVA = "0x2F1F5E0", Offset = "0x2F1E9E0", Length = "0xFA")]
	[Token(Token = "0x6000704")]
	public static void RegisterTextElementForGraphicRebuild(TMP_Text element) { }

	[Address(RVA = "0x2F1F6E0", Offset = "0x2F1EAE0", Length = "0xFA")]
	[Token(Token = "0x6000702")]
	public static void RegisterTextElementForLayoutRebuild(TMP_Text element) { }

	[Address(RVA = "0x2F1F7E0", Offset = "0x2F1EBE0", Length = "0xFA")]
	[Token(Token = "0x6000700")]
	internal static void RegisterTextObjectForUpdate(TMP_Text textObject) { }

	[Address(RVA = "0x2F1F8E0", Offset = "0x2F1ECE0", Length = "0x1CE")]
	[Token(Token = "0x600070B")]
	public static void UnRegisterTextElementForRebuild(TMP_Text element) { }

	[Address(RVA = "0x2F1FAB0", Offset = "0x2F1EEB0", Length = "0xCE")]
	[Token(Token = "0x600070A")]
	internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject) { }

}

