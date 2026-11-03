namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002F6")]
public class DebugUIHandlerVector4 : DebugUIHandlerWidget
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000DA2")]
	public Text nameLabel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000DA3")]
	public UIFoldout valueToggle; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000DA4")]
	public DebugUIHandlerIndirectFloatField fieldX; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000DA5")]
	public DebugUIHandlerIndirectFloatField fieldY; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000DA6")]
	public DebugUIHandlerIndirectFloatField fieldZ; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000DA7")]
	public DebugUIHandlerIndirectFloatField fieldW; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000DA8")]
	private Vector4Field m_Field; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000DA9")]
	private DebugUIHandlerContainer m_Container; //Field offset: 0x98

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x60014EF")]
	public DebugUIHandlerVector4() { }

	[Address(RVA = "0x2CB92E0", Offset = "0x2CB86E0", Length = "0x1F")]
	[CompilerGenerated]
	[Token(Token = "0x60014F8")]
	private float <SetupSettings>b__10_0() { }

	[Address(RVA = "0x2CB9300", Offset = "0x2CB8700", Length = "0x1F")]
	[CompilerGenerated]
	[Token(Token = "0x60014F9")]
	private float <SetupSettings>b__10_1() { }

	[Address(RVA = "0x2CB9320", Offset = "0x2CB8720", Length = "0x22")]
	[CompilerGenerated]
	[Token(Token = "0x60014FA")]
	private float <SetupSettings>b__10_2() { }

	[Address(RVA = "0x2CB8E60", Offset = "0x2CB8260", Length = "0x53")]
	[CompilerGenerated]
	[Token(Token = "0x60014F0")]
	private float <SetWidget>b__8_0() { }

	[Address(RVA = "0x2CB8EC0", Offset = "0x2CB82C0", Length = "0xB7")]
	[CompilerGenerated]
	[Token(Token = "0x60014F1")]
	private void <SetWidget>b__8_1(float x) { }

	[Address(RVA = "0x2CB8F80", Offset = "0x2CB8380", Length = "0x53")]
	[CompilerGenerated]
	[Token(Token = "0x60014F2")]
	private float <SetWidget>b__8_2() { }

	[Address(RVA = "0x2CB8FE0", Offset = "0x2CB83E0", Length = "0xB7")]
	[CompilerGenerated]
	[Token(Token = "0x60014F3")]
	private void <SetWidget>b__8_3(float x) { }

	[Address(RVA = "0x2CB90A0", Offset = "0x2CB84A0", Length = "0x53")]
	[CompilerGenerated]
	[Token(Token = "0x60014F4")]
	private float <SetWidget>b__8_4() { }

	[Address(RVA = "0x2CB9100", Offset = "0x2CB8500", Length = "0xB7")]
	[CompilerGenerated]
	[Token(Token = "0x60014F5")]
	private void <SetWidget>b__8_5(float x) { }

	[Address(RVA = "0x2CB91C0", Offset = "0x2CB85C0", Length = "0x53")]
	[CompilerGenerated]
	[Token(Token = "0x60014F6")]
	private float <SetWidget>b__8_6() { }

	[Address(RVA = "0x2CB9220", Offset = "0x2CB8620", Length = "0xB7")]
	[CompilerGenerated]
	[Token(Token = "0x60014F7")]
	private void <SetWidget>b__8_7(float x) { }

	[Address(RVA = "0x2CB85A0", Offset = "0x2CB79A0", Length = "0xD0")]
	[Token(Token = "0x60014EE")]
	public virtual DebugUIHandlerWidget Next() { }

	[Address(RVA = "0x2CAC6C0", Offset = "0x2CABAC0", Length = "0x2B")]
	[Token(Token = "0x60014ED")]
	public virtual void OnAction() { }

	[Address(RVA = "0x2CAC6F0", Offset = "0x2CABAF0", Length = "0x20")]
	[Token(Token = "0x60014EC")]
	public virtual void OnDecrement(bool fast) { }

	[Address(RVA = "0x2CAC720", Offset = "0x2CABB20", Length = "0x3B")]
	[Token(Token = "0x60014EA")]
	public virtual void OnDeselection() { }

	[Address(RVA = "0x2CAC760", Offset = "0x2CABB60", Length = "0x20")]
	[Token(Token = "0x60014EB")]
	public virtual void OnIncrement(bool fast) { }

	[Address(RVA = "0x2CB8680", Offset = "0x2CB7A80", Length = "0x111")]
	[Token(Token = "0x60014E9")]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x2CB8D20", Offset = "0x2CB8120", Length = "0x13A")]
	[Token(Token = "0x60014E8")]
	private void SetupSettings(DebugUIHandlerIndirectFloatField field) { }

	[Address(RVA = "0x2CB87A0", Offset = "0x2CB7BA0", Length = "0x100")]
	[Token(Token = "0x60014E7")]
	private void SetValue(float v, bool x = false, bool y = false, bool z = false, bool w = false) { }

	[Address(RVA = "0x2CB88B0", Offset = "0x2CB7CB0", Length = "0x46F")]
	[Token(Token = "0x60014E6")]
	internal virtual void SetWidget(Widget widget) { }

}

