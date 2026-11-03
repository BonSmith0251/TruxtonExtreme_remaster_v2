namespace System.Linq.Expressions;

[Token(Token = "0x20000C0")]
public class SymbolDocumentInfo
{
	[Token(Token = "0x40001C8")]
	internal static readonly Guid DocumentType_Text; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001C7")]
	private readonly string <FileName>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000123")]
	public string FileName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600053D")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x226B710", Offset = "0x226AB10", Length = "0x95")]
	[Token(Token = "0x600053E")]
	private static SymbolDocumentInfo() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600053D")]
	public string get_FileName() { }

}

