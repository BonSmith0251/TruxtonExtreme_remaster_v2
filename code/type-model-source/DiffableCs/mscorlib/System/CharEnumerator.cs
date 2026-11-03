namespace System;

[Token(Token = "0x20000C4")]
public sealed class CharEnumerator : IEnumerator, IEnumerator<Char>, IDisposable, ICloneable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002AA")]
	private string _str; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002AB")]
	private int _index; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40002AC")]
	private char _currentElement; //Field offset: 0x1C

	[Token(Token = "0x1700005E")]
	public override char Current
	{
		[Address(RVA = "0x1F90160", Offset = "0x1F8F560", Length = "0xC2")]
		[Token(Token = "0x60004CB")]
		 get { } //Length: 194
	}

	[Token(Token = "0x1700005D")]
	private override object System.Collections.IEnumerator.Current
	{
		[Address(RVA = "0x1F90010", Offset = "0x1F8F410", Length = "0xD8")]
		[Token(Token = "0x60004CA")]
		private get { } //Length: 216
	}

	[Address(RVA = "0x1F900F0", Offset = "0x1F8F4F0", Length = "0x39")]
	[Token(Token = "0x60004C6")]
	internal CharEnumerator(string str) { }

	[Address(RVA = "0x1F90130", Offset = "0x1F8F530", Length = "0x2C")]
	[Token(Token = "0x60004CD")]
	internal CharEnumerator() { }

	[Address(RVA = "0x1F8FF70", Offset = "0x1F8F370", Length = "0x7")]
	[Token(Token = "0x60004C7")]
	public override object Clone() { }

	[Address(RVA = "0x1F8FF80", Offset = "0x1F8F380", Length = "0x24")]
	[Token(Token = "0x60004C9")]
	public override void Dispose() { }

	[Address(RVA = "0x1F90160", Offset = "0x1F8F560", Length = "0xC2")]
	[Token(Token = "0x60004CB")]
	public override char get_Current() { }

	[Address(RVA = "0x1F8FFB0", Offset = "0x1F8F3B0", Length = "0x4E")]
	[Token(Token = "0x60004C8")]
	public override bool MoveNext() { }

	[Address(RVA = "0x1F90000", Offset = "0x1F8F400", Length = "0xE")]
	[Token(Token = "0x60004CC")]
	public override void Reset() { }

	[Address(RVA = "0x1F90010", Offset = "0x1F8F410", Length = "0xD8")]
	[Token(Token = "0x60004CA")]
	private override object System.Collections.IEnumerator.get_Current() { }

}

