namespace System.Security.Cryptography;

[Token(Token = "0x2000119")]
public sealed class OidEnumerator : IEnumerator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004EF")]
	private readonly OidCollection _oids; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004F0")]
	private int _current; //Field offset: 0x18

	[Token(Token = "0x17000113")]
	public Oid Current
	{
		[Address(RVA = "0x262F620", Offset = "0x262EA20", Length = "0x58")]
		[Token(Token = "0x60006C7")]
		 get { } //Length: 88
	}

	[Token(Token = "0x17000114")]
	private override object System.Collections.IEnumerator.Current
	{
		[Address(RVA = "0x262F620", Offset = "0x262EA20", Length = "0x58")]
		[Token(Token = "0x60006C8")]
		private get { } //Length: 88
	}

	[Address(RVA = "0x1F900F0", Offset = "0x1F8F4F0", Length = "0x39")]
	[Token(Token = "0x60006C6")]
	internal OidEnumerator(OidCollection oids) { }

	[Address(RVA = "0x262F620", Offset = "0x262EA20", Length = "0x58")]
	[Token(Token = "0x60006C7")]
	public Oid get_Current() { }

	[Address(RVA = "0x262F5A0", Offset = "0x262E9A0", Length = "0x78")]
	[Token(Token = "0x60006C9")]
	public override bool MoveNext() { }

	[Address(RVA = "0x195A120", Offset = "0x1959520", Length = "0x8")]
	[Token(Token = "0x60006CA")]
	public override void Reset() { }

	[Address(RVA = "0x262F620", Offset = "0x262EA20", Length = "0x58")]
	[Token(Token = "0x60006C8")]
	private override object System.Collections.IEnumerator.get_Current() { }

}

