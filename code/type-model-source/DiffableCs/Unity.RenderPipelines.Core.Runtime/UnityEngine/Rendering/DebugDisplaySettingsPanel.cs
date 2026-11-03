namespace UnityEngine.Rendering;

[Token(Token = "0x2000070")]
public abstract class DebugDisplaySettingsPanel : IDebugDisplaySettingsPanelDisposable, IDebugDisplaySettingsPanel, IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400016D")]
	private readonly List<Widget> m_Widgets; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400016E")]
	private readonly DisplayInfoAttribute m_DisplayInfo; //Field offset: 0x18

	[Token(Token = "0x17000050")]
	public override Flags Flags
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600059F")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700004E")]
	public override int Order
	{
		[Address(RVA = "0x2BD5E10", Offset = "0x2BD5210", Length = "0xE")]
		[Token(Token = "0x600059D")]
		 get { } //Length: 14
	}

	[Token(Token = "0x1700004D")]
	public override string PanelName
	{
		[Address(RVA = "0x2BD5E20", Offset = "0x2BD5220", Length = "0x24")]
		[Token(Token = "0x600059C")]
		 get { } //Length: 36
	}

	[Token(Token = "0x1700004F")]
	public override Widget[] Widgets
	{
		[Address(RVA = "0x2BD5E50", Offset = "0x2BD5250", Length = "0x44")]
		[Token(Token = "0x600059E")]
		 get { } //Length: 68
	}

	[Address(RVA = "0x2BD5CF0", Offset = "0x2BD50F0", Length = "0x11D")]
	[Token(Token = "0x60005A3")]
	protected DebugDisplaySettingsPanel() { }

	[Address(RVA = "0x2BD5BE0", Offset = "0x2BD4FE0", Length = "0xA1")]
	[Token(Token = "0x60005A0")]
	protected void AddWidget(Widget widget) { }

	[Address(RVA = "0x2BD5C90", Offset = "0x2BD5090", Length = "0x5F")]
	[Token(Token = "0x60005A1")]
	protected void Clear() { }

	[Address(RVA = "0x2BD5C90", Offset = "0x2BD5090", Length = "0x5F")]
	[Token(Token = "0x60005A2")]
	public override void Dispose() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600059F")]
	public override Flags get_Flags() { }

	[Address(RVA = "0x2BD5E10", Offset = "0x2BD5210", Length = "0xE")]
	[Token(Token = "0x600059D")]
	public override int get_Order() { }

	[Address(RVA = "0x2BD5E20", Offset = "0x2BD5220", Length = "0x24")]
	[Token(Token = "0x600059C")]
	public override string get_PanelName() { }

	[Address(RVA = "0x2BD5E50", Offset = "0x2BD5250", Length = "0x44")]
	[Token(Token = "0x600059E")]
	public override Widget[] get_Widgets() { }

}

