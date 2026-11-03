namespace UnityEngine.Rendering.Universal;

[BurstCompile]
[Token(Token = "0x200007B")]
internal class ShadowUtility
{
	[Token(Token = "0x200008A")]
	public static class CalculateEdgesFromLines_000002C9$BurstDirectCall
	{
		[Token(Token = "0x40002A8")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x2D48020", Offset = "0x2D47420", Length = "0x17A")]
		[Token(Token = "0x6000337")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x2D47E90", Offset = "0x2D47290", Length = "0x184")]
		[BurstDiscard]
		[Token(Token = "0x6000336")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x2D481A0", Offset = "0x2D475A0", Length = "0x231")]
		[Token(Token = "0x6000338")]
		public static void Invoke(ref NativeArray<Int32>& indices, out NativeArray<ShadowEdge>& outEdges, out NativeArray<Int32>& outShapeStartingEdge, out NativeArray<Boolean>& outShapeIsClosedArray) { }

	}

	[Token(Token = "0x2000089")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class CalculateEdgesFromLines_000002C9$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2CC72B0", Offset = "0x2CC66B0", Length = "0xB5")]
		[Token(Token = "0x6000332")]
		public CalculateEdgesFromLines_000002C9$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x2D483E0", Offset = "0x2D477E0", Length = "0xEF")]
		[Token(Token = "0x6000334")]
		public override IAsyncResult BeginInvoke(ref NativeArray<Int32>& indices, out NativeArray<ShadowEdge>& outEdges, out NativeArray<Int32>& outShapeStartingEdge, out NativeArray<Boolean>& outShapeIsClosedArray, AsyncCallback unnamed_param_4, object unnamed_param_5) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000335")]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x60D5C0", Offset = "0x60C9C0", Length = "0x14")]
		[Token(Token = "0x6000333")]
		public override void Invoke(ref NativeArray<Int32>& indices, out NativeArray<ShadowEdge>& outEdges, out NativeArray<Int32>& outShapeStartingEdge, out NativeArray<Boolean>& outShapeIsClosedArray) { }

	}

	[Token(Token = "0x200008E")]
	public static class CalculateEdgesFromTriangles_000002CC$BurstDirectCall
	{
		[Token(Token = "0x40002AA")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x2D48660", Offset = "0x2D47A60", Length = "0x17A")]
		[Token(Token = "0x6000345")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x2D484D0", Offset = "0x2D478D0", Length = "0x184")]
		[BurstDiscard]
		[Token(Token = "0x6000344")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x2D487E0", Offset = "0x2D47BE0", Length = "0x282")]
		[Token(Token = "0x6000346")]
		public static void Invoke(ref NativeArray<Vector3>& vertices, ref NativeArray<Int32>& indices, bool duplicatesVertices, out NativeArray<Vector3>& newVertices, out NativeArray<ShadowEdge>& outEdges, out NativeArray<Int32>& outShapeStartingEdge, out NativeArray<Boolean>& outShapeIsClosedArray) { }

	}

	[Token(Token = "0x200008D")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class CalculateEdgesFromTriangles_000002CC$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2D48BC0", Offset = "0x2D47FC0", Length = "0xB5")]
		[Token(Token = "0x6000340")]
		public CalculateEdgesFromTriangles_000002CC$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x2D48A70", Offset = "0x2D47E70", Length = "0x146")]
		[Token(Token = "0x6000342")]
		public override IAsyncResult BeginInvoke(ref NativeArray<Vector3>& vertices, ref NativeArray<Int32>& indices, bool duplicatesVertices, out NativeArray<Vector3>& newVertices, out NativeArray<ShadowEdge>& outEdges, out NativeArray<Int32>& outShapeStartingEdge, out NativeArray<Boolean>& outShapeIsClosedArray, AsyncCallback unnamed_param_7, object unnamed_param_8) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000343")]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x1C18110", Offset = "0x1C17510", Length = "0x14")]
		[Token(Token = "0x6000341")]
		public override void Invoke(ref NativeArray<Vector3>& vertices, ref NativeArray<Int32>& indices, bool duplicatesVertices, out NativeArray<Vector3>& newVertices, out NativeArray<ShadowEdge>& outEdges, out NativeArray<Int32>& outShapeStartingEdge, out NativeArray<Boolean>& outShapeIsClosedArray) { }

	}

