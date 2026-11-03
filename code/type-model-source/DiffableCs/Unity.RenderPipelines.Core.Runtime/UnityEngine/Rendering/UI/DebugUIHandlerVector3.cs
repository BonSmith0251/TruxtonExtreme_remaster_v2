namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002F5")]
public class DebugUIHandlerVector3 : DebugUIHandlerWidget
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D9B")]
	public Text nameLabel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D9C")]
	public UIFoldout valueToggle; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000D9D")]
	public DebugUIHandlerIndirectFloatField fieldX; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000D9E")]
	public DebugUIHandlerIndirectFloatField fieldY; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000D9F")]
	public DebugUIHandlerIndirectFloatField fieldZ; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000DA0")]
	private Vector3Field m_Field; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000DA1")]
	private DebugUIHandlerContainer m_Container; //Field offset: 0x90

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x60014DC")]
	public DebugUIHandlerVector3() { }

	[Address(RVA = "0x2CB8530", Offset = "0x2CB7930", Length = "0x1F")]
	[CompilerGenerated]
	[Token(Token = "0x60014E3")]
	private float <SetupSettings>b__9_0() { }

	[Address(RVA = "0x2CB8550", Offset = "0x2CB7950", Length = "0x1F")]
	[CompilerGenerated]
	[Token(Token = "0x60014E4")]
	private float <SetupSettings>b__9_1() { }

	[Address(RVA = "0x2CB8570", Offset = "0x2CB7970", Length = "0x22")]
	[CompilerGenerated]
	[Token(Token = "0x60014E5")]
	private float <SetupSettings>b__9_2() { }

	[Address(RVA = "0x2CB8230", Offset = "0x2CB7630", Length = "0x53")]
	[CompilerGenerated]
	[Token(Token = "0x60014DD")]
	private float <SetWidget>b__7_0() { }

	[Address(RVA = "0x2CB8290", Offset = "0x2CB7690", Length = "0x99")]
	[CompilerGenerated]
	[Token(Token = "0x60014DE")]
	private void <SetWidget>b__7_1(float v) { }

	[Address(RVA = "0x2CB8330", Offset = "0x2CB7730", Length = "0x53")]
	[CompilerGenerated]
	[Token(Token = "0x60014DF")]
	private float <SetWidget>b__7_2() { }

	[Address(RVA = "0x2CB8390", Offset = "0x2CB7790", Length = "0x99")]
	[CompilerGenerated]
	[Token(Token = "0x60014E0")]
	private void <SetWidget>b__7_3(float v) { }

	[Address(RVA = "0x2CB8430", Offset = "0x2CB7830", Length = "0x53")]
	[CompilerGenerated]
	[Token(Token = "0x60014E1")]
	private float <SetWidget>b__7_4() { }

	[Address(RVA = "0x2CB8490", Offset = "0x2CB7890", Length = "0x99")]
	[CompilerGenerated]
	[Token(Token = "0x60014E2")]
	private void <SetWidget>b__7_5(float v) { }

	[Address(RVA = "0x2CB7A90", Offset = "0x2CB6E90", Length = "0xD0")]
	[Token(Token = "0x60014DB")]
	public virtual DebugUIHandlerWidget Next() { }

	[Address(RVA = "0x2CAC6C0", Offset = "0x2CABAC0", Length = "0x2B")]
	[Token(Token = "0x60014DA")]
	public virtual void OnAction() { }

	[Address(RVA = "0x2CAC6F0", Offset = "0x2CABAF0", Length = "0x20")]
	[Token(Token = "0x60014D9")]
	public virtual void OnDecrement(bool fast) { }

	[Address(RVA = "0x2CAC720", Offset = "0x2CABB20", Length = "0x3B")]
	[Token(Token = "0x60014D7")]
	public virtual void OnDeselection() { }

	[Address(RVA = "0x2CAC760", Offset = "0x2CABB60", Length = "0x20")]
	[Token(Token = "0x60014D8")]
	public virtual void OnIncrement(bool fast) { }

	[Address(RVA = "0x2CB7B70", Offset = "0x2CB6F70", Length = "0x111")]
	[Token(Token = "0x60014D6")]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x2CB80F0", Offset = "0x2CB74F0", Length = "0x13A")]
	[Token(Token = "0x60014D5")]
	private void SetupSettings(DebugUIHandlerIndirectFloatField field) { }

	[Address(RVA = "0x2CB7C90", Offset = "0x2CB7090", Length = "0xD8")]
	[Token(Token = "0x60014D4")]
	private void SetValue(float v, bool x = false, bool y = false, bool z = false) { }

	[Address(RVA = "0x2CB7D70", Offset = "0x2CB7170", Length = "0x371")]
	[Token(Token = "0x60014D3")]
	internal virtual void SetWidget(Widget widget) { }

}

