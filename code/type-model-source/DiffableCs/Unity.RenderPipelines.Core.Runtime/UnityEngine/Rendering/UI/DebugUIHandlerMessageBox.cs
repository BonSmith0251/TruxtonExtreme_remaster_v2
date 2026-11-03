namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002E2")]
public class DebugUIHandlerMessageBox : DebugUIHandlerWidget
{
	[Token(Token = "0x4000D5A")]
	private static Color32 k_WarningBackgroundColor; //Field offset: 0x0
	[Token(Token = "0x4000D5B")]
	private static Color32 k_WarningTextColor; //Field offset: 0x4
	[Token(Token = "0x4000D5C")]
	private static Color32 k_ErrorBackgroundColor; //Field offset: 0x8
	[Token(Token = "0x4000D5D")]
	private static Color32 k_ErrorTextColor; //Field offset: 0xC
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D58")]
	public Text nameLabel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D59")]
	private MessageBox m_Field; //Field offset: 0x68

	[Address(RVA = "0x2CB2A80", Offset = "0x2CB1E80", Length = "0x98")]
	[Token(Token = "0x600145A")]
	private static DebugUIHandlerMessageBox() { }

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x6001459")]
	public DebugUIHandlerMessageBox() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6001458")]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x2CB2860", Offset = "0x2CB1C60", Length = "0x1CF")]
	[Token(Token = "0x6001456")]
	internal virtual void SetWidget(Widget widget) { }

	[Address(RVA = "0x2CB2A30", Offset = "0x2CB1E30", Length = "0x43")]
	[Token(Token = "0x6001457")]
	private void Update() { }

}