	[Token(Token = "0x2000086")]
	public static class CalculateLocalBounds_000002C6$BurstDirectCall
	{
		[Token(Token = "0x40002A6")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x2D48D80", Offset = "0x2D48180", Length = "0xE8")]
		[Token(Token = "0x6000329")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x2D48C80", Offset = "0x2D48080", Length = "0xF1")]
		[BurstDiscard]
		[Token(Token = "0x6000328")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x2D48E70", Offset = "0x2D48270", Length = "0x180")]
		[Token(Token = "0x600032A")]
		public static void Invoke(ref NativeArray<Vector3>& inVertices, out Bounds retBounds) { }

	}

	[Token(Token = "0x2000085")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class CalculateLocalBounds_000002C6$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2D30B00", Offset = "0x2D2FF00", Length = "0xB5")]
		[Token(Token = "0x6000324")]
		public CalculateLocalBounds_000002C6$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x2D30A50", Offset = "0x2D2FE50", Length = "0xA9")]
		[Token(Token = "0x6000326")]
		public override IAsyncResult BeginInvoke(ref NativeArray<Vector3>& inVertices, out Bounds retBounds, AsyncCallback unnamed_param_2, object unnamed_param_3) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000327")]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x6000325")]
		public override void Invoke(ref NativeArray<Vector3>& inVertices, out Bounds retBounds) { }

	}

	[Token(Token = "0x2000080")]
	public static class CalculateProjectionInfo_000002C3$BurstDirectCall
	{
		[Token(Token = "0x40002A3")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x2D30D50", Offset = "0x2D30150", Length = "0x17A")]
		[Token(Token = "0x6000314")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x2D30BC0", Offset = "0x2D2FFC0", Length = "0x184")]
		[BurstDiscard]
		[Token(Token = "0x6000313")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x2D30ED0", Offset = "0x2D302D0", Length = "0x245")]
		[Token(Token = "0x6000315")]
		public static void Invoke(ref NativeArray<Vector3>& inVertices, ref NativeArray<ShadowEdge>& inEdges, ref NativeArray<Int32>& inShapeStartingEdge, ref NativeArray<Boolean>& inShapeIsClosedArray, ref NativeArray<Vector2>& outProjectionInfo) { }

	}

	[Token(Token = "0x200007F")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class CalculateProjectionInfo_000002C3$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2CC18C0", Offset = "0x2CC0CC0", Length = "0xB5")]
		[Token(Token = "0x600030F")]
		public CalculateProjectionInfo_000002C3$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x2D31120", Offset = "0x2D30520", Length = "0x11E")]
		[Token(Token = "0x6000311")]
		public override IAsyncResult BeginInvoke(ref NativeArray<Vector3>& inVertices, ref NativeArray<ShadowEdge>& inEdges, ref NativeArray<Int32>& inShapeStartingEdge, ref NativeArray<Boolean>& inShapeIsClosedArray, ref NativeArray<Vector2>& outProjectionInfo, AsyncCallback unnamed_param_5, object unnamed_param_6) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000312")]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x1BB00C0", Offset = "0x1BAF4C0", Length = "0x14")]
		[Token(Token = "0x6000310")]
		public override void Invoke(ref NativeArray<Vector3>& inVertices, ref NativeArray<ShadowEdge>& inEdges, ref NativeArray<Int32>& inShapeStartingEdge, ref NativeArray<Boolean>& inShapeIsClosedArray, ref NativeArray<Vector2>& outProjectionInfo) { }

	}

