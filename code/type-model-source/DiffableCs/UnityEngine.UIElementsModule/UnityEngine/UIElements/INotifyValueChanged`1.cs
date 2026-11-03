namespace UnityEngine.UIElements;

[Token(Token = "0x20000E7")]
public interface INotifyValueChanged
{

	[Token(Token = "0x17000109")]
	public T value
	{
		[Token(Token = "0x6000700")]
		 get { } //Length: 0
		[Token(Token = "0x6000701")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6000700")]
	public T get_value() { }

	[Token(Token = "0x6000701")]
	public void set_value(T value) { }

	[Token(Token = "0x6000702")]
	public void SetValueWithoutNotify(T newValue) { }

}

