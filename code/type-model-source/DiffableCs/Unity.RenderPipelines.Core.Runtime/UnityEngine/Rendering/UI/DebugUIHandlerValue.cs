namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002F1")]
public class DebugUIHandlerValue : DebugUIHandlerWidget
{
	[Token(Token = "0x4000D8C")]
	private static readonly Color k_ZeroColor; //Field offset: 0x0
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D88")]
	public Text nameLabel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D89")]
	public Text valueLabel; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000D8A")]
	private Value m_Field; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000D8B")]
	protected private float m_Timer; //Field offset: 0x78

	[Address(RVA = "0x2CB7170", Offset = "0x2CB6570", Length = "0x45")]
	[Token(Token = "0x60014B5")]
	private static DebugUIHandlerValue() { }

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x60014B4")]
	public DebugUIHandlerValue() { }

	[Address(RVA = "0x2CB11F0", Offset = "0x2CB05F0", Length = "0x68")]
	[Token(Token = "0x60014B2")]
	public virtual void OnDeselection() { }

	[Address(RVA = "0x2CB6F10", Offset = "0x2CB6310", Length = "0x8")]
	[Token(Token = "0x60014AF")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2CB1270", Offset = "0x2CB0670", Length = "0x6A")]
	[Token(Token = "0x60014B1")]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x2CB6F20", Offset = "0x2CB6320", Length = "0x94")]
	[Token(Token = "0x60014B0")]
	internal virtual void SetWidget(Widget widget) { }

	[Address(RVA = "0x2CB6FC0", Offset = "0x2CB63C0", Length = "0x1A2")]
	[Token(Token = "0x60014B3")]
	private void Update() { }

}

