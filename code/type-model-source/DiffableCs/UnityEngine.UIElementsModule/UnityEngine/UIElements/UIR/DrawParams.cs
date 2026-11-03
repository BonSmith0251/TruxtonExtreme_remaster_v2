namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000593")]
internal class DrawParams
{
	[Token(Token = "0x4001304")]
	internal static readonly Rect k_UnlimitedRect; //Field offset: 0x0
	[Token(Token = "0x4001305")]
	internal static readonly Rect k_FullNormalizedRect; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001306")]
	internal readonly Stack<Matrix4x4> view; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001307")]
	internal readonly Stack<Rect> scissor; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001308")]
	internal readonly List<Material> defaultMaterial; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001309")]
	internal readonly List<MaterialPropertyBlock> props; //Field offset: 0x28

	[Address(RVA = "0x32F1C20", Offset = "0x32F1020", Length = "0x58")]
	[Token(Token = "0x600285B")]
	private static DrawParams() { }

	[Address(RVA = "0x32F1C80", Offset = "0x32F1080", Length = "0x15D")]
	[Token(Token = "0x600285A")]
	public DrawParams() { }

	[Address(RVA = "0x32F1A80", Offset = "0x32F0E80", Length = "0x192")]
	[Token(Token = "0x6002859")]
	public void Reset() { }

}

