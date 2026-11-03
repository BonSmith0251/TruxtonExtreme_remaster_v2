namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000351")]
internal struct XDisplayHdrModeInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000990")]
	internal float minToneMapLuminance; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000991")]
	internal float maxToneMapLuminance; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000992")]
	internal float maxFullFrameToneMapLuminance; //Field offset: 0x8

}

