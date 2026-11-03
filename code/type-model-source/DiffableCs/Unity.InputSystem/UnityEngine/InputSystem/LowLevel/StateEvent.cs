namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001C9")]
public struct StateEvent : IInputEventTypeInfo
{
	[CompilerGenerated]
	[Token(Token = "0x20001CA")]
	[UnsafeValueType]
	internal struct <stateData>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A74")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[Token(Token = "0x4000A6F")]
	public const int Type = 1398030676; //Field offset: 0x0
	[Token(Token = "0x4000A70")]
	internal const int kStateDataSizeToSubtract = 1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A71")]
	public InputEvent baseEvent; //Field offset: 0x0
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000A72")]
	public FourCC stateFormat; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[FixedBuffer(typeof(byte), 1)]
	[Token(Token = "0x4000A73")]
	internal <stateData>e__FixedBuffer stateData; //Field offset: 0x18

	[Token(Token = "0x170004DC")]
	public Void* state
	{
		[Address(RVA = "0x2A169C0", Offset = "0x2A15DC0", Length = "0x5")]
		[Token(Token = "0x6001120")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170004DB")]
	public uint stateSizeInBytes
	{
		[Address(RVA = "0x2A169A0", Offset = "0x2A15DA0", Length = "0x13")]
		[Token(Token = "0x600111F")]
		 get { } //Length: 19
	}

	[Token(Token = "0x170004DD")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x2A169D0", Offset = "0x2A15DD0", Length = "0x6")]
		[Token(Token = "0x6001122")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2A16860", Offset = "0x2A15C60", Length = "0x136")]
	[Token(Token = "0x6001126")]
	public static StateEvent* From(InputEventPtr ptr) { }

	[Address(RVA = "0x2A16830", Offset = "0x2A15C30", Length = "0x30")]
	[Token(Token = "0x6001128")]
	public static NativeArray<Byte> From(InputDevice device, out InputEventPtr eventPtr, Allocator allocator = 2) { }

	[Address(RVA = "0x2A16510", Offset = "0x2A15910", Length = "0x31B")]
	[Token(Token = "0x600112A")]
	private static NativeArray<Byte> From(InputDevice device, out InputEventPtr eventPtr, Allocator allocator, bool useDefaultState) { }

	[Address(RVA = "0x2A164E0", Offset = "0x2A158E0", Length = "0x30")]
	[Token(Token = "0x6001129")]
	public static NativeArray<Byte> FromDefaultStateFor(InputDevice device, out InputEventPtr eventPtr, Allocator allocator = 2) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6001127")]
	internal static StateEvent* FromUnchecked(InputEventPtr ptr) { }

	[Address(RVA = "0x2A169C0", Offset = "0x2A15DC0", Length = "0x5")]
	[Token(Token = "0x6001120")]
	public Void* get_state() { }

	[Address(RVA = "0x2A169A0", Offset = "0x2A15DA0", Length = "0x13")]
	[Token(Token = "0x600111F")]
	public uint get_stateSizeInBytes() { }

	[Address(RVA = "0x2A169D0", Offset = "0x2A15DD0", Length = "0x6")]
	[Token(Token = "0x6001122")]
	public override FourCC get_typeStatic() { }

	[Address(RVA = "0x913CD0", Offset = "0x9130D0", Length = "0x1A")]
	[Token(Token = "0x6001125")]
	public static int GetEventSizeWithPayload() { }

	[Address(RVA = "0x913CF0", Offset = "0x9130F0", Length = "0x2DF")]
	[Token(Token = "0x6001123")]
	public TState GetState() { }

	[Address(RVA = "0x913FD0", Offset = "0x9133D0", Length = "0xB4")]
	[Token(Token = "0x6001124")]
	public static TState GetState(InputEventPtr ptr) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6001121")]
	public InputEventPtr ToEventPtr() { }

}

