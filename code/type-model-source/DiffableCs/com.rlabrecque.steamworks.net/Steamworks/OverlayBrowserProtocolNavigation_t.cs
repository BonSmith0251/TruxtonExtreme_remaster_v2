namespace Steamworks;

[CallbackIdentity(349)]
[Token(Token = "0x2000043")]
public struct OverlayBrowserProtocolNavigation_t
{
	[Token(Token = "0x400005D")]
	public const int k_iCallback = 349; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400005E")]
	private Byte[] rgchURI_; //Field offset: 0x0

	[Token(Token = "0x17000005")]
	public string rgchURI
	{
		[Address(RVA = "0x60A5C0", Offset = "0x6099C0", Length = "0x7D")]
		[Token(Token = "0x600087F")]
		 get { } //Length: 125
		[Address(RVA = "0x638F90", Offset = "0x638390", Length = "0xA8")]
		[Token(Token = "0x6000880")]
		 set { } //Length: 168
	}

	[Address(RVA = "0x60A5C0", Offset = "0x6099C0", Length = "0x7D")]
	[Token(Token = "0x600087F")]
	public string get_rgchURI() { }

	[Address(RVA = "0x638F90", Offset = "0x638390", Length = "0xA8")]
	[Token(Token = "0x6000880")]
	public void set_rgchURI(string value) { }

}

