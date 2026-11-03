namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x200012E")]
public sealed class X509Certificate2Enumerator : IEnumerator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000590")]
	private IEnumerator enumerator; //Field offset: 0x10

	[Token(Token = "0x1700012E")]
	public X509Certificate2 Current
	{
		[Address(RVA = "0x264C990", Offset = "0x264BD90", Length = "0x95")]
		[Token(Token = "0x6000720")]
		 get { } //Length: 149
	}

	[Token(Token = "0x1700012F")]
	private override object System.Collections.IEnumerator.Current
	{
		[Address(RVA = "0x264C8D0", Offset = "0x264BCD0", Length = "0x49")]
		[Token(Token = "0x6000722")]
		private get { } //Length: 73
	}

	[Address(RVA = "0x264C920", Offset = "0x264BD20", Length = "0x6B")]
	[Token(Token = "0x600071F")]
	internal X509Certificate2Enumerator(X509Certificate2Collection collection) { }

	[Address(RVA = "0x264C990", Offset = "0x264BD90", Length = "0x95")]
	[Token(Token = "0x6000720")]
	public X509Certificate2 get_Current() { }

	[Address(RVA = "0x264C7E0", Offset = "0x264BBE0", Length = "0x46")]
	[Token(Token = "0x6000721")]
	public bool MoveNext() { }

	[Address(RVA = "0x264C8D0", Offset = "0x264BCD0", Length = "0x49")]
	[Token(Token = "0x6000722")]
	private override object System.Collections.IEnumerator.get_Current() { }

	[Address(RVA = "0x264C830", Offset = "0x264BC30", Length = "0x46")]
	[Token(Token = "0x6000723")]
	private override bool System.Collections.IEnumerator.MoveNext() { }

	[Address(RVA = "0x264C880", Offset = "0x264BC80", Length = "0x49")]
	[Token(Token = "0x6000724")]
	private override void System.Collections.IEnumerator.Reset() { }

}

