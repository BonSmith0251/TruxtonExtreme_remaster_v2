namespace System;

[Token(Token = "0x20000B5")]
public class UriBuilder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400022C")]
	private bool _changed; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400022D")]
	private string _fragment; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400022E")]
	private string _host; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400022F")]
	private string _password; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000230")]
	private string _path; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000231")]
	private int _port; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000232")]
	private string _query; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000233")]
	private string _scheme; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000234")]
	private string _schemeDelimiter; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000235")]
	private Uri _uri; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000236")]
	private string _username; //Field offset: 0x60

	[Token(Token = "0x17000084")]
	public string Path
	{
		[Address(RVA = "0x260E370", Offset = "0x260D770", Length = "0xAB")]
		[Token(Token = "0x6000360")]
		 set { } //Length: 171
	}

	[Token(Token = "0x17000085")]
	public Uri Uri
	{
		[Address(RVA = "0x260E2C0", Offset = "0x260D6C0", Length = "0xA2")]
		[Token(Token = "0x6000361")]
		 get { } //Length: 162
	}

	[Address(RVA = "0x260E0F0", Offset = "0x260D4F0", Length = "0x1CA")]
	[Token(Token = "0x600035E")]
	public UriBuilder(Uri uri) { }

	[Address(RVA = "0x260D7B0", Offset = "0x260CBB0", Length = "0x6A")]
	[Token(Token = "0x6000362")]
	public virtual bool Equals(object rparam) { }

	[Address(RVA = "0x260E2C0", Offset = "0x260D6C0", Length = "0xA2")]
	[Token(Token = "0x6000361")]
	public Uri get_Uri() { }

	[Address(RVA = "0x260D820", Offset = "0x260CC20", Length = "0x30")]
	[Token(Token = "0x6000363")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x260D860", Offset = "0x260CC60", Length = "0x1DB")]
	[Token(Token = "0x600035F")]
	private void Init(Uri uri) { }

	[Address(RVA = "0x260E370", Offset = "0x260D770", Length = "0xAB")]
	[Token(Token = "0x6000360")]
	public void set_Path(string value) { }

	[Address(RVA = "0x260DA40", Offset = "0x260CE40", Length = "0x1BC")]
	[Token(Token = "0x6000364")]
	private void SetFieldsFromUri(Uri uri) { }

	[Address(RVA = "0x260DC00", Offset = "0x260D000", Length = "0x4E2")]
	[Token(Token = "0x6000365")]
	public virtual string ToString() { }

}

