namespace System.Data;

[Token(Token = "0x2000045")]
public enum DataRowVersion : int
{
	Original = 256,
	Current = 512,
	Proposed = 1024,
	Default = 1536,
}

