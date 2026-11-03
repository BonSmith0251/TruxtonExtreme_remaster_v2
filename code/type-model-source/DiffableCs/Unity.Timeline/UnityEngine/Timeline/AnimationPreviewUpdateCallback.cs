namespace UnityEngine.Timeline;

[Token(Token = "0x200000F")]
internal class AnimationPreviewUpdateCallback : ITimelineEvaluateCallback
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002D")]
	private AnimationPlayableOutput m_Output; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400002E")]
	private PlayableGraph m_Graph; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400002F")]
	private List<IAnimationWindowPreview> m_PreviewComponents; //Field offset: 0x30

	[Address(RVA = "0x2F23830", Offset = "0x2F22C30", Length = "0xCA")]
	[Token(Token = "0x6000045")]
	public AnimationPreviewUpdateCallback(AnimationPlayableOutput output) { }

	[Address(RVA = "0x2F234C0", Offset = "0x2F228C0", Length = "0x255")]
	[Token(Token = "0x6000046")]
	public override void Evaluate() { }

	[Address(RVA = "0x2F23720", Offset = "0x2F22B20", Length = "0x109")]
	[Token(Token = "0x6000047")]
	private void FetchPreviewComponents() { }

}

