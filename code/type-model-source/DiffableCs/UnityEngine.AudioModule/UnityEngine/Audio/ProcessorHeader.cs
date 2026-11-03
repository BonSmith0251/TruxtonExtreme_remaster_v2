namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/ScriptableProcessors/ScriptableProcessor.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000023")]
internal struct ProcessorHeader
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000053")]
	private Void* m_Control; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000054")]
	internal Handle DualThreadHandle; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000055")]
	internal IntPtr NativeProcessorFunction; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000056")]
	internal IntPtr NativeControlFunction; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000057")]
	internal IntPtr ProcessorReflectionData; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000058")]
	internal IntPtr ControlReflectionData; //Field offset: 0x30

}