	[Token(Token = "0x2000084")]
	public static class CalculateTriangles_000002C5$BurstDirectCall
	{
		[Token(Token = "0x40002A5")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x2D313D0", Offset = "0x2D307D0", Length = "0x17A")]
		[Token(Token = "0x6000322")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x2D31240", Offset = "0x2D30640", Length = "0x184")]
		[BurstDiscard]
		[Token(Token = "0x6000321")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x2D31550", Offset = "0x2D30950", Length = "0x245")]
		[Token(Token = "0x6000323")]
		public static void Invoke(ref NativeArray<Vector3>& inVertices, ref NativeArray<ShadowEdge>& inEdges, ref NativeArray<Int32>& inShapeStartingEdge, ref NativeArray<Boolean>& inShapeIsClosedArray, ref NativeArray<Int32>& outMeshIndices) { }

	}

	[Token(Token = "0x2000083")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class CalculateTriangles_000002C5$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2CC18C0", Offset = "0x2CC0CC0", Length = "0xB5")]
		[Token(Token = "0x600031D")]
		public CalculateTriangles_000002C5$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x2D317A0", Offset = "0x2D30BA0", Length = "0x112")]
		[Token(Token = "0x600031F")]
		public override IAsyncResult BeginInvoke(ref NativeArray<Vector3>& inVertices, ref NativeArray<ShadowEdge>& inEdges, ref NativeArray<Int32>& inShapeStartingEdge, ref NativeArray<Boolean>& inShapeIsClosedArray, ref NativeArray<Int32>& outMeshIndices, AsyncCallback unnamed_param_5, object unnamed_param_6) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000320")]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x1BB00C0", Offset = "0x1BAF4C0", Length = "0x14")]
		[Token(Token = "0x600031E")]
		public override void Invoke(ref NativeArray<Vector3>& inVertices, ref NativeArray<ShadowEdge>& inEdges, ref NativeArray<Int32>& inShapeStartingEdge, ref NativeArray<Boolean>& inShapeIsClosedArray, ref NativeArray<Int32>& outMeshIndices) { }

	}

	[Token(Token = "0x2000082")]
	public static class CalculateVertices_000002C4$BurstDirectCall
	{
		[Token(Token = "0x40002A4")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x2D31A50", Offset = "0x2D30E50", Length = "0x17A")]
		[Token(Token = "0x600031B")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x2D318C0", Offset = "0x2D30CC0", Length = "0x184")]
		[BurstDiscard]
		[Token(Token = "0x600031A")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x2D31BD0", Offset = "0x2D30FD0", Length = "0x231")]
		[Token(Token = "0x600031C")]
		public static void Invoke(ref NativeArray<Vector3>& inVertices, ref NativeArray<ShadowEdge>& inEdges, ref NativeArray<Vector2>& inEdgeOtherPoints, ref NativeArray<ShadowMeshVertex>& outMeshVertices) { }

	}

	[Token(Token = "0x2000081")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class CalculateVertices_000002C4$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2CC72B0", Offset = "0x2CC66B0", Length = "0xB5")]
		[Token(Token = "0x6000316")]
		public CalculateVertices_000002C4$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x2D31E10", Offset = "0x2D31210", Length = "0xFB")]
		[Token(Token = "0x6000318")]
		public override IAsyncResult BeginInvoke(ref NativeArray<Vector3>& inVertices, ref NativeArray<ShadowEdge>& inEdges, ref NativeArray<Vector2>& inEdgeOtherPoints, ref NativeArray<ShadowMeshVertex>& outMeshVertices, AsyncCallback unnamed_param_4, object unnamed_param_5) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000319")]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x60D5C0", Offset = "0x60C9C0", Length = "0x14")]
		[Token(Token = "0x6000317")]
		public override void Invoke(ref NativeArray<Vector3>& inVertices, ref NativeArray<ShadowEdge>& inEdges, ref NativeArray<Vector2>& inEdgeOtherPoints, ref NativeArray<ShadowMeshVertex>& outMeshVertices) { }

	}

	[Token(Token = "0x2000092")]
	public static class ClipEdges_000002D0$BurstDirectCall
	{
		[Token(Token = "0x40002AC")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x2D49180", Offset = "0x2D48580", Length = "0x17A")]
		[Token(Token = "0x6000353")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x2D48FF0", Offset = "0x2D483F0", Length = "0x184")]
		[BurstDiscard]
		[Token(Token = "0x6000352")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x2D49300", Offset = "0x2D48700", Length = "0x2A6")]
		[Token(Token = "0x6000354")]
		public static void Invoke(ref NativeArray<Vector3>& inVertices, ref NativeArray<ShadowEdge>& inEdges, ref NativeArray<Int32>& inShapeStartingEdge, ref NativeArray<Boolean>& inShapeIsClosedArray, float contractEdge, out NativeArray<Vector3>& outVertices, out NativeArray<ShadowEdge>& outEdges, out NativeArray<Int32>& outShapeStartingEdge) { }

	}

	[Token(Token = "0x2000091")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class ClipEdges_000002D0$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2D49720", Offset = "0x2D48B20", Length = "0xB5")]
		[Token(Token = "0x600034E")]
		public ClipEdges_000002D0$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x2D495B0", Offset = "0x2D489B0", Length = "0x16A")]
		[Token(Token = "0x6000350")]
		public override IAsyncResult BeginInvoke(ref NativeArray<Vector3>& inVertices, ref NativeArray<ShadowEdge>& inEdges, ref NativeArray<Int32>& inShapeStartingEdge, ref NativeArray<Boolean>& inShapeIsClosedArray, float contractEdge, out NativeArray<Vector3>& outVertices, out NativeArray<ShadowEdge>& outEdges, out NativeArray<Int32>& outShapeStartingEdge, AsyncCallback unnamed_param_8, object unnamed_param_9) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000351")]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x1C18250", Offset = "0x1C17650", Length = "0x14")]
		[Token(Token = "0x600034F")]
		public override void Invoke(ref NativeArray<Vector3>& inVertices, ref NativeArray<ShadowEdge>& inEdges, ref NativeArray<Int32>& inShapeStartingEdge, ref NativeArray<Boolean>& inShapeIsClosedArray, float contractEdge, out NativeArray<Vector3>& outVertices, out NativeArray<ShadowEdge>& outEdges, out NativeArray<Int32>& outShapeStartingEdge) { }

	}

