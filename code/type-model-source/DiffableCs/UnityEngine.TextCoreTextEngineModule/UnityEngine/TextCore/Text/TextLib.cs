namespace UnityEngine.TextCore.Text;

[NativeHeader("Modules/TextCoreTextEngine/Native/TextLib.h")]
[Token(Token = "0x200005A")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "Unity.UIElements.PlayModeTests"})]
internal class TextLib
{
	[Token(Token = "0x200005B")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x600028E")]
		public static IntPtr ConvertToNative(TextLib textLib) { }

	}

	[Token(Token = "0x400037E")]
	public const int k_unconstrainedScreenSize = -1; //Field offset: 0x0
	[Token(Token = "0x4000380")]
	public static Func<TextAsset> GetICUAssetEditorDelegate; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400037F")]
	private readonly IntPtr m_Ptr; //Field offset: 0x10

	[Address(RVA = "0x31C1270", Offset = "0x31C0670", Length = "0xD3")]
	[Token(Token = "0x600027F")]
	public TextLib(Byte[] icuData) { }

	[Address(RVA = "0x31BFC70", Offset = "0x31BF070", Length = "0x3D")]
	[NativeMethod(Name = "TextLib::FindIntersectingLink")]
	[Token(Token = "0x6000287")]
	public static int FindIntersectingLink(Vector2 point, IntPtr textGenerationInfo) { }

	[Address(RVA = "0x31BFC20", Offset = "0x31BF020", Length = "0x42")]
	[Token(Token = "0x600028D")]
	private static int FindIntersectingLink_Injected(in Vector2 point, IntPtr textGenerationInfo) { }

	[Address(RVA = "0x31BFDC0", Offset = "0x31BF1C0", Length = "0x1A7")]
	[Token(Token = "0x6000281")]
	public NativeTextInfo GenerateText(NativeTextGenerationSettings settings, IntPtr textGenerationInfo, ref bool wasCached) { }

	[Address(RVA = "0x31BFD20", Offset = "0x31BF120", Length = "0x95")]
	[NativeMethod(Name = "TextLib::GenerateTextMesh", IsThreadSafe = True)]
	[Token(Token = "0x6000285")]
	private NativeTextInfo GenerateTextInternal(NativeTextGenerationSettings settings, IntPtr textGenerationInfo, ref bool uvsAreGenerated) { }

	[Address(RVA = "0x31BFCB0", Offset = "0x31BF0B0", Length = "0x62")]
	[Token(Token = "0x600028B")]
	private static void GenerateTextInternal_Injected(IntPtr _unity_self, in NativeTextGenerationSettings settings, IntPtr textGenerationInfo, ref bool uvsAreGenerated, out NativeTextInfo ret) { }

	[Address(RVA = "0x31BFF70", Offset = "0x31BF370", Length = "0x33")]
	[NativeMethod(Name = "TextLib::GetCharacterCount")]
	[Token(Token = "0x6000288")]
	public static int GetCharacterCount(IntPtr textGenerationInfo) { }

	[Address(RVA = "0x31BFFF0", Offset = "0x31BF3F0", Length = "0xBC")]
	[Token(Token = "0x6000280")]
	private static IntPtr GetInstance(Byte[] icuData) { }

	[Address(RVA = "0x31BFFB0", Offset = "0x31BF3B0", Length = "0x33")]
	[Token(Token = "0x6000289")]
	private static IntPtr GetInstance_Injected(ref ManagedSpanWrapper icuData) { }

	[Address(RVA = "0x31C00B0", Offset = "0x31BF4B0", Length = "0x329")]
	[Token(Token = "0x6000282")]
	public bool HasMissingGlyphs(NativeTextInfo textInfo, ref Dictionary<Int32, HashSet`1<UInt32>>& missingGlyphsPerFontAsset) { }

	[Address(RVA = "0x31C0450", Offset = "0x31BF850", Length = "0x7A")]
	[NativeMethod(Name = "TextLib::MeasureText")]
	[Token(Token = "0x6000286")]
	public Vector2 MeasureText(NativeTextGenerationSettings settings, IntPtr textGenerationInfo) { }

	[Address(RVA = "0x31C03E0", Offset = "0x31BF7E0", Length = "0x62")]
	[Token(Token = "0x600028C")]
	private static void MeasureText_Injected(IntPtr _unity_self, in NativeTextGenerationSettings settings, IntPtr textGenerationInfo, out Vector2 ret) { }

	[Address(RVA = "0x31C04D0", Offset = "0x31BF8D0", Length = "0xCC0")]
	[Token(Token = "0x6000283")]
	public void ProcessMeshInfos(NativeTextInfo textInfo, NativeTextGenerationSettings settings, ref List<List`1<List`1<Int32>>>& textElementIndicesByMesh, ref List<Boolean>& hasMultipleColorsByMesh, bool uvsAreGenerated) { }

	[Address(RVA = "0x31C1200", Offset = "0x31C0600", Length = "0x69")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x6000284")]
	public void ShapeText(NativeTextGenerationSettings settings, IntPtr textGenerationInfo) { }

	[Address(RVA = "0x31C11A0", Offset = "0x31C05A0", Length = "0x52")]
	[Token(Token = "0x600028A")]
	private static void ShapeText_Injected(IntPtr _unity_self, in NativeTextGenerationSettings settings, IntPtr textGenerationInfo) { }

}

