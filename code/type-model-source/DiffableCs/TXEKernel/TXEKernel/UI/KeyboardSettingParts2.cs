namespace TXEKernel.UI;

[Token(Token = "0x2000118")]
public class KeyboardSettingParts2 : KeyboardSettingPartsBase
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000590")]
	private PopupButton _keyButton; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000591")]
	private UITextMeshPro _keyButtonText; //Field offset: 0x30

	[Token(Token = "0x17000220")]
	public virtual PopupButton KeyButton
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60007DD")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60007DE")]
	public KeyboardSettingParts2() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60007DD")]
	public virtual PopupButton get_KeyButton() { }

	[Address(RVA = "0x2720D30", Offset = "0x2720130", Length = "0x6F")]
	[Token(Token = "0x60007DC")]
	public virtual void UpdateString(UIKeyboard key) { }

}

