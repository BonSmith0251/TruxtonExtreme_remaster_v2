namespace Unity.XGamingRuntime;

[Token(Token = "0x2000280")]
public class XSystemRuntimeInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006CE")]
	internal XVersion _runtimeVersion; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006CF")]
	internal XVersion _availableVersion; //Field offset: 0x18

	[Token(Token = "0x170002DD")]
	public XVersion AvailableVersion
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000D3F")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000D40")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002DC")]
	public XVersion RuntimeVersion
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000D3D")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000D3E")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2B83C90", Offset = "0x2B83090", Length = "0xAB")]
	[Token(Token = "0x6000D3B")]
	internal XSystemRuntimeInfo(XSystemRuntimeInfo interop) { }

	[Address(RVA = "0x2B83BF0", Offset = "0x2B82FF0", Length = "0x9B")]
	[Token(Token = "0x6000D3C")]
	public XSystemRuntimeInfo() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000D3F")]
	public XVersion get_AvailableVersion() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000D3D")]
	public XVersion get_RuntimeVersion() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000D40")]
	public void set_AvailableVersion(XVersion value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000D3E")]
	public void set_RuntimeVersion(XVersion value) { }

}

