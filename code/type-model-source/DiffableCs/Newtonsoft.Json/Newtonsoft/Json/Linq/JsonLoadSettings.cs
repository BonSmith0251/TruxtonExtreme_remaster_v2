namespace Newtonsoft.Json.Linq;

[Token(Token = "0x200017D")]
public class JsonLoadSettings
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006FC")]
	private CommentHandling _commentHandling; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40006FD")]
	private LineInfoHandling _lineInfoHandling; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006FE")]
	private DuplicatePropertyNameHandling _duplicatePropertyNameHandling; //Field offset: 0x18

	[Token(Token = "0x1700020B")]
	public CommentHandling CommentHandling
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000C97")]
		 get { } //Length: 85
		[Address(RVA = "0x2189120", Offset = "0x2188520", Length = "0x63")]
		[Token(Token = "0x6000C98")]
		 set { } //Length: 99
	}

	[Token(Token = "0x1700020D")]
	public DuplicatePropertyNameHandling DuplicatePropertyNameHandling
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000C9B")]
		 get { } //Length: 4
		[Address(RVA = "0x2189190", Offset = "0x2188590", Length = "0x63")]
		[Token(Token = "0x6000C9C")]
		 set { } //Length: 99
	}

	[Token(Token = "0x1700020C")]
	public LineInfoHandling LineInfoHandling
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x6000C99")]
		 get { } //Length: 4
		[Address(RVA = "0x2189200", Offset = "0x2188600", Length = "0x63")]
		[Token(Token = "0x6000C9A")]
		 set { } //Length: 99
	}

	[Address(RVA = "0x21890F0", Offset = "0x21884F0", Length = "0x25")]
	[Token(Token = "0x6000C96")]
	public JsonLoadSettings() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000C97")]
	public CommentHandling get_CommentHandling() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000C9B")]
	public DuplicatePropertyNameHandling get_DuplicatePropertyNameHandling() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x6000C99")]
	public LineInfoHandling get_LineInfoHandling() { }

	[Address(RVA = "0x2189120", Offset = "0x2188520", Length = "0x63")]
	[Token(Token = "0x6000C98")]
	public void set_CommentHandling(CommentHandling value) { }

	[Address(RVA = "0x2189190", Offset = "0x2188590", Length = "0x63")]
	[Token(Token = "0x6000C9C")]
	public void set_DuplicatePropertyNameHandling(DuplicatePropertyNameHandling value) { }

	[Address(RVA = "0x2189200", Offset = "0x2188600", Length = "0x63")]
	[Token(Token = "0x6000C9A")]
	public void set_LineInfoHandling(LineInfoHandling value) { }

}

