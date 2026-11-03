namespace UnityEngine.Rendering;

[Token(Token = "0x2000128")]
internal struct ProbeVolumeBakingProcessSettings
{
	[Token(Token = "0x2000129")]
	public enum SettingsVersion : int
	{
		Initial = 0,
		ThreadedVirtualOffset = 1,
		Max = 2,
		Current = 1,
	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400056A")]
	private SettingsVersion m_Version; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400056B")]
	public ProbeDilationSettings dilationSettings; //Field offset: 0x4
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400056C")]
	public VirtualOffsetSettings virtualOffsetSettings; //Field offset: 0x18

	[Token(Token = "0x17000129")]
	internal static ProbeVolumeBakingProcessSettings Default
	{
		[Address(RVA = "0x2C15C10", Offset = "0x2C15010", Length = "0x6E")]
		[Token(Token = "0x6000A4D")]
		internal get { } //Length: 110
	}

	[Address(RVA = "0x2C15BE0", Offset = "0x2C14FE0", Length = "0x27")]
	[Token(Token = "0x6000A4E")]
	internal ProbeVolumeBakingProcessSettings(ProbeDilationSettings dilationSettings, VirtualOffsetSettings virtualOffsetSettings) { }

	[Address(RVA = "0x2C15C10", Offset = "0x2C15010", Length = "0x6E")]
	[Token(Token = "0x6000A4D")]
	internal static ProbeVolumeBakingProcessSettings get_Default() { }

	[Address(RVA = "0x2C15B30", Offset = "0x2C14F30", Length = "0x61")]
	[Token(Token = "0x6000A4F")]
	internal void SetDefaults() { }

	[Address(RVA = "0x2C15BA0", Offset = "0x2C14FA0", Length = "0x32")]
	[Token(Token = "0x6000A50")]
	internal void Upgrade() { }

}

