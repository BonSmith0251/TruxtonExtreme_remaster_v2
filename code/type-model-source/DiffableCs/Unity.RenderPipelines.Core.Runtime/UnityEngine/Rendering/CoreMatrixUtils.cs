namespace UnityEngine.Rendering;

[Token(Token = "0x20001BE")]
public static class CoreMatrixUtils
{

	[Address(RVA = "0x2C45A20", Offset = "0x2C44E20", Length = "0x8D")]
	[Token(Token = "0x6000D99")]
	public static void MatrixTimesTranslation(ref Matrix4x4 inOutMatrix, Vector3 translation) { }

	[Address(RVA = "0x2C45AB0", Offset = "0x2C44EB0", Length = "0x1AB")]
	[Token(Token = "0x6000D9D")]
	private static Matrix4x4 MultiplyGenericOrthoMatrix(Matrix4x4 ortho, Matrix4x4 rhs) { }

	[Address(RVA = "0x2C45DA0", Offset = "0x2C451A0", Length = "0x2EF")]
	[Token(Token = "0x6000D9E")]
	public static Matrix4x4 MultiplyOrthoMatrix(Matrix4x4 ortho, Matrix4x4 rhs, bool centered) { }

	[Address(RVA = "0x2C45C60", Offset = "0x2C45060", Length = "0x133")]
	[Token(Token = "0x6000D9C")]
	private static Matrix4x4 MultiplyOrthoMatrixCentered(Matrix4x4 ortho, Matrix4x4 rhs) { }

	[Address(RVA = "0x2C46090", Offset = "0x2C45490", Length = "0x147")]
	[Token(Token = "0x6000D9B")]
	public static Matrix4x4 MultiplyPerspectiveMatrix(Matrix4x4 perspective, Matrix4x4 rhs) { }

	[Address(RVA = "0x2C461E0", Offset = "0x2C455E0", Length = "0x39B")]
	[Token(Token = "0x6000D9F")]
	public static Matrix4x4 MultiplyProjectionMatrix(Matrix4x4 projMatrix, Matrix4x4 rhs, bool orthoCentered) { }

	[Address(RVA = "0x2C46580", Offset = "0x2C45980", Length = "0xEB")]
	[Token(Token = "0x6000D9A")]
	public static void TranslationTimesMatrix(ref Matrix4x4 inOutMatrix, Vector3 translation) { }

}

