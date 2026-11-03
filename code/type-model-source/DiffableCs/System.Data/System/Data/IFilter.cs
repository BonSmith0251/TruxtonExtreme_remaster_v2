namespace System.Data;

[Token(Token = "0x200006B")]
internal interface IFilter
{

	[Token(Token = "0x60005FF")]
	public bool Invoke(DataRow row, DataRowVersion version) { }

}

