namespace UnityEngine.InputSystem.LowLevel;

[Token(Token = "0x20001AF")]
public struct DeltaStateEvent : IInputEventTypeInfo
{
	[CompilerGenerated]
	[Token(Token = "0x20001B0")]
	[UnsafeValueType]
	internal struct <stateData>e__FixedBuffer
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A0D")]
		public byte FixedElementField; //Field offset: 0x0

	}

	[Token(Token = "0x4000A08")]
	public const int Type = 1145852993; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A09")]
	public InputEvent baseEvent; //Field offset: 0x0
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000A0A")]
	public FourCC stateFormat; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A0B")]
	public uint stateOffset; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[FixedBuffer(typeof(byte), 1)]
	[Token(Token = "0x4000A0C")]
	internal <stateData>e__FixedBuffer stateData; //Field offset: 0x1C

	[Token(Token = "0x17000498")]
	public Void* deltaState
	{
		[Address(RVA = "0x29EAE40", Offset = "0x29EA240", Length = "0x5")]
		[Token(Token = "0x600104F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000497")]
	public uint deltaStateSizeInBytes
	{
		[Address(RVA = "0x29EAE30", Offset = "0x29EA230", Length = "0x8")]
		[Token(Token = "0x600104E")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000499")]
	public override FourCC typeStatic
	{
		[Address(RVA = "0x29EAE50", Offset = "0x29EA250", Length = "0x6")]
		[Token(Token = "0x6001050")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x29EAD00", Offset = "0x29EA100", Length = "0x130")]
	[Token(Token = "0x6001052")]
	public static DeltaStateEvent* From(InputEventPtr ptr) { }

	[Address(RVA = "0x29EA950", Offset = "0x29E9D50", Length = "0x3AE")]
	[Token(Token = "0x6001054")]
	public static NativeArray<Byte> From(InputControl control, out InputEventPtr eventPtr, Allocator allocator = 2) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6001053")]
	internal static DeltaStateEvent* FromUnchecked(InputEventPtr ptr) { }

	[Address(RVA = "0x29EAE40", Offset = "0x29EA240", Length = "0x5")]
	[Token(Token = "0x600104F")]
	public Void* get_deltaState() { }

	[Address(RVA = "0x29EAE30", Offset = "0x29EA230", Length = "0x8")]
	[Token(Token = "0x600104E")]
	public uint get_deltaStateSizeInBytes() { }

	[Address(RVA = "0x29EAE50", Offset = "0x29EA250", Length = "0x6")]
	[Token(Token = "0x6001050")]
	public override FourCC get_typeStatic() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6001051")]
	public InputEventPtr ToEventPtr() { }

}

