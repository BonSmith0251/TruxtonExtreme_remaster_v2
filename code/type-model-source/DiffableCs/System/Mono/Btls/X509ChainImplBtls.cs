namespace Mono.Btls;

[Token(Token = "0x20000A8")]
internal class X509ChainImplBtls : X509ChainImpl
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001F8")]
	private MonoBtlsX509StoreCtx storeCtx; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001F9")]
	private MonoBtlsX509Chain chain; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001FA")]
	private MonoBtlsX509Chain untrustedChain; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001FB")]
	private X509ChainElementCollection elements; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001FC")]
	private X509Certificate2Collection untrusted; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001FD")]
	private X509Certificate2[] certificates; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001FE")]
	private X509ChainPolicy policy; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001FF")]
	private List<X509ChainStatus> chainStatusList; //Field offset: 0x48

	[Token(Token = "0x1700007F")]
	public virtual X509ChainElementCollection ChainElements
	{
		[Address(RVA = "0x26137B0", Offset = "0x2612BB0", Length = "0x2B1")]
		[Token(Token = "0x6000322")]
		 get { } //Length: 689
	}

	[Token(Token = "0x17000080")]
	public virtual X509ChainPolicy ChainPolicy
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000323")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700007D")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x2613A70", Offset = "0x2612E70", Length = "0x15")]
		[Token(Token = "0x6000320")]
		 get { } //Length: 21
	}

	[Token(Token = "0x1700007E")]
	internal MonoBtlsX509StoreCtx StoreCtx
	{
		[Address(RVA = "0x2613A90", Offset = "0x2612E90", Length = "0x1A")]
		[Token(Token = "0x6000321")]
		internal get { } //Length: 26
	}

	[Address(RVA = "0x2613610", Offset = "0x2612A10", Length = "0x19D")]
	[Token(Token = "0x600031E")]
	internal X509ChainImplBtls(MonoBtlsX509Chain chain) { }

	[Address(RVA = "0x2613070", Offset = "0x2612470", Length = "0x59C")]
	[Token(Token = "0x600031F")]
	internal X509ChainImplBtls(MonoBtlsX509StoreCtx storeCtx) { }

	[Address(RVA = "0x2612D20", Offset = "0x2612120", Length = "0x137")]
	[Token(Token = "0x6000324")]
	public virtual void AddStatus(X509ChainStatusFlags errorCode) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000325")]
	public virtual bool Build(X509Certificate2 certificate) { }

	[Address(RVA = "0x2612E60", Offset = "0x2612260", Length = "0x158")]
	[Token(Token = "0x6000327")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x26137B0", Offset = "0x2612BB0", Length = "0x2B1")]
	[Token(Token = "0x6000322")]
	public virtual X509ChainElementCollection get_ChainElements() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000323")]
	public virtual X509ChainPolicy get_ChainPolicy() { }

	[Address(RVA = "0x2613A70", Offset = "0x2612E70", Length = "0x15")]
	[Token(Token = "0x6000320")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x2613A90", Offset = "0x2612E90", Length = "0x1A")]
	[Token(Token = "0x6000321")]
	internal MonoBtlsX509StoreCtx get_StoreCtx() { }

	[Address(RVA = "0x2612FC0", Offset = "0x26123C0", Length = "0xAC")]
	[Token(Token = "0x6000326")]
	public virtual void Reset() { }

}

