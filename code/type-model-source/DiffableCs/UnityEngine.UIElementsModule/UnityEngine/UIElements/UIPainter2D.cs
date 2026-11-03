namespace UnityEngine.UIElements;

[NativeHeader("Modules/UIElements/Core/Native/Renderer/UIPainter2D.bindings.h")]
[Token(Token = "0x20002A6")]
internal static class UIPainter2D
{

	[Address(RVA = "0x340D370", Offset = "0x340C770", Length = "0x33")]
	[Token(Token = "0x6001259")]
	public static void ClearSnapshots(IntPtr handle) { }

	[Address(RVA = "0x340D3B0", Offset = "0x340C7B0", Length = "0x33")]
	[Token(Token = "0x6001256")]
	public static IntPtr Create(bool computeBBox = false) { }

	[Address(RVA = "0x340D3F0", Offset = "0x340C7F0", Length = "0x33")]
	[Token(Token = "0x6001257")]
	public static void Destroy(IntPtr handle) { }

	[Address(RVA = "0x340D480", Offset = "0x340C880", Length = "0x60")]
	[ThreadSafe]
	[Token(Token = "0x600125A")]
	public static MeshWriteDataInterface ExecuteSnapshotFromJob(IntPtr painterHandle, int i) { }

	[Address(RVA = "0x340D430", Offset = "0x340C830", Length = "0x50")]
	[Token(Token = "0x600125B")]
	private static void ExecuteSnapshotFromJob_Injected(IntPtr painterHandle, int i, out MeshWriteDataInterface ret) { }

	[Address(RVA = "0x340D4E0", Offset = "0x340C8E0", Length = "0x33")]
	[Token(Token = "0x6001258")]
	public static void Reset(IntPtr handle) { }

}

