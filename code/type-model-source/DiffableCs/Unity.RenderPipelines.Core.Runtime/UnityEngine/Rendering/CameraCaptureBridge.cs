namespace UnityEngine.Rendering;

[Token(Token = "0x20001BA")]
public static class CameraCaptureBridge
{
	[Token(Token = "0x20001BB")]
	private class CameraEntry
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400089B")]
		internal HashSet<Action`2<RenderTargetIdentifier, CommandBuffer>> actions; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400089C")]
		internal IEnumerator<Action`2<RenderTargetIdentifier, CommandBuffer>> cachedEnumerator; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000D87")]
		public CameraEntry() { }

	}

	[Token(Token = "0x4000899")]
	private static Dictionary<Camera, CameraEntry> actionDict; //Field offset: 0x0
	[Token(Token = "0x400089A")]
	private static bool _enabled; //Field offset: 0x8

	[Token(Token = "0x170001BF")]
	public static bool enabled
	{
		[Address(RVA = "0x2C449D0", Offset = "0x2C43DD0", Length = "0x4F")]
		[Token(Token = "0x6000D80")]
		 get { } //Length: 79
		[Address(RVA = "0x2C44A20", Offset = "0x2C43E20", Length = "0x54")]
		[Token(Token = "0x6000D81")]
		 set { } //Length: 84
	}

	[Address(RVA = "0x2C44940", Offset = "0x2C43D40", Length = "0x84")]
	[Token(Token = "0x6000D86")]
	private static CameraCaptureBridge() { }

	[Address(RVA = "0x2C442E0", Offset = "0x2C436E0", Length = "0x23B")]
	[Token(Token = "0x6000D84")]
	public static void AddCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action) { }

	[Address(RVA = "0x2C449D0", Offset = "0x2C43DD0", Length = "0x4F")]
	[Token(Token = "0x6000D80")]
	public static bool get_enabled() { }

	[Address(RVA = "0x2C44520", Offset = "0x2C43920", Length = "0x169")]
	[Token(Token = "0x6000D83")]
	internal static IEnumerator<Action`2<RenderTargetIdentifier, CommandBuffer>> GetCachedCaptureActionsEnumerator(Camera camera) { }

	[Address(RVA = "0x2C44690", Offset = "0x2C43A90", Length = "0x116")]
	[Token(Token = "0x6000D82")]
	public static IEnumerator<Action`2<RenderTargetIdentifier, CommandBuffer>> GetCaptureActions(Camera camera) { }

	[Address(RVA = "0x2C447B0", Offset = "0x2C43BB0", Length = "0x189")]
	[Token(Token = "0x6000D85")]
	public static void RemoveCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action) { }

	[Address(RVA = "0x2C44A20", Offset = "0x2C43E20", Length = "0x54")]
	[Token(Token = "0x6000D81")]
	public static void set_enabled(bool value) { }

}

