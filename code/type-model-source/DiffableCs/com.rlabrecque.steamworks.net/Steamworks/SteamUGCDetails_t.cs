namespace Steamworks;

[Token(Token = "0x200017A")]
public struct SteamUGCDetails_t
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A06")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A07")]
	public EResult m_eResult; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000A08")]
	public EWorkshopFileType m_eFileType; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A09")]
	public AppId_t m_nCreatorAppID; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000A0A")]
	public AppId_t m_nConsumerAppID; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A0B")]
	private Byte[] m_rgchTitle_; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A0C")]
	private Byte[] m_rgchDescription_; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A0D")]
	public ulong m_ulSteamIDOwner; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A0E")]
	public uint m_rtimeCreated; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000A0F")]
	public uint m_rtimeUpdated; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A10")]
	public uint m_rtimeAddedToUserList; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000A11")]
	public ERemoteStoragePublishedFileVisibility m_eVisibility; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A12")]
	public bool m_bBanned; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x4000A13")]
	public bool m_bAcceptedForUse; //Field offset: 0x41
	[FieldOffset(Offset = "0x42")]
	[Token(Token = "0x4000A14")]
	public bool m_bTagsTruncated; //Field offset: 0x42
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A15")]
	private Byte[] m_rgchTags_; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000A16")]
	public UGCHandle_t m_hFile; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000A17")]
	public UGCHandle_t m_hPreviewFile; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000A18")]
	private Byte[] m_pchFileName_; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000A19")]
	public int m_nFileSize; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000A1A")]
	public int m_nPreviewFileSize; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000A1B")]
	private Byte[] m_rgchURL_; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000A1C")]
	public uint m_unVotesUp; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000A1D")]
	public uint m_unVotesDown; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000A1E")]
	public float m_flScore; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000A1F")]
	public uint m_unNumChildren; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000A20")]
	public ulong m_ulTotalFilesSize; //Field offset: 0x88

	[Token(Token = "0x1700001D")]
	public string m_pchFileName
	{
		[Address(RVA = "0x639840", Offset = "0x638C40", Length = "0x7D")]
		[Token(Token = "0x60008AF")]
		 get { } //Length: 125
		[Address(RVA = "0x639790", Offset = "0x638B90", Length = "0xA8")]
		[Token(Token = "0x60008B0")]
		 set { } //Length: 168
	}

	[Token(Token = "0x1700001B")]
	public string m_rgchDescription
	{
		[Address(RVA = "0x6398C0", Offset = "0x638CC0", Length = "0x7D")]
		[Token(Token = "0x60008AB")]
		 get { } //Length: 125
		[Address(RVA = "0x639A40", Offset = "0x638E40", Length = "0xA8")]
		[Token(Token = "0x60008AC")]
		 set { } //Length: 168
	}

	[Token(Token = "0x1700001C")]
	public string m_rgchTags
	{
		[Address(RVA = "0x63CD70", Offset = "0x63C170", Length = "0x7D")]
		[Token(Token = "0x60008AD")]
		 get { } //Length: 125
		[Address(RVA = "0x639AF0", Offset = "0x638EF0", Length = "0xA8")]
		[Token(Token = "0x60008AE")]
		 set { } //Length: 168
	}

	[Token(Token = "0x1700001A")]
	public string m_rgchTitle
	{
		[Address(RVA = "0x60E060", Offset = "0x60D460", Length = "0x7D")]
		[Token(Token = "0x60008A9")]
		 get { } //Length: 125
		[Address(RVA = "0x639BA0", Offset = "0x638FA0", Length = "0xA8")]
		[Token(Token = "0x60008AA")]
		 set { } //Length: 168
	}

	[Token(Token = "0x1700001E")]
	public string m_rgchURL
	{
		[Address(RVA = "0x6399C0", Offset = "0x638DC0", Length = "0x7D")]
		[Token(Token = "0x60008B1")]
		 get { } //Length: 125
		[Address(RVA = "0x60A510", Offset = "0x609910", Length = "0xA8")]
		[Token(Token = "0x60008B2")]
		 set { } //Length: 168
	}

	[Address(RVA = "0x639840", Offset = "0x638C40", Length = "0x7D")]
	[Token(Token = "0x60008AF")]
	public string get_m_pchFileName() { }

	[Address(RVA = "0x6398C0", Offset = "0x638CC0", Length = "0x7D")]
	[Token(Token = "0x60008AB")]
	public string get_m_rgchDescription() { }

	[Address(RVA = "0x63CD70", Offset = "0x63C170", Length = "0x7D")]
	[Token(Token = "0x60008AD")]
	public string get_m_rgchTags() { }

	[Address(RVA = "0x60E060", Offset = "0x60D460", Length = "0x7D")]
	[Token(Token = "0x60008A9")]
	public string get_m_rgchTitle() { }

	[Address(RVA = "0x6399C0", Offset = "0x638DC0", Length = "0x7D")]
	[Token(Token = "0x60008B1")]
	public string get_m_rgchURL() { }

	[Address(RVA = "0x639790", Offset = "0x638B90", Length = "0xA8")]
	[Token(Token = "0x60008B0")]
	public void set_m_pchFileName(string value) { }

	[Address(RVA = "0x639A40", Offset = "0x638E40", Length = "0xA8")]
	[Token(Token = "0x60008AC")]
	public void set_m_rgchDescription(string value) { }

	[Address(RVA = "0x639AF0", Offset = "0x638EF0", Length = "0xA8")]
	[Token(Token = "0x60008AE")]
	public void set_m_rgchTags(string value) { }

	[Address(RVA = "0x639BA0", Offset = "0x638FA0", Length = "0xA8")]
	[Token(Token = "0x60008AA")]
	public void set_m_rgchTitle(string value) { }

	[Address(RVA = "0x60A510", Offset = "0x609910", Length = "0xA8")]
	[Token(Token = "0x60008B2")]
	public void set_m_rgchURL(string value) { }

}

