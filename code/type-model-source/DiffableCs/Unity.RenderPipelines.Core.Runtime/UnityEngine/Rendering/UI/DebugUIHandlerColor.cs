namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002D4")]
public class DebugUIHandlerColor : DebugUIHandlerWidget
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D25")]
	public Text nameLabel; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D26")]
	public UIFoldout valueToggle; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000D27")]
	public Image colorImage; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000D28")]
	public DebugUIHandlerIndirectFloatField fieldR; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000D29")]
	public DebugUIHandlerIndirectFloatField fieldG; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000D2A")]
	public DebugUIHandlerIndirectFloatField fieldB; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000D2B")]
	public DebugUIHandlerIndirectFloatField fieldA; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000D2C")]
	private ColorField m_Field; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000D2D")]
	private DebugUIHandlerContainer m_Container; //Field offset: 0xA0

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x60013FE")]
	public DebugUIHandlerColor() { }

	[Address(RVA = "0x2CB0020", Offset = "0x2CAF420", Length = "0x1F")]
	[CompilerGenerated]
	[Token(Token = "0x6001407")]
	private float <SetupSettings>b__11_0() { }

	[Address(RVA = "0x2CB0040", Offset = "0x2CAF440", Length = "0x1F")]
	[CompilerGenerated]
	[Token(Token = "0x6001408")]
	private float <SetupSettings>b__11_1() { }

	[Address(RVA = "0x2CB0060", Offset = "0x2CAF460", Length = "0x22")]
	[CompilerGenerated]
	[Token(Token = "0x6001409")]
	private float <SetupSettings>b__11_2() { }

	[Address(RVA = "0x2CAFB60", Offset = "0x2CAEF60", Length = "0x53")]
	[CompilerGenerated]
	[Token(Token = "0x60013FF")]
	private float <SetWidget>b__9_0() { }

	[Address(RVA = "0x2CAFBC0", Offset = "0x2CAEFC0", Length = "0xC4")]
	[CompilerGenerated]
	[Token(Token = "0x6001400")]
	private void <SetWidget>b__9_1(float x) { }

	[Address(RVA = "0x2CAFC90", Offset = "0x2CAF090", Length = "0x53")]
	[CompilerGenerated]
	[Token(Token = "0x6001401")]
	private float <SetWidget>b__9_2() { }

	[Address(RVA = "0x2CAFCF0", Offset = "0x2CAF0F0", Length = "0xC4")]
	[CompilerGenerated]
	[Token(Token = "0x6001402")]
	private void <SetWidget>b__9_3(float x) { }

	[Address(RVA = "0x2CAFDC0", Offset = "0x2CAF1C0", Length = "0x53")]
	[CompilerGenerated]
	[Token(Token = "0x6001403")]
	private float <SetWidget>b__9_4() { }

	[Address(RVA = "0x2CAFE20", Offset = "0x2CAF220", Length = "0xC4")]
	[CompilerGenerated]
	[Token(Token = "0x6001404")]
	private void <SetWidget>b__9_5(float x) { }

	[Address(RVA = "0x2CAFEF0", Offset = "0x2CAF2F0", Length = "0x53")]
	[CompilerGenerated]
	[Token(Token = "0x6001405")]
	private float <SetWidget>b__9_6() { }

	[Address(RVA = "0x2CAFF50", Offset = "0x2CAF350", Length = "0xC4")]
	[CompilerGenerated]
	[Token(Token = "0x6001406")]
	private void <SetWidget>b__9_7(float x) { }

	[Address(RVA = "0x2CAF220", Offset = "0x2CAE620", Length = "0xD0")]
	[Token(Token = "0x60013FD")]
	public virtual DebugUIHandlerWidget Next() { }

	[Address(RVA = "0x2CAC6C0", Offset = "0x2CABAC0", Length = "0x2B")]
	[Token(Token = "0x60013FB")]
	public virtual void OnAction() { }

	[Address(RVA = "0x2CAC6F0", Offset = "0x2CABAF0", Length = "0x20")]
	[Token(Token = "0x60013FA")]
	public virtual void OnDecrement(bool fast) { }

	[Address(RVA = "0x2CAC720", Offset = "0x2CABB20", Length = "0x3B")]
	[Token(Token = "0x60013F8")]
	public virtual void OnDeselection() { }

	[Address(RVA = "0x2CAC760", Offset = "0x2CABB60", Length = "0x20")]
	[Token(Token = "0x60013F9")]
	public virtual void OnIncrement(bool fast) { }

	[Address(RVA = "0x2CAF300", Offset = "0x2CAE700", Length = "0x111")]
	[Token(Token = "0x60013F7")]
	public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous) { }

	[Address(RVA = "0x2CAFA20", Offset = "0x2CAEE20", Length = "0x13A")]
	[Token(Token = "0x60013F6")]
	private void SetupSettings(DebugUIHandlerIndirectFloatField field) { }

	[Address(RVA = "0x2CAF420", Offset = "0x2CAE820", Length = "0x109")]
	[Token(Token = "0x60013F5")]
	private void SetValue(float x, bool r = false, bool g = false, bool b = false, bool a = false) { }

	[Address(RVA = "0x2CAF530", Offset = "0x2CAE930", Length = "0x4E7")]
	[Token(Token = "0x60013F4")]
	internal virtual void SetWidget(Widget widget) { }

	[Address(RVA = "0x2CB0090", Offset = "0x2CAF490", Length = "0xBB")]
	[Token(Token = "0x60013FC")]
	internal void UpdateColor() { }

}

