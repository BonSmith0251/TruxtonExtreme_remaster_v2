namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x200019B")]
internal sealed class LightDelegateCreator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000363")]
	private readonly LambdaExpression _lambda; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000364")]
	private readonly Interpreter <Interpreter>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170001CF")]
	internal Interpreter Interpreter
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60008CF")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x1EE5030", Offset = "0x1EE4430", Length = "0x4E")]
	[Token(Token = "0x60008CE")]
	internal LightDelegateCreator(Interpreter interpreter, LambdaExpression lambda) { }

	[Address(RVA = "0x229B540", Offset = "0x229A940", Length = "0xA")]
	[Token(Token = "0x60008D0")]
	public Delegate CreateDelegate() { }

	[Address(RVA = "0x229B550", Offset = "0x229A950", Length = "0x11B")]
	[Token(Token = "0x60008D1")]
	internal Delegate CreateDelegate(IStrongBox[] closure) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60008CF")]
	internal Interpreter get_Interpreter() { }

}

