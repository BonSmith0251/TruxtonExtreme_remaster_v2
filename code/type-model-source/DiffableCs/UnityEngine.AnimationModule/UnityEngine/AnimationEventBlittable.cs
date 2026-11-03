namespace UnityEngine;

[RequiredByNativeCode]
[Token(Token = "0x2000009")]
internal struct AnimationEventBlittable : IDisposable
{
	[ThreadStatic]
	[Token(Token = "0x4000015")]
	private static GCHandlePool s_handlePool; //Field offset: 0x80000000
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000A")]
	internal float m_Time; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400000B")]
	internal IntPtr m_FunctionName; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000C")]
	internal IntPtr m_StringParameter; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400000D")]
	internal IntPtr m_ObjectReferenceParameter; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000E")]
	internal float m_FloatParameter; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400000F")]
	internal int m_IntParameter; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000010")]
	internal int m_MessageOptions; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000011")]
	internal AnimationEventSource m_Source; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000012")]
	internal IntPtr m_StateSender; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000013")]
	internal AnimatorStateInfo m_AnimatorStateInfo; //Field offset: 0x38
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000014")]
	internal AnimatorClipInfo m_AnimatorClipInfo; //Field offset: 0x5C

	[Address(RVA = "0x2FAF8E0", Offset = "0x2FAECE0", Length = "0x15A")]
	[Token(Token = "0x6000027")]
	public override void Dispose() { }

	[Address(RVA = "0x2FAF870", Offset = "0x2FAEC70", Length = "0x6A")]
	[Token(Token = "0x6000024")]
	internal static void DisposeEvents(IntPtr animationEventBlittableArray, int size) { }

	[Address(RVA = "0x2FAFA40", Offset = "0x2FAEE40", Length = "0x33")]
	[FreeFunction(Name = "AnimationClipBindings::FreeEventsInternal")]
	[Token(Token = "0x6000025")]
	private static void FreeEventsInternal(IntPtr value) { }

	[Address(RVA = "0x2FAFA80", Offset = "0x2FAEE80", Length = "0x257")]
	[Token(Token = "0x6000020")]
	internal static AnimationEventBlittable FromAnimationEvent(AnimationEvent animationEvent) { }

	[Address(RVA = "0x2FAFCE0", Offset = "0x2FAF0E0", Length = "0x216")]
	[Token(Token = "0x6000021")]
	internal static void FromAnimationEvents(AnimationEvent[] animationEvents, AnimationEventBlittable* animationEventBlittables) { }

	[Address(RVA = "0x2FAFF00", Offset = "0x2FAF300", Length = "0x65")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000022")]
	internal static AnimationEvent PointerToAnimationEvent(IntPtr animationEventBlittable) { }

	[Address(RVA = "0x2FAFF70", Offset = "0x2FAF370", Length = "0x136")]
	[Token(Token = "0x6000023")]
	internal static AnimationEvent[] PointerToAnimationEvents(IntPtr animationEventBlittableArray, int size) { }

	[Address(RVA = "0x2FB00B0", Offset = "0x2FAF4B0", Length = "0x4C9")]
	[Token(Token = "0x6000026")]
	internal static AnimationEvent ToAnimationEvent(AnimationEventBlittable animationEventBlittable) { }

}

