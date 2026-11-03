namespace UnityEngine.Timeline;

[Token(Token = "0x2000008")]
internal class AnimationOutputWeightProcessor : ITimelineEvaluateCallback
{
	[Token(Token = "0x2000009")]
	private struct WeightInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000013")]
		public Playable mixer; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000014")]
		public Playable parentMixer; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000015")]
		public int port; //Field offset: 0x20

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000010")]
	private AnimationPlayableOutput m_Output; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000011")]
	private AnimationMotionXToDeltaPlayable m_MotionXPlayable; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000012")]
	private readonly List<WeightInfo> m_Mixers; //Field offset: 0x30

	[Address(RVA = "0x2F22330", Offset = "0x2F21730", Length = "0x19B")]
	[Token(Token = "0x6000014")]
	public AnimationOutputWeightProcessor(AnimationPlayableOutput output) { }

	[Address(RVA = "0x2F21DA0", Offset = "0x2F211A0", Length = "0x15E")]
	[Token(Token = "0x6000017")]
	public override void Evaluate() { }

	[Address(RVA = "0x2F21F00", Offset = "0x2F21300", Length = "0x108")]
	[Token(Token = "0x6000015")]
	private void FindMixers() { }

	[Address(RVA = "0x2F22010", Offset = "0x2F21410", Length = "0x313")]
	[Token(Token = "0x6000016")]
	private void FindMixers(Playable parent, int port, Playable node) { }

}

