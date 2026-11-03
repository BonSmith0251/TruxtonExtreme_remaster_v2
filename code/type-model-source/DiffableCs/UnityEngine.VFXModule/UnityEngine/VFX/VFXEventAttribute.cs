namespace UnityEngine.VFX;

[NativeType(Header = "Modules/VFX/Public/VFXEventAttribute.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000004")]
public sealed class VFXEventAttribute : IDisposable
{
	[Token(Token = "0x2000005")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x347FE30", Offset = "0x347F230", Length = "0x54")]
		[Token(Token = "0x600002C")]
		public static VFXEventAttribute ConvertToManaged(IntPtr ptr) { }

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x600002B")]
		public static IntPtr ConvertToNative(VFXEventAttribute eventAttibute) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000A")]
	private IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400000B")]
	private bool m_Owner; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000C")]
	private VisualEffectAsset m_VfxAsset; //Field offset: 0x20

	[Token(Token = "0x17000001")]
	internal VisualEffectAsset vfxAsset
	{
		[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
		[Token(Token = "0x6000009")]
		internal get { } //Length: 7
	}

	[Address(RVA = "0x3480D70", Offset = "0x3480170", Length = "0x54")]
	[Token(Token = "0x6000001")]
	private VFXEventAttribute(IntPtr ptr, bool owner, VisualEffectAsset vfxAsset) { }

	[Address(RVA = "0x2B7F420", Offset = "0x2B7E820", Length = "0x26")]
	[Token(Token = "0x6000002")]
	private VFXEventAttribute(IntPtr ptr) { }

	[Address(RVA = "0x3480DD0", Offset = "0x34801D0", Length = "0x2D")]
	[Token(Token = "0x6000003")]
	private VFXEventAttribute() { }

	[Address(RVA = "0x347FE90", Offset = "0x347F290", Length = "0x5C")]
	[Token(Token = "0x6000004")]
	internal static VFXEventAttribute CreateEventAttributeWrapper() { }

	[Address(RVA = "0x347FEF0", Offset = "0x347F2F0", Length = "0x9D")]
	[Token(Token = "0x600000C")]
	public override void Dispose() { }

	[Address(RVA = "0x347FF90", Offset = "0x347F390", Length = "0xB1")]
	[Token(Token = "0x600000B")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2F8BCC0", Offset = "0x2F8B0C0", Length = "0x7")]
	[Token(Token = "0x6000009")]
	internal VisualEffectAsset get_vfxAsset() { }

	[Address(RVA = "0x3480090", Offset = "0x347F490", Length = "0x58")]
	[NativeName("HasValueFromScript<bool>")]
	[Token(Token = "0x600000E")]
	public bool HasBool(int nameID) { }

	[Address(RVA = "0x3480050", Offset = "0x347F450", Length = "0x40")]
	[Token(Token = "0x600001D")]
	private static bool HasBool_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3480130", Offset = "0x347F530", Length = "0x58")]
	[NativeName("HasValueFromScript<float>")]
	[Token(Token = "0x6000011")]
	public bool HasFloat(int nameID) { }

	[Address(RVA = "0x34800F0", Offset = "0x347F4F0", Length = "0x40")]
	[Token(Token = "0x6000020")]
	private static bool HasFloat_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x34801D0", Offset = "0x347F5D0", Length = "0x58")]
	[NativeName("HasValueFromScript<int>")]
	[Token(Token = "0x600000F")]
	public bool HasInt(int nameID) { }

	[Address(RVA = "0x3480190", Offset = "0x347F590", Length = "0x40")]
	[Token(Token = "0x600001E")]
	private static bool HasInt_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3480270", Offset = "0x347F670", Length = "0x58")]
	[NativeName("HasValueFromScript<UInt32>")]
	[Token(Token = "0x6000010")]
	public bool HasUint(int nameID) { }

	[Address(RVA = "0x3480230", Offset = "0x347F630", Length = "0x40")]
	[Token(Token = "0x600001F")]
	private static bool HasUint_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3480310", Offset = "0x347F710", Length = "0x58")]
	[NativeName("HasValueFromScript<Vector2f>")]
	[Token(Token = "0x6000012")]
	public bool HasVector2(int nameID) { }

	[Address(RVA = "0x34802D0", Offset = "0x347F6D0", Length = "0x40")]
	[Token(Token = "0x6000021")]
	private static bool HasVector2_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x34803B0", Offset = "0x347F7B0", Length = "0x58")]
	[NativeName("HasValueFromScript<Vector3f>")]
	[Token(Token = "0x6000013")]
	public bool HasVector3(int nameID) { }

	[Address(RVA = "0x3480370", Offset = "0x347F770", Length = "0x40")]
	[Token(Token = "0x6000022")]
	private static bool HasVector3_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3480450", Offset = "0x347F850", Length = "0x58")]
	[NativeName("HasValueFromScript<Vector4f>")]
	[Token(Token = "0x6000014")]
	public bool HasVector4(int nameID) { }

	[Address(RVA = "0x3480410", Offset = "0x347F810", Length = "0x40")]
	[Token(Token = "0x6000023")]
	private static bool HasVector4_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x34804B0", Offset = "0x347F8B0", Length = "0x2A")]
	[Token(Token = "0x6000006")]
	internal static IntPtr Internal_Create() { }

	[Address(RVA = "0x34804E0", Offset = "0x347F8E0", Length = "0x33")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x600000D")]
	internal static void Internal_Destroy(IntPtr ptr) { }

	[Address(RVA = "0x3480570", Offset = "0x347F970", Length = "0xAE")]
	[Token(Token = "0x6000008")]
	internal void Internal_InitFromAsset(VisualEffectAsset vfxAsset) { }

	[Address(RVA = "0x3480520", Offset = "0x347F920", Length = "0x42")]
	[Token(Token = "0x600001C")]
	private static void Internal_InitFromAsset_Injected(IntPtr _unity_self, IntPtr vfxAsset) { }

	[Address(RVA = "0x3480620", Offset = "0x347FA20", Length = "0x115")]
	[Token(Token = "0x6000007")]
	internal static VFXEventAttribute Internal_InstanciateVFXEventAttribute(VisualEffectAsset vfxAsset) { }

	[Address(RVA = "0x3480740", Offset = "0x347FB40", Length = "0x62")]
	[Token(Token = "0x600000A")]
	private void Release() { }

	[Address(RVA = "0x3480810", Offset = "0x347FC10", Length = "0x69")]
	[NativeName("SetValueFromScript<bool>")]
	[Token(Token = "0x6000015")]
	public void SetBool(int nameID, bool b) { }

	[Address(RVA = "0x34807B0", Offset = "0x347FBB0", Length = "0x52")]
	[Token(Token = "0x6000024")]
	private static void SetBool_Injected(IntPtr _unity_self, int nameID, bool b) { }

	[Address(RVA = "0x34808D0", Offset = "0x347FCD0", Length = "0x68")]
	[NativeName("SetValueFromScript<float>")]
	[Token(Token = "0x6000018")]
	public void SetFloat(int nameID, float f) { }

	[Address(RVA = "0x3480880", Offset = "0x347FC80", Length = "0x50")]
	[Token(Token = "0x6000027")]
	private static void SetFloat_Injected(IntPtr _unity_self, int nameID, float f) { }

	[Address(RVA = "0x3480990", Offset = "0x347FD90", Length = "0x67")]
	[NativeName("SetValueFromScript<int>")]
	[Token(Token = "0x6000016")]
	public void SetInt(int nameID, int i) { }

	[Address(RVA = "0x3480940", Offset = "0x347FD40", Length = "0x50")]
	[Token(Token = "0x6000025")]
	private static void SetInt_Injected(IntPtr _unity_self, int nameID, int i) { }

	[Address(RVA = "0x3480A50", Offset = "0x347FE50", Length = "0x67")]
	[NativeName("SetValueFromScript<UInt32>")]
	[Token(Token = "0x6000017")]
	public void SetUint(int nameID, uint i) { }

	[Address(RVA = "0x3480A00", Offset = "0x347FE00", Length = "0x50")]
	[Token(Token = "0x6000026")]
	private static void SetUint_Injected(IntPtr _unity_self, int nameID, uint i) { }

	[Address(RVA = "0x3480B10", Offset = "0x347FF10", Length = "0x62")]
	[NativeName("SetValueFromScript<Vector2f>")]
	[Token(Token = "0x6000019")]
	public void SetVector2(int nameID, Vector2 v) { }

	[Address(RVA = "0x3480AC0", Offset = "0x347FEC0", Length = "0x50")]
	[Token(Token = "0x6000028")]
	private static void SetVector2_Injected(IntPtr _unity_self, int nameID, in Vector2 v) { }

	[Address(RVA = "0x3480BD0", Offset = "0x347FFD0", Length = "0x67")]
	[NativeName("SetValueFromScript<Vector3f>")]
	[Token(Token = "0x600001A")]
	public void SetVector3(int nameID, Vector3 v) { }

	[Address(RVA = "0x3480B80", Offset = "0x347FF80", Length = "0x50")]
	[Token(Token = "0x6000029")]
	private static void SetVector3_Injected(IntPtr _unity_self, int nameID, in Vector3 v) { }

	[Address(RVA = "0x3480C90", Offset = "0x3480090", Length = "0x67")]
	[NativeName("SetValueFromScript<Vector4f>")]
	[Token(Token = "0x600001B")]
	public void SetVector4(int nameID, Vector4 v) { }

	[Address(RVA = "0x3480C40", Offset = "0x3480040", Length = "0x50")]
	[Token(Token = "0x600002A")]
	private static void SetVector4_Injected(IntPtr _unity_self, int nameID, in Vector4 v) { }

	[Address(RVA = "0x3480D00", Offset = "0x3480100", Length = "0x65")]
	[Token(Token = "0x6000005")]
	internal void SetWrapValue(IntPtr ptrToEventAttribute) { }

}

