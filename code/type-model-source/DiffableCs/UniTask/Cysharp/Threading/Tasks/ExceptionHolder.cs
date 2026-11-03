namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000104")]
internal class ExceptionHolder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003C3")]
	private ExceptionDispatchInfo exception; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003C4")]
	private bool calledGet; //Field offset: 0x18

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x600064C")]
	public ExceptionHolder(ExceptionDispatchInfo exception) { }

	[Address(RVA = "0x2734790", Offset = "0x2733B90", Length = "0xA6")]
	[Token(Token = "0x600064E")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2734840", Offset = "0x2733C40", Length = "0x58")]
	[Token(Token = "0x600064D")]
	public ExceptionDispatchInfo GetException() { }

}

