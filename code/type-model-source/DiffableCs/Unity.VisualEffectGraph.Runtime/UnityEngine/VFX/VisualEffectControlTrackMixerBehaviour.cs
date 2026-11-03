namespace UnityEngine.VFX;

[Token(Token = "0x2000039")]
internal class VisualEffectControlTrackMixerBehaviour : PlayableBehaviour
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000C6")]
	private VisualEffectControlTrackController m_ScrubbingCacheHelper; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000C7")]
	private VisualEffect m_Target; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000C8")]
	private bool m_ReinitWithBinding; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x40000C9")]
	private bool m_ReinitWithUnbinding; //Field offset: 0x21

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60000B0")]
	public VisualEffectControlTrackMixerBehaviour() { }

	[Address(RVA = "0x2F7C970", Offset = "0x2F7BD70", Length = "0x1F4")]
	[Token(Token = "0x60000A8")]
	private void ApplyFrame(Playable playable, FrameData data) { }

	[Address(RVA = "0x2F7CB70", Offset = "0x2F7BF70", Length = "0x8F")]
	[Token(Token = "0x60000A9")]
	private void BindVFX(VisualEffect vfx) { }

	[Address(RVA = "0x2F7CC00", Offset = "0x2F7C000", Length = "0x9")]
	[Token(Token = "0x60000A7")]
	public void Init(VisualEffectControlTrack parentTrack, bool reinitWithBinding, bool reinitWithUnbinding) { }

	[Address(RVA = "0x2F7CC10", Offset = "0x2F7C010", Length = "0xCC")]
	[Token(Token = "0x60000AD")]
	private void InvalidateScrubbingHelper() { }

	[Address(RVA = "0x2F7CCE0", Offset = "0x2F7C0E0", Length = "0xBA")]
	[Token(Token = "0x60000AC")]
	public virtual void OnBehaviourPause(Playable playable, FrameData data) { }

	[Address(RVA = "0x2F7CDA0", Offset = "0x2F7C1A0", Length = "0x7")]
	[Token(Token = "0x60000AE")]
	public virtual void OnPlayableCreate(Playable playable) { }

	[Address(RVA = "0x2F7CDB0", Offset = "0x2F7C1B0", Length = "0x1F")]
	[Token(Token = "0x60000AF")]
	public virtual void OnPlayableDestroy(Playable playable) { }

	[Address(RVA = "0x2F7CDD0", Offset = "0x2F7C1D0", Length = "0x24E")]
	[Token(Token = "0x60000AB")]
	public virtual void PrepareFrame(Playable playable, FrameData data) { }

	[Address(RVA = "0x2F7D020", Offset = "0x2F7C420", Length = "0x8E")]
	[Token(Token = "0x60000AA")]
	private void UnbindVFX() { }

}

