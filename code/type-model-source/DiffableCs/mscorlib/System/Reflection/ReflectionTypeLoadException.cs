namespace System.Reflection;

[Token(Token = "0x20004F9")]
public sealed class ReflectionTypeLoadException : SystemException, ISerializable
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40013A6")]
	private readonly Type[] <Types>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40013A7")]
	private readonly Exception[] <LoaderExceptions>k__BackingField; //Field offset: 0x98

	[Token(Token = "0x17000455")]
	public Exception[] LoaderExceptions
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60022D4")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000456")]
	public virtual string Message
	{
		[Address(RVA = "0x1F63370", Offset = "0x1F62770", Length = "0xA")]
		[Token(Token = "0x60022D5")]
		 get { } //Length: 10
	}

	[Address(RVA = "0x1F63300", Offset = "0x1F62700", Length = "0x65")]
	[Token(Token = "0x60022D1")]
	public ReflectionTypeLoadException(Type[] classes, Exception[] exceptions) { }

	[Address(RVA = "0x1F631D0", Offset = "0x1F625D0", Length = "0x125")]
	[Token(Token = "0x60022D2")]
	private ReflectionTypeLoadException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F62F50", Offset = "0x1F62350", Length = "0x154")]
	[Token(Token = "0x60022D7")]
	private string CreateString(bool isMessage) { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60022D4")]
	public Exception[] get_LoaderExceptions() { }

	[Address(RVA = "0x1F63370", Offset = "0x1F62770", Length = "0xA")]
	[Token(Token = "0x60022D5")]
	public virtual string get_Message() { }

	[Address(RVA = "0x1F630B0", Offset = "0x1F624B0", Length = "0x104")]
	[Token(Token = "0x60022D3")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F631C0", Offset = "0x1F625C0", Length = "0xA")]
	[Token(Token = "0x60022D6")]
	public virtual string ToString() { }

}

