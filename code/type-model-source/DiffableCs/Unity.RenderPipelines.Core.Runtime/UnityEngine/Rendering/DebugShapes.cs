namespace UnityEngine.Rendering;

[Token(Token = "0x2000097")]
public class DebugShapes
{
	[Token(Token = "0x400020D")]
	private static DebugShapes s_Instance; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400020E")]
	private Mesh m_sphereMesh; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400020F")]
	private Mesh m_boxMesh; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000210")]
	private Mesh m_coneMesh; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000211")]
	private Mesh m_pyramidMesh; //Field offset: 0x28

	[Token(Token = "0x1700006C")]
	public static DebugShapes instance
	{
		[Address(RVA = "0x2BE1840", Offset = "0x2BE0C40", Length = "0x8D")]
		[Token(Token = "0x6000686")]
		 get { } //Length: 141
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000692")]
	public DebugShapes() { }

	[Address(RVA = "0x2BDEE20", Offset = "0x2BDE220", Length = "0xCB8")]
	[Token(Token = "0x6000688")]
	private void BuildBox(ref Mesh outputMesh, float length, float width, float height) { }

	[Address(RVA = "0x2BDFAE0", Offset = "0x2BDEEE0", Length = "0xA8A")]
	[Token(Token = "0x6000689")]
	private void BuildCone(ref Mesh outputMesh, float height, float topRadius, float bottomRadius, int nbSides) { }

	[Address(RVA = "0x2BE0570", Offset = "0x2BDF970", Length = "0x9E")]
	[Token(Token = "0x600068E")]
	public Mesh BuildCustomSphereMesh(float radius, uint longSubdiv, uint latSubdiv) { }

	[Address(RVA = "0x2BE0610", Offset = "0x2BDFA10", Length = "0x475")]
	[Token(Token = "0x600068A")]
	private void BuildPyramid(ref Mesh outputMesh, float width, float height, float depth) { }

	[Address(RVA = "0x2BE0A90", Offset = "0x2BDFE90", Length = "0x17A")]
	[Token(Token = "0x600068B")]
	private void BuildShapes() { }

	[Address(RVA = "0x2BE0C10", Offset = "0x2BE0010", Length = "0x951")]
	[Token(Token = "0x6000687")]
	private void BuildSphere(ref Mesh outputMesh, float radius, uint longSubdiv, uint latSubdiv) { }

	[Address(RVA = "0x2BE1840", Offset = "0x2BE0C40", Length = "0x8D")]
	[Token(Token = "0x6000686")]
	public static DebugShapes get_instance() { }

	[Address(RVA = "0x2BE1570", Offset = "0x2BE0970", Length = "0x246")]
	[Token(Token = "0x600068C")]
	private void RebuildResources() { }

	[Address(RVA = "0x2BE17C0", Offset = "0x2BE0BC0", Length = "0x1A")]
	[Token(Token = "0x600068F")]
	public Mesh RequestBoxMesh() { }

	[Address(RVA = "0x2BE17E0", Offset = "0x2BE0BE0", Length = "0x1A")]
	[Token(Token = "0x6000690")]
	public Mesh RequestConeMesh() { }

	[Address(RVA = "0x2BE1800", Offset = "0x2BE0C00", Length = "0x1A")]
	[Token(Token = "0x6000691")]
	public Mesh RequestPyramidMesh() { }

	[Address(RVA = "0x2BE1820", Offset = "0x2BE0C20", Length = "0x1A")]
	[Token(Token = "0x600068D")]
	public Mesh RequestSphereMesh() { }

}

