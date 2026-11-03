namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000217")]
public class XGameSaveContainerInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005AA")]
	internal XGameSaveContainerInfo interop; //Field offset: 0x10

	[Token(Token = "0x170001FF")]
	public uint BlobCount
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000AF8")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[Token(Token = "0x6000AF9")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170001FE")]
	public string DisplayName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000AF6")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000AF7")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000201")]
	public long LastModifiedTime
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000AFC")]
		 get { } //Length: 5
		[Address(RVA = "0x2162050", Offset = "0x2161450", Length = "0x5")]
		[Token(Token = "0x6000AFD")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170001FD")]
	public string Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000AF4")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
		[Token(Token = "0x6000AF5")]
		 set { } //Length: 12
	}

	[Token(Token = "0x17000202")]
	public bool NeedsSync
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[Token(Token = "0x6000AFE")]
		 get { } //Length: 5
		[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
		[Token(Token = "0x6000AFF")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000200")]
	public ulong TotalSize
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000AFA")]
		 get { } //Length: 5
		[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
		[Token(Token = "0x6000AFB")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x2B7C120", Offset = "0x2B7B520", Length = "0x43")]
	[Token(Token = "0x6000AF2")]
	internal XGameSaveContainerInfo(XGameSaveContainerInfo interop) { }

	[Address(RVA = "0x2B7C0F0", Offset = "0x2B7B4F0", Length = "0x25")]
	[Token(Token = "0x6000AF3")]
	public XGameSaveContainerInfo() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000AF8")]
	public uint get_BlobCount() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000AF6")]
	public string get_DisplayName() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000AFC")]
	public long get_LastModifiedTime() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000AF4")]
	public string get_Name() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[Token(Token = "0x6000AFE")]
	public bool get_NeedsSync() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000AFA")]
	public ulong get_TotalSize() { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[Token(Token = "0x6000AF9")]
	public void set_BlobCount(uint value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000AF7")]
	public void set_DisplayName(string value) { }

	[Address(RVA = "0x2162050", Offset = "0x2161450", Length = "0x5")]
	[Token(Token = "0x6000AFD")]
	public void set_LastModifiedTime(long value) { }

	[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
	[Token(Token = "0x6000AF5")]
	public void set_Name(string value) { }

	[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
	[Token(Token = "0x6000AFF")]
	public void set_NeedsSync(bool value) { }

	[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
	[Token(Token = "0x6000AFB")]
	public void set_TotalSize(ulong value) { }

}

