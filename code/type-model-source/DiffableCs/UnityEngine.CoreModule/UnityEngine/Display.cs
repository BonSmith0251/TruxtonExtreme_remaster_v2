namespace UnityEngine;

[NativeHeader("Runtime/Graphics/DisplayManager.h")]
[Token(Token = "0x20000D2")]
[UsedByNativeCode]
public class Display
{
	[Token(Token = "0x20000D3")]
	internal sealed class DisplaysUpdatedDelegate : MulticastDelegate
	{

		[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
		[Token(Token = "0x6000624")]
		public DisplaysUpdatedDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
		[Token(Token = "0x6000625")]
		public override void Invoke() { }

	}

	[Token(Token = "0x4000254")]
	public static Display[] displays; //Field offset: 0x0
	[Token(Token = "0x4000255")]
	private static Display _mainDisplay; //Field offset: 0x8
	[Token(Token = "0x4000256")]
	private static int m_ActiveEditorGameViewTarget; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000257")]
	private static DisplaysUpdatedDelegate onDisplaysUpdated; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000253")]
	internal IntPtr nativeDisplay; //Field offset: 0x10

	[Token(Token = "0x17000113")]
	public static Display main
	{
		[Address(RVA = "0x2FF23C0", Offset = "0x2FF17C0", Length = "0x4F")]
		[Token(Token = "0x600061C")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700010F")]
	public int renderingHeight
	{
		[Address(RVA = "0x2FF2410", Offset = "0x2FF1810", Length = "0x7F")]
		[Token(Token = "0x6000617")]
		 get { } //Length: 127
	}

	[Token(Token = "0x1700010E")]
	public int renderingWidth
	{
		[Address(RVA = "0x2FF2490", Offset = "0x2FF1890", Length = "0x7F")]
		[Token(Token = "0x6000616")]
		 get { } //Length: 127
	}

	[Token(Token = "0x17000112")]
	public bool requiresSrgbBlitToBackbuffer
	{
		[Address(RVA = "0x2FF2510", Offset = "0x2FF1910", Length = "0x68")]
		[Token(Token = "0x600061A")]
		 get { } //Length: 104
	}

	[Token(Token = "0x17000111")]
	public int systemHeight
	{
		[Address(RVA = "0x2FF2580", Offset = "0x2FF1980", Length = "0x7F")]
		[Token(Token = "0x6000619")]
		 get { } //Length: 127
	}

	[Token(Token = "0x17000110")]
	public int systemWidth
	{
		[Address(RVA = "0x2FF2600", Offset = "0x2FF1A00", Length = "0x7F")]
		[Token(Token = "0x6000618")]
		 get { } //Length: 127
	}

	[Address(RVA = "0x2FF21F0", Offset = "0x2FF15F0", Length = "0x18A")]
	[Token(Token = "0x6000623")]
	private static Display() { }

	[Address(RVA = "0x2FF2380", Offset = "0x2FF1780", Length = "0x37")]
	[Token(Token = "0x6000614")]
	internal Display() { }

	[Address(RVA = "0x2B7F420", Offset = "0x2B7E820", Length = "0x26")]
	[Token(Token = "0x6000615")]
	internal Display(IntPtr nativeDisplay) { }

	[Address(RVA = "0x2FF1D40", Offset = "0x2FF1140", Length = "0x8C")]
	[RequiredByNativeCode]
	[Token(Token = "0x600061E")]
	internal static void FireDisplaysUpdated() { }

	[Address(RVA = "0x2FF23C0", Offset = "0x2FF17C0", Length = "0x4F")]
	[Token(Token = "0x600061C")]
	public static Display get_main() { }

	[Address(RVA = "0x2FF2410", Offset = "0x2FF1810", Length = "0x7F")]
	[Token(Token = "0x6000617")]
	public int get_renderingHeight() { }

	[Address(RVA = "0x2FF2490", Offset = "0x2FF1890", Length = "0x7F")]
	[Token(Token = "0x6000616")]
	public int get_renderingWidth() { }

	[Address(RVA = "0x2FF2510", Offset = "0x2FF1910", Length = "0x68")]
	[Token(Token = "0x600061A")]
	public bool get_requiresSrgbBlitToBackbuffer() { }

	[Address(RVA = "0x2FF2580", Offset = "0x2FF1980", Length = "0x7F")]
	[Token(Token = "0x6000619")]
	public int get_systemHeight() { }

	[Address(RVA = "0x2FF2600", Offset = "0x2FF1A00", Length = "0x7F")]
	[Token(Token = "0x6000618")]
	public int get_systemWidth() { }

	[Address(RVA = "0x2FF1DD0", Offset = "0x2FF11D0", Length = "0x52")]
	[FreeFunction("UnityDisplayManager_DisplayRenderingResolution")]
	[Token(Token = "0x6000620")]
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[Address(RVA = "0x2FF1E30", Offset = "0x2FF1230", Length = "0x52")]
	[FreeFunction("UnityDisplayManager_DisplaySystemResolution")]
	[Token(Token = "0x600061F")]
	private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[Address(RVA = "0x2FF1E90", Offset = "0x2FF1290", Length = "0x1E4")]
	[RequiredByNativeCode]
	[Token(Token = "0x600061D")]
	internal static void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	[Address(RVA = "0x2FF20E0", Offset = "0x2FF14E0", Length = "0xC5")]
	[Token(Token = "0x600061B")]
	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	[Address(RVA = "0x2FF2080", Offset = "0x2FF1480", Length = "0x5E")]
	[FreeFunction("UnityDisplayManager_RelativeMouseAt")]
	[Token(Token = "0x6000621")]
	private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry) { }

	[Address(RVA = "0x2FF21B0", Offset = "0x2FF15B0", Length = "0x33")]
	[FreeFunction("UnityDisplayManager_RequiresSRGBBlitToBackbuffer")]
	[Token(Token = "0x6000622")]
	private static bool RequiresSrgbBlitToBackbufferImpl(IntPtr nativeDisplay) { }

}