	[Token(Token = "0x2000088")]
	public static class GenerateInteriorMesh_000002C7$BurstDirectCall
	{
		[Token(Token = "0x40002A7")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x2D499A0", Offset = "0x2D48DA0", Length = "0x17A")]
		[Token(Token = "0x6000330")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x2D49810", Offset = "0x2D48C10", Length = "0x184")]
		[BurstDiscard]
		[Token(Token = "0x600032F")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x2D49B20", Offset = "0x2D48F20", Length = "0x27F")]
		[Token(Token = "0x6000331")]
		public static void Invoke(ref NativeArray<ShadowMeshVertex>& inVertices, ref NativeArray<Int32>& inIndices, ref NativeArray<ShadowEdge>& inEdges, out NativeArray<ShadowMeshVertex>& outVertices, out NativeArray<Int32>& outIndices, out int outStartIndex, out int outIndexCount) { }

	}

	[Token(Token = "0x2000087")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class GenerateInteriorMesh_000002C7$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2D49EE0", Offset = "0x2D492E0", Length = "0xB5")]
		[Token(Token = "0x600032B")]
		public GenerateInteriorMesh_000002C7$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x2D49DA0", Offset = "0x2D491A0", Length = "0x140")]
		[Token(Token = "0x600032D")]
		public override IAsyncResult BeginInvoke(ref NativeArray<ShadowMeshVertex>& inVertices, ref NativeArray<Int32>& inIndices, ref NativeArray<ShadowEdge>& inEdges, out NativeArray<ShadowMeshVertex>& outVertices, out NativeArray<Int32>& outIndices, out int outStartIndex, out int outIndexCount, AsyncCallback unnamed_param_7, object unnamed_param_8) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600032E")]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x1C18110", Offset = "0x1C17510", Length = "0x14")]
		[Token(Token = "0x600032C")]
		public override void Invoke(ref NativeArray<ShadowMeshVertex>& inVertices, ref NativeArray<Int32>& inIndices, ref NativeArray<ShadowEdge>& inEdges, out NativeArray<ShadowMeshVertex>& outVertices, out NativeArray<Int32>& outIndices, out int outStartIndex, out int outIndexCount) { }

	}

	[Token(Token = "0x200008C")]
	public static class GetVertexReferenceStats_000002CA$BurstDirectCall
	{
		[Token(Token = "0x40002A9")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x2D4A130", Offset = "0x2D49530", Length = "0x17A")]
		[Token(Token = "0x600033E")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x2D49FA0", Offset = "0x2D493A0", Length = "0x184")]
		[BurstDiscard]
		[Token(Token = "0x600033D")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x2D4A2B0", Offset = "0x2D496B0", Length = "0x265")]
		[Token(Token = "0x600033F")]
		public static void Invoke(ref NativeArray<Vector3>& vertices, ref NativeArray<ShadowEdge>& edges, int vertexCount, out bool hasReusedVertices, out int newVertexCount, out NativeArray<RemappingInfo>& remappingInfo) { }

	}

	[Token(Token = "0x200008B")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class GetVertexReferenceStats_000002CA$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2D4A650", Offset = "0x2D49A50", Length = "0xB5")]
		[Token(Token = "0x6000339")]
		public GetVertexReferenceStats_000002CA$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x2D4A520", Offset = "0x2D49920", Length = "0x123")]
		[Token(Token = "0x600033B")]
		public override IAsyncResult BeginInvoke(ref NativeArray<Vector3>& vertices, ref NativeArray<ShadowEdge>& edges, int vertexCount, out bool hasReusedVertices, out int newVertexCount, out NativeArray<RemappingInfo>& remappingInfo, AsyncCallback unnamed_param_6, object unnamed_param_7) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600033C")]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x1C17FD0", Offset = "0x1C173D0", Length = "0x14")]
		[Token(Token = "0x600033A")]
		public override void Invoke(ref NativeArray<Vector3>& vertices, ref NativeArray<ShadowEdge>& edges, int vertexCount, out bool hasReusedVertices, out int newVertexCount, out NativeArray<RemappingInfo>& remappingInfo) { }

	}

