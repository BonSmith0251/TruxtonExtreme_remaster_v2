namespace System.Net;

[Token(Token = "0x2000247")]
public class IPHostEntry
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000927")]
	private string hostName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000928")]
	private String[] aliases; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000929")]
	private IPAddress[] addressList; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400092A")]
	internal bool isTrustedHost; //Field offset: 0x28

	[Token(Token = "0x1700032A")]
	public IPAddress[] AddressList
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000F6B")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000F6C")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000329")]
	public String[] Aliases
	{
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000F6A")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000328")]
	public string HostName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000F68")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000F69")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x26AA880", Offset = "0x26A9C80", Length = "0xB")]
	[Token(Token = "0x6000F6D")]
	public IPHostEntry() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000F6B")]
	public IPAddress[] get_AddressList() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000F68")]
	public string get_HostName() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000F6C")]
	public void set_AddressList(IPAddress[] value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000F6A")]
	public void set_Aliases(String[] value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000F69")]
	public void set_HostName(string value) { }

}

