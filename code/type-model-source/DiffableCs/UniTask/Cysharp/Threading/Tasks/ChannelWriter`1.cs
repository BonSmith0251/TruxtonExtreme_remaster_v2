namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000021")]
public abstract class ChannelWriter
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000BA")]
	protected ChannelWriter`1() { }

	[Address(RVA = "0x16D1110", Offset = "0x16D0510", Length = "0x5C")]
	[Token(Token = "0x60000B9")]
	public void Complete(Exception error = null) { }

	[Token(Token = "0x60000B8")]
	public abstract bool TryComplete(Exception error = null) { }

	[Token(Token = "0x60000B7")]
	public abstract bool TryWrite(T item) { }

}

