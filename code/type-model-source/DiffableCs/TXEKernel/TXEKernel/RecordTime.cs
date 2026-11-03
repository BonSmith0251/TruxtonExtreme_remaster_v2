namespace TXEKernel;

[Token(Token = "0x2000082")]
public class RecordTime : RecordInt64
{
	[Token(Token = "0x2000083")]
	internal class TimeParams : BaseParamsT<Int64>
	{

		[Address(RVA = "0x2700CD0", Offset = "0x27000D0", Length = "0x4B")]
		[Token(Token = "0x600049A")]
		public TimeParams(string label) { }

	}


	[Token(Token = "0x1700018C")]
	public long MSec
	{
		[Address(RVA = "0x26F6A80", Offset = "0x26F5E80", Length = "0x39")]
		[Token(Token = "0x6000496")]
		 get { } //Length: 57
		[Address(RVA = "0x26F6B10", Offset = "0x26F5F10", Length = "0x4A")]
		[Token(Token = "0x6000497")]
		 set { } //Length: 74
	}

	[Token(Token = "0x1700018D")]
	public long Sec
	{
		[Address(RVA = "0x26F6AC0", Offset = "0x26F5EC0", Length = "0x47")]
		[Token(Token = "0x6000498")]
		 get { } //Length: 71
		[Address(RVA = "0x26F6B60", Offset = "0x26F5F60", Length = "0x58")]
		[Token(Token = "0x6000499")]
		 set { } //Length: 88
	}

	[Address(RVA = "0x26F66A0", Offset = "0x26F5AA0", Length = "0x48")]
	[Token(Token = "0x6000495")]
	public RecordTime(TimeParams p) { }

	[Address(RVA = "0x26F6A80", Offset = "0x26F5E80", Length = "0x39")]
	[Token(Token = "0x6000496")]
	public long get_MSec() { }

	[Address(RVA = "0x26F6AC0", Offset = "0x26F5EC0", Length = "0x47")]
	[Token(Token = "0x6000498")]
	public long get_Sec() { }

	[Address(RVA = "0x26F6B10", Offset = "0x26F5F10", Length = "0x4A")]
	[Token(Token = "0x6000497")]
	public void set_MSec(long value) { }

	[Address(RVA = "0x26F6B60", Offset = "0x26F5F60", Length = "0x58")]
	[Token(Token = "0x6000499")]
	public void set_Sec(long value) { }

}

