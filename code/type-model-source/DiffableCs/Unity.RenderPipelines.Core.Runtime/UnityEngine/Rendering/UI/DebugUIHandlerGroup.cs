namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002DD")]
public class DebugUIHandlerGroup : DebugUIHandlerWidget
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D43")]
	public Text nameLabel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D44")]
	public Transform header; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000D45")]
	private Container m_Field; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000D46")]
	private DebugUIHandlerContainer m_Container; //Field offset: 0x78

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x600143A")]
	public DebugUIHandlerGroup() { }

	[Address(RVA = "0x2CB1C80", Offset = "0x2CB1080", Length = "0xB3")]
	[Token(Token = "0x6001439")]
	public virtual DebugUIHandlerWidget Next() { }

	[Address(RVA = "0x2CB1D40", Offset = "0x2CB1140", Length = "0xBF")]
	[Token(Token = "0x6001438")]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x2CB1E00", Offset = "0x2CB1200", Length = "0xFF")]
	[Token(Token = "0x6001437")]
	internal virtual void SetWidget(Widget widget) { }

}

