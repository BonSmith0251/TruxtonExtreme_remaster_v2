namespace UnityEngine.UI;

[Token(Token = "0x200007A")]
internal class ReflectionMethodsCache
{
	[Token(Token = "0x200007D")]
	internal sealed class GetRaycastNonAllocCallback : MulticastDelegate
	{

		[Address(RVA = "0x344AE20", Offset = "0x344A220", Length = "0xA6")]
		[Token(Token = "0x600050F")]
		public GetRaycastNonAllocCallback(object object, IntPtr method) { }

		[Address(RVA = "0x344AED0", Offset = "0x344A2D0", Length = "0xC3")]
		[Token(Token = "0x6000511")]
		public override IAsyncResult BeginInvoke(Ray r, RaycastHit[] results, float f, int i, AsyncCallback callback, object object) { }

		[Address(RVA = "0xF64600", Offset = "0xF63A00", Length = "0x27")]
		[Token(Token = "0x6000512")]
		public override int EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x344ADE0", Offset = "0x344A1E0", Length = "0x40")]
		[Token(Token = "0x6000510")]
		public override int Invoke(Ray r, RaycastHit[] results, float f, int i) { }

	}

	[Token(Token = "0x200007F")]
	internal sealed class GetRayIntersectionAllCallback : MulticastDelegate
	{

		[Address(RVA = "0x344AC60", Offset = "0x344A060", Length = "0xA6")]
		[Token(Token = "0x6000517")]
		public GetRayIntersectionAllCallback(object object, IntPtr method) { }

		[Address(RVA = "0x344AB70", Offset = "0x3449F70", Length = "0xA6")]
		[Token(Token = "0x6000519")]
		public override IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600051A")]
		public override RaycastHit2D[] EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x344AC20", Offset = "0x344A020", Length = "0x35")]
		[Token(Token = "0x6000518")]
		public override RaycastHit2D[] Invoke(Ray r, float f, int i) { }

	}

	[Token(Token = "0x2000080")]
	internal sealed class GetRayIntersectionAllNonAllocCallback : MulticastDelegate
	{

		[Address(RVA = "0x344AE20", Offset = "0x344A220", Length = "0xA6")]
		[Token(Token = "0x600051B")]
		public GetRayIntersectionAllNonAllocCallback(object object, IntPtr method) { }

		[Address(RVA = "0x344AD10", Offset = "0x344A110", Length = "0xC3")]
		[Token(Token = "0x600051D")]
		public override IAsyncResult BeginInvoke(Ray r, RaycastHit2D[] results, float f, int i, AsyncCallback callback, object object) { }

		[Address(RVA = "0xF64600", Offset = "0xF63A00", Length = "0x27")]
		[Token(Token = "0x600051E")]
		public override int EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x344ADE0", Offset = "0x344A1E0", Length = "0x40")]
		[Token(Token = "0x600051C")]
		public override int Invoke(Ray r, RaycastHit2D[] results, float f, int i) { }

	}

	[Token(Token = "0x200007E")]
	internal sealed class Raycast2DCallback : MulticastDelegate
	{

		[Address(RVA = "0x344C750", Offset = "0x344BB50", Length = "0xA6")]
		[Token(Token = "0x6000513")]
		public Raycast2DCallback(object object, IntPtr method) { }

		[Address(RVA = "0x344C5D0", Offset = "0x344B9D0", Length = "0xC9")]
		[Token(Token = "0x6000515")]
		public override IAsyncResult BeginInvoke(Vector2 p1, Vector2 p2, float f, int i, AsyncCallback callback, object object) { }

		[Address(RVA = "0x344C6A0", Offset = "0x344BAA0", Length = "0x42")]
		[Token(Token = "0x6000516")]
		public override RaycastHit2D EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x344C6F0", Offset = "0x344BAF0", Length = "0x59")]
		[Token(Token = "0x6000514")]
		public override RaycastHit2D Invoke(Vector2 p1, Vector2 p2, float f, int i) { }

	}

	[Token(Token = "0x200007B")]
	internal sealed class Raycast3DCallback : MulticastDelegate
	{

		[Address(RVA = "0x344C8E0", Offset = "0x344BCE0", Length = "0xA6")]
		[Token(Token = "0x6000507")]
		public Raycast3DCallback(object object, IntPtr method) { }

		[Address(RVA = "0x344C800", Offset = "0x344BC00", Length = "0xDE")]
		[Token(Token = "0x6000509")]
		public override IAsyncResult BeginInvoke(Ray r, out RaycastHit hit, float f, int i, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2B824D0", Offset = "0x2B818D0", Length = "0x30")]
		[Token(Token = "0x600050A")]
		public override bool EndInvoke(out RaycastHit hit, IAsyncResult result) { }

		[Address(RVA = "0x344ADE0", Offset = "0x344A1E0", Length = "0x40")]
		[Token(Token = "0x6000508")]
		public override bool Invoke(Ray r, out RaycastHit hit, float f, int i) { }

	}

	[Token(Token = "0x200007C")]
	internal sealed class RaycastAllCallback : MulticastDelegate
	{

		[Address(RVA = "0x344AC60", Offset = "0x344A060", Length = "0xA6")]
		[Token(Token = "0x600050B")]
		public RaycastAllCallback(object object, IntPtr method) { }

		[Address(RVA = "0x344C990", Offset = "0x344BD90", Length = "0xA6")]
		[Token(Token = "0x600050D")]
		public override IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600050E")]
		public override RaycastHit[] EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x344AC20", Offset = "0x344A020", Length = "0x35")]
		[Token(Token = "0x600050C")]
		public override RaycastHit[] Invoke(Ray r, float f, int i) { }

	}

	[Token(Token = "0x4000263")]
	private static ReflectionMethodsCache s_ReflectionMethodsCache; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400025D")]
	public Raycast3DCallback raycast3D; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400025E")]
	public RaycastAllCallback raycast3DAll; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400025F")]
	public GetRaycastNonAllocCallback getRaycastNonAlloc; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000260")]
	public Raycast2DCallback raycast2D; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000261")]
	public GetRayIntersectionAllCallback getRayIntersectionAll; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000262")]
	public GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc; //Field offset: 0x38

	[Token(Token = "0x17000152")]
	public static ReflectionMethodsCache Singleton
	{
		[Address(RVA = "0x344F350", Offset = "0x344E750", Length = "0x8D")]
		[Token(Token = "0x6000506")]
		 get { } //Length: 141
	}

	[Address(RVA = "0x344E380", Offset = "0x344D780", Length = "0xFCB")]
	[Token(Token = "0x6000505")]
	public ReflectionMethodsCache() { }

	[Address(RVA = "0x344F350", Offset = "0x344E750", Length = "0x8D")]
	[Token(Token = "0x6000506")]
	public static ReflectionMethodsCache get_Singleton() { }

}

