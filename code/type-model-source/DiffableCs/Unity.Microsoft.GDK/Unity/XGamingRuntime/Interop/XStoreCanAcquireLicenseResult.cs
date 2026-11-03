namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000382")]
internal struct XStoreCanAcquireLicenseResult
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009F5")]
	internal string licensableSku; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009F6")]
	internal XStoreCanLicenseStatus status; //Field offset: 0x8

}

