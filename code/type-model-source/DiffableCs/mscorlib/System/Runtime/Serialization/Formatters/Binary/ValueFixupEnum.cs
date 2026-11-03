namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x200040B")]
internal enum ValueFixupEnum : int
{
	Empty = 0,
	Array = 1,
	Header = 2,
	Member = 3,
}

