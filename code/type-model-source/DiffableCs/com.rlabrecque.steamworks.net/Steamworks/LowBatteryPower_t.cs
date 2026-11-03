namespace Steamworks;

[CallbackIdentity(702)]
[Token(Token = "0x20000F7")]
public struct LowBatteryPower_t
{
	[Token(Token = "0x4000307")]
	public const int k_iCallback = 702; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000308")]
	public byte m_nMinutesBatteryLeft; //Field offset: 0x0

}

