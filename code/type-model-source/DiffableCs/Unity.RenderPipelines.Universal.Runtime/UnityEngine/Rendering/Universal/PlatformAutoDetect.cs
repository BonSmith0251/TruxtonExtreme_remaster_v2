namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001FA")]
internal static class PlatformAutoDetect
{
	[CompilerGenerated]
	[Token(Token = "0x4000C04")]
	private static bool <isXRMobile>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x4000C05")]
	private static bool <isShaderAPIMobileDefined>k__BackingField; //Field offset: 0x1
	[CompilerGenerated]
	[Token(Token = "0x4000C06")]
	private static bool <isSwitch>k__BackingField; //Field offset: 0x2
	[CompilerGenerated]
	[Token(Token = "0x4000C07")]
	private static bool <isSwitch2>k__BackingField; //Field offset: 0x3
	[Token(Token = "0x4000C08")]
	internal static bool isRunningOnPowerVRGPU; //Field offset: 0x4

	[Token(Token = "0x1700029D")]
	internal static bool isShaderAPIMobileDefined
	{
		[Address(RVA = "0x2E07DB0", Offset = "0x2E071B0", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x6000AC5")]
		internal get { } //Length: 79
		[Address(RVA = "0x2E07EF0", Offset = "0x2E072F0", Length = "0x54")]
		[CompilerGenerated]
		[Token(Token = "0x6000AC6")]
		private set { } //Length: 84
	}

	[Token(Token = "0x1700029E")]
	internal static bool isSwitch
	{
		[Address(RVA = "0x2E07E50", Offset = "0x2E07250", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x6000AC7")]
		internal get { } //Length: 79
		[Address(RVA = "0x2E07FB0", Offset = "0x2E073B0", Length = "0x54")]
		[CompilerGenerated]
		[Token(Token = "0x6000AC8")]
		private set { } //Length: 84
	}

	[Token(Token = "0x1700029F")]
	internal static bool isSwitch2
	{
		[Address(RVA = "0x2E07E00", Offset = "0x2E07200", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x6000AC9")]
		internal get { } //Length: 79
		[Address(RVA = "0x2E07F50", Offset = "0x2E07350", Length = "0x54")]
		[CompilerGenerated]
		[Token(Token = "0x6000ACA")]
		private set { } //Length: 84
	}

	[Token(Token = "0x1700029C")]
	internal static bool isXRMobile
	{
		[Address(RVA = "0x2E07EA0", Offset = "0x2E072A0", Length = "0x4E")]
		[CompilerGenerated]
		[Token(Token = "0x6000AC3")]
		internal get { } //Length: 78
		[Address(RVA = "0x2E08010", Offset = "0x2E07410", Length = "0x53")]
		[CompilerGenerated]
		[Token(Token = "0x6000AC4")]
		private set { } //Length: 83
	}

	[Address(RVA = "0x2E07D00", Offset = "0x2E07100", Length = "0xAC")]
	[Token(Token = "0x6000ACC")]
	private static PlatformAutoDetect() { }

	[Address(RVA = "0x2E07DB0", Offset = "0x2E071B0", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x6000AC5")]
	internal static bool get_isShaderAPIMobileDefined() { }

	[Address(RVA = "0x2E07E50", Offset = "0x2E07250", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x6000AC7")]
	internal static bool get_isSwitch() { }

	[Address(RVA = "0x2E07E00", Offset = "0x2E07200", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x6000AC9")]
	internal static bool get_isSwitch2() { }

	[Address(RVA = "0x2E07EA0", Offset = "0x2E072A0", Length = "0x4E")]
	[CompilerGenerated]
	[Token(Token = "0x6000AC3")]
	internal static bool get_isXRMobile() { }

	[Address(RVA = "0x2E07990", Offset = "0x2E06D90", Length = "0x1BD")]
	[Token(Token = "0x6000AC2")]
	internal static void Initialize() { }

	[Address(RVA = "0x2E07EF0", Offset = "0x2E072F0", Length = "0x54")]
	[CompilerGenerated]
	[Token(Token = "0x6000AC6")]
	private static void set_isShaderAPIMobileDefined(bool value) { }

	[Address(RVA = "0x2E07FB0", Offset = "0x2E073B0", Length = "0x54")]
	[CompilerGenerated]
	[Token(Token = "0x6000AC8")]
	private static void set_isSwitch(bool value) { }

	[Address(RVA = "0x2E07F50", Offset = "0x2E07350", Length = "0x54")]
	[CompilerGenerated]
	[Token(Token = "0x6000ACA")]
	private static void set_isSwitch2(bool value) { }

	[Address(RVA = "0x2E08010", Offset = "0x2E07410", Length = "0x53")]
	[CompilerGenerated]
	[Token(Token = "0x6000AC4")]
	private static void set_isXRMobile(bool value) { }

	[Address(RVA = "0x2E07B50", Offset = "0x2E06F50", Length = "0x1A6")]
	[Token(Token = "0x6000ACB")]
	internal static ShEvalMode ShAutoDetect(ShEvalMode mode) { }

}

