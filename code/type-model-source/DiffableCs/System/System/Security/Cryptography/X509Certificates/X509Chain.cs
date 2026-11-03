namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000135")]
public class X509Chain : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000599")]
	private X509ChainImpl impl; //Field offset: 0x10

	[Token(Token = "0x17000152")]
	public X509ChainElementCollection ChainElements
	{
		[Address(RVA = "0x26578B0", Offset = "0x2656CB0", Length = "0x72")]
		[Token(Token = "0x6000775")]
		 get { } //Length: 114
	}

	[Token(Token = "0x17000153")]
	public X509ChainPolicy ChainPolicy
	{
		[Address(RVA = "0x2657930", Offset = "0x2656D30", Length = "0x72")]
		[Token(Token = "0x6000776")]
		 get { } //Length: 114
	}

	[Token(Token = "0x17000151")]
	internal X509ChainImpl Impl
	{
		[Address(RVA = "0x26579B0", Offset = "0x2656DB0", Length = "0x54")]
		[Token(Token = "0x6000770")]
		internal get { } //Length: 84
	}

	[Address(RVA = "0x26577C0", Offset = "0x2656BC0", Length = "0x66")]
	[Token(Token = "0x6000771")]
	public X509Chain() { }

	[Address(RVA = "0x2657830", Offset = "0x2656C30", Length = "0x75")]
	[Token(Token = "0x6000772")]
	public X509Chain(bool useMachineContext) { }

	[Address(RVA = "0x2657740", Offset = "0x2656B40", Length = "0x71")]
	[Token(Token = "0x6000773")]
	internal X509Chain(X509ChainImpl impl) { }

	[Address(RVA = "0x26576F0", Offset = "0x2656AF0", Length = "0x45")]
	[MonoTODO("Mono's X509Chain is fully managed. All handles are invalid.")]
	[Token(Token = "0x6000774")]
	public X509Chain(IntPtr chainContext) { }

	[Address(RVA = "0x2657440", Offset = "0x2656840", Length = "0x81")]
	[MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
	[Token(Token = "0x6000777")]
	public bool Build(X509Certificate2 certificate) { }

	[Address(RVA = "0x26574D0", Offset = "0x26568D0", Length = "0x95")]
	[Token(Token = "0x6000779")]
	public static X509Chain Create() { }

	[Address(RVA = "0x2657600", Offset = "0x2656A00", Length = "0x61")]
	[Token(Token = "0x600077A")]
	public override void Dispose() { }

	[Address(RVA = "0x2657570", Offset = "0x2656970", Length = "0x8A")]
	[Token(Token = "0x600077B")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1E56230", Offset = "0x1E55630", Length = "0x65")]
	[Token(Token = "0x600077C")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x26578B0", Offset = "0x2656CB0", Length = "0x72")]
	[Token(Token = "0x6000775")]
	public X509ChainElementCollection get_ChainElements() { }

	[Address(RVA = "0x2657930", Offset = "0x2656D30", Length = "0x72")]
	[Token(Token = "0x6000776")]
	public X509ChainPolicy get_ChainPolicy() { }

	[Address(RVA = "0x26579B0", Offset = "0x2656DB0", Length = "0x54")]
	[Token(Token = "0x6000770")]
	internal X509ChainImpl get_Impl() { }

	[Address(RVA = "0x2657670", Offset = "0x2656A70", Length = "0x72")]
	[Token(Token = "0x6000778")]
	public void Reset() { }

}

