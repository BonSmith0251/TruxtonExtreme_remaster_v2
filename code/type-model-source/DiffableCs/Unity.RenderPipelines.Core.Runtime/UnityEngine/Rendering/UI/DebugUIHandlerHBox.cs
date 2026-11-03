namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002DE")]
public class DebugUIHandlerHBox : DebugUIHandlerWidget
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D47")]
	private DebugUIHandlerContainer m_Container; //Field offset: 0x60

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x600143E")]
	public DebugUIHandlerHBox() { }

	[Address(RVA = "0x2CB1F00", Offset = "0x2CB1300", Length = "0xB3")]
	[Token(Token = "0x600143D")]
	public virtual DebugUIHandlerWidget Next() { }

	[Address(RVA = "0x2CB1FC0", Offset = "0x2CB13C0", Length = "0xBF")]
	[Token(Token = "0x600143C")]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x2CB2080", Offset = "0x2CB1480", Length = "0x65")]
	[Token(Token = "0x600143B")]
	internal virtual void SetWidget(Widget widget) { }

}

