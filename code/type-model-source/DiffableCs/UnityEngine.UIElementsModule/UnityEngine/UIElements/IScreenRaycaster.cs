namespace UnityEngine.UIElements;

[Token(Token = "0x200027F")]
internal interface IScreenRaycaster
{

	[Token(Token = "0x6001186")]
	public IEnumerable<ValueTuple`3<Ray, Camera, Boolean>> MakeRay(Vector2 mousePosition, int pointerId, Nullable<Int32> targetDisplay) { }

	[Token(Token = "0x6001185")]
	public void Update() { }

}

