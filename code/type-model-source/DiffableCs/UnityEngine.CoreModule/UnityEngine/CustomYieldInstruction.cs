namespace UnityEngine;

[Token(Token = "0x20001A5")]
public abstract class CustomYieldInstruction : IEnumerator
{

	[Token(Token = "0x170002DE")]
	public override object Current
	{
		[Address(RVA = "0xE37D50", Offset = "0xE37150", Length = "0x5")]
		[Token(Token = "0x6001304")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002DD")]
	public abstract bool keepWaiting
	{
		[Token(Token = "0x6001303")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001307")]
	protected CustomYieldInstruction() { }

	[Address(RVA = "0xE37D50", Offset = "0xE37150", Length = "0x5")]
	[Token(Token = "0x6001304")]
	public override object get_Current() { }

	[Token(Token = "0x6001303")]
	public abstract bool get_keepWaiting() { }

	[Address(RVA = "0x1F71DF0", Offset = "0x1F711F0", Length = "0x14")]
	[Token(Token = "0x6001305")]
	public override bool MoveNext() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001306")]
	public override void Reset() { }

}