	[Token(Token = "0x200007C")]
	internal enum ProjectionType : int
	{
		ProjectionNone = -1,
		ProjectionHard = 0,
		ProjectionSoftLeft = 1,
		ProjectionSoftRight = 3,
	}

	[Token(Token = "0x200007E")]
	public struct RemappingInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400029F")]
		public int count; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40002A0")]
		public int index; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40002A1")]
		public int v0Offset; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40002A2")]
		public int v1Offset; //Field offset: 0xC

		[Address(RVA = "0x2D358D0", Offset = "0x2D34CD0", Length = "0x10")]
		[Token(Token = "0x600030E")]
		public void Initialize() { }

	}

	[Token(Token = "0x2000090")]
	public static class ReverseWindingOrder_000002CD$BurstDirectCall
	{
		[Token(Token = "0x40002AB")]
		private static IntPtr Pointer; //Field offset: 0x0

		[Address(RVA = "0x2D4EFF0", Offset = "0x2D4E3F0", Length = "0x17A")]
		[Token(Token = "0x600034C")]
		private static IntPtr GetFunctionPointer() { }

		[Address(RVA = "0x2D4EE60", Offset = "0x2D4E260", Length = "0x184")]
		[BurstDiscard]
		[Token(Token = "0x600034B")]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		[Address(RVA = "0x2D4F170", Offset = "0x2D4E570", Length = "0x332")]
		[Token(Token = "0x600034D")]
		public static void Invoke(ref NativeArray<Int32>& inShapeStartingEdge, ref NativeArray<ShadowEdge>& inOutSortedEdges) { }

	}

	[Token(Token = "0x200008F")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class ReverseWindingOrder_000002CD$PostfixBurstDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2D30B00", Offset = "0x2D2FF00", Length = "0xB5")]
		[Token(Token = "0x6000347")]
		public ReverseWindingOrder_000002CD$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		[Address(RVA = "0x2D4F4B0", Offset = "0x2D4E8B0", Length = "0xA9")]
		[Token(Token = "0x6000349")]
		public override IAsyncResult BeginInvoke(ref NativeArray<Int32>& inShapeStartingEdge, ref NativeArray<ShadowEdge>& inOutSortedEdges, AsyncCallback unnamed_param_2, object unnamed_param_3) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600034A")]
		public override void EndInvoke(IAsyncResult unnamed_param_0) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x6000348")]
		public override void Invoke(ref NativeArray<Int32>& inShapeStartingEdge, ref NativeArray<ShadowEdge>& inOutSortedEdges) { }

	}

	[Token(Token = "0x200007D")]
	public struct ShadowMeshVertex
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400029D")]
		internal Vector3 position; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400029E")]
		internal Vector4 tangent; //Field offset: 0xC

		[Address(RVA = "0x2D3FCA0", Offset = "0x2D3F0A0", Length = "0x50")]
		[Token(Token = "0x600030D")]
		internal ShadowMeshVertex(ProjectionType inProjectionType, Vector2 inEdgePosition0, Vector2 inEdgePosition1) { }

	}

	[Token(Token = "0x4000292")]
	internal const int k_AdditionalVerticesPerEdge = 4; //Field offset: 0x0
	[Token(Token = "0x4000293")]
	internal const int k_VerticesPerTriangle = 3; //Field offset: 0x0
	[Token(Token = "0x4000294")]
	internal const int k_TrianglesPerEdge = 3; //Field offset: 0x0
	[Token(Token = "0x4000295")]
	internal const int k_MinimumEdges = 3; //Field offset: 0x0
	[Token(Token = "0x4000296")]
	internal const int k_SafeSize = 40; //Field offset: 0x0
	[Token(Token = "0x4000297")]
	private static VertexAttributeDescriptor[] m_VertexLayout; //Field offset: 0x0

