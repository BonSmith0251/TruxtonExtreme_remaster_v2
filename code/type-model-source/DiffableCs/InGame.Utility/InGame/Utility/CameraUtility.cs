namespace InGame.Utility;

[Token(Token = "0x2000004")]
public class CameraUtility
{
	[Token(Token = "0x2000005")]
	internal class Param
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000006")]
		public Vector3 rot; //Field offset: 0x10
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000007")]
		public float fov; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000008")]
		public float clipNear; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000009")]
		public float clipFar; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400000A")]
		public Vector2 lensShift; //Field offset: 0x28

		[Address(RVA = "0x1DD8AF0", Offset = "0x1DD7EF0", Length = "0x66")]
		[Token(Token = "0x6000005")]
		public Param() { }

	}


	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000004")]
	public CameraUtility() { }

	[Address(RVA = "0x1DD6A10", Offset = "0x1DD5E10", Length = "0xFE")]
	[Token(Token = "0x6000003")]
	public static void SetParameter(Camera tcam, Param p) { }

}

