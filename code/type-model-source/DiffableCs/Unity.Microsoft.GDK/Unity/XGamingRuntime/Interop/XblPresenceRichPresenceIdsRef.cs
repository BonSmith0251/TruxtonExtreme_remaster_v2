namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200032E")]
internal class XblPresenceRichPresenceIdsRef
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000901")]
	internal readonly Byte[] scid; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000902")]
	internal readonly UTF8StringPtr presenceId; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000903")]
	private readonly IntPtr presenceTokenIds; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000904")]
	private readonly SizeT presenceTokenIdsCount; //Field offset: 0x28

	[Address(RVA = "0x2BB7C10", Offset = "0x2BB7010", Length = "0x140")]
	[Token(Token = "0x600119B")]
	internal XblPresenceRichPresenceIdsRef(XblPresenceRichPresenceIds richPresenceIds, DisposableCollection disposableCollection) { }

	[Address(RVA = "0x2BB5950", Offset = "0x2BB4D50", Length = "0x9A")]
	[Token(Token = "0x600119C")]
	internal static bool ValidateFields(string scid) { }

}