	[Address(RVA = "0x2D44EF0", Offset = "0x2D442F0", Length = "0xF6")]
	[Token(Token = "0x6000302")]
	private static ShadowUtility() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000301")]
	public ShadowUtility() { }

	[Address(RVA = "0x2D42850", Offset = "0x2D41C50", Length = "0xE")]
	[BurstCompile]
	[MonoPInvokeCallback(typeof(CalculateEdgesFromLines_000002C9$PostfixBurstDelegate))]
	[Token(Token = "0x60002F9")]
	public static void CalculateEdgesFromLines(ref NativeArray<Int32>& indices, out NativeArray<ShadowEdge>& outEdges, out NativeArray<Int32>& outShapeStartingEdge, out NativeArray<Boolean>& outShapeIsClosedArray) { }

	[Address(RVA = "0x2D42560", Offset = "0x2D41960", Length = "0x2E8")]
	[BurstCompile]
	[Token(Token = "0x6000308")]
	internal static void CalculateEdgesFromLines$BurstManaged(ref NativeArray<Int32>& indices, out NativeArray<ShadowEdge>& outEdges, out NativeArray<Int32>& outShapeStartingEdge, out NativeArray<Boolean>& outShapeIsClosedArray) { }

	[Address(RVA = "0x2D42E90", Offset = "0x2D42290", Length = "0xE")]
	[BurstCompile]
	[MonoPInvokeCallback(typeof(CalculateEdgesFromTriangles_000002CC$PostfixBurstDelegate))]
	[Token(Token = "0x60002FC")]
	public static void CalculateEdgesFromTriangles(ref NativeArray<Vector3>& vertices, ref NativeArray<Int32>& indices, bool duplicatesVertices, out NativeArray<Vector3>& newVertices, out NativeArray<ShadowEdge>& outEdges, out NativeArray<Int32>& outShapeStartingEdge, out NativeArray<Boolean>& outShapeIsClosedArray) { }

	[Address(RVA = "0x2D42860", Offset = "0x2D41C60", Length = "0x62E")]
	[BurstCompile]
	[Token(Token = "0x600030A")]
	internal static void CalculateEdgesFromTriangles$BurstManaged(ref NativeArray<Vector3>& vertices, ref NativeArray<Int32>& indices, bool duplicatesVertices, out NativeArray<Vector3>& newVertices, out NativeArray<ShadowEdge>& outEdges, out NativeArray<Int32>& outShapeStartingEdge, out NativeArray<Boolean>& outShapeIsClosedArray) { }

	[Address(RVA = "0x2D431A0", Offset = "0x2D425A0", Length = "0x8")]
	[BurstCompile]
	[MonoPInvokeCallback(typeof(CalculateLocalBounds_000002C6$PostfixBurstDelegate))]
	[Token(Token = "0x60002F6")]
	internal static void CalculateLocalBounds(ref NativeArray<Vector3>& inVertices, out Bounds retBounds) { }

	[Address(RVA = "0x2D42EA0", Offset = "0x2D422A0", Length = "0x2FA")]
	[BurstCompile]
	[Token(Token = "0x6000306")]
	internal static void CalculateLocalBounds$BurstManaged(ref NativeArray<Vector3>& inVertices, out Bounds retBounds) { }

	[Address(RVA = "0x2D43460", Offset = "0x2D42860", Length = "0xE")]
	[BurstCompile]
	[MonoPInvokeCallback(typeof(CalculateProjectionInfo_000002C3$PostfixBurstDelegate))]
	[Token(Token = "0x60002F3")]
	internal static void CalculateProjectionInfo(ref NativeArray<Vector3>& inVertices, ref NativeArray<ShadowEdge>& inEdges, ref NativeArray<Int32>& inShapeStartingEdge, ref NativeArray<Boolean>& inShapeIsClosedArray, ref NativeArray<Vector2>& outProjectionInfo) { }

