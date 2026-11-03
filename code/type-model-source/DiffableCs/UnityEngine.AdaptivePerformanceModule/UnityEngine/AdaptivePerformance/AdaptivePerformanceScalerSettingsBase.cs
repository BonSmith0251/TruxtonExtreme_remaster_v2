namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000039")]
public class AdaptivePerformanceScalerSettingsBase
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40000ED")]
	[Tooltip("Name of the scaler.")]
	private string m_Name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40000EE")]
	[Tooltip("Active")]
	private bool m_Enabled; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x40000EF")]
	[Tooltip("Scale to control the quality impact for the scaler. No quality change when 1, improved quality when >1, and lowered quality when <1.")]
	private float m_Scale; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40000F0")]
	[Tooltip("Visual impact the scaler has on the application. The higher the value, the more impact the scaler has on the visuals.")]
	private ScalerVisualImpact m_VisualImpact; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x40000F1")]
	[Tooltip("Application bottleneck that the scaler targets. The target selected has the most impact on the quality control of this scaler.")]
	private ScalerTarget m_Target; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40000F2")]
	[Tooltip("Maximum level for the scaler. This is tied to the implementation of the scaler to divide the levels into concrete steps.")]
	private int m_MaxLevel; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x40000F3")]
	[Tooltip("Minimum value for the scale boundary.")]
	private float m_MinBound; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40000F4")]
	[Tooltip("Maximum value for the scale boundary.")]
	private float m_MaxBound; //Field offset: 0x30

	[Token(Token = "0x1700009C")]
	public bool enabled
	{
		[Address(RVA = "0x2F8BCB0", Offset = "0x2F8B0B0", Length = "0x7")]
		[Token(Token = "0x60001C2")]
		 get { } //Length: 7
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[Token(Token = "0x60001C3")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000A2")]
	public float maxBound
	{
		[Address(RVA = "0x2F92DA0", Offset = "0x2F921A0", Length = "0x8")]
		[Token(Token = "0x60001CE")]
		 get { } //Length: 8
		[Address(RVA = "0x2828CF0", Offset = "0x28280F0", Length = "0x6")]
		[Token(Token = "0x60001CF")]
		 set { } //Length: 6
	}

	[Token(Token = "0x170000A0")]
	public int maxLevel
	{
		[Address(RVA = "0x1073730", Offset = "0x1072B30", Length = "0x6")]
		[Token(Token = "0x60001CA")]
		 get { } //Length: 6
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[Token(Token = "0x60001CB")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000A1")]
	public float minBound
	{
		[Address(RVA = "0x2F92DB0", Offset = "0x2F921B0", Length = "0x8")]
		[Token(Token = "0x60001CC")]
		 get { } //Length: 8
		[Address(RVA = "0x2EAE500", Offset = "0x2EAD900", Length = "0x6")]
		[Token(Token = "0x60001CD")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700009B")]
	public string name
	{
		[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
		[Token(Token = "0x60001C0")]
		 get { } //Length: 7
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x60001C1")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700009D")]
	public float scale
	{
		[Address(RVA = "0x2F92DC0", Offset = "0x2F921C0", Length = "0x8")]
		[Token(Token = "0x60001C4")]
		 get { } //Length: 8
		[Address(RVA = "0x1E18720", Offset = "0x1E17B20", Length = "0x6")]
		[Token(Token = "0x60001C5")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700009F")]
	public ScalerTarget target
	{
		[Address(RVA = "0x2F92DD0", Offset = "0x2F921D0", Length = "0x6")]
		[Token(Token = "0x60001C8")]
		 get { } //Length: 6
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[Token(Token = "0x60001C9")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700009E")]
	public ScalerVisualImpact visualImpact
	{
		[Address(RVA = "0x1073710", Offset = "0x1072B10", Length = "0x6")]
		[Token(Token = "0x60001C6")]
		 get { } //Length: 6
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[Token(Token = "0x60001C7")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2F92D20", Offset = "0x2F92120", Length = "0x7D")]
	[Token(Token = "0x60001D0")]
	public AdaptivePerformanceScalerSettingsBase() { }

	[Address(RVA = "0x2F8BCB0", Offset = "0x2F8B0B0", Length = "0x7")]
	[Token(Token = "0x60001C2")]
	public bool get_enabled() { }

	[Address(RVA = "0x2F92DA0", Offset = "0x2F921A0", Length = "0x8")]
	[Token(Token = "0x60001CE")]
	public float get_maxBound() { }

	[Address(RVA = "0x1073730", Offset = "0x1072B30", Length = "0x6")]
	[Token(Token = "0x60001CA")]
	public int get_maxLevel() { }

	[Address(RVA = "0x2F92DB0", Offset = "0x2F921B0", Length = "0x8")]
	[Token(Token = "0x60001CC")]
	public float get_minBound() { }

	[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
	[Token(Token = "0x60001C0")]
	public string get_name() { }

	[Address(RVA = "0x2F92DC0", Offset = "0x2F921C0", Length = "0x8")]
	[Token(Token = "0x60001C4")]
	public float get_scale() { }

	[Address(RVA = "0x2F92DD0", Offset = "0x2F921D0", Length = "0x6")]
	[Token(Token = "0x60001C8")]
	public ScalerTarget get_target() { }

	[Address(RVA = "0x1073710", Offset = "0x1072B10", Length = "0x6")]
	[Token(Token = "0x60001C6")]
	public ScalerVisualImpact get_visualImpact() { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[Token(Token = "0x60001C3")]
	public void set_enabled(bool value) { }

	[Address(RVA = "0x2828CF0", Offset = "0x28280F0", Length = "0x6")]
	[Token(Token = "0x60001CF")]
	public void set_maxBound(float value) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[Token(Token = "0x60001CB")]
	public void set_maxLevel(int value) { }

	[Address(RVA = "0x2EAE500", Offset = "0x2EAD900", Length = "0x6")]
	[Token(Token = "0x60001CD")]
	public void set_minBound(float value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x60001C1")]
	public void set_name(string value) { }

	[Address(RVA = "0x1E18720", Offset = "0x1E17B20", Length = "0x6")]
	[Token(Token = "0x60001C5")]
	public void set_scale(float value) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[Token(Token = "0x60001C9")]
	public void set_target(ScalerTarget value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[Token(Token = "0x60001C7")]
	public void set_visualImpact(ScalerVisualImpact value) { }

}

