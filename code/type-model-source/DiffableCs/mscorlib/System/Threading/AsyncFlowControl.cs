namespace System.Threading;

[Token(Token = "0x2000224")]
public struct AsyncFlowControl : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009FA")]
	private bool useEC; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009FB")]
	private ExecutionContext _ec; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009FC")]
	private Thread _thread; //Field offset: 0x10

	[Address(RVA = "0x2093430", Offset = "0x2092830", Length = "0x7")]
	[Token(Token = "0x6001251")]
	public override void Dispose() { }

	[Address(RVA = "0x2093440", Offset = "0x2092840", Length = "0xB3")]
	[Token(Token = "0x6001254")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2093500", Offset = "0x2092900", Length = "0x3E")]
	[Token(Token = "0x6001255")]
	public bool Equals(AsyncFlowControl obj) { }

	[Address(RVA = "0x2093540", Offset = "0x2092940", Length = "0xCB")]
	[Token(Token = "0x6001253")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2093610", Offset = "0x2092A10", Length = "0x65")]
	[Token(Token = "0x6001250")]
	internal void Setup() { }

	[Address(RVA = "0x2093680", Offset = "0x2092A80", Length = "0x22E")]
	[Token(Token = "0x6001252")]
	public void Undo() { }

}

