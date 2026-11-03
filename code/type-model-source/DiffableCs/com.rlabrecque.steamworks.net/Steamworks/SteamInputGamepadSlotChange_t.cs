namespace Steamworks;

[CallbackIdentity(2804)]
[Token(Token = "0x2000072")]
public struct SteamInputGamepadSlotChange_t
{
	[Token(Token = "0x4000120")]
	public const int k_iCallback = 2804; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000121")]
	public AppId_t m_unAppID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000122")]
	public InputHandle_t m_ulDeviceHandle; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000123")]
	public ESteamInputType m_eDeviceType; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000124")]
	public int m_nOldGamepadSlot; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000125")]
	public int m_nNewGamepadSlot; //Field offset: 0x18

}

