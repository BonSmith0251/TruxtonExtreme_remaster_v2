namespace System.IO;

[Token(Token = "0x2000634")]
internal struct DisableMediaInsertionPrompt : IDisposable
{
	[Token(Token = "0x40018CA")]
	private static bool useUWPFallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40018C8")]
	private bool _disableSuccess; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40018C9")]
	private uint _oldMode; //Field offset: 0x4

	[Address(RVA = "0x1FD4C20", Offset = "0x1FD4020", Length = "0x79")]
	[Token(Token = "0x6002E05")]
	public static DisableMediaInsertionPrompt Create() { }

	[Address(RVA = "0x1FD4CA0", Offset = "0x1FD40A0", Length = "0x26")]
	[Token(Token = "0x6002E06")]
	public override void Dispose() { }

}

