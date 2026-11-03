namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002EA")]
public class DebugUIHandlerProgressBar : DebugUIHandlerWidget
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D71")]
	public Text nameLabel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D72")]
	public Text valueLabel; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000D73")]
	public RectTransform progressBarRect; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000D74")]
	private ProgressBarValue m_Value; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000D75")]
	private float m_Timer; //Field offset: 0x80

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x6001485")]
	public DebugUIHandlerProgressBar() { }

	[Address(RVA = "0x2CAC720", Offset = "0x2CABB20", Length = "0x3B")]
	[Token(Token = "0x6001482")]
	public virtual void OnDeselection() { }

	[Address(RVA = "0x5ABEE0", Offset = "0x5AB2E0", Length = "0xB")]
	[Token(Token = "0x600147F")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2CACF90", Offset = "0x2CAC390", Length = "0x3D")]
	[Token(Token = "0x6001481")]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x2CB4170", Offset = "0x2CB3570", Length = "0x9D")]
	[Token(Token = "0x6001480")]
	internal virtual void SetWidget(Widget widget) { }

	[Address(RVA = "0x2CB4350", Offset = "0x2CB3750", Length = "0x75")]
	[Token(Token = "0x6001483")]
	private void Update() { }

	[Address(RVA = "0x2CB4210", Offset = "0x2CB3610", Length = "0x137")]
	[Token(Token = "0x6001484")]
	private void UpdateValue() { }

}

