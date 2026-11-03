namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001C0")]
public struct InputEventPtr : IEquatable<InputEventPtr>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A35")]
	private readonly InputEvent* m_EventPtr; //Field offset: 0x0

	[Token(Token = "0x170004B9")]
	public InputEvent* data
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x60010AB")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170004B6")]
	public int deviceId
	{
		[Address(RVA = "0x29F79E0", Offset = "0x29F6DE0", Length = "0x11")]
		[Token(Token = "0x60010A5")]
		 get { } //Length: 17
		[Address(RVA = "0x29F7D90", Offset = "0x29F7190", Length = "0x68")]
		[Token(Token = "0x60010A6")]
		 set { } //Length: 104
	}

	[Token(Token = "0x170004B2")]
	public bool handled
	{
		[Address(RVA = "0x29F7A00", Offset = "0x29F6E00", Length = "0x13")]
		[Token(Token = "0x600109F")]
		 get { } //Length: 19
		[Address(RVA = "0x29F7E00", Offset = "0x29F7200", Length = "0x7F")]
		[Token(Token = "0x60010A0")]
		 set { } //Length: 127
	}

	[Token(Token = "0x170004B3")]
	public int id
	{
		[Address(RVA = "0x29F7A20", Offset = "0x29F6E20", Length = "0x14")]
		[Token(Token = "0x60010A1")]
		 get { } //Length: 20
		[Address(RVA = "0x29F7E80", Offset = "0x29F7280", Length = "0x71")]
		[Token(Token = "0x60010A2")]
		 set { } //Length: 113
	}

	[Token(Token = "0x170004B8")]
	internal double internalTime
	{
		[Address(RVA = "0x29F7A40", Offset = "0x29F6E40", Length = "0x13")]
		[Token(Token = "0x60010A9")]
		internal get { } //Length: 19
		[Address(RVA = "0x29F7F00", Offset = "0x29F7300", Length = "0x69")]
		[Token(Token = "0x60010AA")]
		internal set { } //Length: 105
	}

	[Token(Token = "0x170004B5")]
	public uint sizeInBytes
	{
		[Address(RVA = "0x29F7A60", Offset = "0x29F6E60", Length = "0x11")]
		[Token(Token = "0x60010A4")]
		 get { } //Length: 17
	}

	[Token(Token = "0x170004BA")]
	internal FourCC stateFormat
	{
		[Address(RVA = "0x29F7A80", Offset = "0x29F6E80", Length = "0xC1")]
		[Token(Token = "0x60010AC")]
		internal get { } //Length: 193
	}

	[Token(Token = "0x170004BC")]
	internal uint stateOffset
	{
		[Address(RVA = "0x29F7B50", Offset = "0x29F6F50", Length = "0xCB")]
		[Token(Token = "0x60010AE")]
		internal get { } //Length: 203
	}

	[Token(Token = "0x170004BB")]
	internal uint stateSizeInBytes
	{
		[Address(RVA = "0x29F7C20", Offset = "0x29F7020", Length = "0xFC")]
		[Token(Token = "0x60010AD")]
		internal get { } //Length: 252
	}

	[Token(Token = "0x170004B7")]
	public double time
	{
		[Address(RVA = "0x29F7D20", Offset = "0x29F7120", Length = "0x58")]
		[Token(Token = "0x60010A7")]
		 get { } //Length: 88
		[Address(RVA = "0x29F7F70", Offset = "0x29F7370", Length = "0x9E")]
		[Token(Token = "0x60010A8")]
		 set { } //Length: 158
	}

	[Token(Token = "0x170004B4")]
	public FourCC type
	{
		[Address(RVA = "0x29F7D80", Offset = "0x29F7180", Length = "0xF")]
		[Token(Token = "0x60010A3")]
		 get { } //Length: 15
	}

	[Token(Token = "0x170004B1")]
	public bool valid
	{
		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[Token(Token = "0x600109E")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x600109D")]
	public InputEventPtr(InputEvent* eventPtr) { }

	[Address(RVA = "0x29F7850", Offset = "0x29F6C50", Length = "0xB6")]
	[Token(Token = "0x60010B4")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x29F7910", Offset = "0x29F6D10", Length = "0x45")]
	[Token(Token = "0x60010B3")]
	public override bool Equals(InputEventPtr other) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x60010B9")]
	public static InputEventPtr From(InputEvent* eventPtr) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x60010BB")]
	public static InputEvent* FromInputEventPtr(InputEventPtr eventPtr) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x60010AB")]
	public InputEvent* get_data() { }

	[Address(RVA = "0x29F79E0", Offset = "0x29F6DE0", Length = "0x11")]
	[Token(Token = "0x60010A5")]
	public int get_deviceId() { }

	[Address(RVA = "0x29F7A00", Offset = "0x29F6E00", Length = "0x13")]
	[Token(Token = "0x600109F")]
	public bool get_handled() { }

	[Address(RVA = "0x29F7A20", Offset = "0x29F6E20", Length = "0x14")]
	[Token(Token = "0x60010A1")]
	public int get_id() { }

	[Address(RVA = "0x29F7A40", Offset = "0x29F6E40", Length = "0x13")]
	[Token(Token = "0x60010A9")]
	internal double get_internalTime() { }

	[Address(RVA = "0x29F7A60", Offset = "0x29F6E60", Length = "0x11")]
	[Token(Token = "0x60010A4")]
	public uint get_sizeInBytes() { }

	[Address(RVA = "0x29F7A80", Offset = "0x29F6E80", Length = "0xC1")]
	[Token(Token = "0x60010AC")]
	internal FourCC get_stateFormat() { }

	[Address(RVA = "0x29F7B50", Offset = "0x29F6F50", Length = "0xCB")]
	[Token(Token = "0x60010AE")]
	internal uint get_stateOffset() { }

	[Address(RVA = "0x29F7C20", Offset = "0x29F7020", Length = "0xFC")]
	[Token(Token = "0x60010AD")]
	internal uint get_stateSizeInBytes() { }

	[Address(RVA = "0x29F7D20", Offset = "0x29F7120", Length = "0x58")]
	[Token(Token = "0x60010A7")]
	public double get_time() { }

	[Address(RVA = "0x29F7D80", Offset = "0x29F7180", Length = "0xF")]
	[Token(Token = "0x60010A3")]
	public FourCC get_type() { }

	[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
	[Token(Token = "0x600109E")]
	public bool get_valid() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x60010B5")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x847420", Offset = "0x846820", Length = "0x77")]
	[Token(Token = "0x60010AF")]
	public bool IsA() { }

	[Address(RVA = "0x29F7960", Offset = "0x29F6D60", Length = "0x20")]
	[Token(Token = "0x60010B0")]
	public InputEventPtr Next() { }

	[Address(RVA = "0x604B30", Offset = "0x603F30", Length = "0x7")]
	[Token(Token = "0x60010B6")]
	public static bool op_Equality(InputEventPtr left, InputEventPtr right) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x60010BA")]
	public static InputEvent* op_Implicit(InputEventPtr eventPtr) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x60010B8")]
	public static InputEventPtr op_Implicit(InputEvent* eventPtr) { }

	[Address(RVA = "0x604B50", Offset = "0x603F50", Length = "0x7")]
	[Token(Token = "0x60010B7")]
	public static bool op_Inequality(InputEventPtr left, InputEventPtr right) { }

	[Address(RVA = "0x29F7D90", Offset = "0x29F7190", Length = "0x68")]
	[Token(Token = "0x60010A6")]
	public void set_deviceId(int value) { }

	[Address(RVA = "0x29F7E00", Offset = "0x29F7200", Length = "0x7F")]
	[Token(Token = "0x60010A0")]
	public void set_handled(bool value) { }

	[Address(RVA = "0x29F7E80", Offset = "0x29F7280", Length = "0x71")]
	[Token(Token = "0x60010A2")]
	public void set_id(int value) { }

	[Address(RVA = "0x29F7F00", Offset = "0x29F7300", Length = "0x69")]
	[Token(Token = "0x60010AA")]
	internal void set_internalTime(double value) { }

	[Address(RVA = "0x29F7F70", Offset = "0x29F7370", Length = "0x9E")]
	[Token(Token = "0x60010A8")]
	public void set_time(double value) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x60010B2")]
	public InputEvent* ToPointer() { }

	[Address(RVA = "0x29F7980", Offset = "0x29F6D80", Length = "0x5C")]
	[Token(Token = "0x60010B1")]
	public virtual string ToString() { }

}

