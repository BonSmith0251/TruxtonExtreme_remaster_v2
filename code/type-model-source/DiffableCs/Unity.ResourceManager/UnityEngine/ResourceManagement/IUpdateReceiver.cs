namespace UnityEngine.ResourceManagement;

[Token(Token = "0x2000011")]
public interface IUpdateReceiver
{

	[Token(Token = "0x600009A")]
	public void Update(float unscaledDeltaTime) { }

}

