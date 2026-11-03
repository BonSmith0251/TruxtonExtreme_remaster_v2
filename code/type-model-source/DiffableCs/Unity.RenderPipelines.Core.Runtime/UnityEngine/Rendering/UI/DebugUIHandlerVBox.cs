namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002F3")]
public class DebugUIHandlerVBox : DebugUIHandlerWidget
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D94")]
	private DebugUIHandlerContainer m_Container; //Field offset: 0x60

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x60014C1")]
	public DebugUIHandlerVBox() { }

	[Address(RVA = "0x2CB6520", Offset = "0x2CB5920", Length = "0xB3")]
	[Token(Token = "0x60014C0")]
	public virtual DebugUIHandlerWidget Next() { }

	[Address(RVA = "0x2CB65E0", Offset = "0x2CB59E0", Length = "0xBF")]
	[Token(Token = "0x60014BF")]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x2CB66A0", Offset = "0x2CB5AA0", Length = "0x65")]
	[Token(Token = "0x60014BE")]
	internal virtual void SetWidget(Widget widget) { }

}

