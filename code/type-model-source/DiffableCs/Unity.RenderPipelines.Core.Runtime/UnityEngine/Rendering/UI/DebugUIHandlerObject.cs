namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002E3")]
public class DebugUIHandlerObject : DebugUIHandlerWidget
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D5E")]
	public Text nameLabel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D5F")]
	public Text valueLabel; //Field offset: 0x68

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x600145E")]
	public DebugUIHandlerObject() { }

	[Address(RVA = "0x2CB11F0", Offset = "0x2CB05F0", Length = "0x68")]
	[Token(Token = "0x600145D")]
	public virtual void OnDeselection() { }

	[Address(RVA = "0x2CB1270", Offset = "0x2CB0670", Length = "0x6A")]
	[Token(Token = "0x600145C")]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x2CB2FF0", Offset = "0x2CB23F0", Length = "0x122")]
	[Token(Token = "0x600145B")]
	internal virtual void SetWidget(Widget widget) { }

}

