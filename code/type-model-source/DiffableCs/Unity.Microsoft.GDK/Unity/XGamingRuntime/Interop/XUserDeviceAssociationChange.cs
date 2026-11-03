namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20003A6")]
internal struct XUserDeviceAssociationChange
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A62")]
	internal APP_LOCAL_DEVICE_ID deviceId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A63")]
	internal XUserLocalId oldUser; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A64")]
	internal XUserLocalId newUser; //Field offset: 0x10

}

