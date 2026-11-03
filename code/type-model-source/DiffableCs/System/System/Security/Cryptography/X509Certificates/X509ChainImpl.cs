namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000139")]
internal abstract class X509ChainImpl : IDisposable
{

	[Token(Token = "0x1700015E")]
	public abstract X509ChainElementCollection ChainElements
	{
		[Token(Token = "0x6000797")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700015F")]
	public abstract X509ChainPolicy ChainPolicy
	{
		[Token(Token = "0x6000798")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700015D")]
	public abstract bool IsValid
	{
		[Token(Token = "0x6000795")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600079F")]
	protected X509ChainImpl() { }

	[Token(Token = "0x600079A")]
	public abstract void AddStatus(X509ChainStatusFlags errorCode) { }

	[Token(Token = "0x6000799")]
	public abstract bool Build(X509Certificate2 certificate) { }

	[Address(RVA = "0x2656AF0", Offset = "0x2655EF0", Length = "0x61")]
	[Token(Token = "0x600079C")]
	public override void Dispose() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600079D")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x2656B60", Offset = "0x2655F60", Length = "0x65")]
	[Token(Token = "0x600079E")]
	protected virtual void Finalize() { }

	[Token(Token = "0x6000797")]
	public abstract X509ChainElementCollection get_ChainElements() { }

	[Token(Token = "0x6000798")]
	public abstract X509ChainPolicy get_ChainPolicy() { }

	[Token(Token = "0x6000795")]
	public abstract bool get_IsValid() { }

	[Token(Token = "0x600079B")]
	public abstract void Reset() { }

	[Address(RVA = "0x2656BD0", Offset = "0x2655FD0", Length = "0x4B")]
	[Token(Token = "0x6000796")]
	protected void ThrowIfContextInvalid() { }

}

