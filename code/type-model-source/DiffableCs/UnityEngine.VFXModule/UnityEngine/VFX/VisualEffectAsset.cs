namespace UnityEngine.VFX;

[NativeHeader("VFXScriptingClasses.h")]
[NativeHeader("Modules/VFX/Public/VisualEffectAsset.h")]
[Token(Token = "0x2000012")]
[UsedByNativeCode]
public class VisualEffectAsset : VisualEffectObject
{
	[Token(Token = "0x4000027")]
	public const string PlayEventName = "OnPlay"; //Field offset: 0x0
	[Token(Token = "0x4000028")]
	public const string StopEventName = "OnStop"; //Field offset: 0x0
	[Token(Token = "0x4000029")]
	public static readonly int PlayEventID; //Field offset: 0x0
	[Token(Token = "0x400002A")]
	public static readonly int StopEventID; //Field offset: 0x4

	[Address(RVA = "0x34832C0", Offset = "0x34826C0", Length = "0x7A")]
	[Token(Token = "0x600007A")]
	private static VisualEffectAsset() { }

	[Address(RVA = "0x3483340", Offset = "0x3482740", Length = "0x49")]
	[Token(Token = "0x6000079")]
	public VisualEffectAsset() { }

	[Address(RVA = "0x3482800", Offset = "0x3481C00", Length = "0xC8")]
	[FreeFunction(Name = "VisualEffectAssetBindings::GetEvents", HasExplicitThis = True)]
	[Token(Token = "0x6000071")]
	public void GetEvents(List<String> names) { }

	[Address(RVA = "0x34827B0", Offset = "0x3481BB0", Length = "0x42")]
	[Token(Token = "0x600007E")]
	private static void GetEvents_Injected(IntPtr _unity_self, List<String> names) { }

	[Address(RVA = "0x3482920", Offset = "0x3481D20", Length = "0xC8")]
	[FreeFunction(Name = "VisualEffectAssetBindings::GetExposedProperties", HasExplicitThis = True)]
	[Token(Token = "0x6000070")]
	public void GetExposedProperties(List<VFXExposedProperty> exposedProperties) { }

	[Address(RVA = "0x34828D0", Offset = "0x3481CD0", Length = "0x42")]
	[Token(Token = "0x600007D")]
	private static void GetExposedProperties_Injected(IntPtr _unity_self, List<VFXExposedProperty> exposedProperties) { }

	[Address(RVA = "0x3482A30", Offset = "0x3481E30", Length = "0xB1")]
	[Token(Token = "0x6000078")]
	public VFXSpace GetExposedSpace(string name) { }

	[Address(RVA = "0x3482AF0", Offset = "0x3481EF0", Length = "0xA4")]
	[FreeFunction(Name = "VisualEffectAssetBindings::GetExposedSpace", HasExplicitThis = True)]
	[Token(Token = "0x600006F")]
	public VFXSpace GetExposedSpace(int nameID) { }

	[Address(RVA = "0x34829F0", Offset = "0x3481DF0", Length = "0x40")]
	[Token(Token = "0x600007C")]
	private static VFXSpace GetExposedSpace_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3482BF0", Offset = "0x3481FF0", Length = "0xC8")]
	[FreeFunction(Name = "VisualEffectAssetBindings::GetOutputEventNamesFromScript", HasExplicitThis = True)]
	[Token(Token = "0x6000075")]
	internal void GetOutputEventNames(List<String> names) { }

	[Address(RVA = "0x3482BA0", Offset = "0x3481FA0", Length = "0x42")]
	[Token(Token = "0x6000082")]
	private static void GetOutputEventNames_Injected(IntPtr _unity_self, List<String> names) { }

	[Address(RVA = "0x3482D10", Offset = "0x3482110", Length = "0xC8")]
	[FreeFunction(Name = "VisualEffectAssetBindings::GetParticleSystemNamesFromScript", HasExplicitThis = True)]
	[Token(Token = "0x6000074")]
	internal void GetParticleSystemNames(List<String> names) { }

	[Address(RVA = "0x3482CC0", Offset = "0x34820C0", Length = "0x42")]
	[Token(Token = "0x6000081")]
	private static void GetParticleSystemNames_Injected(IntPtr _unity_self, List<String> names) { }

	[Address(RVA = "0x3482E30", Offset = "0x3482230", Length = "0xC8")]
	[FreeFunction(Name = "VisualEffectAssetBindings::GetSpawnSystemNamesFromScript", HasExplicitThis = True)]
	[Token(Token = "0x6000076")]
	internal void GetSpawnSystemNames(List<String> names) { }

	[Address(RVA = "0x3482DE0", Offset = "0x34821E0", Length = "0x42")]
	[Token(Token = "0x6000083")]
	private static void GetSpawnSystemNames_Injected(IntPtr _unity_self, List<String> names) { }

	[Address(RVA = "0x3482F50", Offset = "0x3482350", Length = "0xC8")]
	[FreeFunction(Name = "VisualEffectAssetBindings::GetSystemNamesFromScript", HasExplicitThis = True)]
	[Token(Token = "0x6000073")]
	internal void GetSystemNames(List<String> names) { }

	[Address(RVA = "0x3482F00", Offset = "0x3482300", Length = "0x42")]
	[Token(Token = "0x6000080")]
	private static void GetSystemNames_Injected(IntPtr _unity_self, List<String> names) { }

	[Address(RVA = "0x3483060", Offset = "0x3482460", Length = "0xB1")]
	[Token(Token = "0x6000077")]
	public TextureDimension GetTextureDimension(string name) { }

	[Address(RVA = "0x3483120", Offset = "0x3482520", Length = "0xA4")]
	[FreeFunction(Name = "VisualEffectAssetBindings::GetTextureDimension", HasExplicitThis = True)]
	[Token(Token = "0x600006E")]
	public TextureDimension GetTextureDimension(int nameID) { }

	[Address(RVA = "0x3483020", Offset = "0x3482420", Length = "0x40")]
	[Token(Token = "0x600007B")]
	private static TextureDimension GetTextureDimension_Injected(IntPtr _unity_self, int nameID) { }

	[Address(RVA = "0x3483210", Offset = "0x3482610", Length = "0xA4")]
	[FreeFunction(Name = "VisualEffectAssetBindings::HasSystemFromScript", HasExplicitThis = True)]
	[Token(Token = "0x6000072")]
	internal bool HasSystem(int nameID) { }

	[Address(RVA = "0x34831D0", Offset = "0x34825D0", Length = "0x40")]
	[Token(Token = "0x600007F")]
	private static bool HasSystem_Injected(IntPtr _unity_self, int nameID) { }

}

