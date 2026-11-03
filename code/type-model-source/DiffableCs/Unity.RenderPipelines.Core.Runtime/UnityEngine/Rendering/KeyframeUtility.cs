namespace UnityEngine.Rendering;

[Token(Token = "0x20001F0")]
public class KeyframeUtility
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000EC1")]
	public KeyframeUtility() { }

	[Address(RVA = "0x2C5F1F0", Offset = "0x2C5E5F0", Length = "0x1FE")]
	[Token(Token = "0x6000EBE")]
	private static void EvalCurveSegmentAndDeriv(out float dstValue, out float dstDeriv, Keyframe lhsKey, Keyframe rhsKey, float desiredTime) { }

	[Address(RVA = "0x2C5F3F0", Offset = "0x2C5E7F0", Length = "0x172")]
	[Token(Token = "0x6000EBF")]
	private static Keyframe EvalKeyAtTime(NativeArray<Keyframe> keys, int lhsIndex, int rhsIndex, float startTime, float endTime, float currTime) { }

	[Address(RVA = "0x2C5F570", Offset = "0x2C5E970", Length = "0x1A8")]
	[Token(Token = "0x6000EBD")]
	private static Keyframe FetchKeyFromIndexClampEdge(NativeArray<Keyframe> keys, int index, float segmentStartTime, float segmentEndTime) { }

	[Address(RVA = "0x2C5F720", Offset = "0x2C5EB20", Length = "0x122")]
	[Token(Token = "0x6000EBC")]
	private static Keyframe GetKeyframeAndClampEdge(NativeArray<Keyframe> keys, int index) { }

	[Address(RVA = "0x2C5F850", Offset = "0x2C5EC50", Length = "0x721")]
	[Token(Token = "0x6000EC0")]
	public static void InterpAnimationCurve(ref AnimationCurve lhsAndResultCurve, AnimationCurve rhsCurve, float t) { }

	[Address(RVA = "0x2C5FF80", Offset = "0x2C5F380", Length = "0x24F")]
	[Token(Token = "0x6000EBB")]
	private static Keyframe LerpSingleKeyframe(Keyframe lhs, Keyframe rhs, float t) { }

	[Address(RVA = "0x2C601D0", Offset = "0x2C5F5D0", Length = "0x19")]
	[Token(Token = "0x6000EBA")]
	public static void ResetAnimationCurve(AnimationCurve curve) { }

}

