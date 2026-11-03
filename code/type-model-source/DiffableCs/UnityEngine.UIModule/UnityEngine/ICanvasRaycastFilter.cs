namespace UnityEngine;

[Token(Token = "0x2000002")]
public interface ICanvasRaycastFilter
{

	[Token(Token = "0x6000001")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

}

