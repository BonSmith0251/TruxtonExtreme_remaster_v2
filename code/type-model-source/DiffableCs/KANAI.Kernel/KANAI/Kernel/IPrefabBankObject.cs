namespace KANAI.Kernel;

[Token(Token = "0x2000028")]
public interface IPrefabBankObject
{

	[Token(Token = "0x6000159")]
	public GameObject GetObject() { }

	[Address(RVA = "0x1DEA5E0", Offset = "0x1DE99E0", Length = "0x106")]
	[Token(Token = "0x600015A")]
	public int InstanceID() { }

	[Token(Token = "0x6000158")]
	public void SetActiveBank(bool tactive) { }

	[Token(Token = "0x6000157")]
	public void SetupCache() { }

}

