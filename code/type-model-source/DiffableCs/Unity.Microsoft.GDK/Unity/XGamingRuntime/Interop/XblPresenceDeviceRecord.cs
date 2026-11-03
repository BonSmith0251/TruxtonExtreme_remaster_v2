namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000328")]
internal struct XblPresenceDeviceRecord
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008F3")]
	internal readonly XblPresenceDeviceType deviceType; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40008F4")]
	private readonly IntPtr titleRecords; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008F5")]
	private readonly SizeT titleRecordsCount; //Field offset: 0x10

	[Address(RVA = "0x9E75C0", Offset = "0x9E69C0", Length = "0x4E")]
	[Token(Token = "0x600118D")]
	internal T[] GetTitleRecords(Func<XblPresenceTitleRecord, T> ctor) { }

}

