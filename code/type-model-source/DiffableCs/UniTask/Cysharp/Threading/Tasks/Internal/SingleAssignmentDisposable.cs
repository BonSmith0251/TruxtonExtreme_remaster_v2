namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x2000232")]
internal sealed class SingleAssignmentDisposable : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000601")]
	private readonly object gate; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000602")]
	private IDisposable current; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000603")]
	private bool disposed; //Field offset: 0x20

	[Token(Token = "0x17000074")]
	public IDisposable Disposable
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000C8B")]
		 get { } //Length: 5
		[Address(RVA = "0x278B100", Offset = "0x278A500", Length = "0x188")]
		[Token(Token = "0x6000C8C")]
		 set { } //Length: 392
	}

	[Token(Token = "0x17000073")]
	public bool IsDisposed
	{
		[Address(RVA = "0x278B060", Offset = "0x278A460", Length = "0x92")]
		[Token(Token = "0x6000C8A")]
		 get { } //Length: 146
	}

	[Address(RVA = "0x278AFF0", Offset = "0x278A3F0", Length = "0x66")]
	[Token(Token = "0x6000C8E")]
	public SingleAssignmentDisposable() { }

	[Address(RVA = "0x278AF00", Offset = "0x278A300", Length = "0xEB")]
	[Token(Token = "0x6000C8D")]
	public override void Dispose() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000C8B")]
	public IDisposable get_Disposable() { }

	[Address(RVA = "0x278B060", Offset = "0x278A460", Length = "0x92")]
	[Token(Token = "0x6000C8A")]
	public bool get_IsDisposed() { }

	[Address(RVA = "0x278B100", Offset = "0x278A500", Length = "0x188")]
	[Token(Token = "0x6000C8C")]
	public void set_Disposable(IDisposable value) { }

}

