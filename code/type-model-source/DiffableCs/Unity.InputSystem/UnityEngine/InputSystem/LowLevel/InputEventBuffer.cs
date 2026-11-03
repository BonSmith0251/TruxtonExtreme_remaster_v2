namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001BA")]
public struct InputEventBuffer : IEnumerable<InputEventPtr>, IEnumerable, IDisposable, ICloneable
{
	[Token(Token = "0x20001BB")]
	private struct Enumerator : IEnumerator<InputEventPtr>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A2A")]
		private readonly InputEvent* m_Buffer; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000A2B")]
		private readonly int m_EventCount; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A2C")]
		private InputEvent* m_CurrentEvent; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A2D")]
		private int m_CurrentIndex; //Field offset: 0x18

		[Token(Token = "0x170004AF")]
		public override InputEventPtr Current
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x6001094")]
			 get { } //Length: 5
		}

		[Token(Token = "0x170004B0")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x29EF6A0", Offset = "0x29EEAA0", Length = "0x45")]
			[Token(Token = "0x6001095")]
			private get { } //Length: 69
		}

		[Address(RVA = "0x29EF850", Offset = "0x29EEC50", Length = "0x62")]
		[Token(Token = "0x6001090")]
		public Enumerator(InputEventBuffer buffer) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6001093")]
		public override void Dispose() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001094")]
		public override InputEventPtr get_Current() { }

		[Address(RVA = "0x29EF600", Offset = "0x29EEA00", Length = "0x4C")]
		[Token(Token = "0x6001091")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1D86D20", Offset = "0x1D86120", Length = "0xA")]
		[Token(Token = "0x6001092")]
		public override void Reset() { }

		[Address(RVA = "0x29EF6A0", Offset = "0x29EEAA0", Length = "0x45")]
		[Token(Token = "0x6001095")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[Token(Token = "0x4000A25")]
	public const long BufferSizeUnknown = -1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A26")]
	private NativeArray<Byte> m_Buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A27")]
	private long m_SizeInBytes; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A28")]
	private int m_EventCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000A29")]
	private bool m_WeOwnTheBuffer; //Field offset: 0x1C

	[Token(Token = "0x170004AE")]
	public InputEventPtr bufferPtr
	{
		[Address(RVA = "0x29F72E0", Offset = "0x29F66E0", Length = "0x44")]
		[Token(Token = "0x6001083")]
		 get { } //Length: 68
	}

	[Token(Token = "0x170004AC")]
	public long capacityInBytes
	{
		[Address(RVA = "0x29F7330", Offset = "0x29F6730", Length = "0x3D")]
		[Token(Token = "0x6001081")]
		 get { } //Length: 61
	}

	[Token(Token = "0x170004AD")]
	public NativeArray<Byte> data
	{
		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[Token(Token = "0x6001082")]
		 get { } //Length: 10
	}

	[Token(Token = "0x170004AA")]
	public int eventCount
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x600107F")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170004AB")]
	public long sizeInBytes
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001080")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x29F6FE0", Offset = "0x29F63E0", Length = "0x1C2")]
	[Token(Token = "0x6001084")]
	public InputEventBuffer(InputEvent* eventPtr, int eventCount, int sizeInBytes = -1, int capacityInBytes = -1) { }

	[Address(RVA = "0x29F71B0", Offset = "0x29F65B0", Length = "0x126")]
	[Token(Token = "0x6001085")]
	public InputEventBuffer(NativeArray<Byte> buffer, int eventCount, int sizeInBytes = -1, bool transferNativeArrayOwnership = false) { }

	[Address(RVA = "0x29F68C0", Offset = "0x29F5CC0", Length = "0xA1")]
	[Token(Token = "0x600108A")]
	internal void AdvanceToNextEvent(ref InputEvent* currentReadPos, ref InputEvent* currentWritePos, ref int numEventsRetainedInBuffer, ref int numRemainingEvents, bool leaveEventInBuffer) { }

	[Address(RVA = "0x29F6970", Offset = "0x29F5D70", Length = "0x2CD")]
	[Token(Token = "0x6001087")]
	public InputEvent* AllocateEvent(int sizeInBytes, int capacityIncrementInBytes = 2048, Allocator allocator = 4) { }

	[Address(RVA = "0x29F6C40", Offset = "0x29F6040", Length = "0x89")]
	[Token(Token = "0x6001086")]
	public void AppendEvent(InputEvent* eventPtr, int capacityIncrementInBytes = 2048, Allocator allocator = 4) { }

	[Address(RVA = "0x29F6CD0", Offset = "0x29F60D0", Length = "0xC2")]
	[Token(Token = "0x600108E")]
	public InputEventBuffer Clone() { }

	[Address(RVA = "0x29F6DA0", Offset = "0x29F61A0", Length = "0x80")]
	[Token(Token = "0x6001088")]
	public bool Contains(InputEvent* eventPtr) { }

	[Address(RVA = "0x29F6E20", Offset = "0x29F6220", Length = "0x4D")]
	[Token(Token = "0x600108D")]
	public override void Dispose() { }

	[Address(RVA = "0x29F72E0", Offset = "0x29F66E0", Length = "0x44")]
	[Token(Token = "0x6001083")]
	public InputEventPtr get_bufferPtr() { }

	[Address(RVA = "0x29F7330", Offset = "0x29F6730", Length = "0x3D")]
	[Token(Token = "0x6001081")]
	public long get_capacityInBytes() { }

	[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
	[Token(Token = "0x6001082")]
	public NativeArray<Byte> get_data() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x600107F")]
	public int get_eventCount() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001080")]
	public long get_sizeInBytes() { }

	[Address(RVA = "0x29F6E70", Offset = "0x29F6270", Length = "0xD9")]
	[Token(Token = "0x600108B")]
	public override IEnumerator<InputEventPtr> GetEnumerator() { }

	[Address(RVA = "0x29F6F50", Offset = "0x29F6350", Length = "0x11")]
	[Token(Token = "0x6001089")]
	public void Reset() { }

	[Address(RVA = "0x29F6F70", Offset = "0x29F6370", Length = "0x7")]
	[Token(Token = "0x600108C")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x29F6F80", Offset = "0x29F6380", Length = "0x5D")]
	[Token(Token = "0x600108F")]
	private override object System.ICloneable.Clone() { }

}

