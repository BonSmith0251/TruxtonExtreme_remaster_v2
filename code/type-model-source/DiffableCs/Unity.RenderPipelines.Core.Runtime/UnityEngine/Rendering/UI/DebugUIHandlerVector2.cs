namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002F4")]
public class DebugUIHandlerVector2 : DebugUIHandlerWidget
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D95")]
	public Text nameLabel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D96")]
	public UIFoldout valueToggle; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000D97")]
	public DebugUIHandlerIndirectFloatField fieldX; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000D98")]
	public DebugUIHandlerIndirectFloatField fieldY; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000D99")]
	private Vector2Field m_Field; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000D9A")]
	private DebugUIHandlerContainer m_Container; //Field offset: 0x88

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x60014CB")]
	public DebugUIHandlerVector2() { }

	[Address(RVA = "0x2CB7A20", Offset = "0x2CB6E20", Length = "0x1F")]
	[CompilerGenerated]
	[Token(Token = "0x60014D0")]
	private float <SetupSettings>b__8_0() { }

	[Address(RVA = "0x2CB7A40", Offset = "0x2CB6E40", Length = "0x1F")]
	[CompilerGenerated]
	[Token(Token = "0x60014D1")]
	private float <SetupSettings>b__8_1() { }

	[Address(RVA = "0x2CB7A60", Offset = "0x2CB6E60", Length = "0x22")]
	[CompilerGenerated]
	[Token(Token = "0x60014D2")]
	private float <SetupSettings>b__8_2() { }

	[Address(RVA = "0x2CB7840", Offset = "0x2CB6C40", Length = "0x53")]
	[CompilerGenerated]
	[Token(Token = "0x60014CC")]
	private float <SetWidget>b__6_0() { }

	[Address(RVA = "0x2CB78A0", Offset = "0x2CB6CA0", Length = "0x87")]
	[CompilerGenerated]
	[Token(Token = "0x60014CD")]
	private void <SetWidget>b__6_1(float x) { }

	[Address(RVA = "0x2CB7930", Offset = "0x2CB6D30", Length = "0x53")]
	[CompilerGenerated]
	[Token(Token = "0x60014CE")]
	private float <SetWidget>b__6_2() { }

	[Address(RVA = "0x2CB7990", Offset = "0x2CB6D90", Length = "0x87")]
	[CompilerGenerated]
	[Token(Token = "0x60014CF")]
	private void <SetWidget>b__6_3(float x) { }

	[Address(RVA = "0x2CB71C0", Offset = "0x2CB65C0", Length = "0xD0")]
	[Token(Token = "0x60014CA")]
	public virtual DebugUIHandlerWidget Next() { }

	[Address(RVA = "0x2CAC6C0", Offset = "0x2CABAC0", Length = "0x2B")]
	[Token(Token = "0x60014C9")]
	public virtual void OnAction() { }

	[Address(RVA = "0x2CAC6F0", Offset = "0x2CABAF0", Length = "0x20")]
	[Token(Token = "0x60014C8")]
	public virtual void OnDecrement(bool fast) { }

	[Address(RVA = "0x2CAC720", Offset = "0x2CABB20", Length = "0x3B")]
	[Token(Token = "0x60014C6")]
	public virtual void OnDeselection() { }

	[Address(RVA = "0x2CAC760", Offset = "0x2CABB60", Length = "0x20")]
	[Token(Token = "0x60014C7")]
	public virtual void OnIncrement(bool fast) { }

	[Address(RVA = "0x2CB72A0", Offset = "0x2CB66A0", Length = "0x111")]
	[Token(Token = "0x60014C5")]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x2CB7700", Offset = "0x2CB6B00", Length = "0x13A")]
	[Token(Token = "0x60014C4")]
	private void SetupSettings(DebugUIHandlerIndirectFloatField field) { }

	[Address(RVA = "0x2CB73C0", Offset = "0x2CB67C0", Length = "0xB8")]
	[Token(Token = "0x60014C3")]
	private void SetValue(float v, bool x = false, bool y = false) { }

	[Address(RVA = "0x2CB7480", Offset = "0x2CB6880", Length = "0x27D")]
	[Token(Token = "0x60014C2")]
	internal virtual void SetWidget(Widget widget) { }

}

