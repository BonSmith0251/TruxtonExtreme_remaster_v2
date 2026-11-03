namespace System;

[Token(Token = "0x20001D1")]
internal interface TypeIdentifier : TypeName, IEquatable<TypeName>
{

	[Token(Token = "0x17000170")]
	public string InternalName
	{
		[Token(Token = "0x6001087")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001087")]
	public string get_InternalName() { }

}

