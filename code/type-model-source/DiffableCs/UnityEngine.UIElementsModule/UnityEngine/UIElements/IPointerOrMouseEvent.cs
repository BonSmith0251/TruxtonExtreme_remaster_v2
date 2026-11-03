namespace UnityEngine.UIElements;

[Token(Token = "0x2000225")]
internal interface IPointerOrMouseEvent
{

	[Token(Token = "0x170002B6")]
	public Vector3 deltaPosition
	{
		[Token(Token = "0x6000EEA")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170002B5")]
	public Vector3 position
	{
		[Token(Token = "0x6000EE9")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000EE9")]
	public Vector3 get_position() { }

	[Token(Token = "0x6000EEA")]
	public void set_deltaPosition(Vector3 value) { }

}

