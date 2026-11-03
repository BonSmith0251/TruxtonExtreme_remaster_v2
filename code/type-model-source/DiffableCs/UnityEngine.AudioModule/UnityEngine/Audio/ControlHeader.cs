namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/ScriptableProcessors/ControlHeader.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000013")]
internal struct ControlHeader
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400002B")]
	internal Handle Handle; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002C")]
	internal IntPtr ManagedTransport; //Field offset: 0x10

}

