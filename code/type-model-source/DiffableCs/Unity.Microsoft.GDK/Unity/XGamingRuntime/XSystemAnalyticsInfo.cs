namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore.Interop")]
[Token(Token = "0x200027F")]
public class XSystemAnalyticsInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006CB")]
	internal XSystemAnalyticsInfo interop; //Field offset: 0x10
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40006CC")]
	private XVersion _osVersion; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40006CD")]
	private XVersion _hostingOsVersion; //Field offset: 0x38

	[Token(Token = "0x170002DA")]
	public string Family
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000D37")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000D38")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002DB")]
	public string Form
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000D39")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x6000D3A")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002D9")]
	public XVersion HostingOsVersion
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000D35")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x6000D36")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002D8")]
	public XVersion OsVersion
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000D33")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x6000D34")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2B83790", Offset = "0x2B82B90", Length = "0xC6")]
	[Token(Token = "0x6000D31")]
	internal XSystemAnalyticsInfo(XSystemAnalyticsInfo interop) { }

	[Address(RVA = "0x2B83860", Offset = "0x2B82C60", Length = "0xA6")]
	[Token(Token = "0x6000D32")]
	public XSystemAnalyticsInfo() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000D37")]
	public string get_Family() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000D39")]
	public string get_Form() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000D35")]
	public XVersion get_HostingOsVersion() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000D33")]
	public XVersion get_OsVersion() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000D38")]
	public void set_Family(string value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x6000D3A")]
	public void set_Form(string value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x6000D36")]
	public void set_HostingOsVersion(XVersion value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x6000D34")]
	public void set_OsVersion(XVersion value) { }

}

