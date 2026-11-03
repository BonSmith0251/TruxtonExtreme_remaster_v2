namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001F6")]
public class XblTitleStorageBlobMetadata
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000554")]
	internal XblTitleStorageBlobMetadata interop; //Field offset: 0x10

	[Token(Token = "0x170001D8")]
	public string BlobPath
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000A65")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
		[Token(Token = "0x6000A66")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170001D9")]
	public XblTitleStorageBlobType BlobType
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000A67")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x6000A68")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170001DD")]
	public DateTime ClientTimestamp
	{
		[Address(RVA = "0x2B8C980", Offset = "0x2B8BD80", Length = "0x4A")]
		[Token(Token = "0x6000A6F")]
		 get { } //Length: 74
		[Address(RVA = "0x2B8C9E0", Offset = "0x2B8BDE0", Length = "0x2E")]
		[Token(Token = "0x6000A70")]
		 set { } //Length: 46
	}

	[Token(Token = "0x170001DB")]
	public string DisplayName
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000A6B")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000A6C")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001DC")]
	public string ETag
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000A6D")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x6000A6E")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001DE")]
	public ulong Length
	{
		[Address(RVA = "0x2B8C9D0", Offset = "0x2B8BDD0", Length = "0xB")]
		[Token(Token = "0x6000A71")]
		 get { } //Length: 11
		[Address(RVA = "0x2B8CA10", Offset = "0x2B8BE10", Length = "0x2E")]
		[Token(Token = "0x6000A72")]
		 set { } //Length: 46
	}

	[Token(Token = "0x170001DF")]
	public string ServiceConfigurationId
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000A73")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[Token(Token = "0x6000A74")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001DA")]
	public XblTitleStorageType StorageType
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x6000A69")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[Token(Token = "0x6000A6A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170001E0")]
	public ulong XboxUserId
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000A75")]
		 get { } //Length: 5
		[Address(RVA = "0x2161FF0", Offset = "0x21613F0", Length = "0x5")]
		[Token(Token = "0x6000A76")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x2B8C930", Offset = "0x2B8BD30", Length = "0x4B")]
	[Token(Token = "0x6000A63")]
	internal XblTitleStorageBlobMetadata(XblTitleStorageBlobMetadata interopHandle) { }

	[Address(RVA = "0x2B82A70", Offset = "0x2B81E70", Length = "0x29")]
	[Token(Token = "0x6000A64")]
	public XblTitleStorageBlobMetadata() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000A65")]
	public string get_BlobPath() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000A67")]
	public XblTitleStorageBlobType get_BlobType() { }

	[Address(RVA = "0x2B8C980", Offset = "0x2B8BD80", Length = "0x4A")]
	[Token(Token = "0x6000A6F")]
	public DateTime get_ClientTimestamp() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000A6B")]
	public string get_DisplayName() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000A6D")]
	public string get_ETag() { }

	[Address(RVA = "0x2B8C9D0", Offset = "0x2B8BDD0", Length = "0xB")]
	[Token(Token = "0x6000A71")]
	public ulong get_Length() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000A73")]
	public string get_ServiceConfigurationId() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x6000A69")]
	public XblTitleStorageType get_StorageType() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000A75")]
	public ulong get_XboxUserId() { }

	[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
	[Token(Token = "0x6000A66")]
	public void set_BlobPath(string value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[Token(Token = "0x6000A68")]
	public void set_BlobType(XblTitleStorageBlobType value) { }

	[Address(RVA = "0x2B8C9E0", Offset = "0x2B8BDE0", Length = "0x2E")]
	[Token(Token = "0x6000A70")]
	public void set_ClientTimestamp(DateTime value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000A6C")]
	public void set_DisplayName(string value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x6000A6E")]
	public void set_ETag(string value) { }

	[Address(RVA = "0x2B8CA10", Offset = "0x2B8BE10", Length = "0x2E")]
	[Token(Token = "0x6000A72")]
	public void set_Length(ulong value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x6000A74")]
	public void set_ServiceConfigurationId(string value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[Token(Token = "0x6000A6A")]
	public void set_StorageType(XblTitleStorageType value) { }

	[Address(RVA = "0x2161FF0", Offset = "0x21613F0", Length = "0x5")]
	[Token(Token = "0x6000A76")]
	public void set_XboxUserId(ulong value) { }

}

