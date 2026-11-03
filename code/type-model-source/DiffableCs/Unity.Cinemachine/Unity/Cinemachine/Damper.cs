namespace Unity.Cinemachine;

[Token(Token = "0x20000DB")]
public static class Damper
{
	[Token(Token = "0x20000DC")]
	public static class AverageFrameRateTracker
	{
		[Token(Token = "0x4000352")]
		private const int kBufferSize = 100; //Field offset: 0x0
		[Token(Token = "0x4000353")]
		private static Single[] s_Buffer; //Field offset: 0x0
		[Token(Token = "0x4000357")]
		public const float kSubframeTime = 0.0009765625; //Field offset: 0x0
		[Token(Token = "0x4000354")]
		private static int s_NumItems; //Field offset: 0x8
		[Token(Token = "0x4000355")]
		private static int s_Head; //Field offset: 0xC
		[Token(Token = "0x4000356")]
		private static float s_Sum; //Field offset: 0x10
		[CompilerGenerated]
		[Token(Token = "0x4000358")]
		private static float <FPS>k__BackingField; //Field offset: 0x14
		[CompilerGenerated]
		[Token(Token = "0x4000359")]
		private static float <DampTimeScale>k__BackingField; //Field offset: 0x18

		[Token(Token = "0x170000DF")]
		public private static float DampTimeScale
		{
			[Address(RVA = "0x2833E50", Offset = "0x2833250", Length = "0x50")]
			[CompilerGenerated]
			[Token(Token = "0x600040C")]
			 get { } //Length: 80
			[Address(RVA = "0x2833EF0", Offset = "0x28332F0", Length = "0x5D")]
			[CompilerGenerated]
			[Token(Token = "0x600040D")]
			private set { } //Length: 93
		}

		[Token(Token = "0x170000DE")]
		public private static float FPS
		{
			[Address(RVA = "0x2833EA0", Offset = "0x28332A0", Length = "0x50")]
			[CompilerGenerated]
			[Token(Token = "0x600040A")]
			 get { } //Length: 80
			[Address(RVA = "0x2833F50", Offset = "0x2833350", Length = "0x5D")]
			[CompilerGenerated]
			[Token(Token = "0x600040B")]
			private set { } //Length: 93
		}

		[Address(RVA = "0x2833DB0", Offset = "0x28331B0", Length = "0x9E")]
		[Token(Token = "0x6000413")]
		private static AverageFrameRateTracker() { }

		[Address(RVA = "0x2833900", Offset = "0x2832D00", Length = "0x24C")]
		[Token(Token = "0x6000411")]
		private static void Append() { }

		[Address(RVA = "0x2833E50", Offset = "0x2833250", Length = "0x50")]
		[CompilerGenerated]
		[Token(Token = "0x600040C")]
		public static float get_DampTimeScale() { }

		[Address(RVA = "0x2833EA0", Offset = "0x28332A0", Length = "0x50")]
		[CompilerGenerated]
		[Token(Token = "0x600040A")]
		public static float get_FPS() { }

		[Address(RVA = "0x2833B50", Offset = "0x2832F50", Length = "0x40")]
		[RuntimeInitializeOnLoadMethod]
		[Token(Token = "0x600040E")]
		private static void Initialize() { }

		[Address(RVA = "0x2833B90", Offset = "0x2832F90", Length = "0x40")]
		[Token(Token = "0x600040F")]
		private static void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

		[Address(RVA = "0x2833BD0", Offset = "0x2832FD0", Length = "0x107")]
		[Token(Token = "0x6000410")]
		internal static void Reset() { }

		[Address(RVA = "0x2833EF0", Offset = "0x28332F0", Length = "0x5D")]
		[CompilerGenerated]
		[Token(Token = "0x600040D")]
		private static void set_DampTimeScale(float value) { }

		[Address(RVA = "0x2833F50", Offset = "0x2833350", Length = "0x5D")]
		[CompilerGenerated]
		[Token(Token = "0x600040B")]
		private static void set_FPS(float value) { }

		[Address(RVA = "0x2833CE0", Offset = "0x28330E0", Length = "0xCC")]
		[Token(Token = "0x6000412")]
		internal static void SetDampTimeScale(float fps) { }

	}

	[Token(Token = "0x400034F")]
	private const float Epsilon = 0.0001; //Field offset: 0x0
	[Token(Token = "0x4000350")]
	public const float kNegligibleResidual = 0.01; //Field offset: 0x0
	[Token(Token = "0x4000351")]
	private const float kLogNegligibleResidual = -4.6051702; //Field offset: 0x0

	[Address(RVA = "0x28440E0", Offset = "0x28434E0", Length = "0x75")]
	[Token(Token = "0x6000405")]
	public static float Damp(float initial, float dampTime, float deltaTime) { }

	[Address(RVA = "0x2844160", Offset = "0x2843560", Length = "0x1E2")]
	[Token(Token = "0x6000406")]
	public static Vector3 Damp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	[Address(RVA = "0x2843F00", Offset = "0x2843300", Length = "0x1D8")]
	[Token(Token = "0x6000407")]
	public static Vector3 Damp(Vector3 initial, float dampTime, float deltaTime) { }

	[Address(RVA = "0x2844350", Offset = "0x2843750", Length = "0x2B")]
	[Token(Token = "0x6000403")]
	private static float DecayConstant(float time, float residual) { }

	[Address(RVA = "0x2844380", Offset = "0x2843780", Length = "0x29")]
	[Token(Token = "0x6000404")]
	private static float DecayedRemainder(float initial, float decayConstant, float deltaTime) { }

	[Address(RVA = "0x28443B0", Offset = "0x28437B0", Length = "0x24D")]
	[Token(Token = "0x6000409")]
	internal static float StableDamp(float initial, float dampTime, float deltaTime) { }

	[Address(RVA = "0x2844600", Offset = "0x2843A00", Length = "0x6B")]
	[Token(Token = "0x6000408")]
	internal static float StandardDamp(float initial, float dampTime, float deltaTime) { }

}

