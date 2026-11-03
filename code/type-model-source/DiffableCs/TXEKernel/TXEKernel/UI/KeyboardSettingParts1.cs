namespace TXEKernel.UI;

[Token(Token = "0x2000117")]
public class KeyboardSettingParts1 : KeyboardSettingPartsBase
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400058F")]
	private UISlideSelecter _keySelecter; //Field offset: 0x28

	[Token(Token = "0x1700021F")]
	public virtual UISlideSelecter KeySelecter
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60007DA")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60007DB")]
	public KeyboardSettingParts1() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60007DA")]
	public virtual UISlideSelecter get_KeySelecter() { }

}

