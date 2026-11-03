namespace UnityEngine.Timeline;

[Token(Token = "0x2000058")]
public interface ITimeControl
{

	[Token(Token = "0x60002EF")]
	public void OnControlTimeStart() { }

	[Token(Token = "0x60002F0")]
	public void OnControlTimeStop() { }

	[Token(Token = "0x60002EE")]
	public void SetTime(double time) { }

}

