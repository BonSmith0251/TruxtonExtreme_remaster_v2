namespace UnityEngine.UIElements;

[Token(Token = "0x20004AF")]
internal class TextEventHandler
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000FDA")]
	private TextElement m_TextElement; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FDB")]
	private EventCallback<PointerDownEvent> m_LinkTagOnPointerDown; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FDC")]
	private EventCallback<PointerUpEvent> m_LinkTagOnPointerUp; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000FDD")]
	private EventCallback<PointerMoveEvent> m_LinkTagOnPointerMove; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000FDE")]
	private EventCallback<PointerOutEvent> m_LinkTagOnPointerOut; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000FDF")]
	private EventCallback<PointerUpEvent> m_ATagOnPointerUp; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000FE0")]
	private EventCallback<PointerMoveEvent> m_ATagOnPointerMove; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000FE1")]
	private EventCallback<PointerOverEvent> m_ATagOnPointerOver; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000FE2")]
	private EventCallback<PointerOutEvent> m_ATagOnPointerOut; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000FE3")]
	internal bool isOverridingCursor; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000FE4")]
	internal int currentLinkIDHash; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000FE5")]
	internal bool hasLinkTag; //Field offset: 0x60
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x4000FE6")]
	internal bool hasATag; //Field offset: 0x61

	[Token(Token = "0x1700097F")]
	private TextInfo textInfo
	{
		[Address(RVA = "0x32AC770", Offset = "0x32ABB70", Length = "0x29")]
		[Token(Token = "0x6002392")]
		private get { } //Length: 41
	}

	[Address(RVA = "0x32AC730", Offset = "0x32ABB30", Length = "0x38")]
	[Token(Token = "0x6002393")]
	public TextEventHandler(TextElement textElement) { }

	[Address(RVA = "0x32AACA0", Offset = "0x32AA0A0", Length = "0x164")]
	[Token(Token = "0x6002398")]
	private void AllocateATagCallbacks() { }

	[Address(RVA = "0x32AAE10", Offset = "0x32AA210", Length = "0x164")]
	[Token(Token = "0x6002396")]
	private void AllocateLinkCallbacks() { }

	[Address(RVA = "0x32AA790", Offset = "0x32A9B90", Length = "0x2C2")]
	[Token(Token = "0x600239B")]
	private void ATagOnPointerMove(PointerMoveEvent pme) { }

	[Address(RVA = "0x3285510", Offset = "0x3284910", Length = "0x5")]
	[Token(Token = "0x600239C")]
	private void ATagOnPointerOut(PointerOutEvent evt) { }

	[Address(RVA = "0x3285510", Offset = "0x3284910", Length = "0x5")]
	[Token(Token = "0x600239A")]
	private void ATagOnPointerOver(PointerOverEvent _) { }

	[Address(RVA = "0x32AAA60", Offset = "0x32A9E60", Length = "0x23A")]
	[Token(Token = "0x6002399")]
	private void ATagOnPointerUp(PointerUpEvent pue) { }

	[Address(RVA = "0x32AC770", Offset = "0x32ABB70", Length = "0x29")]
	[Token(Token = "0x6002392")]
	private TextInfo get_textInfo() { }

	[Address(RVA = "0x32AAF80", Offset = "0x32AA380", Length = "0x12C")]
	[Token(Token = "0x60023A3")]
	internal void HandleATag() { }

	[Address(RVA = "0x32AB0B0", Offset = "0x32AA4B0", Length = "0x630")]
	[Token(Token = "0x60023A1")]
	internal void HandleLinkAndATagCallbacks() { }

	[Address(RVA = "0x32AB6F0", Offset = "0x32AAAF0", Length = "0x12C")]
	[Token(Token = "0x60023A2")]
	internal void HandleLinkTag() { }

	[Address(RVA = "0x3285290", Offset = "0x3284690", Length = "0xB")]
	[Token(Token = "0x6002397")]
	private bool HasAllocatedATagCallbacks() { }

	[Address(RVA = "0x32852A0", Offset = "0x32846A0", Length = "0xB")]
	[Token(Token = "0x6002395")]
	private bool HasAllocatedLinkCallbacks() { }

	[Address(RVA = "0x32AB820", Offset = "0x32AAC20", Length = "0x349")]
	[Token(Token = "0x600239D")]
	private void LinkTagOnPointerDown(PointerDownEvent pde) { }

	[Address(RVA = "0x32ABB70", Offset = "0x32AAF70", Length = "0x58E")]
	[Token(Token = "0x600239F")]
	private void LinkTagOnPointerMove(PointerMoveEvent pme) { }

	[Address(RVA = "0x32AC100", Offset = "0x32AB500", Length = "0x14B")]
	[Token(Token = "0x60023A0")]
	private void LinkTagOnPointerOut(PointerOutEvent poe) { }

	[Address(RVA = "0x32AC250", Offset = "0x32AB650", Length = "0x349")]
	[Token(Token = "0x600239E")]
	private void LinkTagOnPointerUp(PointerUpEvent pue) { }

	[Address(RVA = "0x32AC5A0", Offset = "0x32AB9A0", Length = "0x183")]
	[Token(Token = "0x6002394")]
	public void OnDestroy() { }

}

