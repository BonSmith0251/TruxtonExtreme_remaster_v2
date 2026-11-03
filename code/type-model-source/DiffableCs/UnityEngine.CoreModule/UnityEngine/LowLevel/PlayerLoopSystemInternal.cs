namespace UnityEngine.LowLevel;

[MovedFrom("UnityEngine.Experimental.LowLevel")]
[NativeType(Header = "Runtime/Misc/PlayerLoop.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000267")]
internal struct PlayerLoopSystemInternal
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007E2")]
	public Type type; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40007E3")]
	public UpdateFunction updateDelegate; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007E4")]
	public IntPtr updateFunction; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007E5")]
	public IntPtr loopConditionFunction; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007E6")]
	public int numSubSystems; //Field offset: 0x20

}

