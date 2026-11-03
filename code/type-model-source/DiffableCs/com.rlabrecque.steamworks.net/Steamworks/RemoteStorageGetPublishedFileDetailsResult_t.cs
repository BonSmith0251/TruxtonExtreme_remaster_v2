namespace Steamworks;

[CallbackIdentity(1318)]
[Token(Token = "0x20000B6")]
public struct RemoteStorageGetPublishedFileDetailsResult_t
{
	[Token(Token = "0x40001FD")]
	public const int k_iCallback = 1318; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001FE")]
	public EResult m_eResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001FF")]
	public PublishedFileId_t m_nPublishedFileId; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000200")]
	public AppId_t m_nCreatorAppID; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000201")]
	public AppId_t m_nConsumerAppID; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000202")]
	private Byte[] m_rgchTitle_; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000203")]
	private Byte[] m_rgchDescription_; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000204")]
	public UGCHandle_t m_hFile; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000205")]
	public UGCHandle_t m_hPreviewFile; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000206")]
	public ulong m_ulSteamIDOwner; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000207")]
	public uint m_rtimeCreated; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000208")]
	public uint m_rtimeUpdated; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000209")]
	public ERemoteStoragePublishedFileVisibility m_eVisibility; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400020A")]
	public bool m_bBanned; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400020B")]
	private Byte[] m_rgchTags_; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400020C")]
	public bool m_bTagsTruncated; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400020D")]
	private Byte[] m_pchFileName_; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400020E")]
	public int m_nFileSize; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x400020F")]
	public int m_nPreviewFileSize; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000210")]
	private Byte[] m_rgchURL_; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000211")]
	public EWorkshopFileType m_eFileType; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000212")]
	public bool m_bAcceptedForUse; //Field offset: 0x7C

	[Token(Token = "0x17000012")]
	public string m_pchFileName
	{
		[Address(RVA = "0x639840", Offset = "0x638C40", Length = "0x7D")]
		[Token(Token = "0x6000899")]
		 get { } //Length: 125
		[Address(RVA = "0x639790", Offset = "0x638B90", Length = "0xA8")]
		[Token(Token = "0x600089A")]
		 set { } //Length: 168
	}

	[Token(Token = "0x17000010")]
	public string m_rgchDescription
	{
		[Address(RVA = "0x6398C0", Offset = "0x638CC0", Length = "0x7D")]
		[Token(Token = "0x6000895")]
		 get { } //Length: 125
		[Address(RVA = "0x639A40", Offset = "0x638E40", Length = "0xA8")]
		[Token(Token = "0x6000896")]
		 set { } //Length: 168
	}

	[Token(Token = "0x17000011")]
	public string m_rgchTags
	{
		[Address(RVA = "0x639940", Offset = "0x638D40", Length = "0x7D")]
		[Token(Token = "0x6000897")]
		 get { } //Length: 125
		[Address(RVA = "0x639AF0", Offset = "0x638EF0", Length = "0xA8")]
		[Token(Token = "0x6000898")]
		 set { } //Length: 168
	}

	[Token(Token = "0x1700000F")]
	public string m_rgchTitle
	{
		[Address(RVA = "0x60E060", Offset = "0x60D460", Length = "0x7D")]
		[Token(Token = "0x6000893")]
		 get { } //Length: 125
		[Address(RVA = "0x639BA0", Offset = "0x638FA0", Length = "0xA8")]
		[Token(Token = "0x6000894")]
		 set { } //Length: 168
	}

	[Token(Token = "0x17000013")]
	public string m_rgchURL
	{
		[Address(RVA = "0x6399C0", Offset = "0x638DC0", Length = "0x7D")]
		[Token(Token = "0x600089B")]
		 get { } //Length: 125
		[Address(RVA = "0x60A510", Offset = "0x609910", Length = "0xA8")]
		[Token(Token = "0x600089C")]
		 set { } //Length: 168
	}

	[Address(RVA = "0x639840", Offset = "0x638C40", Length = "0x7D")]
	[Token(Token = "0x6000899")]
	public string get_m_pchFileName() { }

	[Address(RVA = "0x6398C0", Offset = "0x638CC0", Length = "0x7D")]
	[Token(Token = "0x6000895")]
	public string get_m_rgchDescription() { }

	[Address(RVA = "0x639940", Offset = "0x638D40", Length = "0x7D")]
	[Token(Token = "0x6000897")]
	public string get_m_rgchTags() { }

	[Address(RVA = "0x60E060", Offset = "0x60D460", Length = "0x7D")]
	[Token(Token = "0x6000893")]
	public string get_m_rgchTitle() { }

	[Address(RVA = "0x6399C0", Offset = "0x638DC0", Length = "0x7D")]
	[Token(Token = "0x600089B")]
	public string get_m_rgchURL() { }

	[Address(RVA = "0x639790", Offset = "0x638B90", Length = "0xA8")]
	[Token(Token = "0x600089A")]
	public void set_m_pchFileName(string value) { }

	[Address(RVA = "0x639A40", Offset = "0x638E40", Length = "0xA8")]
	[Token(Token = "0x6000896")]
	public void set_m_rgchDescription(string value) { }

	[Address(RVA = "0x639AF0", Offset = "0x638EF0", Length = "0xA8")]
	[Token(Token = "0x6000898")]
	public void set_m_rgchTags(string value) { }

	[Address(RVA = "0x639BA0", Offset = "0x638FA0", Length = "0xA8")]
	[Token(Token = "0x6000894")]
	public void set_m_rgchTitle(string value) { }

	[Address(RVA = "0x60A510", Offset = "0x609910", Length = "0xA8")]
	[Token(Token = "0x600089C")]
	public void set_m_rgchURL(string value) { }

}

