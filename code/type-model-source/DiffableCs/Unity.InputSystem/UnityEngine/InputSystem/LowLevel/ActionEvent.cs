namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001AD")]
internal struct ActionEvent : IInputEventTypeInfo
{
	[CompilerGenerated]
	[Token(Token = "0x20001AE")]
	[UnsafeValueType]
	internal struct <m_ValueData>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A07")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009FF")]
	public InputEvent baseEvent; //Field offset: 0x0
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000A00")]
	private ushort m_ControlIndex; //Field offset: 0x14
	[FieldOffset(Offset = "0x16")]
	[Token(Token = "0x4000A01")]
	private ushort m_BindingIndex; //Field offset: 0x16
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A02")]
	private ushort m_InteractionIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1A")]
	[Token(Token = "0x4000A03")]
	private byte m_StateIndex; //Field offset: 0x1A
	[FieldOffset(Offset = "0x1B")]
	[Token(Token = "0x4000A04")]
	private byte m_Phase; //Field offset: 0x1B
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000A05")]
	private double m_StartTime; //Field offset: 0x1C
	[FieldOffset(Offset = "0x24")]
	[FixedBuffer(typeof(byte), 1)]
	[Token(Token = "0x4000A06")]
	public <m_ValueData>e__FixedBuffer m_ValueData; //Field offset: 0x24

	[Token(Token = "0x17000494")]
	public int bindingIndex
	{
		[Address(RVA = "0x29EA640", Offset = "0x29E9A40", Length = "0x5")]
		[Token(Token = "0x6001046")]
		 get { } //Length: 5
		[Address(RVA = "0x29EA6E0", Offset = "0x29E9AE0", Length = "0x67")]
		[Token(Token = "0x6001047")]
		 set { } //Length: 103
	}

	[Token(Token = "0x17000493")]
	public int controlIndex
	{
		[Address(RVA = "0x1963870", Offset = "0x1962C70", Length = "0x5")]
		[Token(Token = "0x6001044")]
		 get { } //Length: 5
		[Address(RVA = "0x29EA750", Offset = "0x29E9B50", Length = "0x67")]
		[Token(Token = "0x6001045")]
		 set { } //Length: 103
	}

	[Token(Token = "0x17000495")]
	public int interactionIndex
	{
		[Address(RVA = "0x29EA650", Offset = "0x29E9A50", Length = "0x16")]
		[Token(Token = "0x6001048")]
		 get { } //Length: 22
		[Address(RVA = "0x29EA7C0", Offset = "0x29E9BC0", Length = "0x77")]
		[Token(Token = "0x6001049")]
		 set { } //Length: 119
	}

	[Token(Token = "0x1700048F")]
	public InputActionPhase phase
	{
		[Address(RVA = "0x29EA670", Offset = "0x29E9A70", Length = "0x5")]
		[Token(Token = "0x600103E")]
		 get { } //Length: 5
		[Address(RVA = "0x29EA840", Offset = "0x29E9C40", Length = "0x4")]
		[Token(Token = "0x600103F")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700048E")]
	public double startTime
	{
		[Address(RVA = "0x293B910", Offset = "0x293AD10", Length = "0x6")]
		[Token(Token = "0x600103C")]
		 get { } //Length: 6
		[Address(RVA = "0x29EA850", Offset = "0x29E9C50", Length = "0x6")]
		[Token(Token = "0x600103D")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000492")]
	public int stateIndex
	{
		[Address(RVA = "0x116C050", Offset = "0x116B450", Length = "0x5")]
		[Token(Token = "0x6001042")]
		 get { } //Length: 5
		[Address(RVA = "0x29EA860", Offset = "0x29E9C60", Length = "0x66")]
		[Token(Token = "0x6001043")]
		 set { } //Length: 102
	}

	[Token(Token = "0x1700048D")]
	public static FourCC Type
	{
		[Address(RVA = "0x29EA600", Offset = "0x29E9A00", Length = "0x3A")]
		[Token(Token = "0x600103B")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000496")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29EA680", Offset = "0x29E9A80", Length = "0x3A")]
		[Token(Token = "0x600104B")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000490")]
	public Byte* valueData
	{
		[Address(RVA = "0x29EA6C0", Offset = "0x29E9AC0", Length = "0x5")]
		[Token(Token = "0x6001040")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000491")]
	public int valueSizeInBytes
	{
		[Address(RVA = "0x29EA6D0", Offset = "0x29E9AD0", Length = "0x8")]
		[Token(Token = "0x6001041")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x29EA4C0", Offset = "0x29E98C0", Length = "0x130")]
	[Token(Token = "0x600104D")]
	public static ActionEvent* From(InputEventPtr ptr) { }

	[Address(RVA = "0x29EA640", Offset = "0x29E9A40", Length = "0x5")]
	[Token(Token = "0x6001046")]
	public int get_bindingIndex() { }

	[Address(RVA = "0x1963870", Offset = "0x1962C70", Length = "0x5")]
	[Token(Token = "0x6001044")]
	public int get_controlIndex() { }

	[Address(RVA = "0x29EA650", Offset = "0x29E9A50", Length = "0x16")]
	[Token(Token = "0x6001048")]
	public int get_interactionIndex() { }

	[Address(RVA = "0x29EA670", Offset = "0x29E9A70", Length = "0x5")]
	[Token(Token = "0x600103E")]
	public InputActionPhase get_phase() { }

	[Address(RVA = "0x293B910", Offset = "0x293AD10", Length = "0x6")]
	[Token(Token = "0x600103C")]
	public double get_startTime() { }

	[Address(RVA = "0x116C050", Offset = "0x116B450", Length = "0x5")]
	[Token(Token = "0x6001042")]
	public int get_stateIndex() { }

	[Address(RVA = "0x29EA600", Offset = "0x29E9A00", Length = "0x3A")]
	[Token(Token = "0x600103B")]
	public static FourCC get_Type() { }

	[Address(RVA = "0x29EA680", Offset = "0x29E9A80", Length = "0x3A")]
	[Token(Token = "0x600104B")]
	public override FourCC get_typeStatic() { }

	[Address(RVA = "0x29EA6C0", Offset = "0x29E9AC0", Length = "0x5")]
	[Token(Token = "0x6001040")]
	public Byte* get_valueData() { }

	[Address(RVA = "0x29EA6D0", Offset = "0x29E9AD0", Length = "0x8")]
	[Token(Token = "0x6001041")]
	public int get_valueSizeInBytes() { }

	[Address(RVA = "0x29EA5F0", Offset = "0x29E99F0", Length = "0x4")]
	[Token(Token = "0x600104C")]
	public static int GetEventSizeWithValueSize(int valueSizeInBytes) { }

	[Address(RVA = "0x29EA6E0", Offset = "0x29E9AE0", Length = "0x67")]
	[Token(Token = "0x6001047")]
	public void set_bindingIndex(int value) { }

	[Address(RVA = "0x29EA750", Offset = "0x29E9B50", Length = "0x67")]
	[Token(Token = "0x6001045")]
	public void set_controlIndex(int value) { }

	[Address(RVA = "0x29EA7C0", Offset = "0x29E9BC0", Length = "0x77")]
	[Token(Token = "0x6001049")]
	public void set_interactionIndex(int value) { }

	[Address(RVA = "0x29EA840", Offset = "0x29E9C40", Length = "0x4")]
	[Token(Token = "0x600103F")]
	public void set_phase(InputActionPhase value) { }

	[Address(RVA = "0x29EA850", Offset = "0x29E9C50", Length = "0x6")]
	[Token(Token = "0x600103D")]
	public void set_startTime(double value) { }

	[Address(RVA = "0x29EA860", Offset = "0x29E9C60", Length = "0x66")]
	[Token(Token = "0x6001043")]
	public void set_stateIndex(int value) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x600104A")]
	public InputEventPtr ToEventPtr() { }

}

