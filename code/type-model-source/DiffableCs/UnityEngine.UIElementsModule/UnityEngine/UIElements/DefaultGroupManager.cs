namespace UnityEngine.UIElements;

[Token(Token = "0x2000292")]
internal class DefaultGroupManager : IGroupManager
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A2D")]
	private List<IGroupBoxOption> m_GroupOptions; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A2E")]
	private IGroupBoxOption m_SelectedOption; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A2F")]
	private IGroupBox m_GroupBox; //Field offset: 0x20

	[Address(RVA = "0x33FD830", Offset = "0x33FCC30", Length = "0x77")]
	[Token(Token = "0x6001201")]
	public DefaultGroupManager() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60011FD")]
	public override void Init(IGroupBox groupBox) { }

	[Address(RVA = "0x33FD4D0", Offset = "0x33FC8D0", Length = "0x1DF")]
	[Token(Token = "0x60011FE")]
	public override void OnOptionSelectionChanged(IGroupBoxOption selectedOption) { }

	[Address(RVA = "0x33FD6B0", Offset = "0x33FCAB0", Length = "0xF4")]
	[Token(Token = "0x60011FF")]
	public override void RegisterOption(IGroupBoxOption option) { }

	[Address(RVA = "0x33FD7B0", Offset = "0x33FCBB0", Length = "0x7C")]
	[Token(Token = "0x6001200")]
	public override void UnregisterOption(IGroupBoxOption option) { }

}

