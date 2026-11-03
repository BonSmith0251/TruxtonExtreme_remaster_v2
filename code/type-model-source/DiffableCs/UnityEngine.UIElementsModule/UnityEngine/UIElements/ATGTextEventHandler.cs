namespace UnityEngine.UIElements;

[Token(Token = "0x200049F")]
internal class ATGTextEventHandler
{
	[Token(Token = "0x4000F43")]
	private static readonly Regex s_ATagRegex; //Field offset: 0x0
	[Token(Token = "0x4000F44")]
	private static readonly Regex s_LinkTagRegex; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000F4E")]
	private static Action<Dictionary`2<String, String>> onComplexHyperlinkClicked; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F45")]
	private TextElement m_TextElement; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F46")]
	private EventCallback<PointerDownEvent> m_LinkTagOnPointerDown; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F47")]
	private EventCallback<PointerUpEvent> m_LinkTagOnPointerUp; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F48")]
	private EventCallback<PointerMoveEvent> m_LinkTagOnPointerMove; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000F49")]
	private EventCallback<PointerOutEvent> m_LinkTagOnPointerOut; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000F4A")]
	private EventCallback<PointerUpEvent> m_HyperlinkOnPointerUp; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000F4B")]
	private EventCallback<PointerMoveEvent> m_HyperlinkOnPointerMove; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000F4C")]
	private EventCallback<PointerOverEvent> m_HyperlinkOnPointerOver; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000F4D")]
	private EventCallback<PointerOutEvent> m_HyperlinkOnPointerOut; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000F4F")]
	internal bool isOverridingCursor; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000F50")]
	internal int currentLinkIDHash; //Field offset: 0x5C

	[Address(RVA = "0x3286C60", Offset = "0x3286060", Length = "0xE0")]
	[Token(Token = "0x600229D")]
	private static ATGTextEventHandler() { }

	[Address(RVA = "0x3286D40", Offset = "0x3286140", Length = "0xA1")]
	[Token(Token = "0x600228A")]
	public ATGTextEventHandler(TextElement textElement) { }

	[Address(RVA = "0x3284FB0", Offset = "0x32843B0", Length = "0x164")]
	[Token(Token = "0x600228F")]
	private void AllocateHyperlinkCallbacks() { }

	[Address(RVA = "0x3285120", Offset = "0x3284520", Length = "0x164")]
	[Token(Token = "0x600228D")]
	private void AllocateLinkCallbacks() { }

	[Address(RVA = "0x3285290", Offset = "0x3284690", Length = "0xB")]
	[Token(Token = "0x600228E")]
	private bool HasAllocatedHyperlinkCallbacks() { }

	[Address(RVA = "0x32852A0", Offset = "0x32846A0", Length = "0xB")]
	[Token(Token = "0x600228C")]
	private bool HasAllocatedLinkCallbacks() { }

	[Address(RVA = "0x32852B0", Offset = "0x32846B0", Length = "0x255")]
	[Token(Token = "0x6002293")]
	private void HyperlinkOnPointerMove(PointerMoveEvent pme) { }

	[Address(RVA = "0x3285510", Offset = "0x3284910", Length = "0x5")]
	[Token(Token = "0x6002294")]
	private void HyperlinkOnPointerOut(PointerOutEvent evt) { }

	[Address(RVA = "0x3285510", Offset = "0x3284910", Length = "0x5")]
	[Token(Token = "0x6002292")]
	private void HyperlinkOnPointerOver(PointerOverEvent _) { }

	[Address(RVA = "0x3285520", Offset = "0x3284920", Length = "0x207")]
	[Token(Token = "0x6002290")]
	private void HyperlinkOnPointerUp(PointerUpEvent pue) { }

	[Address(RVA = "0x3285730", Offset = "0x3284B30", Length = "0x3B2")]
	[Token(Token = "0x6002291")]
	private static bool IsComplexHyperLink(string link, out Dictionary<String, String>& hyperLinkData) { }

	[Address(RVA = "0x3285AF0", Offset = "0x3284EF0", Length = "0x236")]
	[Token(Token = "0x6002295")]
	private void LinkTagOnPointerDown(PointerDownEvent pde) { }

	[Address(RVA = "0x3285D30", Offset = "0x3285130", Length = "0x466")]
	[Token(Token = "0x6002297")]
	private void LinkTagOnPointerMove(PointerMoveEvent pme) { }

	[Address(RVA = "0x32861A0", Offset = "0x32855A0", Length = "0x14B")]
	[Token(Token = "0x6002298")]
	private void LinkTagOnPointerOut(PointerOutEvent poe) { }

	[Address(RVA = "0x32862F0", Offset = "0x32856F0", Length = "0x236")]
	[Token(Token = "0x6002296")]
	private void LinkTagOnPointerUp(PointerUpEvent pue) { }

	[Address(RVA = "0x3286530", Offset = "0x3285930", Length = "0x1F")]
	[Token(Token = "0x600228B")]
	public void OnDestroy() { }

	[Address(RVA = "0x3286550", Offset = "0x3285950", Length = "0x286")]
	[Token(Token = "0x600229B")]
	internal void RegisterHyperlinkCallbacks() { }

	[Address(RVA = "0x32867E0", Offset = "0x3285BE0", Length = "0x247")]
	[Token(Token = "0x6002299")]
	internal void RegisterLinkTagCallbacks() { }

	[Address(RVA = "0x3286A30", Offset = "0x3285E30", Length = "0x13C")]
	[Token(Token = "0x600229C")]
	internal void UnRegisterHyperlinkCallbacks() { }

	[Address(RVA = "0x3286B70", Offset = "0x3285F70", Length = "0xE0")]
	[Token(Token = "0x600229A")]
	internal void UnRegisterLinkTagCallbacks() { }

}

