namespace Unity.XGamingRuntime;

[Token(Token = "0x2000235")]
public class XGameUiTextEntryOptions
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000620")]
	internal XGameUiTextEntryOptions data; //Field offset: 0x10

	[Token(Token = "0x17000229")]
	public XGameUiTextEntryInputScope InputScope
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000B6F")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x6000B70")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700022A")]
	public XGameUiTextEntryPositionHint PositionHint
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x6000B71")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[Token(Token = "0x6000B72")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700022B")]
	public XGameUiTextEntryVisibilityFlags VisibilityFlags
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000B73")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x6000B74")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2B80B30", Offset = "0x2B7FF30", Length = "0x31")]
	[Token(Token = "0x6000B6D")]
	internal XGameUiTextEntryOptions(XGameUiTextEntryOptions interop) { }

	[Address(RVA = "0x2B80B70", Offset = "0x2B7FF70", Length = "0x1F")]
	[Token(Token = "0x6000B6E")]
	public XGameUiTextEntryOptions() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000B6F")]
	public XGameUiTextEntryInputScope get_InputScope() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x6000B71")]
	public XGameUiTextEntryPositionHint get_PositionHint() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000B73")]
	public XGameUiTextEntryVisibilityFlags get_VisibilityFlags() { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x6000B70")]
	public void set_InputScope(XGameUiTextEntryInputScope value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[Token(Token = "0x6000B72")]
	public void set_PositionHint(XGameUiTextEntryPositionHint value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[Token(Token = "0x6000B74")]
	public void set_VisibilityFlags(XGameUiTextEntryVisibilityFlags value) { }

}

