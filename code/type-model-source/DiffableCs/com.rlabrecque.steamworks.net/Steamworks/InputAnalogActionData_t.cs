namespace Steamworks;

[Token(Token = "0x2000173")]
public struct InputAnalogActionData_t
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009E6")]
	public EInputSourceMode eMode; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40009E7")]
	public float x; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009E8")]
	public float y; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40009E9")]
	public byte bActive; //Field offset: 0xC

}

