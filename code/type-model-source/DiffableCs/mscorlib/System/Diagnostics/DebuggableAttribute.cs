namespace System.Diagnostics;

[AttributeUsage(3, AllowMultiple = False)]
[ComVisible(True)]
[Token(Token = "0x2000586")]
public sealed class DebuggableAttribute : Attribute
{
	[ComVisible(True)]
	[Flags]
	[Token(Token = "0x2000587")]
	internal enum DebuggingModes : int
	{
		None = 0,
		Default = 1,
		DisableOptimizations = 256,
		IgnoreSymbolStoreSequencePoints = 2,
		EnableEditAndContinue = 4,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001753")]
	private DebuggingModes m_debuggingModes; //Field offset: 0x10

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x60028E7")]
	public DebuggableAttribute(DebuggingModes modes) { }

}

