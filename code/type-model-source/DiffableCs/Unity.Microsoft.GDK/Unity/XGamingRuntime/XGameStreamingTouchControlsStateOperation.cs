namespace Unity.XGamingRuntime;

[Token(Token = "0x2000226")]
public class XGameStreamingTouchControlsStateOperation
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005F6")]
	internal XGameStreamingTouchControlsStateOperation _interop; //Field offset: 0x10
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005F7")]
	internal XGameStreamingTouchControlsStateValue _value; //Field offset: 0x30

	[Token(Token = "0x1700020D")]
	internal XGameStreamingTouchControlsStateOperation interop
	{
		[Address(RVA = "0x2B816B0", Offset = "0x2B80AB0", Length = "0x31")]
		[Token(Token = "0x6000B27")]
		internal get { } //Length: 49
	}

	[Token(Token = "0x1700020E")]
	public XGameStreamingTouchControlsStateOperationKind OperationKind
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000B28")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x6000B29")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700020F")]
	public string Path
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000B2A")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000B2B")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000210")]
	public XGameStreamingTouchControlsStateValue Value
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000B2C")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x6000B2D")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2B81590", Offset = "0x2B80990", Length = "0x95")]
	[Token(Token = "0x6000B25")]
	internal XGameStreamingTouchControlsStateOperation(XGameStreamingTouchControlsStateOperation interop) { }

	[Address(RVA = "0x2B81630", Offset = "0x2B80A30", Length = "0x78")]
	[Token(Token = "0x6000B26")]
	public XGameStreamingTouchControlsStateOperation() { }

	[Address(RVA = "0x2B816B0", Offset = "0x2B80AB0", Length = "0x31")]
	[Token(Token = "0x6000B27")]
	internal XGameStreamingTouchControlsStateOperation get_interop() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000B28")]
	public XGameStreamingTouchControlsStateOperationKind get_OperationKind() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000B2A")]
	public string get_Path() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000B2C")]
	public XGameStreamingTouchControlsStateValue get_Value() { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x6000B29")]
	public void set_OperationKind(XGameStreamingTouchControlsStateOperationKind value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000B2B")]
	public void set_Path(string value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x6000B2D")]
	public void set_Value(XGameStreamingTouchControlsStateValue value) { }

}

