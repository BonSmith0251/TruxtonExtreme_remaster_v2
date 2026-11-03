namespace KANAI.Kernel;

[Token(Token = "0x200001F")]
public class MeshCreater
{

	[Address(RVA = "0x1DEC070", Offset = "0x1DEB470", Length = "0x246")]
	[Token(Token = "0x6000112")]
	private static Vector3 _calcNormal(Nullable<Vector3> prev, Vector3 current, Nullable<Vector3> next, bool isXY) { }

	[Address(RVA = "0x1DEC2C0", Offset = "0x1DEB6C0", Length = "0x3BD")]
	[Token(Token = "0x6000118")]
	private static List<Vector3> _createList(Collider2D collider) { }

	[Address(RVA = "0x1DEC8E0", Offset = "0x1DEBCE0", Length = "0x3CE")]
	[Token(Token = "0x6000113")]
	private static List<Vector3> _createVectorTable(BoxCollider2D boxCollider2D) { }

	[Address(RVA = "0x1DED3F0", Offset = "0x1DEC7F0", Length = "0x1A7")]
	[Token(Token = "0x6000114")]
	private static List<Vector3> _createVectorTable(EdgeCollider2D edgeCollider2D) { }

	[Address(RVA = "0x1DEC680", Offset = "0x1DEBA80", Length = "0x25F")]
	[Token(Token = "0x6000115")]
	private static List<Vector3> _createVectorTable(PolygonCollider2D polygonCollider2D) { }

	[Address(RVA = "0x1DED170", Offset = "0x1DEC570", Length = "0x27D")]
	[Token(Token = "0x6000116")]
	private static List<Vector3> _createVectorTable(CircleCollider2D circleCollider2D) { }

	[Address(RVA = "0x1DECCB0", Offset = "0x1DEC0B0", Length = "0x4B5")]
	[Token(Token = "0x6000117")]
	private static List<Vector3> _createVectorTable(CapsuleCollider2D capCollider2D) { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000119")]
	public MeshCreater() { }

	[Address(RVA = "0x1DEB790", Offset = "0x1DEAB90", Length = "0x39")]
	[Token(Token = "0x6000110")]
	public static Mesh CreateMesh(Collider2D collider, float width = 0.2) { }

	[Address(RVA = "0x1DEB7D0", Offset = "0x1DEABD0", Length = "0x899")]
	[Token(Token = "0x6000111")]
	public static Mesh CreateMesh(List<Vector3> points, float width) { }

}

