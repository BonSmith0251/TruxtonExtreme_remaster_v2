namespace System.Threading;

[IsReadOnly]
[Token(Token = "0x2000208")]
public struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009A8")]
	private readonly CancellationCallbackInfo m_callbackInfo; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009A9")]
	private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo; //Field offset: 0x8

	[Address(RVA = "0xAEE2A0", Offset = "0xAED6A0", Length = "0x34")]
	[Token(Token = "0x60011D0")]
	internal CancellationTokenRegistration(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo) { }

	[Address(RVA = "0x2093BF0", Offset = "0x2092FF0", Length = "0x140")]
	[Token(Token = "0x60011D2")]
	public override void Dispose() { }

	[Address(RVA = "0x2093DD0", Offset = "0x20931D0", Length = "0xE9")]
	[Token(Token = "0x60011D3")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2093D40", Offset = "0x2093140", Length = "0x87")]
	[Token(Token = "0x60011D4")]
	public override bool Equals(CancellationTokenRegistration other) { }

	[Address(RVA = "0x2093EC0", Offset = "0x20932C0", Length = "0xA9")]
	[Token(Token = "0x60011D5")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2093F70", Offset = "0x2093370", Length = "0x88")]
	[Token(Token = "0x60011D1")]
	public bool Unregister() { }

}

