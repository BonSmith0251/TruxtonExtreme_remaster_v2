namespace System.Data;

[Token(Token = "0x20000A0")]
internal enum SchemaFormat : int
{
	Public = 1,
	Remoting = 2,
	WebService = 3,
	RemotingSkipSchema = 4,
	WebServiceSkipSchema = 5,
}

