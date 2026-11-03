namespace TXEKernel;

[Token(Token = "0x2000084")]
public class RecordDateTime : RecordInt64
{
	[Token(Token = "0x2000085")]
	internal class DateTimeParams : BaseParamsT<Int64>
	{

		[Address(RVA = "0x26F0AD0", Offset = "0x26EFED0", Length = "0xA2")]
		[Token(Token = "0x60004A2")]
		public DateTimeParams(string label) { }

	}


	[Token(Token = "0x1700018E")]
	public DateTime DateTime
	{
		[Address(RVA = "0x26F66F0", Offset = "0x26F5AF0", Length = "0xB8")]
		[Token(Token = "0x60004A0")]
		 get { } //Length: 184
		[Address(RVA = "0x26F67B0", Offset = "0x26F5BB0", Length = "0x6A")]
		[Token(Token = "0x60004A1")]
		 set { } //Length: 106
	}

	[Address(RVA = "0x26F66A0", Offset = "0x26F5AA0", Length = "0x48")]
	[Token(Token = "0x600049B")]
	public RecordDateTime(DateTimeParams p) { }

	[Address(RVA = "0x26F66F0", Offset = "0x26F5AF0", Length = "0xB8")]
	[Token(Token = "0x60004A0")]
	public DateTime get_DateTime() { }

	[Address(RVA = "0x26F6430", Offset = "0x26F5830", Length = "0x98")]
	[Token(Token = "0x600049C")]
	public bool IsValid() { }

	[Address(RVA = "0x26F67B0", Offset = "0x26F5BB0", Length = "0x6A")]
	[Token(Token = "0x60004A1")]
	public void set_DateTime(DateTime value) { }

	[Address(RVA = "0x26F64D0", Offset = "0x26F58D0", Length = "0xB0")]
	[Token(Token = "0x600049F")]
	public void SetInvalid() { }

	[Address(RVA = "0x26F6580", Offset = "0x26F5980", Length = "0xA3")]
	[Token(Token = "0x600049D")]
	public void SetValid() { }

	[Address(RVA = "0x26F6630", Offset = "0x26F5A30", Length = "0x6B")]
	[Token(Token = "0x600049E")]
	public void SetValid(DateTime dateTime) { }

}

