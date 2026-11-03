namespace UnityEngine.ResourceManagement.Util;

[Token(Token = "0x2000037")]
public interface IAllocationStrategy
{

	[Token(Token = "0x6000147")]
	public object New(Type type, int typeHash) { }

	[Token(Token = "0x6000148")]
	public void Release(int typeHash, object obj) { }

}

