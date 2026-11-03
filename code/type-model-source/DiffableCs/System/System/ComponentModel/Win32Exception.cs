namespace System.ComponentModel;

[Token(Token = "0x20001C1")]
public class Win32Exception : ExternalException, ISerializable
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40006DA")]
	private readonly int nativeErrorCode; //Field offset: 0x90

	[Token(Token = "0x1700021A")]
	public int NativeErrorCode
	{
		[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
		[Token(Token = "0x6000B61")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x26974F0", Offset = "0x26968F0", Length = "0x6F")]
	[Token(Token = "0x6000B5D")]
	public Win32Exception() { }

	[Address(RVA = "0x2697620", Offset = "0x2696A20", Length = "0x37")]
	[Token(Token = "0x6000B5E")]
	public Win32Exception(int error) { }

	[Address(RVA = "0x26975F0", Offset = "0x26969F0", Length = "0x2E")]
	[Token(Token = "0x6000B5F")]
	public Win32Exception(int error, string message) { }

	[Address(RVA = "0x2697560", Offset = "0x2696960", Length = "0x81")]
	[Token(Token = "0x6000B60")]
	protected Win32Exception(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
	[Token(Token = "0x6000B61")]
	public int get_NativeErrorCode() { }

	[Address(RVA = "0x2696950", Offset = "0x2695D50", Length = "0x434")]
	[Token(Token = "0x6000B63")]
	internal static string GetErrorMessage(int error) { }

	[Address(RVA = "0x2697420", Offset = "0x2696820", Length = "0xC5")]
	[Token(Token = "0x6000B62")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

