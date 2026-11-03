namespace Unity.XGamingRuntime;

[Token(Token = "0x2000225")]
public class XGameStreamingTouchControlsStateValue
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005F4")]
	internal XGameStreamingTouchControlsStateValue interop; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005F5")]
	internal string _stringValue; //Field offset: 0x20

	[Token(Token = "0x1700020B")]
	public bool BoolValue
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[Token(Token = "0x6000B21")]
		 get { } //Length: 5
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[Token(Token = "0x6000B22")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700020A")]
	public double DoubleValue
	{
		[Address(RVA = "0x1CC53D0", Offset = "0x1CC47D0", Length = "0x6")]
		[Token(Token = "0x6000B1F")]
		 get { } //Length: 6
		[Address(RVA = "0x290B1D0", Offset = "0x290A5D0", Length = "0x6")]
		[Token(Token = "0x6000B20")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700020C")]
	public uint IntegerValue
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000B23")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x6000B24")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000209")]
	public string StringValue
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000B1D")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000B1E")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000208")]
	public XGameStreamingTouchControlsStateValueKind ValueKind
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000B1B")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[Token(Token = "0x6000B1C")]
		 set { } //Length: 4
	}

	[Address(RVA = "0xB49C20", Offset = "0xB49020", Length = "0x29")]
	[Token(Token = "0x6000B19")]
	internal XGameStreamingTouchControlsStateValue(XGameStreamingTouchControlsStateValue interop) { }

	[Address(RVA = "0x2B6E870", Offset = "0x2B6DC70", Length = "0x1D")]
	[Token(Token = "0x6000B1A")]
	public XGameStreamingTouchControlsStateValue() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[Token(Token = "0x6000B21")]
	public bool get_BoolValue() { }

	[Address(RVA = "0x1CC53D0", Offset = "0x1CC47D0", Length = "0x6")]
	[Token(Token = "0x6000B1F")]
	public double get_DoubleValue() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000B23")]
	public uint get_IntegerValue() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000B1D")]
	public string get_StringValue() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000B1B")]
	public XGameStreamingTouchControlsStateValueKind get_ValueKind() { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[Token(Token = "0x6000B22")]
	public void set_BoolValue(bool value) { }

	[Address(RVA = "0x290B1D0", Offset = "0x290A5D0", Length = "0x6")]
	[Token(Token = "0x6000B20")]
	public void set_DoubleValue(double value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[Token(Token = "0x6000B24")]
	public void set_IntegerValue(uint value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000B1E")]
	public void set_StringValue(string value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[Token(Token = "0x6000B1C")]
	public void set_ValueKind(XGameStreamingTouchControlsStateValueKind value) { }

}

