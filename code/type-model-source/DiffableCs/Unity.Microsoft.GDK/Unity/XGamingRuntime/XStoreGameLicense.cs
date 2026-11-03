namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000274")]
public class XStoreGameLicense
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006A8")]
	internal XStoreGameLicense interop; //Field offset: 0x10

	[Token(Token = "0x170002CB")]
	public long ExpirationDate
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000D03")]
		 get { } //Length: 5
		[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
		[Token(Token = "0x6000D04")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170002C5")]
	public bool IsActive
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[Token(Token = "0x6000CF7")]
		 get { } //Length: 5
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[Token(Token = "0x6000CF8")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170002C7")]
	public bool IsDiscLicense
	{
		[Address(RVA = "0x116C050", Offset = "0x116B450", Length = "0x5")]
		[Token(Token = "0x6000CFB")]
		 get { } //Length: 5
		[Address(RVA = "0x21BAC00", Offset = "0x21BA000", Length = "0x4")]
		[Token(Token = "0x6000CFC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170002C8")]
	public bool IsTrial
	{
		[Address(RVA = "0x29EA670", Offset = "0x29E9A70", Length = "0x5")]
		[Token(Token = "0x6000CFD")]
		 get { } //Length: 5
		[Address(RVA = "0x29EA840", Offset = "0x29E9C40", Length = "0x4")]
		[Token(Token = "0x6000CFE")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170002C6")]
	public bool IsTrialOwnedByThisUser
	{
		[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
		[Token(Token = "0x6000CF9")]
		 get { } //Length: 5
		[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
		[Token(Token = "0x6000CFA")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170002C4")]
	public string SkuStoreId
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000CF5")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
		[Token(Token = "0x6000CF6")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170002C9")]
	public uint TrialTimeRemainingInSeconds
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x6000CFF")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[Token(Token = "0x6000D00")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170002CA")]
	public string TrialUniqueId
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000D01")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000D02")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2B82650", Offset = "0x2B81A50", Length = "0x3B")]
	[Token(Token = "0x6000CF3")]
	internal XStoreGameLicense(XStoreGameLicense interop) { }

	[Address(RVA = "0x2B82130", Offset = "0x2B81530", Length = "0x21")]
	[Token(Token = "0x6000CF4")]
	public XStoreGameLicense() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000D03")]
	public long get_ExpirationDate() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[Token(Token = "0x6000CF7")]
	public bool get_IsActive() { }

	[Address(RVA = "0x116C050", Offset = "0x116B450", Length = "0x5")]
	[Token(Token = "0x6000CFB")]
	public bool get_IsDiscLicense() { }

	[Address(RVA = "0x29EA670", Offset = "0x29E9A70", Length = "0x5")]
	[Token(Token = "0x6000CFD")]
	public bool get_IsTrial() { }

	[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
	[Token(Token = "0x6000CF9")]
	public bool get_IsTrialOwnedByThisUser() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000CF5")]
	public string get_SkuStoreId() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x6000CFF")]
	public uint get_TrialTimeRemainingInSeconds() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000D01")]
	public string get_TrialUniqueId() { }

	[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
	[Token(Token = "0x6000D04")]
	public void set_ExpirationDate(long value) { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[Token(Token = "0x6000CF8")]
	public void set_IsActive(bool value) { }

	[Address(RVA = "0x21BAC00", Offset = "0x21BA000", Length = "0x4")]
	[Token(Token = "0x6000CFC")]
	public void set_IsDiscLicense(bool value) { }

	[Address(RVA = "0x29EA840", Offset = "0x29E9C40", Length = "0x4")]
	[Token(Token = "0x6000CFE")]
	public void set_IsTrial(bool value) { }

	[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
	[Token(Token = "0x6000CFA")]
	public void set_IsTrialOwnedByThisUser(bool value) { }

	[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
	[Token(Token = "0x6000CF6")]
	public void set_SkuStoreId(string value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[Token(Token = "0x6000D00")]
	public void set_TrialTimeRemainingInSeconds(uint value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000D02")]
	public void set_TrialUniqueId(string value) { }

}

