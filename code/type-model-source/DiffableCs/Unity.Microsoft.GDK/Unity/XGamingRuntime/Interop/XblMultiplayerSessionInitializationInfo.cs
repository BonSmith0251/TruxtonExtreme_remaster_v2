namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002FD")]
internal struct XblMultiplayerSessionInitializationInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000834")]
	internal XblMultiplayerInitializationStage Stage; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000835")]
	internal TimeT StageStartTime; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000836")]
	internal uint Episode; //Field offset: 0x10

}

