namespace UnityEngine.UIElements;

[Obsolete("IUxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x200050C")]
public interface IBaseUxmlFactory
{

	[Token(Token = "0x170009CF")]
	public string uxmlQualifiedName
	{
		[Token(Token = "0x600258C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170009D0")]
	public Type uxmlType
	{
		[Token(Token = "0x600258D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600258E")]
	public bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc) { }

	[Token(Token = "0x600258C")]
	public string get_uxmlQualifiedName() { }

	[Token(Token = "0x600258D")]
	public Type get_uxmlType() { }

}

