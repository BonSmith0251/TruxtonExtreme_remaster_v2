namespace UnityEngine;

[NativeHeader("Runtime/Export/Math/Gradient.bindings.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000152")]
public class Gradient : IEquatable<Gradient>
{
	[Token(Token = "0x2000153")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x30465A0", Offset = "0x30459A0", Length = "0x58")]
		[Token(Token = "0x600102F")]
		public static Gradient ConvertToManaged(IntPtr ptr) { }

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x600102E")]
		public static IntPtr ConvertToNative(Gradient graident) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000586")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ParticleSystemModule"})]
	internal IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000587")]
	private bool m_RequiresNativeCleanup; //Field offset: 0x18

	[Token(Token = "0x17000286")]
	public GradientAlphaKey[] alphaKeys
	{
		[Address(RVA = "0x3048D00", Offset = "0x3048100", Length = "0xED")]
		[FreeFunction("Gradient_Bindings::GetAlphaKeysArray", IsThreadSafe = True, HasExplicitThis = True)]
		[Token(Token = "0x600101A")]
		 get { } //Length: 237
	}

	[Token(Token = "0x17000285")]
	public GradientColorKey[] colorKeys
	{
		[Address(RVA = "0x3048E40", Offset = "0x3048240", Length = "0xED")]
		[FreeFunction("Gradient_Bindings::GetColorKeysArray", IsThreadSafe = True, HasExplicitThis = True)]
		[Token(Token = "0x6001019")]
		 get { } //Length: 237
	}

	[NativeProperty(IsThreadSafe = True)]
	[Token(Token = "0x17000288")]
	public ColorSpace colorSpace
	{
		[Address(RVA = "0x3048F70", Offset = "0x3048370", Length = "0x51")]
		[Token(Token = "0x600101D")]
		 get { } //Length: 81
		[Address(RVA = "0x30490B0", Offset = "0x30484B0", Length = "0x58")]
		[Token(Token = "0x600101E")]
		 set { } //Length: 88
	}

	[NativeProperty(IsThreadSafe = True)]
	[Token(Token = "0x17000287")]
	public GradientMode mode
	{
		[Address(RVA = "0x3049010", Offset = "0x3048410", Length = "0x51")]
		[Token(Token = "0x600101B")]
		 get { } //Length: 81
		[Address(RVA = "0x3049150", Offset = "0x3048550", Length = "0x58")]
		[Token(Token = "0x600101C")]
		 set { } //Length: 88
	}

	[Address(RVA = "0x3048C40", Offset = "0x3048040", Length = "0x3F")]
	[RequiredByNativeCode]
	[Token(Token = "0x6001015")]
	public Gradient() { }

	[Address(RVA = "0x3048C80", Offset = "0x3048080", Length = "0x2A")]
	[Token(Token = "0x6001016")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ParticleSystemModule"})]
	internal Gradient(IntPtr ptr) { }

	[Address(RVA = "0x30483C0", Offset = "0x30477C0", Length = "0x51")]
	[FreeFunction(Name = "Gradient_Bindings::Cleanup", IsThreadSafe = True, HasExplicitThis = True)]
	[Token(Token = "0x6001013")]
	private void Cleanup() { }

	[Address(RVA = "0x3048380", Offset = "0x3047780", Length = "0x33")]
	[Token(Token = "0x6001024")]
	private static void Cleanup_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3048540", Offset = "0x3047940", Length = "0xD0")]
	[Token(Token = "0x6001022")]
	public override bool Equals(Gradient other) { }

	[Address(RVA = "0x3048420", Offset = "0x3047820", Length = "0x11F")]
	[Token(Token = "0x6001021")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x3048680", Offset = "0x3047A80", Length = "0x79")]
	[FreeFunction(Name = "Gradient_Bindings::Evaluate", IsThreadSafe = True, HasExplicitThis = True)]
	[Token(Token = "0x6001018")]
	public Color Evaluate(float time) { }

	[Address(RVA = "0x3048620", Offset = "0x3047A20", Length = "0x52")]
	[Token(Token = "0x6001026")]
	private static void Evaluate_Injected(IntPtr _unity_self, float time, out Color ret) { }

	[Address(RVA = "0x3048700", Offset = "0x3047B00", Length = "0x8B")]
	[Token(Token = "0x6001017")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x3048D00", Offset = "0x3048100", Length = "0xED")]
	[FreeFunction("Gradient_Bindings::GetAlphaKeysArray", IsThreadSafe = True, HasExplicitThis = True)]
	[Token(Token = "0x600101A")]
	public GradientAlphaKey[] get_alphaKeys() { }

	[Address(RVA = "0x3048CB0", Offset = "0x30480B0", Length = "0x42")]
	[Token(Token = "0x6001028")]
	private static void get_alphaKeys_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x3048E40", Offset = "0x3048240", Length = "0xED")]
	[FreeFunction("Gradient_Bindings::GetColorKeysArray", IsThreadSafe = True, HasExplicitThis = True)]
	[Token(Token = "0x6001019")]
	public GradientColorKey[] get_colorKeys() { }

	[Address(RVA = "0x3048DF0", Offset = "0x30481F0", Length = "0x42")]
	[Token(Token = "0x6001027")]
	private static void get_colorKeys_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x3048F70", Offset = "0x3048370", Length = "0x51")]
	[Token(Token = "0x600101D")]
	public ColorSpace get_colorSpace() { }

	[Address(RVA = "0x3048F30", Offset = "0x3048330", Length = "0x33")]
	[Token(Token = "0x600102B")]
	private static ColorSpace get_colorSpace_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3049010", Offset = "0x3048410", Length = "0x51")]
	[Token(Token = "0x600101B")]
	public GradientMode get_mode() { }

	[Address(RVA = "0x3048FD0", Offset = "0x30483D0", Length = "0x33")]
	[Token(Token = "0x6001029")]
	private static GradientMode get_mode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3048790", Offset = "0x3047B90", Length = "0xD")]
	[Token(Token = "0x6001023")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x30487A0", Offset = "0x3047BA0", Length = "0x2A")]
	[FreeFunction(Name = "Gradient_Bindings::Init", IsThreadSafe = True)]
	[Token(Token = "0x6001012")]
	private static IntPtr Init() { }

	[Address(RVA = "0x3048820", Offset = "0x3047C20", Length = "0x5A")]
	[FreeFunction("Gradient_Bindings::Internal_Equals", IsThreadSafe = True, HasExplicitThis = True)]
	[Token(Token = "0x6001014")]
	private bool Internal_Equals(IntPtr other) { }

	[Address(RVA = "0x30487D0", Offset = "0x3047BD0", Length = "0x42")]
	[Token(Token = "0x6001025")]
	private static bool Internal_Equals_Injected(IntPtr _unity_self, IntPtr other) { }

	[Address(RVA = "0x30490B0", Offset = "0x30484B0", Length = "0x58")]
	[Token(Token = "0x600101E")]
	public void set_colorSpace(ColorSpace value) { }

	[Address(RVA = "0x3049070", Offset = "0x3048470", Length = "0x40")]
	[Token(Token = "0x600102C")]
	private static void set_colorSpace_Injected(IntPtr _unity_self, ColorSpace value) { }

	[Address(RVA = "0x3049150", Offset = "0x3048550", Length = "0x58")]
	[Token(Token = "0x600101C")]
	public void set_mode(GradientMode value) { }

	[Address(RVA = "0x3049110", Offset = "0x3048510", Length = "0x40")]
	[Token(Token = "0x600102A")]
	private static void set_mode_Injected(IntPtr _unity_self, GradientMode value) { }

	[Address(RVA = "0x3048A20", Offset = "0x3047E20", Length = "0x217")]
	[Token(Token = "0x600101F")]
	public void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys) { }

	[Address(RVA = "0x30488E0", Offset = "0x3047CE0", Length = "0x13B")]
	[FreeFunction(Name = "Gradient_Bindings::SetKeysWithSpans", HasExplicitThis = True, IsThreadSafe = True)]
	[Token(Token = "0x6001020")]
	public void SetKeys(ReadOnlySpan<GradientColorKey> colorKeys, ReadOnlySpan<GradientAlphaKey> alphaKeys) { }

	[Address(RVA = "0x3048880", Offset = "0x3047C80", Length = "0x52")]
	[Token(Token = "0x600102D")]
	private static void SetKeys_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colorKeys, ref ManagedSpanWrapper alphaKeys) { }

}

