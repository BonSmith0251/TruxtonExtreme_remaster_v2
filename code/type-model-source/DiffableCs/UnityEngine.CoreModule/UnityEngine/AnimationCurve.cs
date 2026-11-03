namespace UnityEngine;

[DefaultMember("Item")]
[NativeHeader("Runtime/Math/AnimationCurve.bindings.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000092")]
public class AnimationCurve : IEquatable<AnimationCurve>
{
	[Token(Token = "0x2000093")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x2FCEE40", Offset = "0x2FCE240", Length = "0x58")]
		[Token(Token = "0x600027C")]
		public static AnimationCurve ConvertToManaged(IntPtr ptr) { }

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x600027D")]
		public static IntPtr ConvertToNative(AnimationCurve animationCurve) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000150")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ParticleSystemModule"})]
	internal IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000151")]
	private bool m_RequiresNativeCleanup; //Field offset: 0x18

	[Token(Token = "0x17000053")]
	public Keyframe Item
	{
		[Address(RVA = "0x2FCC830", Offset = "0x2FCBC30", Length = "0xAA")]
		[Token(Token = "0x6000260")]
		 get { } //Length: 170
	}

	[Token(Token = "0x17000052")]
	public Keyframe[] keys
	{
		[Address(RVA = "0x2FCC930", Offset = "0x2FCBD30", Length = "0xED")]
		[FreeFunction("AnimationCurveBindings::GetKeysArray", HasExplicitThis = True, IsThreadSafe = True)]
		[Token(Token = "0x6000258")]
		 get { } //Length: 237
		[Address(RVA = "0x2FCCB10", Offset = "0x2FCBF10", Length = "0xF8")]
		[FreeFunction("AnimationCurveBindings::SetKeysWithSpan", HasExplicitThis = True, IsThreadSafe = True)]
		[Token(Token = "0x6000259")]
		 set { } //Length: 248
	}

	[Token(Token = "0x17000054")]
	public int length
	{
		[Address(RVA = "0x2FCCA60", Offset = "0x2FCBE60", Length = "0x51")]
		[NativeMethod("GetKeyCount", IsThreadSafe = True)]
		[Token(Token = "0x6000261")]
		 get { } //Length: 81
	}

	[Address(RVA = "0x2FCC7F0", Offset = "0x2FCBBF0", Length = "0x34")]
	[Token(Token = "0x6000267")]
	public AnimationCurve(Keyframe[] keys) { }

	[Address(RVA = "0x2FCC780", Offset = "0x2FCBB80", Length = "0x27")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000268")]
	public AnimationCurve() { }

	[Address(RVA = "0x2FCC7B0", Offset = "0x2FCBBB0", Length = "0x38")]
	[Token(Token = "0x6000269")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.ParticleSystemModule"})]
	internal AnimationCurve(IntPtr ptr, bool ownMemory) { }

	[Address(RVA = "0x2FCB840", Offset = "0x2FCAC40", Length = "0x71")]
	[FreeFunction("AnimationCurveBindings::AddKeySmoothTangents", HasExplicitThis = True, IsThreadSafe = True)]
	[Token(Token = "0x600025A")]
	public int AddKey(float time, float value) { }

	[Address(RVA = "0x2FCB7C0", Offset = "0x2FCABC0", Length = "0x70")]
	[Token(Token = "0x600025B")]
	public int AddKey(Keyframe key) { }

	[Address(RVA = "0x2FCB6B0", Offset = "0x2FCAAB0", Length = "0x53")]
	[Token(Token = "0x6000273")]
	private static int AddKey_Injected(IntPtr _unity_self, float time, float value) { }

	[Address(RVA = "0x2FCB760", Offset = "0x2FCAB60", Length = "0x5A")]
	[NativeMethod("AddKey", IsThreadSafe = True)]
	[Token(Token = "0x600025C")]
	private int AddKey_Internal(Keyframe key) { }

	[Address(RVA = "0x2FCB710", Offset = "0x2FCAB10", Length = "0x42")]
	[Token(Token = "0x6000274")]
	private static int AddKey_Internal_Injected(IntPtr _unity_self, in Keyframe key) { }

	[Address(RVA = "0x2FCB900", Offset = "0x2FCAD00", Length = "0x51")]
	[FreeFunction("AnimationCurveBindings::ClearKeys", HasExplicitThis = True, IsThreadSafe = True)]
	[Token(Token = "0x600025E")]
	public void ClearKeys() { }

	[Address(RVA = "0x2FCB8C0", Offset = "0x2FCACC0", Length = "0x33")]
	[Token(Token = "0x6000276")]
	private static void ClearKeys_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FCB960", Offset = "0x2FCAD60", Length = "0x60")]
	[Token(Token = "0x600026C")]
	public void CopyFrom(AnimationCurve other) { }

	[Address(RVA = "0x2FCB9D0", Offset = "0x2FCADD0", Length = "0x1BE")]
	[Token(Token = "0x6000266")]
	public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	[Address(RVA = "0x2FCBC90", Offset = "0x2FCB090", Length = "0x17A")]
	[Token(Token = "0x600026A")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2FCBB90", Offset = "0x2FCAF90", Length = "0xF2")]
	[Token(Token = "0x600026B")]
	public override bool Equals(AnimationCurve other) { }

	[Address(RVA = "0x2FCBE60", Offset = "0x2FCB260", Length = "0x61")]
	[ThreadSafe]
	[Token(Token = "0x6000257")]
	public float Evaluate(float time) { }

	[Address(RVA = "0x2FCBE10", Offset = "0x2FCB210", Length = "0x43")]
	[Token(Token = "0x6000270")]
	private static float Evaluate_Injected(IntPtr _unity_self, float time) { }

	[Address(RVA = "0x2FCBED0", Offset = "0x2FCB2D0", Length = "0x7F")]
	[Token(Token = "0x6000256")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2FCC830", Offset = "0x2FCBC30", Length = "0xAA")]
	[Token(Token = "0x6000260")]
	public Keyframe get_Item(int index) { }

	[Address(RVA = "0x2FCC930", Offset = "0x2FCBD30", Length = "0xED")]
	[FreeFunction("AnimationCurveBindings::GetKeysArray", HasExplicitThis = True, IsThreadSafe = True)]
	[Token(Token = "0x6000258")]
	public Keyframe[] get_keys() { }

	[Address(RVA = "0x2FCC8E0", Offset = "0x2FCBCE0", Length = "0x42")]
	[Token(Token = "0x6000271")]
	private static void get_keys_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	[Address(RVA = "0x2FCCA60", Offset = "0x2FCBE60", Length = "0x51")]
	[NativeMethod("GetKeyCount", IsThreadSafe = True)]
	[Token(Token = "0x6000261")]
	public int get_length() { }

	[Address(RVA = "0x2FCCA20", Offset = "0x2FCBE20", Length = "0x33")]
	[Token(Token = "0x6000278")]
	private static int get_length_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FCBF90", Offset = "0x2FCB390", Length = "0x51")]
	[FreeFunction("AnimationCurveBindings::GetHashCode", HasExplicitThis = True, IsThreadSafe = True)]
	[Token(Token = "0x6000263")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2FCBF50", Offset = "0x2FCB350", Length = "0x33")]
	[Token(Token = "0x600027A")]
	private static int GetHashCode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x2FCC040", Offset = "0x2FCB440", Length = "0x80")]
	[FreeFunction("AnimationCurveBindings::GetKey", HasExplicitThis = True, IsThreadSafe = True)]
	[NativeThrows]
	[Token(Token = "0x6000262")]
	private Keyframe GetKey(int index) { }

	[Address(RVA = "0x2FCBFF0", Offset = "0x2FCB3F0", Length = "0x50")]
	[Token(Token = "0x6000279")]
	private static void GetKey_Injected(IntPtr _unity_self, int index, out Keyframe ret) { }

	[Address(RVA = "0x2FCC120", Offset = "0x2FCB520", Length = "0x5A")]
	[FreeFunction("AnimationCurveBindings::Internal_CopyFrom", HasExplicitThis = True, IsThreadSafe = True)]
	[Token(Token = "0x6000255")]
	private void Internal_CopyFrom(IntPtr other) { }

	[Address(RVA = "0x2FCC0D0", Offset = "0x2FCB4D0", Length = "0x42")]
	[Token(Token = "0x600026F")]
	private static void Internal_CopyFrom_Injected(IntPtr _unity_self, IntPtr other) { }

	[Address(RVA = "0x2FCC1C0", Offset = "0x2FCB5C0", Length = "0xBC")]
	[FreeFunction("AnimationCurveBindings::Internal_Create", IsThreadSafe = True)]
	[Token(Token = "0x6000253")]
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	[Address(RVA = "0x2FCC180", Offset = "0x2FCB580", Length = "0x33")]
	[Token(Token = "0x600026D")]
	private static IntPtr Internal_Create_Injected(ref ManagedSpanWrapper keys) { }

	[Address(RVA = "0x2FCC280", Offset = "0x2FCB680", Length = "0x33")]
	[FreeFunction("AnimationCurveBindings::Internal_Destroy", IsThreadSafe = True)]
	[Token(Token = "0x6000252")]
	private static void Internal_Destroy(IntPtr ptr) { }

	[Address(RVA = "0x2FCC310", Offset = "0x2FCB710", Length = "0x5A")]
	[FreeFunction("AnimationCurveBindings::Internal_Equals", HasExplicitThis = True, IsThreadSafe = True)]
	[Token(Token = "0x6000254")]
	private bool Internal_Equals(IntPtr other) { }

	[Address(RVA = "0x2FCC2C0", Offset = "0x2FCB6C0", Length = "0x42")]
	[Token(Token = "0x600026E")]
	private static bool Internal_Equals_Injected(IntPtr _unity_self, IntPtr other) { }

	[Address(RVA = "0x2FCC370", Offset = "0x2FCB770", Length = "0x1EF")]
	[Token(Token = "0x6000265")]
	public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	[Address(RVA = "0x2FCC5B0", Offset = "0x2FCB9B0", Length = "0x67")]
	[FreeFunction("AnimationCurveBindings::MoveKey", HasExplicitThis = True, IsThreadSafe = True)]
	[NativeThrows]
	[Token(Token = "0x600025D")]
	public int MoveKey(int index, Keyframe key) { }

	[Address(RVA = "0x2FCC560", Offset = "0x2FCB960", Length = "0x50")]
	[Token(Token = "0x6000275")]
	private static int MoveKey_Injected(IntPtr _unity_self, int index, in Keyframe key) { }

	[Address(RVA = "0x2FCC660", Offset = "0x2FCBA60", Length = "0x58")]
	[FreeFunction("AnimationCurveBindings::RemoveKey", HasExplicitThis = True, IsThreadSafe = True)]
	[NativeThrows]
	[Token(Token = "0x600025F")]
	public void RemoveKey(int index) { }

	[Address(RVA = "0x2FCC620", Offset = "0x2FCBA20", Length = "0x40")]
	[Token(Token = "0x6000277")]
	private static void RemoveKey_Injected(IntPtr _unity_self, int index) { }

	[Address(RVA = "0x2FCCB10", Offset = "0x2FCBF10", Length = "0xF8")]
	[FreeFunction("AnimationCurveBindings::SetKeysWithSpan", HasExplicitThis = True, IsThreadSafe = True)]
	[Token(Token = "0x6000259")]
	public void set_keys(Keyframe[] value) { }

	[Address(RVA = "0x2FCCAC0", Offset = "0x2FCBEC0", Length = "0x42")]
	[Token(Token = "0x6000272")]
	private static void set_keys_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	[Address(RVA = "0x2FCC710", Offset = "0x2FCBB10", Length = "0x68")]
	[FreeFunction("AnimationCurveBindings::SmoothTangents", HasExplicitThis = True, IsThreadSafe = True)]
	[NativeThrows]
	[Token(Token = "0x6000264")]
	public void SmoothTangents(int index, float weight) { }

	[Address(RVA = "0x2FCC6C0", Offset = "0x2FCBAC0", Length = "0x50")]
	[Token(Token = "0x600027B")]
	private static void SmoothTangents_Injected(IntPtr _unity_self, int index, float weight) { }

}

