namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002F2")]
public class DebugUIHandlerValueTuple : DebugUIHandlerWidget
{
	[Token(Token = "0x4000D91")]
	private const float k_XOffset = 230; //Field offset: 0x0
	[Token(Token = "0x4000D93")]
	private static readonly Color k_ZeroColor; //Field offset: 0x0
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D8D")]
	public Text nameLabel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D8E")]
	public Text valueLabel; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000D8F")]
	protected private ValueTuple m_Field; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000D90")]
	protected private Text[] valueElements; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000D92")]
	private float m_Timer; //Field offset: 0x80

	[Address(RVA = "0x2CB6EC0", Offset = "0x2CB62C0", Length = "0x45")]
	[Token(Token = "0x60014BD")]
	private static DebugUIHandlerValueTuple() { }

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x60014BC")]
	public DebugUIHandlerValueTuple() { }

	[Address(RVA = "0x2CAC720", Offset = "0x2CABB20", Length = "0x3B")]
	[Token(Token = "0x60014B8")]
	public virtual void OnDeselection() { }

	[Address(RVA = "0x5ABEE0", Offset = "0x5AB2E0", Length = "0xB")]
	[Token(Token = "0x60014B6")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2CACF90", Offset = "0x2CAC390", Length = "0x3D")]
	[Token(Token = "0x60014B7")]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x2CB6710", Offset = "0x2CB5B10", Length = "0x47F")]
	[Token(Token = "0x60014B9")]
	internal virtual void SetWidget(Widget widget) { }

	[Address(RVA = "0x2CB6E20", Offset = "0x2CB6220", Length = "0x92")]
	[Token(Token = "0x60014BB")]
	private void Update() { }

	[Address(RVA = "0x2CB6B90", Offset = "0x2CB5F90", Length = "0x283")]
	[Token(Token = "0x60014BA")]
	internal override void UpdateValueLabels() { }

}

