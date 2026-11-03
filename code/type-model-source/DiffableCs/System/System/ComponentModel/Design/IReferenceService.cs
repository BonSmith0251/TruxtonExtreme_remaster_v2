namespace System.ComponentModel.Design;

[Token(Token = "0x20001CC")]
public interface IReferenceService
{

	[Token(Token = "0x6000B7D")]
	public string GetName(object reference) { }

	[Token(Token = "0x6000B7C")]
	public object GetReference(string name) { }

	[Token(Token = "0x6000B7E")]
	public Object[] GetReferences(Type baseType) { }

}

