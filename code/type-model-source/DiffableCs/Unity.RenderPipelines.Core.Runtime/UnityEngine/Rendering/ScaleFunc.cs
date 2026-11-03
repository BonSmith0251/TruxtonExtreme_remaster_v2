namespace UnityEngine.Rendering;

[Token(Token = "0x200019D")]
public sealed class ScaleFunc : MulticastDelegate
{

	[Address(RVA = "0x17C8B10", Offset = "0x17C7F10", Length = "0xA6")]
	[Token(Token = "0x6000C18")]
	public ScaleFunc(object object, IntPtr method) { }

	[Address(RVA = "0x2C4F670", Offset = "0x2C4EA70", Length = "0x7A")]
	[Token(Token = "0x6000C1A")]
	public override IAsyncResult BeginInvoke(Vector2Int size, AsyncCallback callback, object object) { }

	[Address(RVA = "0x17C9A80", Offset = "0x17C8E80", Length = "0x28")]
	[Token(Token = "0x6000C1B")]
	public override Vector2Int EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x6000C19")]
	public override Vector2Int Invoke(Vector2Int size) { }

}