	[Address(RVA = "0x2D431B0", Offset = "0x2D425B0", Length = "0x2AB")]
	[BurstCompile]
	[Token(Token = "0x6000303")]
	internal static void CalculateProjectionInfo$BurstManaged(ref NativeArray<Vector3>& inVertices, ref NativeArray<ShadowEdge>& inEdges, ref NativeArray<Int32>& inShapeStartingEdge, ref NativeArray<Boolean>& inShapeIsClosedArray, ref NativeArray<Vector2>& outProjectionInfo) { }

	[Address(RVA = "0x2D43470", Offset = "0x2D42870", Length = "0xE")]
	[BurstCompile]
	[MonoPInvokeCallback(typeof(CalculateTriangles_000002C5$PostfixBurstDelegate))]
	[Token(Token = "0x60002F5")]
	internal static void CalculateTriangles(ref NativeArray<Vector3>& inVertices, ref NativeArray<ShadowEdge>& inEdges, ref NativeArray<Int32>& inShapeStartingEdge, ref NativeArray<Boolean>& inShapeIsClosedArray, ref NativeArray<Int32>& outMeshIndices) { }

	[Address(RVA = "0x2D30510", Offset = "0x2D2F910", Length = "0x22B")]
	[BurstCompile]
	[Token(Token = "0x6000305")]
	internal static void CalculateTriangles$BurstManaged(ref NativeArray<Vector3>& inVertices, ref NativeArray<ShadowEdge>& inEdges, ref NativeArray<Int32>& inShapeStartingEdge, ref NativeArray<Boolean>& inShapeIsClosedArray, ref NativeArray<Int32>& outMeshIndices) { }

	[Address(RVA = "0x2D43480", Offset = "0x2D42880", Length = "0xE")]
	[BurstCompile]
	[MonoPInvokeCallback(typeof(CalculateVertices_000002C4$PostfixBurstDelegate))]
	[Token(Token = "0x60002F4")]
	internal static void CalculateVertices(ref NativeArray<Vector3>& inVertices, ref NativeArray<ShadowEdge>& inEdges, ref NativeArray<Vector2>& inEdgeOtherPoints, ref NativeArray<ShadowMeshVertex>& outMeshVertices) { }

	[Address(RVA = "0x2D30740", Offset = "0x2D2FB40", Length = "0x30C")]
	[BurstCompile]
	[Token(Token = "0x6000304")]
	internal static void CalculateVertices$BurstManaged(ref NativeArray<Vector3>& inVertices, ref NativeArray<ShadowEdge>& inEdges, ref NativeArray<Vector2>& inEdgeOtherPoints, ref NativeArray<ShadowMeshVertex>& outMeshVertices) { }

	[Address(RVA = "0x2D44000", Offset = "0x2D43400", Length = "0xE")]
	[BurstCompile]
	[MonoPInvokeCallback(typeof(ClipEdges_000002D0$PostfixBurstDelegate))]
	[Token(Token = "0x6000300")]
	public static void ClipEdges(ref NativeArray<Vector3>& inVertices, ref NativeArray<ShadowEdge>& inEdges, ref NativeArray<Int32>& inShapeStartingEdge, ref NativeArray<Boolean>& inShapeIsClosedArray, float contractEdge, out NativeArray<Vector3>& outVertices, out NativeArray<ShadowEdge>& outEdges, out NativeArray<Int32>& outShapeStartingEdge) { }

	[Address(RVA = "0x2D43490", Offset = "0x2D42890", Length = "0xB66")]
	[BurstCompile]
	[Token(Token = "0x600030C")]
	internal static void ClipEdges$BurstManaged(ref NativeArray<Vector3>& inVertices, ref NativeArray<ShadowEdge>& inEdges, ref NativeArray<Int32>& inShapeStartingEdge, ref NativeArray<Boolean>& inShapeIsClosedArray, float contractEdge, out NativeArray<Vector3>& outVertices, out NativeArray<ShadowEdge>& outEdges, out NativeArray<Int32>& outShapeStartingEdge) { }

	[Address(RVA = "0x2D44590", Offset = "0x2D43990", Length = "0xE")]
	[BurstCompile]
	[MonoPInvokeCallback(typeof(GenerateInteriorMesh_000002C7$PostfixBurstDelegate))]
	[Token(Token = "0x60002F7")]
	private static void GenerateInteriorMesh(ref NativeArray<ShadowMeshVertex>& inVertices, ref NativeArray<Int32>& inIndices, ref NativeArray<ShadowEdge>& inEdges, out NativeArray<ShadowMeshVertex>& outVertices, out NativeArray<Int32>& outIndices, out int outStartIndex, out int outIndexCount) { }

