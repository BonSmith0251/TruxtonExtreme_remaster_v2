namespace System;

[Token(Token = "0x20000BD")]
public class BadImageFormatException : SystemException
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400029E")]
	private string _fileName; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400029F")]
	private string _fusionLog; //Field offset: 0x98

	[Token(Token = "0x1700005C")]
	public virtual string Message
	{
		[Address(RVA = "0x1F8CF30", Offset = "0x1F8C330", Length = "0x90")]
		[Token(Token = "0x6000429")]
		 get { } //Length: 144
	}

	[Address(RVA = "0x1F8CEE0", Offset = "0x1F8C2E0", Length = "0x44")]
	[Token(Token = "0x6000423")]
	public BadImageFormatException() { }

	[Address(RVA = "0x1F8CE80", Offset = "0x1F8C280", Length = "0x1E")]
	[Token(Token = "0x6000424")]
	public BadImageFormatException(string message) { }

	[Address(RVA = "0x1F8CE60", Offset = "0x1F8C260", Length = "0x1E")]
	[Token(Token = "0x6000425")]
	public BadImageFormatException(string message, Exception inner) { }

	[Address(RVA = "0x1F8CEA0", Offset = "0x1F8C2A0", Length = "0x3F")]
	[Token(Token = "0x6000426")]
	public BadImageFormatException(string message, string fileName) { }

	[Address(RVA = "0x1F8CD90", Offset = "0x1F8C190", Length = "0xC4")]
	[Token(Token = "0x6000427")]
	protected BadImageFormatException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F8CF30", Offset = "0x1F8C330", Length = "0x90")]
	[Token(Token = "0x6000429")]
	public virtual string get_Message() { }

	[Address(RVA = "0x1F8CA00", Offset = "0x1F8BE00", Length = "0x102")]
	[Token(Token = "0x6000428")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F8CB10", Offset = "0x1F8BF10", Length = "0x8C")]
	[Token(Token = "0x600042A")]
	private void SetMessageField() { }

	[Address(RVA = "0x1F8CBA0", Offset = "0x1F8BFA0", Length = "0x1EF")]
	[Token(Token = "0x600042B")]
	public virtual string ToString() { }

}

