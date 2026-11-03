namespace UnityEngine.U2D;

[NativeType(Header = "Runtime/2D/Common/ClipperOffsetWrapper.h")]
[Token(Token = "0x2000434")]
internal struct ClipperOffset2D
{
	[Token(Token = "0x2000436")]
	internal enum EndType : int
	{
		etClosedPolygon = 0,
		etClosedLine = 1,
		etOpenButt = 2,
		etOpenSquare = 3,
		etOpenRound = 4,
	}

	[Token(Token = "0x2000435")]
	internal enum JoinType : int
	{
		jtSquare = 0,
		jtRound = 1,
		jtMiter = 2,
	}

	[NativeType(Header = "Runtime/2D/Common/ClipperOffsetWrapper.h")]
	[Token(Token = "0x2000437")]
	internal struct PathArguments
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F15")]
		public JoinType joinType; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000F16")]
		public EndType endType; //Field offset: 0x4

	}

	[Token(Token = "0x2000438")]
	internal struct Solution
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F17")]
		public NativeArray<Vector2> points; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000F18")]
		public NativeArray<Int32> pathSizes; //Field offset: 0x10

		[Address(RVA = "0x30CD210", Offset = "0x30CC610", Length = "0x80")]
		[Token(Token = "0x6001F9D")]
		public void Dispose() { }

	}


	[Address(RVA = "0x30BC7C0", Offset = "0x30BBBC0", Length = "0x254")]
	[Token(Token = "0x6001F9A")]
	public static void Execute(ref Solution solution, NativeArray<Vector2> inPoints, NativeArray<Int32> inPathSizes, NativeArray<PathArguments> inPathArguments, Allocator inSolutionAllocator, double inDelta = 0, double inMiterLimit = 2, double inRoundPrecision = 0.25, double inArcTolerance = 0, double inIntScale = 65536, bool useRounding = false) { }

	[Address(RVA = "0x30BCA70", Offset = "0x30BBE70", Length = "0x7D")]
	[NativeMethod(Name = "ClipperOffset2D::Execute", IsFreeFunction = True, IsThreadSafe = True)]
	[Token(Token = "0x6001F9B")]
	private static void Internal_Execute(out IntPtr outClippedPoints, out int outClippedPointsCount, out IntPtr outClippedPathSizes, out int outClippedPathCount, IntPtr inPoints, int inPointCount, IntPtr inPathSizes, IntPtr inPathArguments, int inPathCount, double inDelta, double inMiterLimit, double inRoundPrecision, double inArcTolerance, double inIntScale, bool useRounding) { }

	[Address(RVA = "0x30BCA20", Offset = "0x30BBE20", Length = "0x42")]
	[NativeMethod(Name = "ClipperOffset2D::Execute_Cleanup", IsFreeFunction = True, IsThreadSafe = True)]
	[Token(Token = "0x6001F9C")]
	private static void Internal_Execute_Cleanup(IntPtr inPoints, IntPtr inPathSizes) { }

}

