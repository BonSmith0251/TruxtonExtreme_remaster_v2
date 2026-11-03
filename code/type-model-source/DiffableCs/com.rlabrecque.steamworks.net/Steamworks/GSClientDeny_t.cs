namespace Steamworks;

[CallbackIdentity(202)]
[Token(Token = "0x2000049")]
public struct GSClientDeny_t
{
	[Token(Token = "0x400006F")]
	public const int k_iCallback = 202; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000070")]
	public CSteamID m_SteamID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000071")]
	public EDenyReason m_eDenyReason; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000072")]
	private Byte[] m_rgchOptionalText_; //Field offset: 0x10

	[Token(Token = "0x17000006")]
	public string m_rgchOptionalText
	{
		[Address(RVA = "0x604550", Offset = "0x603950", Length = "0x7D")]
		[Token(Token = "0x6000881")]
		 get { } //Length: 125
		[Address(RVA = "0x60A460", Offset = "0x609860", Length = "0xA8")]
		[Token(Token = "0x6000882")]
		 set { } //Length: 168
	}

	[Address(RVA = "0x604550", Offset = "0x603950", Length = "0x7D")]
	[Token(Token = "0x6000881")]
	public string get_m_rgchOptionalText() { }

	[Address(RVA = "0x60A460", Offset = "0x609860", Length = "0xA8")]
	[Token(Token = "0x6000882")]
	public void set_m_rgchOptionalText(string value) { }

}

