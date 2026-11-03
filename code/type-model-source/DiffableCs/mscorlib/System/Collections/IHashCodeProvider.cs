namespace System.Collections;

[Obsolete("Please use IEqualityComparer instead.")]
[Token(Token = "0x20005D0")]
public interface IHashCodeProvider
{

	[Token(Token = "0x6002B0D")]
	public int GetHashCode(object obj) { }

}

