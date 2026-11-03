namespace UnityEngine;

[Token(Token = "0x2000003")]
public sealed class AndroidJavaException : Exception
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000001")]
	private string mJavaStackTrace; //Field offset: 0x90

	[Token(Token = "0x17000001")]
	public virtual string StackTrace
	{
		[Address(RVA = "0x2FA37C0", Offset = "0x2FA2BC0", Length = "0x27")]
		[Token(Token = "0x6000004")]
		 get { } //Length: 39
	}

	[Address(RVA = "0x2FA3740", Offset = "0x2FA2B40", Length = "0x7C")]
	[Token(Token = "0x6000003")]
	internal AndroidJavaException(string message, string javaStackTrace) { }

	[Address(RVA = "0x2FA37C0", Offset = "0x2FA2BC0", Length = "0x27")]
	[Token(Token = "0x6000004")]
	public virtual string get_StackTrace() { }

}

