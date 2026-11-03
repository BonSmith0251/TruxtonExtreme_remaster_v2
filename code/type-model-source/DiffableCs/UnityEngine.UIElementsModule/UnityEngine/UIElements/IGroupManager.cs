namespace UnityEngine.UIElements;

[Token(Token = "0x2000291")]
internal interface IGroupManager
{

	[Token(Token = "0x60011F9")]
	public void Init(IGroupBox groupBox) { }

	[Token(Token = "0x60011FA")]
	public void OnOptionSelectionChanged(IGroupBoxOption selectedOption) { }

	[Token(Token = "0x60011FB")]
	public void RegisterOption(IGroupBoxOption option) { }

	[Token(Token = "0x60011FC")]
	public void UnregisterOption(IGroupBoxOption option) { }

}

