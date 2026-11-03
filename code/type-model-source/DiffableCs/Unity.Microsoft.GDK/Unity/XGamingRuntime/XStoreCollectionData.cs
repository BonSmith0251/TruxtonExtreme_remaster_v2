namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000267")]
public class XStoreCollectionData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400067D")]
	internal XStoreCollectionData interop; //Field offset: 0x10

	[Token(Token = "0x1700028A")]
	public long AcquiredDate
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000C82")]
		 get { } //Length: 5
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[Token(Token = "0x6000C83")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000290")]
	public string CampaignId
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000C8E")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x6000C8F")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000291")]
	public string DeveloperOfferId
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000C90")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[Token(Token = "0x6000C91")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700028C")]
	public long EndDate
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000C86")]
		 get { } //Length: 5
		[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
		[Token(Token = "0x6000C87")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700028D")]
	public bool IsTrial
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x6000C88")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[Token(Token = "0x6000C89")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700028F")]
	public uint Quantity
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x6000C8C")]
		 get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[Token(Token = "0x6000C8D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700028B")]
	public long StartDate
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000C84")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[Token(Token = "0x6000C85")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700028E")]
	public uint TrialTimeRemainingInSeconds
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x6000C8A")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
		[Token(Token = "0x6000C8B")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2B829C0", Offset = "0x2B81DC0", Length = "0x4D")]
	[Token(Token = "0x6000C80")]
	internal XStoreCollectionData(XStoreCollectionData interop) { }

	[Address(RVA = "0x2B82990", Offset = "0x2B81D90", Length = "0x2B")]
	[Token(Token = "0x6000C81")]
	public XStoreCollectionData() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000C82")]
	public long get_AcquiredDate() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000C8E")]
	public string get_CampaignId() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000C90")]
	public string get_DeveloperOfferId() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000C86")]
	public long get_EndDate() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x6000C88")]
	public bool get_IsTrial() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x6000C8C")]
	public uint get_Quantity() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000C84")]
	public long get_StartDate() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x6000C8A")]
	public uint get_TrialTimeRemainingInSeconds() { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[Token(Token = "0x6000C83")]
	public void set_AcquiredDate(long value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x6000C8F")]
	public void set_CampaignId(string value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x6000C91")]
	public void set_DeveloperOfferId(string value) { }

	[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
	[Token(Token = "0x6000C87")]
	public void set_EndDate(long value) { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[Token(Token = "0x6000C89")]
	public void set_IsTrial(bool value) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[Token(Token = "0x6000C8D")]
	public void set_Quantity(uint value) { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[Token(Token = "0x6000C85")]
	public void set_StartDate(long value) { }

	[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
	[Token(Token = "0x6000C8B")]
	public void set_TrialTimeRemainingInSeconds(uint value) { }

}

