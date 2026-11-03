namespace System;

[Token(Token = "0x20001D0")]
internal interface TypeName : IEquatable<TypeName>
{

	[Token(Token = "0x1700016F")]
	public string DisplayName
	{
		[Token(Token = "0x6001086")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001086")]
	public string get_DisplayName() { }

}

