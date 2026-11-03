namespace UnityEngine.UIElements;

[Obsolete("IUxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x200050D")]
public interface IUxmlFactory : IBaseUxmlFactory
{

	[Token(Token = "0x600258F")]
	public VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

}

