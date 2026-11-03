namespace UnityEngine.TextCore.Text;

[ExcludeFromObjectFactory]
[ExcludeFromPreset]
[NativeHeader("Modules/TextCoreTextEngine/TextColorGradient.h")]
[Token(Token = "0x200003C")]
public class TextColorGradient : ScriptableObject
{
	[Token(Token = "0x400019B")]
	private const ColorGradientMode k_DefaultColorMode = 3; //Field offset: 0x0
	[Token(Token = "0x400019C")]
	private static readonly Color k_DefaultColor; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000196")]
	public ColorGradientMode colorMode; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000197")]
	public Color topLeft; //Field offset: 0x1C
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000198")]
	public Color topRight; //Field offset: 0x2C
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000199")]
	public Color bottomLeft; //Field offset: 0x3C
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400019A")]
	public Color bottomRight; //Field offset: 0x4C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400019D")]
	private IntPtr m_NativeInstance; //Field offset: 0x60

	[Token(Token = "0x17000040")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal IntPtr nativeInstance
	{
		[Address(RVA = "0x31B3340", Offset = "0x31B2740", Length = "0x190")]
		[Token(Token = "0x6000185")]
		internal get { } //Length: 400
	}

	[Address(RVA = "0x31B3170", Offset = "0x31B2570", Length = "0x3E")]
	[Token(Token = "0x600018D")]
	private static TextColorGradient() { }

	[Address(RVA = "0x31B3280", Offset = "0x31B2680", Length = "0xB7")]
	[Token(Token = "0x6000186")]
	public TextColorGradient() { }

	[Address(RVA = "0x31B31B0", Offset = "0x31B25B0", Length = "0x4B")]
	[Token(Token = "0x6000187")]
	public TextColorGradient(Color color) { }

	[Address(RVA = "0x31B3200", Offset = "0x31B2600", Length = "0x73")]
	[Token(Token = "0x6000188")]
	public TextColorGradient(Color color0, Color color1, Color color2, Color color3) { }

	[Address(RVA = "0x31B2D80", Offset = "0x31B2180", Length = "0x8B")]
	[Token(Token = "0x600018A")]
	private static IntPtr CreateNative(Color32 tl, Color32 tr, Color32 bl, Color32 br, IntPtr managedObject) { }

	[Address(RVA = "0x31B2D10", Offset = "0x31B2110", Length = "0x62")]
	[Token(Token = "0x600018E")]
	private static IntPtr CreateNative_Injected(in Color32 tl, in Color32 tr, in Color32 bl, in Color32 br, IntPtr managedObject) { }

	[Address(RVA = "0x31B2E10", Offset = "0x31B2210", Length = "0x42")]
	[Token(Token = "0x600018B")]
	private static void DestroyNative(IntPtr nativeInstance, IntPtr managedObject) { }

	[Address(RVA = "0x31B3340", Offset = "0x31B2740", Length = "0x190")]
	[Token(Token = "0x6000185")]
	internal IntPtr get_nativeInstance() { }

	[Address(RVA = "0x31B2E60", Offset = "0x31B2260", Length = "0x163")]
	[Token(Token = "0x6000189")]
	internal void MarkNativeDirty() { }

	[Address(RVA = "0x31B2FD0", Offset = "0x31B23D0", Length = "0x9E")]
	[Token(Token = "0x6000184")]
	private void OnDisable() { }

	[Address(RVA = "0x31B2E60", Offset = "0x31B2260", Length = "0x163")]
	[Token(Token = "0x6000183")]
	private void OnValidate() { }

	[Address(RVA = "0x31B30E0", Offset = "0x31B24E0", Length = "0x8A")]
	[Token(Token = "0x600018C")]
	private static void UpdateNative(IntPtr instance, Color32 tl, Color32 tr, Color32 bl, Color32 br) { }

	[Address(RVA = "0x31B3070", Offset = "0x31B2470", Length = "0x62")]
	[Token(Token = "0x600018F")]
	private static void UpdateNative_Injected(IntPtr instance, in Color32 tl, in Color32 tr, in Color32 bl, in Color32 br) { }

}

