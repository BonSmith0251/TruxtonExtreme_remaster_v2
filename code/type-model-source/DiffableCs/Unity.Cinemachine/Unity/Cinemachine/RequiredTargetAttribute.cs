namespace Unity.Cinemachine;

[Token(Token = "0x20000AB")]
public sealed class RequiredTargetAttribute : Attribute
{
	[Token(Token = "0x20000AC")]
	internal enum RequiredTargets : int
	{
		None = 0,
		Tracking = 1,
		LookAt = 2,
		GroupLookAt = 3,
	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000291")]
	private RequiredTargets <RequiredTarget>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x170000B3")]
	public private RequiredTargets RequiredTarget
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000337")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000338")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x609F60", Offset = "0x609360", Length = "0x24")]
	[Token(Token = "0x6000339")]
	public RequiredTargetAttribute(RequiredTargets requiredTarget) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000337")]
	public RequiredTargets get_RequiredTarget() { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000338")]
	private void set_RequiredTarget(RequiredTargets value) { }

}

