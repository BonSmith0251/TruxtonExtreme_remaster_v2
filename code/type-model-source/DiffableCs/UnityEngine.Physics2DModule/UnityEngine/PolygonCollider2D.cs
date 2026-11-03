namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/PolygonCollider2D.h")]
[Token(Token = "0x2000016")]
public sealed class PolygonCollider2D : Collider2D
{

	[Token(Token = "0x17000027")]
	public int pathCount
	{
		[Address(RVA = "0x3131FB0", Offset = "0x31313B0", Length = "0x76")]
		[Token(Token = "0x600008C")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000026")]
	public Vector2[] points
	{
		[Address(RVA = "0x3132080", Offset = "0x3131480", Length = "0x12A")]
		[NativeMethod("GetPoints_Binding")]
		[Token(Token = "0x600008A")]
		 get { } //Length: 298
		[Address(RVA = "0x3132200", Offset = "0x3131600", Length = "0x104")]
		[NativeMethod("SetPoints_Binding")]
		[Token(Token = "0x600008B")]
		 set { } //Length: 260
	}

	[Address(RVA = "0x3131FB0", Offset = "0x31313B0", Length = "0x76")]
	[Token(Token = "0x600008C")]
	public int get_pathCount() { }

	[Address(RVA = "0x3131F70", Offset = "0x3131370", Length = "0x33")]
	[Token(Token = "0x6000092")]
	private static int get_pathCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3132080", Offset = "0x3131480", Length = "0x12A")]
	[NativeMethod("GetPoints_Binding")]
	[Token(Token = "0x600008A")]
	public Vector2[] get_points() { }

	[Address(RVA = "0x3132030", Offset = "0x3131430", Length = "0x42")]
	[Token(Token = "0x6000090")]
	private static void get_points_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x3131D30", Offset = "0x3131130", Length = "0x17D")]
	[Token(Token = "0x600008D")]
	public Vector2[] GetPath(int index) { }

	[Address(RVA = "0x3131BF0", Offset = "0x3130FF0", Length = "0x13B")]
	[NativeMethod("GetPath_Binding")]
	[Token(Token = "0x600008E")]
	private Vector2[] GetPath_Internal(int index) { }

	[Address(RVA = "0x3131BA0", Offset = "0x3130FA0", Length = "0x50")]
	[Token(Token = "0x6000093")]
	private static void GetPath_Internal_Injected(IntPtr _unity_self, int index, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x3131EF0", Offset = "0x31312F0", Length = "0x76")]
	[NativeMethod("GetPointCount")]
	[Token(Token = "0x6000089")]
	public int GetTotalPointCount() { }

	[Address(RVA = "0x3131EB0", Offset = "0x31312B0", Length = "0x33")]
	[Token(Token = "0x600008F")]
	private static int GetTotalPointCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3132200", Offset = "0x3131600", Length = "0x104")]
	[NativeMethod("SetPoints_Binding")]
	[Token(Token = "0x600008B")]
	public void set_points(Vector2[] value) { }

	[Address(RVA = "0x31321B0", Offset = "0x31315B0", Length = "0x42")]
	[Token(Token = "0x6000091")]
	private static void set_points_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

}

