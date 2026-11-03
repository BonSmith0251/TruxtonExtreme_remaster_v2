namespace UnityEngine.U2D;

[NativeType(Header = "Runtime/2D/Common/ClipperWrapper.h")]
[Token(Token = "0x200042C")]
internal struct Clipper2D
{
	[Token(Token = "0x200042D")]
	internal enum ClipType : int
	{
		ctIntersection = 0,
		ctUnion = 1,
		ctDifference = 2,
		ctXor = 3,
	}

	[NativeType(Header = "Runtime/2D/Common/ClipperWrapper.h")]
	[Token(Token = "0x2000432")]
	internal struct ExecuteArguments
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F01")]
		public InitOptions initOption; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000F02")]
		public ClipType clipType; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000F03")]
		public PolyFillType subjFillType; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000F04")]
		public PolyFillType clipFillType; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000F05")]
		public bool reverseSolution; //Field offset: 0x10
		[FieldOffset(Offset = "0x11")]
		[Token(Token = "0x4000F06")]
		public bool strictlySimple; //Field offset: 0x11
		[FieldOffset(Offset = "0x12")]
		[Token(Token = "0x4000F07")]
		public bool preserveColinear; //Field offset: 0x12

		[Address(RVA = "0x30BE810", Offset = "0x30BDC10", Length = "0x2A")]
		[Token(Token = "0x6001F98")]
		public ExecuteArguments(InitOptions inInitOption = 0, ClipType inClipType = 0, PolyFillType inSubjFillType = 0, PolyFillType inClipFillType = 0, bool inReverseSolution = false, bool inStrictlySimple = false, bool inPreserveColinear = false) { }

	}

	[Token(Token = "0x2000430")]
	internal enum InitOptions : int
	{
		ioDefault = 0,
		oReverseSolution = 1,
		ioStrictlySimple = 2,
		ioPreserveCollinear = 4,
	}

	[NativeType(Header = "Runtime/2D/Common/ClipperWrapper.h")]
	[Token(Token = "0x2000431")]
	internal struct PathArguments
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EFF")]
		public PolyType polyType; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000F00")]
		public bool closed; //Field offset: 0x4

		[Address(RVA = "0xAEE2F0", Offset = "0xAED6F0", Length = "0x7")]
		[Token(Token = "0x6001F97")]
		public PathArguments(PolyType inPolyType = 0, bool inClosed = false) { }

	}

	[Token(Token = "0x200042F")]
	internal enum PolyFillType : int
	{
		pftEvenOdd = 0,
		pftNonZero = 1,
		pftPositive = 2,
		pftNegative = 3,
	}

	[Token(Token = "0x200042E")]
	internal enum PolyType : int
	{
		ptSubject = 0,
		ptClip = 1,
	}

	[Token(Token = "0x2000433")]
	internal struct Solution : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F08")]
		public NativeArray<Vector2> points; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000F09")]
		public NativeArray<Int32> pathSizes; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000F0A")]
		public NativeArray<Rect> boundingRect; //Field offset: 0x20

		[Address(RVA = "0x30CD290", Offset = "0x30CC690", Length = "0xAF")]
		[Token(Token = "0x6001F99")]
		public override void Dispose() { }

	}


	[Address(RVA = "0x30BC2D0", Offset = "0x30BB6D0", Length = "0x336")]
	[Token(Token = "0x6001F93")]
	public static void Execute(ref Solution solution, NativeArray<Vector2> inPoints, NativeArray<Int32> inPathSizes, NativeArray<PathArguments> inPathArguments, ExecuteArguments inExecuteArguments, Allocator inSolutionAllocator, int inIntScale = 65536, bool useRounding = false) { }

	[Address(RVA = "0x30BC6E0", Offset = "0x30BBAE0", Length = "0xDF")]
	[NativeMethod(Name = "Clipper2D::Execute", IsFreeFunction = True, IsThreadSafe = True)]
	[Token(Token = "0x6001F94")]
	private static Rect Internal_Execute(out IntPtr outClippedPoints, out int outClippedPointsCount, out IntPtr outClippedPathSizes, out int outClippedPathCount, IntPtr inPoints, int inPointCount, IntPtr inPathSizes, IntPtr inPathArguments, int inPathCount, ExecuteArguments inExecuteArguments, float inIntScale, bool useRounding) { }

	[Address(RVA = "0x30BC610", Offset = "0x30BBA10", Length = "0x42")]
	[NativeMethod(Name = "Clipper2D::Execute_Cleanup", IsFreeFunction = True, IsThreadSafe = True)]
	[Token(Token = "0x6001F95")]
	private static void Internal_Execute_Cleanup(IntPtr inPoints, IntPtr inPathSizes) { }

	[Address(RVA = "0x30BC660", Offset = "0x30BBA60", Length = "0x75")]
	[Token(Token = "0x6001F96")]
	private static void Internal_Execute_Injected(out IntPtr outClippedPoints, out int outClippedPointsCount, out IntPtr outClippedPathSizes, out int outClippedPathCount, IntPtr inPoints, int inPointCount, IntPtr inPathSizes, IntPtr inPathArguments, int inPathCount, in ExecuteArguments inExecuteArguments, float inIntScale, bool useRounding, out Rect ret) { }

}

