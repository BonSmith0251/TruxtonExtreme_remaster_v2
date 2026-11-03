namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x200001C")]
public static class AdaptivePerformanceRenderSettings
{
	[Token(Token = "0x400007D")]
	private static float s_MaxShadowDistanceMultiplier; //Field offset: 0x0
	[Token(Token = "0x400007E")]
	private static float s_ShadowResolutionMultiplier; //Field offset: 0x4
	[Token(Token = "0x400007F")]
	private static float s_RenderScaleMultiplier; //Field offset: 0x8
	[Token(Token = "0x4000080")]
	private static float s_DecalsMaxDistance; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000081")]
	private static int <MainLightShadowCascadesCountBias>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000082")]
	private static int <ShadowQualityBias>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000083")]
	private static float <LutBias>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000084")]
	private static int <AntiAliasingQualityBias>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000085")]
	private static bool <SkipDynamicBatching>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000086")]
	private static bool <SkipFrontToBackSorting>k__BackingField; //Field offset: 0x21
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000087")]
	private static bool <SkipTransparentObjects>k__BackingField; //Field offset: 0x22

	[Token(Token = "0x17000044")]
	public static int AntiAliasingQualityBias
	{
		[Address(RVA = "0x2F91E00", Offset = "0x2F91200", Length = "0x4E")]
		[CompilerGenerated]
		[Token(Token = "0x60000DC")]
		 get { } //Length: 78
		[Address(RVA = "0x2F92170", Offset = "0x2F91570", Length = "0x53")]
		[CompilerGenerated]
		[Token(Token = "0x60000DD")]
		 set { } //Length: 83
	}

	[Token(Token = "0x1700003E")]
	public static float DecalsDrawDistance
	{
		[Address(RVA = "0x2F91E50", Offset = "0x2F91250", Length = "0x50")]
		[Token(Token = "0x60000D0")]
		 get { } //Length: 80
		[Address(RVA = "0x2F921D0", Offset = "0x2F915D0", Length = "0x5D")]
		[Token(Token = "0x60000D1")]
		 set { } //Length: 93
	}

	[Token(Token = "0x17000041")]
	public static float LutBias
	{
		[Address(RVA = "0x2F91EA0", Offset = "0x2F912A0", Length = "0x50")]
		[CompilerGenerated]
		[Token(Token = "0x60000D6")]
		 get { } //Length: 80
		[Address(RVA = "0x2F92230", Offset = "0x2F91630", Length = "0x5D")]
		[CompilerGenerated]
		[Token(Token = "0x60000D7")]
		 set { } //Length: 93
	}

	[Token(Token = "0x1700003F")]
	public static int MainLightShadowCascadesCountBias
	{
		[Address(RVA = "0x2F91EF0", Offset = "0x2F912F0", Length = "0x4E")]
		[CompilerGenerated]
		[Token(Token = "0x60000D2")]
		 get { } //Length: 78
		[Address(RVA = "0x2F92290", Offset = "0x2F91690", Length = "0x53")]
		[CompilerGenerated]
		[Token(Token = "0x60000D3")]
		 set { } //Length: 83
	}

	[Token(Token = "0x1700003D")]
	public static float MainLightShadowmapResolutionMultiplier
	{
		[Address(RVA = "0x2F91F40", Offset = "0x2F91340", Length = "0x50")]
		[Token(Token = "0x60000CE")]
		 get { } //Length: 80
		[Address(RVA = "0x2F922F0", Offset = "0x2F916F0", Length = "0x7A")]
		[Token(Token = "0x60000CF")]
		 set { } //Length: 122
	}

	[Token(Token = "0x17000042")]
	public static float MaxShadowDistanceMultiplier
	{
		[Address(RVA = "0x2F91F90", Offset = "0x2F91390", Length = "0x4F")]
		[Token(Token = "0x60000D8")]
		 get { } //Length: 79
		[Address(RVA = "0x2F92370", Offset = "0x2F91770", Length = "0x79")]
		[Token(Token = "0x60000D9")]
		 set { } //Length: 121
	}

	[Token(Token = "0x17000043")]
	public static float RenderScaleMultiplier
	{
		[Address(RVA = "0x2F91FE0", Offset = "0x2F913E0", Length = "0x50")]
		[Token(Token = "0x60000DA")]
		 get { } //Length: 80
		[Address(RVA = "0x2F923F0", Offset = "0x2F917F0", Length = "0x7A")]
		[Token(Token = "0x60000DB")]
		 set { } //Length: 122
	}

	[Token(Token = "0x17000040")]
	public static int ShadowQualityBias
	{
		[Address(RVA = "0x2F92030", Offset = "0x2F91430", Length = "0x4E")]
		[CompilerGenerated]
		[Token(Token = "0x60000D4")]
		 get { } //Length: 78
		[Address(RVA = "0x2F92470", Offset = "0x2F91870", Length = "0x53")]
		[CompilerGenerated]
		[Token(Token = "0x60000D5")]
		 set { } //Length: 83
	}

