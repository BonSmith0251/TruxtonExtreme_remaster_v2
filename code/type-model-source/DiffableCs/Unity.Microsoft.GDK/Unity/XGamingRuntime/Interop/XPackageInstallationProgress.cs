namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000374")]
internal struct XPackageInstallationProgress
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009D4")]
	internal ulong totalBytes; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009D5")]
	internal ulong installedBytes; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009D6")]
	internal ulong launchBytes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009D7")]
	internal bool launchable; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x40009D8")]
	internal bool completed; //Field offset: 0x19

}

