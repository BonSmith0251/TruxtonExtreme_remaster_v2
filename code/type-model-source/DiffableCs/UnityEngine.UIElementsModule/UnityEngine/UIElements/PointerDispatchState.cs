namespace UnityEngine.UIElements;

[Token(Token = "0x20002C7")]
internal class PointerDispatchState
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B3F")]
	private IEventHandler[] m_PendingPointerCapture; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B40")]
	private IEventHandler[] m_PointerCapture; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B41")]
	private Boolean[] m_ShouldSendCompatibilityMouseEvents; //Field offset: 0x20

	[Address(RVA = "0x340B320", Offset = "0x340A720", Length = "0x1B9")]
	[Token(Token = "0x600135B")]
	public PointerDispatchState() { }

	[Address(RVA = "0x340A910", Offset = "0x3409D10", Length = "0x2C")]
	[Token(Token = "0x6001363")]
	public void ActivateCompatibilityMouseEvents(int pointerId) { }

	[Address(RVA = "0x340A940", Offset = "0x3409D40", Length = "0x1CB")]
	[Token(Token = "0x600135F")]
	public void CapturePointer(IEventHandler handler, int pointerId) { }

	[Address(RVA = "0x2583D50", Offset = "0x2583150", Length = "0x2B")]
	[Token(Token = "0x600135D")]
	public IEventHandler GetCapturingElement(int pointerId) { }

	[Address(RVA = "0x340AB10", Offset = "0x3409F10", Length = "0x2E")]
	[Token(Token = "0x600135E")]
	public bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	[Address(RVA = "0x340AB40", Offset = "0x3409F40", Length = "0x2C")]
	[Token(Token = "0x6001364")]
	public void PreventCompatibilityMouseEvents(int pointerId) { }

	[Address(RVA = "0x340AB70", Offset = "0x3409F70", Length = "0x51A")]
	[Token(Token = "0x6001362")]
	public void ProcessPointerCapture(int pointerId) { }

	[Address(RVA = "0x340B090", Offset = "0x340A490", Length = "0xB2")]
	[Token(Token = "0x6001360")]
	public void ReleasePointer(int pointerId) { }

	[Address(RVA = "0x340B150", Offset = "0x340A550", Length = "0x3C")]
	[Token(Token = "0x6001361")]
	public void ReleasePointer(IEventHandler handler, int pointerId) { }

	[Address(RVA = "0x340B190", Offset = "0x340A590", Length = "0xE4")]
	[Token(Token = "0x600135C")]
	internal void Reset() { }

	[Address(RVA = "0x340B280", Offset = "0x340A680", Length = "0x9C")]
	[Token(Token = "0x6001365")]
	public bool ShouldSendCompatibilityMouseEvents(IPointerEvent evt) { }

}

