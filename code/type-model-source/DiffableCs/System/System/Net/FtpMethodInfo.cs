namespace System.Net;

[Token(Token = "0x2000234")]
internal class FtpMethodInfo
{
	[Token(Token = "0x4000890")]
	private static readonly FtpMethodInfo[] s_knownMethodInfo; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400088C")]
	internal string Method; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400088D")]
	internal FtpOperation Operation; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400088E")]
	internal FtpMethodFlags Flags; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400088F")]
	internal string HttpCommand; //Field offset: 0x20

	[Token(Token = "0x170002F9")]
	internal bool IsCommandOnly
	{
		[Address(RVA = "0x26A1700", Offset = "0x26A0B00", Length = "0x8")]
		[Token(Token = "0x6000EEF")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170002FB")]
	internal bool IsDownload
	{
		[Address(RVA = "0x23F2BC0", Offset = "0x23F1FC0", Length = "0x7")]
		[Token(Token = "0x6000EF1")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x170002FA")]
	internal bool IsUpload
	{
		[Address(RVA = "0x26A1710", Offset = "0x26A0B10", Length = "0x8")]
		[Token(Token = "0x6000EF0")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170002FC")]
	internal bool ShouldParseForResponseUri
	{
		[Address(RVA = "0x26A1720", Offset = "0x26A0B20", Length = "0x8")]
		[Token(Token = "0x6000EF2")]
		internal get { } //Length: 8
	}

	[Address(RVA = "0x26A0E40", Offset = "0x26A0240", Length = "0x8B8")]
	[Token(Token = "0x6000EF4")]
	private static FtpMethodInfo() { }

	[Address(RVA = "0x1DA0730", Offset = "0x1D9FB30", Length = "0x63")]
	[Token(Token = "0x6000EED")]
	internal FtpMethodInfo(string method, FtpOperation operation, FtpMethodFlags flags, string httpCommand) { }

	[Address(RVA = "0x26A1700", Offset = "0x26A0B00", Length = "0x8")]
	[Token(Token = "0x6000EEF")]
	internal bool get_IsCommandOnly() { }

	[Address(RVA = "0x23F2BC0", Offset = "0x23F1FC0", Length = "0x7")]
	[Token(Token = "0x6000EF1")]
	internal bool get_IsDownload() { }

	[Address(RVA = "0x26A1710", Offset = "0x26A0B10", Length = "0x8")]
	[Token(Token = "0x6000EF0")]
	internal bool get_IsUpload() { }

	[Address(RVA = "0x26A1720", Offset = "0x26A0B20", Length = "0x8")]
	[Token(Token = "0x6000EF2")]
	internal bool get_ShouldParseForResponseUri() { }

	[Address(RVA = "0x26A0CC0", Offset = "0x26A00C0", Length = "0x162")]
	[Token(Token = "0x6000EF3")]
	internal static FtpMethodInfo GetMethodInfo(string method) { }

	[Address(RVA = "0x26A0E30", Offset = "0x26A0230", Length = "0x7")]
	[Token(Token = "0x6000EEE")]
	internal bool HasFlag(FtpMethodFlags flags) { }

}

