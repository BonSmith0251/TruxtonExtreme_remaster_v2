namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200032F")]
internal struct XblPresenceTitleRecord
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000905")]
	internal readonly uint titleId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000906")]
	internal readonly UTF8StringPtr titleName; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000907")]
	internal readonly TimeT lastModified; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000908")]
	internal readonly bool titleActive; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000909")]
	internal readonly UTF8StringPtr richPresenceString; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400090A")]
	internal readonly XblPresenceTitleViewState viewState; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400090B")]
	private readonly IntPtr broadcastRecord; //Field offset: 0x30

	[Address(RVA = "0x9E7610", Offset = "0x9E6A10", Length = "0x4A")]
	[Token(Token = "0x600119D")]
	internal T GetBroadcastRecord(Func<XblPresenceBroadcastRecord, T> ctor) { }

}

