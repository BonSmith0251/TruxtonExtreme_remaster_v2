namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000038")]
internal static class LightUtility
{
	[Token(Token = "0x200003A")]
	public struct LightMeshVertex
	{
		[Token(Token = "0x4000122")]
		public static readonly VertexAttributeDescriptor[] VertexLayout; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400011F")]
		public Vector3 position; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000120")]
		public Color color; //Field offset: 0xC
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000121")]
		public Vector2 uv; //Field offset: 0x1C

		[Address(RVA = "0x2D27BE0", Offset = "0x2D26FE0", Length = "0x136")]
		[Token(Token = "0x6000173")]
		private static LightMeshVertex() { }

	}

	[Token(Token = "0x2000039")]
	private enum PivotType : int
	{
		PivotBase = 0,
		PivotCurve = 1,
		PivotIntersect = 2,
		PivotSkip = 3,
		PivotClip = 4,
	}


	[Address(RVA = "0x2D27DF0", Offset = "0x2D271F0", Length = "0xA")]
	[Token(Token = "0x6000164")]
	public static bool CheckForChange(LightType a, ref LightType b) { }

	[Address(RVA = "0x2D27D50", Offset = "0x2D27150", Length = "0x7B")]
	[Token(Token = "0x6000165")]
	public static bool CheckForChange(Component a, ref Component b) { }

	[Address(RVA = "0x2D27DF0", Offset = "0x2D271F0", Length = "0xA")]
	[Token(Token = "0x6000166")]
	public static bool CheckForChange(int a, ref int b) { }

	[Address(RVA = "0x2D27DD0", Offset = "0x2D271D0", Length = "0x15")]
	[Token(Token = "0x6000167")]
	public static bool CheckForChange(float a, ref float b) { }

	[Address(RVA = "0x2D27E00", Offset = "0x2D27200", Length = "0xB")]
	[Token(Token = "0x6000168")]
	public static bool CheckForChange(bool a, ref bool b) { }

	[Address(RVA = "0x2D27E10", Offset = "0x2D27210", Length = "0x39E")]
	[Token(Token = "0x600016A")]
	private static List<IntPoint> DegeneratePivots(List<IntPoint> path, List<IntPoint> inPath, ref int interiorStart) { }

	[Address(RVA = "0x2D281B0", Offset = "0x2D275B0", Length = "0x30E")]
	[Token(Token = "0x600016C")]
	private static List<IntPoint> FixPivots(List<IntPoint> outPath, List<IntPoint> inPath, ref int interiorStart) { }

	[Address(RVA = "0x2D284C0", Offset = "0x2D278C0", Length = "0x982")]
	[Token(Token = "0x6000170")]
	public static Bounds GenerateParametricMesh(Light2D light, float radius, float falloffDistance, float angle, int sides, float batchColor) { }

	[Address(RVA = "0x2D28E50", Offset = "0x2D28250", Length = "0x10A3")]
	[Token(Token = "0x600016F")]
	public static Bounds GenerateShapeMesh(Light2D light, Vector3[] shapePath, float falloffDistance, float batchColor) { }

	[Address(RVA = "0x2D29F00", Offset = "0x2D29300", Length = "0x5B7")]
	[Token(Token = "0x6000171")]
	public static Bounds GenerateSpriteMesh(Light2D light, Sprite sprite, float batchColor) { }

	[Address(RVA = "0x2D2A4C0", Offset = "0x2D298C0", Length = "0x43B")]
	[Token(Token = "0x600016D")]
	internal static List<Vector2> GetOutlinePath(Vector3[] shapePath, float offsetDistance) { }

	[Address(RVA = "0x2D2A900", Offset = "0x2D29D00", Length = "0xC8")]
	[Token(Token = "0x6000172")]
	public static int GetShapePathHash(Vector3[] path) { }

	[Address(RVA = "0x2D2A9D0", Offset = "0x2D29DD0", Length = "0x214")]
	[Token(Token = "0x600016B")]
	private static List<IntPoint> SortPivots(List<IntPoint> outPath, List<IntPoint> inPath) { }

	[Address(RVA = "0x2D2ABF0", Offset = "0x2D29FF0", Length = "0xA8")]
	[Token(Token = "0x6000169")]
	private static bool TestPivot(List<IntPoint> path, int activePoint, long lastPoint) { }

	[Address(RVA = "0x2D2ACA0", Offset = "0x2D2A0A0", Length = "0x220")]
	[Token(Token = "0x600016E")]
	private static void TransferToMesh(NativeArray<LightMeshVertex> vertices, int vertexCount, NativeArray<UInt16> indices, int indexCount, Light2D light) { }

}

