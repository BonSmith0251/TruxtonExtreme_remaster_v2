namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000138")]
public sealed class X509ChainElementEnumerator : IEnumerator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400059F")]
	private IEnumerator enumerator; //Field offset: 0x10

	[Token(Token = "0x1700015B")]
	public X509ChainElement Current
	{
		[Address(RVA = "0x2651E40", Offset = "0x2651240", Length = "0x95")]
		[Token(Token = "0x6000791")]
		 get { } //Length: 149
	}

	[Token(Token = "0x1700015C")]
	private override object System.Collections.IEnumerator.Current
	{
		[Address(RVA = "0x2651D80", Offset = "0x2651180", Length = "0x49")]
		[Token(Token = "0x6000792")]
		private get { } //Length: 73
	}

	[Address(RVA = "0x2651DD0", Offset = "0x26511D0", Length = "0x6B")]
	[Token(Token = "0x6000790")]
	internal X509ChainElementEnumerator(IEnumerable enumerable) { }

	[Address(RVA = "0x2651E40", Offset = "0x2651240", Length = "0x95")]
	[Token(Token = "0x6000791")]
	public X509ChainElement get_Current() { }

	[Address(RVA = "0x2651CE0", Offset = "0x26510E0", Length = "0x46")]
	[Token(Token = "0x6000793")]
	public override bool MoveNext() { }

	[Address(RVA = "0x2651D30", Offset = "0x2651130", Length = "0x49")]
	[Token(Token = "0x6000794")]
	public override void Reset() { }

	[Address(RVA = "0x2651D80", Offset = "0x2651180", Length = "0x49")]
	[Token(Token = "0x6000792")]
	private override object System.Collections.IEnumerator.get_Current() { }

}

