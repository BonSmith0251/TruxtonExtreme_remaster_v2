namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000216")]
public class XGameSaveBlob
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005A8")]
	private XGameSaveBlobInfo <Info>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005A9")]
	private Byte[] <Data>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170001FC")]
	public Byte[] Data
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000AEF")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000AF0")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001FB")]
	public XGameSaveBlobInfo Info
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000AED")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000AEE")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2B80ED0", Offset = "0x2B802D0", Length = "0xCB")]
	[Token(Token = "0x6000AF1")]
	internal XGameSaveBlob(XGameSaveBlobInterop interop) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000AEF")]
	public Byte[] get_Data() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000AED")]
	public XGameSaveBlobInfo get_Info() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000AF0")]
	public void set_Data(Byte[] value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000AEE")]
	public void set_Info(XGameSaveBlobInfo value) { }

}