	[Token(Token = "0x17000045")]
	public static bool SkipDynamicBatching
	{
		[Address(RVA = "0x2F92080", Offset = "0x2F91480", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x60000DE")]
		 get { } //Length: 79
		[Address(RVA = "0x2F924D0", Offset = "0x2F918D0", Length = "0x54")]
		[CompilerGenerated]
		[Token(Token = "0x60000DF")]
		 set { } //Length: 84
	}

	[Token(Token = "0x17000046")]
	public static bool SkipFrontToBackSorting
	{
		[Address(RVA = "0x2F920D0", Offset = "0x2F914D0", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x60000E0")]
		 get { } //Length: 79
		[Address(RVA = "0x2F92530", Offset = "0x2F91930", Length = "0x54")]
		[CompilerGenerated]
		[Token(Token = "0x60000E1")]
		 set { } //Length: 84
	}

	[Token(Token = "0x17000047")]
	public static bool SkipTransparentObjects
	{
		[Address(RVA = "0x2F92120", Offset = "0x2F91520", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x60000E2")]
		 get { } //Length: 79
		[Address(RVA = "0x2F92590", Offset = "0x2F91990", Length = "0x54")]
		[CompilerGenerated]
		[Token(Token = "0x60000E3")]
		 set { } //Length: 84
	}

	[Address(RVA = "0x2F91D80", Offset = "0x2F91180", Length = "0x78")]
	[Token(Token = "0x60000E4")]
	private static AdaptivePerformanceRenderSettings() { }

	[Address(RVA = "0x2F91E00", Offset = "0x2F91200", Length = "0x4E")]
	[CompilerGenerated]
	[Token(Token = "0x60000DC")]
	public static int get_AntiAliasingQualityBias() { }

	[Address(RVA = "0x2F91E50", Offset = "0x2F91250", Length = "0x50")]
	[Token(Token = "0x60000D0")]
	public static float get_DecalsDrawDistance() { }

	[Address(RVA = "0x2F91EA0", Offset = "0x2F912A0", Length = "0x50")]
	[CompilerGenerated]
	[Token(Token = "0x60000D6")]
	public static float get_LutBias() { }

	[Address(RVA = "0x2F91EF0", Offset = "0x2F912F0", Length = "0x4E")]
	[CompilerGenerated]
	[Token(Token = "0x60000D2")]
	public static int get_MainLightShadowCascadesCountBias() { }

	[Address(RVA = "0x2F91F40", Offset = "0x2F91340", Length = "0x50")]
	[Token(Token = "0x60000CE")]
	public static float get_MainLightShadowmapResolutionMultiplier() { }

	[Address(RVA = "0x2F91F90", Offset = "0x2F91390", Length = "0x4F")]
	[Token(Token = "0x60000D8")]
	public static float get_MaxShadowDistanceMultiplier() { }

	[Address(RVA = "0x2F91FE0", Offset = "0x2F913E0", Length = "0x50")]
	[Token(Token = "0x60000DA")]
	public static float get_RenderScaleMultiplier() { }

	[Address(RVA = "0x2F92030", Offset = "0x2F91430", Length = "0x4E")]
	[CompilerGenerated]
	[Token(Token = "0x60000D4")]
	public static int get_ShadowQualityBias() { }

	[Address(RVA = "0x2F92080", Offset = "0x2F91480", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x60000DE")]
	public static bool get_SkipDynamicBatching() { }

	[Address(RVA = "0x2F920D0", Offset = "0x2F914D0", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x60000E0")]
	public static bool get_SkipFrontToBackSorting() { }

	[Address(RVA = "0x2F92120", Offset = "0x2F91520", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x60000E2")]
	public static bool get_SkipTransparentObjects() { }

	[Address(RVA = "0x2F92170", Offset = "0x2F91570", Length = "0x53")]
	[CompilerGenerated]
	[Token(Token = "0x60000DD")]
	public static void set_AntiAliasingQualityBias(int value) { }

	[Address(RVA = "0x2F921D0", Offset = "0x2F915D0", Length = "0x5D")]
	[Token(Token = "0x60000D1")]
	public static void set_DecalsDrawDistance(float value) { }

	[Address(RVA = "0x2F92230", Offset = "0x2F91630", Length = "0x5D")]
	[CompilerGenerated]
	[Token(Token = "0x60000D7")]
	public static void set_LutBias(float value) { }

	[Address(RVA = "0x2F92290", Offset = "0x2F91690", Length = "0x53")]
	[CompilerGenerated]
	[Token(Token = "0x60000D3")]
	public static void set_MainLightShadowCascadesCountBias(int value) { }

	[Address(RVA = "0x2F922F0", Offset = "0x2F916F0", Length = "0x7A")]
	[Token(Token = "0x60000CF")]
	public static void set_MainLightShadowmapResolutionMultiplier(float value) { }

	[Address(RVA = "0x2F92370", Offset = "0x2F91770", Length = "0x79")]
	[Token(Token = "0x60000D9")]
	public static void set_MaxShadowDistanceMultiplier(float value) { }

	[Address(RVA = "0x2F923F0", Offset = "0x2F917F0", Length = "0x7A")]
	[Token(Token = "0x60000DB")]
	public static void set_RenderScaleMultiplier(float value) { }

	[Address(RVA = "0x2F92470", Offset = "0x2F91870", Length = "0x53")]
	[CompilerGenerated]
	[Token(Token = "0x60000D5")]
	public static void set_ShadowQualityBias(int value) { }

	[Address(RVA = "0x2F924D0", Offset = "0x2F918D0", Length = "0x54")]
	[CompilerGenerated]
	[Token(Token = "0x60000DF")]
	public static void set_SkipDynamicBatching(bool value) { }

	[Address(RVA = "0x2F92530", Offset = "0x2F91930", Length = "0x54")]
	[CompilerGenerated]
	[Token(Token = "0x60000E1")]
	public static void set_SkipFrontToBackSorting(bool value) { }

	[Address(RVA = "0x2F92590", Offset = "0x2F91990", Length = "0x54")]
	[CompilerGenerated]
	[Token(Token = "0x60000E3")]
	public static void set_SkipTransparentObjects(bool value) { }

}

