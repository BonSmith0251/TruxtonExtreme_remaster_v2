namespace Mono.Security.Interface;

[Token(Token = "0x200003E")]
public class MonoTlsConnectionInfo
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001E0")]
	private CipherSuiteCode <CipherSuiteCode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40001E1")]
	private TlsProtocols <ProtocolVersion>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001E2")]
	private string <PeerDomainName>k__BackingField; //Field offset: 0x18

	[CLSCompliant(False)]
	[Token(Token = "0x17000062")]
	public CipherSuiteCode CipherSuiteCode
	{
		[Address(RVA = "0x111BFC0", Offset = "0x111B3C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000147")]
		 get { } //Length: 5
		[Address(RVA = "0x1E51EE0", Offset = "0x1E512E0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000148")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000064")]
	public string PeerDomainName
	{
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600014B")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000063")]
	public TlsProtocols ProtocolVersion
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000149")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600014A")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600014D")]
	public MonoTlsConnectionInfo() { }

	[Address(RVA = "0x111BFC0", Offset = "0x111B3C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000147")]
	public CipherSuiteCode get_CipherSuiteCode() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000149")]
	public TlsProtocols get_ProtocolVersion() { }

	[Address(RVA = "0x1E51EE0", Offset = "0x1E512E0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000148")]
	public void set_CipherSuiteCode(CipherSuiteCode value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600014B")]
	public void set_PeerDomainName(string value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600014A")]
	public void set_ProtocolVersion(TlsProtocols value) { }

	[Address(RVA = "0x1E51E40", Offset = "0x1E51240", Length = "0x96")]
	[Token(Token = "0x600014C")]
	public virtual string ToString() { }

}

