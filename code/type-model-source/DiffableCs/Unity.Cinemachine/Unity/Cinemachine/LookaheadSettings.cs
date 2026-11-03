namespace Unity.Cinemachine;

[Token(Token = "0x20000D5")]
public struct LookaheadSettings
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400032D")]
	public bool Enabled; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Range(0, 1)]
	[Token(Token = "0x400032E")]
	[Tooltip("Predict the position this many seconds into the future.  Note that this setting is sensitive to noisy animation, and can amplify the noise, resulting in undesirable jitter.  If the camera jitters unacceptably when the target is in motion, turn down this setting, or animate the target more smoothly.")]
	public float Time; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Range(0, 30)]
	[Token(Token = "0x400032F")]
	[Tooltip("Controls the smoothness of the lookahead algorithm.  Larger values smooth out jittery predictions and also increase prediction lag")]
	public float Smoothing; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000330")]
	[Tooltip("If checked, movement along the Y axis will be ignored for lookahead calculations")]
	public bool IgnoreY; //Field offset: 0xC

}

