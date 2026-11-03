namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002AB")]
public class DisposableCollection : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000729")]
	private readonly List<IDisposable> disposables; //Field offset: 0x10

	[Address(RVA = "0x2B8E2F0", Offset = "0x2B8D6F0", Length = "0x77")]
	[Token(Token = "0x6000DE9")]
	public DisposableCollection() { }

	[Address(RVA = "0x7D1300", Offset = "0x7D0700", Length = "0xB1")]
	[Token(Token = "0x6000DED")]
	public T Add(T disposable) { }

	[Address(RVA = "0x2B8E0D0", Offset = "0x2B8D4D0", Length = "0x56")]
	[Token(Token = "0x6000DEA")]
	public override void Dispose() { }

	[Address(RVA = "0x2B8E130", Offset = "0x2B8D530", Length = "0x156")]
	[Token(Token = "0x6000DEB")]
	private void Dispose(bool isDisposing) { }

	[Address(RVA = "0x2B8E290", Offset = "0x2B8D690", Length = "0x5A")]
	[Token(Token = "0x6000DEC")]
	protected virtual void Finalize() { }

}

