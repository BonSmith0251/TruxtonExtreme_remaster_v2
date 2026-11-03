namespace System.Collections;

[Token(Token = "0x20005AB")]
public interface IStructuralEquatable
{

	[Token(Token = "0x6002964")]
	public bool Equals(object other, IEqualityComparer comparer) { }

	[Token(Token = "0x6002965")]
	public int GetHashCode(IEqualityComparer comparer) { }

}

