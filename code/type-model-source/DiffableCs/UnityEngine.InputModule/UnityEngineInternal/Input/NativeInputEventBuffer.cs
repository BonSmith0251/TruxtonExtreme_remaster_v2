namespace UnityEngineInternal.Input;

[Token(Token = "0x2000004")]
internal struct NativeInputEventBuffer
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000007")]
	public Void* eventBuffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000008")]
	public int eventCount; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000009")]
	public int sizeInBytes; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000A")]
	public int capacityInBytes; //Field offset: 0x10

}

