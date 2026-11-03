namespace Mono.Unity;

[Token(Token = "0x2000045")]
internal class X509ChainImplUnityTls : X509ChainImpl
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000093")]
	private X509ChainElementCollection elements; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000094")]
	private unitytls_x509list* ownedList; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000095")]
	private unitytls_x509list_ref nativeCertificateChain; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000096")]
	private X509ChainPolicy policy; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000097")]
	private List<X509ChainStatus> chainStatusList; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000098")]
	private bool reverseOrder; //Field offset: 0x38

	[Token(Token = "0x17000016")]
	public virtual X509ChainElementCollection ChainElements
	{
		[Address(RVA = "0x22D2900", Offset = "0x22D1D00", Length = "0x361")]
		[Token(Token = "0x60000A5")]
		 get { } //Length: 865
	}

	[Token(Token = "0x17000017")]
	public virtual X509ChainPolicy ChainPolicy
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60000A7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000014")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x22D2C70", Offset = "0x22D2070", Length = "0x28")]
		[Token(Token = "0x60000A3")]
		 get { } //Length: 40
	}

	[Token(Token = "0x17000015")]
	internal unitytls_x509list_ref NativeCertificateChain
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60000A4")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x22D2860", Offset = "0x22D1C60", Length = "0x9F")]
	[Token(Token = "0x60000A1")]
	internal X509ChainImplUnityTls(unitytls_x509list_ref nativeCertificateChain, bool reverseOrder = false) { }

	[Address(RVA = "0x22D2780", Offset = "0x22D1B80", Length = "0xDE")]
	[Token(Token = "0x60000A2")]
	internal X509ChainImplUnityTls(unitytls_x509list* ownedList, unitytls_errorstate* errorState, bool reverseOrder = false) { }

	[Address(RVA = "0x22D2570", Offset = "0x22D1970", Length = "0x137")]
	[Token(Token = "0x60000A6")]
	public virtual void AddStatus(X509ChainStatusFlags error) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60000A8")]
	public virtual bool Build(X509Certificate2 certificate) { }

	[Address(RVA = "0x22D26B0", Offset = "0x22D1AB0", Length = "0x3B")]
	[Token(Token = "0x60000AA")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x22D2900", Offset = "0x22D1D00", Length = "0x361")]
	[Token(Token = "0x60000A5")]
	public virtual X509ChainElementCollection get_ChainElements() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60000A7")]
	public virtual X509ChainPolicy get_ChainPolicy() { }

	[Address(RVA = "0x22D2C70", Offset = "0x22D2070", Length = "0x28")]
	[Token(Token = "0x60000A3")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60000A4")]
	internal unitytls_x509list_ref get_NativeCertificateChain() { }

	[Address(RVA = "0x22D26F0", Offset = "0x22D1AF0", Length = "0x8B")]
	[Token(Token = "0x60000A9")]
	public virtual void Reset() { }

}

