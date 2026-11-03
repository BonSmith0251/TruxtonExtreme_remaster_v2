namespace UnityEngine.InputSystem;

[Token(Token = "0x2000017")]
public interface IInputActionCollection : IEnumerable<InputAction>, IEnumerable
{

	[Token(Token = "0x1700007F")]
	public Nullable<InputBinding> bindingMask
	{
		[Token(Token = "0x6000122")]
		 get { } //Length: 0
		[Token(Token = "0x6000123")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000081")]
	public ReadOnlyArray<InputControlScheme> controlSchemes
	{
		[Token(Token = "0x6000126")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000080")]
	public Nullable<ReadOnlyArray`1<InputDevice>> devices
	{
		[Token(Token = "0x6000124")]
		 get { } //Length: 0
		[Token(Token = "0x6000125")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6000127")]
	public bool Contains(InputAction action) { }

	[Token(Token = "0x6000129")]
	public void Disable() { }

	[Token(Token = "0x6000128")]
	public void Enable() { }

	[Token(Token = "0x6000122")]
	public Nullable<InputBinding> get_bindingMask() { }

	[Token(Token = "0x6000126")]
	public ReadOnlyArray<InputControlScheme> get_controlSchemes() { }

	[Token(Token = "0x6000124")]
	public Nullable<ReadOnlyArray`1<InputDevice>> get_devices() { }

	[Token(Token = "0x6000123")]
	public void set_bindingMask(Nullable<InputBinding> value) { }

	[Token(Token = "0x6000125")]
	public void set_devices(Nullable<ReadOnlyArray`1<InputDevice>> value) { }

}

