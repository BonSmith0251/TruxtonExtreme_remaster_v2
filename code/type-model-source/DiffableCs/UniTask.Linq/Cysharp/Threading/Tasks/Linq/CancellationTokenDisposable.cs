namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20001A0")]
internal sealed class CancellationTokenDisposable : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000FF2")]
	private readonly CancellationTokenSource cts; //Field offset: 0x10

	[Token(Token = "0x17000042")]
	public CancellationToken Token
	{
		[Address(RVA = "0x16C7210", Offset = "0x16C6610", Length = "0x1D")]
		[Token(Token = "0x6000799")]
		 get { } //Length: 29
	}

	[Address(RVA = "0x2751C30", Offset = "0x2751030", Length = "0x66")]
	[Token(Token = "0x600079B")]
	public CancellationTokenDisposable() { }

	[Address(RVA = "0x16C7160", Offset = "0x16C6560", Length = "0x3D")]
	[Token(Token = "0x600079A")]
	public override void Dispose() { }

	[Address(RVA = "0x16C7210", Offset = "0x16C6610", Length = "0x1D")]
	[Token(Token = "0x6000799")]
	public CancellationToken get_Token() { }

}

