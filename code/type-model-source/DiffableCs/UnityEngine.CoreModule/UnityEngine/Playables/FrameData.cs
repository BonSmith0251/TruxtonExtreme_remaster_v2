namespace UnityEngine.Playables;

[Token(Token = "0x2000312")]
public struct FrameData
{
	[Token(Token = "0x2000314")]
	internal enum EvaluationType : int
	{
		Evaluate = 0,
		Playback = 1,
	}

	[Flags]
	[Token(Token = "0x2000313")]
	public enum Flags : int
	{
		Evaluate = 1,
		SeekOccured = 2,
		Loop = 4,
		Hold = 8,
		EffectivePlayStateDelayed = 16,
		EffectivePlayStatePlaying = 32,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400080E")]
	internal ulong m_FrameID; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400080F")]
	internal double m_DeltaTime; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000810")]
	internal float m_Weight; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000811")]
	internal float m_EffectiveWeight; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000812")]
	internal double m_EffectiveParentDelay; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000813")]
	internal float m_EffectiveParentSpeed; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000814")]
	internal float m_EffectiveSpeed; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000815")]
	internal Flags m_Flags; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000816")]
	internal PlayableOutput m_Output; //Field offset: 0x30

	[Token(Token = "0x170003A0")]
	public float deltaTime
	{
		[Address(RVA = "0x3078A20", Offset = "0x3077E20", Length = "0xC")]
		[Token(Token = "0x60018DE")]
		 get { } //Length: 12
	}

	[Token(Token = "0x170003A8")]
	public PlayState effectivePlayState
	{
		[Address(RVA = "0x3078A30", Offset = "0x3077E30", Length = "0x19")]
		[Token(Token = "0x60018E6")]
		 get { } //Length: 25
	}

	[Token(Token = "0x170003A2")]
	public float effectiveSpeed
	{
		[Address(RVA = "0x3076950", Offset = "0x3075D50", Length = "0x8")]
		[Token(Token = "0x60018E0")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170003A1")]
	public float effectiveWeight
	{
		[Address(RVA = "0x199AC40", Offset = "0x199A040", Length = "0x8")]
		[Token(Token = "0x60018DF")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170003A3")]
	public EvaluationType evaluationType
	{
		[Address(RVA = "0x3078A50", Offset = "0x3077E50", Length = "0xB")]
		[Token(Token = "0x60018E1")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170003A7")]
	public PlayableOutput output
	{
		[Address(RVA = "0x3078A60", Offset = "0x3077E60", Length = "0xB")]
		[Token(Token = "0x60018E5")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170003A4")]
	public bool seekOccurred
	{
		[Address(RVA = "0x3078A70", Offset = "0x3077E70", Length = "0xA")]
		[Token(Token = "0x60018E2")]
		 get { } //Length: 10
	}

	[Token(Token = "0x170003A6")]
	public bool timeHeld
	{
		[Address(RVA = "0x3078A80", Offset = "0x3077E80", Length = "0xB")]
		[Token(Token = "0x60018E4")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170003A5")]
	public bool timeLooped
	{
		[Address(RVA = "0x3078A90", Offset = "0x3077E90", Length = "0xB")]
		[Token(Token = "0x60018E3")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x3078A20", Offset = "0x3077E20", Length = "0xC")]
	[Token(Token = "0x60018DE")]
	public float get_deltaTime() { }

	[Address(RVA = "0x3078A30", Offset = "0x3077E30", Length = "0x19")]
	[Token(Token = "0x60018E6")]
	public PlayState get_effectivePlayState() { }

	[Address(RVA = "0x3076950", Offset = "0x3075D50", Length = "0x8")]
	[Token(Token = "0x60018E0")]
	public float get_effectiveSpeed() { }

	[Address(RVA = "0x199AC40", Offset = "0x199A040", Length = "0x8")]
	[Token(Token = "0x60018DF")]
	public float get_effectiveWeight() { }

	[Address(RVA = "0x3078A50", Offset = "0x3077E50", Length = "0xB")]
	[Token(Token = "0x60018E1")]
	public EvaluationType get_evaluationType() { }

	[Address(RVA = "0x3078A60", Offset = "0x3077E60", Length = "0xB")]
	[Token(Token = "0x60018E5")]
	public PlayableOutput get_output() { }

	[Address(RVA = "0x3078A70", Offset = "0x3077E70", Length = "0xA")]
	[Token(Token = "0x60018E2")]
	public bool get_seekOccurred() { }

	[Address(RVA = "0x3078A80", Offset = "0x3077E80", Length = "0xB")]
	[Token(Token = "0x60018E4")]
	public bool get_timeHeld() { }

	[Address(RVA = "0x3078A90", Offset = "0x3077E90", Length = "0xB")]
	[Token(Token = "0x60018E3")]
	public bool get_timeLooped() { }

	[Address(RVA = "0x3078A10", Offset = "0x3077E10", Length = "0xD")]
	[Token(Token = "0x60018DD")]
	private bool HasFlags(Flags flag) { }

}