	[Address(RVA = "0x2D44010", Offset = "0x2D43410", Length = "0x57A")]
	[BurstCompile]
	[Token(Token = "0x6000307")]
	internal static void GenerateInteriorMesh$BurstManaged(ref NativeArray<ShadowMeshVertex>& inVertices, ref NativeArray<Int32>& inIndices, ref NativeArray<ShadowEdge>& inEdges, out NativeArray<ShadowMeshVertex>& outVertices, out NativeArray<Int32>& outIndices, out int outStartIndex, out int outIndexCount) { }

	[Address(RVA = "0x2D445A0", Offset = "0x2D439A0", Length = "0x3EB")]
	[Token(Token = "0x60002F8")]
	public static Bounds GenerateShadowMesh(Mesh mesh, NativeArray<Vector3> inVertices, NativeArray<ShadowEdge> inEdges, NativeArray<Int32> inShapeStartingEdge, NativeArray<Boolean> inShapeIsClosedArray, bool allowContraction, bool fill, OutlineTopology topology) { }

	[Address(RVA = "0x2D44990", Offset = "0x2D43D90", Length = "0x26")]
	[Token(Token = "0x60002FE")]
	private static int GetClosedPathCount(ref NativeArray<Int32>& inShapeStartingEdge, ref NativeArray<Boolean>& inShapeIsClosedArray) { }

	[Address(RVA = "0x2D449C0", Offset = "0x2D43DC0", Length = "0x1E")]
	[Token(Token = "0x60002F2")]
	private static int GetNextShapeStart(int currentShape, Int32* inShapeStartingEdgePtr, int inShapeStartingEdgeLength, int maxValue) { }

	[Address(RVA = "0x2D449E0", Offset = "0x2D43DE0", Length = "0xB4")]
	[Token(Token = "0x60002FF")]
	private static void GetPathInfo(NativeArray<ShadowEdge> inEdges, NativeArray<Int32> inShapeStartingEdge, NativeArray<Boolean> inShapeIsClosedArray, out int closedPathArrayCount, out int closedPathsCount, out int openPathArrayCount, out int openPathsCount) { }

	[Address(RVA = "0x2D44CC0", Offset = "0x2D440C0", Length = "0xE")]
	[BurstCompile]
	[MonoPInvokeCallback(typeof(GetVertexReferenceStats_000002CA$PostfixBurstDelegate))]
	[Token(Token = "0x60002FA")]
	internal static void GetVertexReferenceStats(ref NativeArray<Vector3>& vertices, ref NativeArray<ShadowEdge>& edges, int vertexCount, out bool hasReusedVertices, out int newVertexCount, out NativeArray<RemappingInfo>& remappingInfo) { }

	[Address(RVA = "0x2D44AA0", Offset = "0x2D43EA0", Length = "0x215")]
	[BurstCompile]
	[Token(Token = "0x6000309")]
	internal static void GetVertexReferenceStats$BurstManaged(ref NativeArray<Vector3>& vertices, ref NativeArray<ShadowEdge>& edges, int vertexCount, out bool hasReusedVertices, out int newVertexCount, out NativeArray<RemappingInfo>& remappingInfo) { }

	[Address(RVA = "0x2D44CD0", Offset = "0x2D440D0", Length = "0xCC")]
	[Token(Token = "0x60002FB")]
	public static bool IsTriangleReversed(NativeArray<Vector3> vertices, int idx0, int idx1, int idx2) { }

	[Address(RVA = "0x2D44EE0", Offset = "0x2D442E0", Length = "0x8")]
	[BurstCompile]
	[MonoPInvokeCallback(typeof(ReverseWindingOrder_000002CD$PostfixBurstDelegate))]
	[Token(Token = "0x60002FD")]
	public static void ReverseWindingOrder(ref NativeArray<Int32>& inShapeStartingEdge, ref NativeArray<ShadowEdge>& inOutSortedEdges) { }

	[Address(RVA = "0x2D44DA0", Offset = "0x2D441A0", Length = "0x138")]
	[BurstCompile]
	[Token(Token = "0x600030B")]
	internal static void ReverseWindingOrder$BurstManaged(ref NativeArray<Int32>& inShapeStartingEdge, ref NativeArray<ShadowEdge>& inOutSortedEdges) { }

}

