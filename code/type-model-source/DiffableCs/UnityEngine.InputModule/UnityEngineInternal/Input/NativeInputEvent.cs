namespace UnityEngineInternal.Input;

[Token(Token = "0x2000005")]
internal struct NativeInputEvent
{
	[Token(Token = "0x400000B")]
	public const int alignment = 4; //Field offset: 0x0
	[Token(Token = "0x400000C")]
	public const int structSize = 20; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000D")]
	public NativeInputEventType type; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400000E")]
	public ushort sizeInBytes; //Field offset: 0x4
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x400000F")]
	public ushort deviceId; //Field offset: 0x6
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000010")]
	public double time; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000011")]
	public int eventId; //Field offset: 0x10

}

