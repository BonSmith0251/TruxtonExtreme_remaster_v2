namespace System.Globalization;

[Token(Token = "0x2000540")]
public class CultureNotFoundException : ArgumentException
{
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001505")]
	private string _invalidCultureName; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001506")]
	private Nullable<Int32> _invalidCultureId; //Field offset: 0xA0

	[Token(Token = "0x1700053D")]
	private static string DefaultMessage
	{
		[Address(RVA = "0x1F52880", Offset = "0x1F51C80", Length = "0x2C")]
		[Token(Token = "0x600264B")]
		private get { } //Length: 44
	}

	[Token(Token = "0x1700053E")]
	private string FormatedInvalidCultureId
	{
		[Address(RVA = "0x1F528B0", Offset = "0x1F51CB0", Length = "0x117")]
		[Token(Token = "0x600264C")]
		private get { } //Length: 279
	}

	[Token(Token = "0x1700053B")]
	public override Nullable<Int32> InvalidCultureId
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[Token(Token = "0x6002649")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700053C")]
	public override string InvalidCultureName
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x600264A")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700053F")]
	public virtual string Message
	{
		[Address(RVA = "0x1F529D0", Offset = "0x1F51DD0", Length = "0x196")]
		[Token(Token = "0x600264D")]
		 get { } //Length: 406
	}

	[Address(RVA = "0x1F52680", Offset = "0x1F51A80", Length = "0x3C")]
	[Token(Token = "0x6002645")]
	public CultureNotFoundException() { }

	[Address(RVA = "0x1F52660", Offset = "0x1F51A60", Length = "0x11")]
	[Token(Token = "0x6002646")]
	public CultureNotFoundException(string paramName, string message) { }

	[Address(RVA = "0x1F526C0", Offset = "0x1F51AC0", Length = "0x1B0")]
	[Token(Token = "0x6002647")]
	protected CultureNotFoundException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F52880", Offset = "0x1F51C80", Length = "0x2C")]
	[Token(Token = "0x600264B")]
	private static string get_DefaultMessage() { }

	[Address(RVA = "0x1F528B0", Offset = "0x1F51CB0", Length = "0x117")]
	[Token(Token = "0x600264C")]
	private string get_FormatedInvalidCultureId() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[Token(Token = "0x6002649")]
	public override Nullable<Int32> get_InvalidCultureId() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x600264A")]
	public override string get_InvalidCultureName() { }

	[Address(RVA = "0x1F529D0", Offset = "0x1F51DD0", Length = "0x196")]
	[Token(Token = "0x600264D")]
	public virtual string get_Message() { }

	[Address(RVA = "0x1F52520", Offset = "0x1F51920", Length = "0x132")]
	[Token(Token = "0x6002648")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

