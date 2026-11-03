namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001B9")]
public struct InputEvent
{
	[Token(Token = "0x4000A1F")]
	private const uint kHandledMask = 2147483648; //Field offset: 0x0
	[Token(Token = "0x4000A20")]
	private const uint kIdMask = 2147483647; //Field offset: 0x0
	[Token(Token = "0x4000A21")]
	internal const int kBaseEventSize = 20; //Field offset: 0x0
	[Token(Token = "0x4000A22")]
	public const int InvalidEventId = 0; //Field offset: 0x0
	[Token(Token = "0x4000A23")]
	internal const int kAlignment = 4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A24")]
	private NativeInputEvent m_Event; //Field offset: 0x0

	[Token(Token = "0x170004A6")]
	public int deviceId
	{
		[Address(RVA = "0x29FB380", Offset = "0x29FA780", Length = "0x5")]
		[Token(Token = "0x6001072")]
		 get { } //Length: 5
		[Address(RVA = "0x29FB400", Offset = "0x29FA800", Length = "0x5")]
		[Token(Token = "0x6001073")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170004A5")]
	public int eventId
	{
		[Address(RVA = "0x29FB390", Offset = "0x29FA790", Length = "0x8")]
		[Token(Token = "0x6001070")]
		 get { } //Length: 8
		[Address(RVA = "0x29FB410", Offset = "0x29FA810", Length = "0xE")]
		[Token(Token = "0x6001071")]
		 set { } //Length: 14
	}

	[Token(Token = "0x170004A9")]
	public bool handled
	{
		[Address(RVA = "0x29F45A0", Offset = "0x29F39A0", Length = "0x7")]
		[Token(Token = "0x6001079")]
		 get { } //Length: 7
		[Address(RVA = "0x29FB420", Offset = "0x29FA820", Length = "0x1C")]
		[Token(Token = "0x600107A")]
		 set { } //Length: 28
	}

	[Token(Token = "0x170004A8")]
	internal double internalTime
	{
		[Address(RVA = "0xDA0C90", Offset = "0xDA0090", Length = "0x6")]
		[Token(Token = "0x6001076")]
		internal get { } //Length: 6
		[Address(RVA = "0x290B1F0", Offset = "0x290A5F0", Length = "0x6")]
		[Token(Token = "0x6001077")]
		internal set { } //Length: 6
	}

	[Token(Token = "0x170004A4")]
	public uint sizeInBytes
	{
		[Address(RVA = "0x29FB3A0", Offset = "0x29FA7A0", Length = "0x5")]
		[Token(Token = "0x600106E")]
		 get { } //Length: 5
		[Address(RVA = "0x29FB440", Offset = "0x29FA840", Length = "0xA6")]
		[Token(Token = "0x600106F")]
		 set { } //Length: 166
	}

	[Token(Token = "0x170004A7")]
	public double time
	{
		[Address(RVA = "0x29FB3B0", Offset = "0x29FA7B0", Length = "0x43")]
		[Token(Token = "0x6001074")]
		 get { } //Length: 67
		[Address(RVA = "0x29FB4F0", Offset = "0x29FA8F0", Length = "0x50")]
		[Token(Token = "0x6001075")]
		 set { } //Length: 80
	}

	[Token(Token = "0x170004A3")]
	public FourCC type
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x600106C")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x600106D")]
		 set { } //Length: 3
	}

	[Address(RVA = "0x29FB2C0", Offset = "0x29FA6C0", Length = "0xB0")]
	[Token(Token = "0x6001078")]
	public InputEvent(FourCC type, int sizeInBytes, int deviceId, double time = -1) { }

	[Address(RVA = "0x29FAE50", Offset = "0x29FA250", Length = "0x42")]
	[Token(Token = "0x600107E")]
	public static bool Equals(InputEvent* first, InputEvent* second) { }

	[Address(RVA = "0x29FB380", Offset = "0x29FA780", Length = "0x5")]
	[Token(Token = "0x6001072")]
	public int get_deviceId() { }

	[Address(RVA = "0x29FB390", Offset = "0x29FA790", Length = "0x8")]
	[Token(Token = "0x6001070")]
	public int get_eventId() { }

	[Address(RVA = "0x29F45A0", Offset = "0x29F39A0", Length = "0x7")]
	[Token(Token = "0x6001079")]
	public bool get_handled() { }

	[Address(RVA = "0xDA0C90", Offset = "0xDA0090", Length = "0x6")]
	[Token(Token = "0x6001076")]
	internal double get_internalTime() { }

	[Address(RVA = "0x29FB3A0", Offset = "0x29FA7A0", Length = "0x5")]
	[Token(Token = "0x600106E")]
	public uint get_sizeInBytes() { }

	[Address(RVA = "0x29FB3B0", Offset = "0x29FA7B0", Length = "0x43")]
	[Token(Token = "0x6001074")]
	public double get_time() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x600106C")]
	public FourCC get_type() { }

	[Address(RVA = "0x29FB000", Offset = "0x29FA400", Length = "0x14")]
	[Token(Token = "0x600107C")]
	internal static InputEvent* GetNextInMemory(InputEvent* currentPtr) { }

	[Address(RVA = "0x29FAEA0", Offset = "0x29FA2A0", Length = "0x154")]
	[Token(Token = "0x600107D")]
	internal static InputEvent* GetNextInMemoryChecked(InputEvent* currentPtr, ref InputEventBuffer buffer) { }

	[Address(RVA = "0x29FB400", Offset = "0x29FA800", Length = "0x5")]
	[Token(Token = "0x6001073")]
	public void set_deviceId(int value) { }

	[Address(RVA = "0x29FB410", Offset = "0x29FA810", Length = "0xE")]
	[Token(Token = "0x6001071")]
	public void set_eventId(int value) { }

	[Address(RVA = "0x29FB420", Offset = "0x29FA820", Length = "0x1C")]
	[Token(Token = "0x600107A")]
	public void set_handled(bool value) { }

	[Address(RVA = "0x290B1F0", Offset = "0x290A5F0", Length = "0x6")]
	[Token(Token = "0x6001077")]
	internal void set_internalTime(double value) { }

	[Address(RVA = "0x29FB440", Offset = "0x29FA840", Length = "0xA6")]
	[Token(Token = "0x600106F")]
	public void set_sizeInBytes(uint value) { }

	[Address(RVA = "0x29FB4F0", Offset = "0x29FA8F0", Length = "0x50")]
	[Token(Token = "0x6001075")]
	public void set_time(double value) { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x600106D")]
	public void set_type(FourCC value) { }

	[Address(RVA = "0x29FB020", Offset = "0x29FA420", Length = "0x29F")]
	[Token(Token = "0x600107B")]
	public virtual string ToString() { }

}

