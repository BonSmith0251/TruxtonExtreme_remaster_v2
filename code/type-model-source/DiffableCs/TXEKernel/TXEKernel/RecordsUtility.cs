namespace TXEKernel;

[Token(Token = "0x2000096")]
public static class RecordsUtility
{

	[Address(RVA = "0x8E1270", Offset = "0x8E0670", Length = "0x9CE")]
	[Token(Token = "0x60004FD")]
	public static T DataLoad(string key) { }

	[Address(RVA = "0x8E2DE0", Offset = "0x8E21E0", Length = "0x72B")]
	[Token(Token = "0x60004FE")]
	public static void DataSave(string key, T value) { }

}

