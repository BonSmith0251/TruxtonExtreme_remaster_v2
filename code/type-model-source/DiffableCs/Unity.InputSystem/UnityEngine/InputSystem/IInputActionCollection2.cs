namespace UnityEngine.InputSystem;

[Token(Token = "0x2000018")]
public interface IInputActionCollection2 : IInputActionCollection, IEnumerable<InputAction>, IEnumerable
{

	[Token(Token = "0x17000082")]
	public IEnumerable<InputBinding> bindings
	{
		[Token(Token = "0x600012A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600012B")]
	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false) { }

	[Token(Token = "0x600012C")]
	public int FindBinding(InputBinding mask, out InputAction action) { }

	[Token(Token = "0x600012A")]
	public IEnumerable<InputBinding> get_bindings() { }

}

