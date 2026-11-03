namespace UnityEngine;

[Token(Token = "0x2000003")]
public class WWWForm
{
	[Token(Token = "0x4000002")]
	private static Byte[] dDash; //Field offset: 0x0
	[Token(Token = "0x4000003")]
	private static Byte[] crlf; //Field offset: 0x8
	[Token(Token = "0x4000004")]
	private static Byte[] contentTypeHeader; //Field offset: 0x10
	[Token(Token = "0x4000005")]
	private static Byte[] dispositionHeader; //Field offset: 0x18
	[Token(Token = "0x4000006")]
	private static Byte[] endQuote; //Field offset: 0x20
	[Token(Token = "0x4000007")]
	private static Byte[] fileNameField; //Field offset: 0x28
	[Token(Token = "0x4000008")]
	private static Byte[] ampersand; //Field offset: 0x30
	[Token(Token = "0x4000009")]
	private static Byte[] equal; //Field offset: 0x38

	[Token(Token = "0x17000001")]
	internal static Encoding DefaultEncoding
	{
		[Address(RVA = "0x347ECA0", Offset = "0x347E0A0", Length = "0x9")]
		[Token(Token = "0x6000006")]
		internal get { } //Length: 9
	}

	[Address(RVA = "0x347E940", Offset = "0x347DD40", Length = "0x350")]
	[Token(Token = "0x6000007")]
	private static WWWForm() { }

	[Address(RVA = "0x347ECA0", Offset = "0x347E0A0", Length = "0x9")]
	[Token(Token = "0x6000006")]
	internal static Encoding get_DefaultEncoding() { }

}

