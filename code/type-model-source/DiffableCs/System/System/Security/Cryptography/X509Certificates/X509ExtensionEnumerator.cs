namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000140")]
public sealed class X509ExtensionEnumerator : IEnumerator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005C0")]
	private IEnumerator enumerator; //Field offset: 0x10

	[Token(Token = "0x17000176")]
	public X509Extension Current
	{
		[Address(RVA = "0x2658CC0", Offset = "0x26580C0", Length = "0x95")]
		[Token(Token = "0x60007EC")]
		 get { } //Length: 149
	}

	[Token(Token = "0x17000177")]
	private override object System.Collections.IEnumerator.Current
	{
		[Address(RVA = "0x2658C10", Offset = "0x2658010", Length = "0x49")]
		[Token(Token = "0x60007ED")]
		private get { } //Length: 73
	}

	[Address(RVA = "0x2658C60", Offset = "0x2658060", Length = "0x51")]
	[Token(Token = "0x60007EB")]
	internal X509ExtensionEnumerator(ArrayList list) { }

	[Address(RVA = "0x2658CC0", Offset = "0x26580C0", Length = "0x95")]
	[Token(Token = "0x60007EC")]
	public X509Extension get_Current() { }

	[Address(RVA = "0x2658B70", Offset = "0x2657F70", Length = "0x46")]
	[Token(Token = "0x60007EE")]
	public override bool MoveNext() { }

	[Address(RVA = "0x2658BC0", Offset = "0x2657FC0", Length = "0x49")]
	[Token(Token = "0x60007EF")]
	public override void Reset() { }

	[Address(RVA = "0x2658C10", Offset = "0x2658010", Length = "0x49")]
	[Token(Token = "0x60007ED")]
	private override object System.Collections.IEnumerator.get_Current() { }

}

