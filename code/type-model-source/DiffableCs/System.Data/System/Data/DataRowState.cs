namespace System.Data;

[Flags]
[Token(Token = "0x2000044")]
public enum DataRowState : int
{
	Detached = 1,
	Unchanged = 2,
	Added = 4,
	Deleted = 8,
	Modified = 16,
}

