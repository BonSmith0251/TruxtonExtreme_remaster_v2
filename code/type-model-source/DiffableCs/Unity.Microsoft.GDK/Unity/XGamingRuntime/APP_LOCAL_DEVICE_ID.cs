namespace Unity.XGamingRuntime;

[Token(Token = "0x200029A")]
public class APP_LOCAL_DEVICE_ID
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400071D")]
	internal APP_LOCAL_DEVICE_ID interop; //Field offset: 0x10

	[Token(Token = "0x170002EC")]
	public Byte[] Value
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000D7D")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
		[Token(Token = "0x6000D7E")]
		 set { } //Length: 12
	}

	[Address(RVA = "0x1606F40", Offset = "0x1606340", Length = "0x30")]
	[Token(Token = "0x6000D7B")]
	internal APP_LOCAL_DEVICE_ID(APP_LOCAL_DEVICE_ID interop) { }

	[Address(RVA = "0x2B7F400", Offset = "0x2B7E800", Length = "0x1C")]
	[Token(Token = "0x6000D7C")]
	public APP_LOCAL_DEVICE_ID() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000D7D")]
	public Byte[] get_Value() { }

	[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
	[Token(Token = "0x6000D7E")]
	public void set_Value(Byte[] value) { }

}

