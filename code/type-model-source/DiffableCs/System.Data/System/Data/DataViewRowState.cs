namespace System.Data;

[Flags]
[Token(Token = "0x2000055")]
public enum DataViewRowState : int
{
	None = 0,
	Unchanged = 2,
	Added = 4,
	Deleted = 8,
	ModifiedCurrent = 16,
	ModifiedOriginal = 32,
	OriginalRows = 42,
	CurrentRows = 22,
}

