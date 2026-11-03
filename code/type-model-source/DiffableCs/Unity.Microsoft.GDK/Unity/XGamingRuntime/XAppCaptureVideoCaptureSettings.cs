namespace Unity.XGamingRuntime;

[Token(Token = "0x2000100")]
public class XAppCaptureVideoCaptureSettings
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001D1")]
	internal XAppCaptureVideoCaptureSettings interop; //Field offset: 0x10

	[Token(Token = "0x17000063")]
	public XAppCaptureVideoColorFormat ColorFormat
	{
		[Address(RVA = "0x1E08E00", Offset = "0x1E08200", Length = "0x5")]
		[Token(Token = "0x6000637")]
		 get { } //Length: 5
		[Address(RVA = "0x1EA5240", Offset = "0x1EA4640", Length = "0x4")]
		[Token(Token = "0x6000638")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000062")]
	public XAppCaptureVideoEncoding Encoding
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x6000635")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[Token(Token = "0x6000636")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000060")]
	public uint Height
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x6000631")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[Token(Token = "0x6000632")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000064")]
	public bool IsCaptureByGamesAllowed
	{
		[Address(RVA = "0x25832A0", Offset = "0x25826A0", Length = "0x5")]
		[Token(Token = "0x6000639")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C3A0", Offset = "0x2B7B7A0", Length = "0x4")]
		[Token(Token = "0x600063A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000061")]
	public ulong MaxRecordTimespanDurationInMs
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000633")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[Token(Token = "0x6000634")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700005F")]
	public uint Width
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x600062F")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x6000630")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x11A7D10", Offset = "0x11A7110", Length = "0x33")]
	[Token(Token = "0x600062D")]
	internal XAppCaptureVideoCaptureSettings(XAppCaptureVideoCaptureSettings interop) { }

	[Address(RVA = "0x2B7C180", Offset = "0x2B7B580", Length = "0x23")]
	[Token(Token = "0x600062E")]
	public XAppCaptureVideoCaptureSettings() { }

	[Address(RVA = "0x1E08E00", Offset = "0x1E08200", Length = "0x5")]
	[Token(Token = "0x6000637")]
	public XAppCaptureVideoColorFormat get_ColorFormat() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x6000635")]
	public XAppCaptureVideoEncoding get_Encoding() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x6000631")]
	public uint get_Height() { }

	[Address(RVA = "0x25832A0", Offset = "0x25826A0", Length = "0x5")]
	[Token(Token = "0x6000639")]
	public bool get_IsCaptureByGamesAllowed() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000633")]
	public ulong get_MaxRecordTimespanDurationInMs() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x600062F")]
	public uint get_Width() { }

	[Address(RVA = "0x1EA5240", Offset = "0x1EA4640", Length = "0x4")]
	[Token(Token = "0x6000638")]
	public void set_ColorFormat(XAppCaptureVideoColorFormat value) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[Token(Token = "0x6000636")]
	public void set_Encoding(XAppCaptureVideoEncoding value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[Token(Token = "0x6000632")]
	public void set_Height(uint value) { }

	[Address(RVA = "0x2B7C3A0", Offset = "0x2B7B7A0", Length = "0x4")]
	[Token(Token = "0x600063A")]
	public void set_IsCaptureByGamesAllowed(bool value) { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[Token(Token = "0x6000634")]
	public void set_MaxRecordTimespanDurationInMs(ulong value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x6000630")]
	public void set_Width(uint value) { }

}

