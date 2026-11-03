namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001C1")]
internal struct InputEventStream
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A36")]
	private InputEventBuffer m_NativeBuffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A37")]
	private InputEvent* m_CurrentNativeEventReadPtr; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A38")]
	private InputEvent* m_CurrentNativeEventWritePtr; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A39")]
	private int m_RemainingNativeEventCount; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000A3A")]
	private readonly int m_MaxAppendedEvents; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A3B")]
	private InputEventBuffer m_AppendBuffer; //Field offset: 0x38
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000A3C")]
	private InputEvent* m_CurrentAppendEventReadPtr; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000A3D")]
	private InputEvent* m_CurrentAppendEventWritePtr; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000A3E")]
	private int m_RemainingAppendEventCount; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000A3F")]
	private int m_NumEventsRetainedInBuffer; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000A40")]
	private bool m_IsOpen; //Field offset: 0x70

	[Token(Token = "0x170004C0")]
	public InputEvent* currentEventPtr
	{
		[Address(RVA = "0x29F85E0", Offset = "0x29F79E0", Length = "0x19")]
		[Token(Token = "0x60010BF")]
		 get { } //Length: 25
	}

	[Token(Token = "0x170004BD")]
	public bool isOpen
	{
		[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
		[Token(Token = "0x60010BC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004C1")]
	public uint numBytesRetainedInBuffer
	{
		[Address(RVA = "0x29F8600", Offset = "0x29F7A00", Length = "0x55")]
		[Token(Token = "0x60010C0")]
		 get { } //Length: 85
	}

	[Token(Token = "0x170004BF")]
	public int numEventsRetainedInBuffer
	{
		[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
		[Token(Token = "0x60010BE")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170004BE")]
	public int remainingEventCount
	{
		[Address(RVA = "0x29F8660", Offset = "0x29F7A60", Length = "0x7")]
		[Token(Token = "0x60010BD")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x29F8540", Offset = "0x29F7940", Length = "0x99")]
	[Token(Token = "0x60010C1")]
	public InputEventStream(ref InputEventBuffer eventBuffer, int maxAppendedEvents) { }

	[Address(RVA = "0x29F8010", Offset = "0x29F7410", Length = "0x92")]
	[Token(Token = "0x60010C5")]
	public InputEvent* Advance(bool leaveEventInBuffer) { }

	[Address(RVA = "0x29F80B0", Offset = "0x29F74B0", Length = "0x9C")]
	[Token(Token = "0x60010C3")]
	public void CleanUpAfterException() { }

	[Address(RVA = "0x29F8150", Offset = "0x29F7550", Length = "0x16B")]
	[Token(Token = "0x60010C2")]
	public void Close(ref InputEventBuffer eventBuffer) { }

	[Address(RVA = "0x29F85E0", Offset = "0x29F79E0", Length = "0x19")]
	[Token(Token = "0x60010BF")]
	public InputEvent* get_currentEventPtr() { }

	[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
	[Token(Token = "0x60010BC")]
	public bool get_isOpen() { }

	[Address(RVA = "0x29F8600", Offset = "0x29F7A00", Length = "0x55")]
	[Token(Token = "0x60010C0")]
	public uint get_numBytesRetainedInBuffer() { }

	[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
	[Token(Token = "0x60010BE")]
	public int get_numEventsRetainedInBuffer() { }

	[Address(RVA = "0x29F8660", Offset = "0x29F7A60", Length = "0x7")]
	[Token(Token = "0x60010BD")]
	public int get_remainingEventCount() { }

	[Address(RVA = "0x29F82C0", Offset = "0x29F76C0", Length = "0x3A")]
	[Token(Token = "0x60010C6")]
	public InputEvent* Peek() { }

	[Address(RVA = "0x29F8300", Offset = "0x29F7700", Length = "0x23C")]
	[Token(Token = "0x60010C4")]
	public void Write(InputEvent* eventPtr) { }

}

