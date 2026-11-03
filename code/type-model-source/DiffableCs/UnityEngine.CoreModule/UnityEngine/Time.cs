namespace UnityEngine;

[NativeHeader("Runtime/Input/TimeManager.h")]
[StaticAccessor("GetTimeManager()", StaticAccessorType::Dot (0))]
[Token(Token = "0x20001ED")]
public class Time
{

	[Token(Token = "0x17000331")]
	public static float deltaTime
	{
		[Address(RVA = "0x308B0E0", Offset = "0x308A4E0", Length = "0x2A")]
		[Token(Token = "0x60015D0")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000336")]
	public static float fixedDeltaTime
	{
		[Address(RVA = "0x308B110", Offset = "0x308A510", Length = "0x2A")]
		[Token(Token = "0x60015D5")]
		 get { } //Length: 42
		[Address(RVA = "0x308B460", Offset = "0x308A860", Length = "0x3A")]
		[Token(Token = "0x60015D6")]
		 set { } //Length: 58
	}

	[Token(Token = "0x17000332")]
	public static float fixedTime
	{
		[Address(RVA = "0x308B140", Offset = "0x308A540", Length = "0x2A")]
		[Token(Token = "0x60015D1")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000334")]
	public static float fixedUnscaledTime
	{
		[Address(RVA = "0x308B170", Offset = "0x308A570", Length = "0x2A")]
		[Token(Token = "0x60015D3")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700033A")]
	public static int frameCount
	{
		[Address(RVA = "0x308B1A0", Offset = "0x308A5A0", Length = "0x2A")]
		[Token(Token = "0x60015DA")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700033E")]
	public static bool inFixedTimeStep
	{
		[Address(RVA = "0x308B1D0", Offset = "0x308A5D0", Length = "0x2A")]
		[NativeName("IsUsingFixedTimeStep")]
		[Token(Token = "0x60015DE")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000337")]
	public static float maximumDeltaTime
	{
		[Address(RVA = "0x308B200", Offset = "0x308A600", Length = "0x2A")]
		[Token(Token = "0x60015D7")]
		 get { } //Length: 42
	}

	[NativeProperty("Realtime")]
	[Token(Token = "0x1700033C")]
	public static float realtimeSinceStartup
	{
		[Address(RVA = "0x308B260", Offset = "0x308A660", Length = "0x2A")]
		[Token(Token = "0x60015DC")]
		 get { } //Length: 42
	}

	[NativeProperty("Realtime")]
	[Token(Token = "0x1700033D")]
	public static double realtimeSinceStartupAsDouble
	{
		[Address(RVA = "0x308B230", Offset = "0x308A630", Length = "0x2A")]
		[Token(Token = "0x60015DD")]
		 get { } //Length: 42
	}

	[NativeProperty("RenderFrameCount")]
	[Token(Token = "0x1700033B")]
	public static int renderedFrameCount
	{
		[Address(RVA = "0x308B290", Offset = "0x308A690", Length = "0x2A")]
		[Token(Token = "0x60015DB")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000338")]
	public static float smoothDeltaTime
	{
		[Address(RVA = "0x308B2C0", Offset = "0x308A6C0", Length = "0x2A")]
		[Token(Token = "0x60015D8")]
		 get { } //Length: 42
	}

	[NativeProperty("CurTime")]
	[Token(Token = "0x1700032E")]
	public static float time
	{
		[Address(RVA = "0x308B3D0", Offset = "0x308A7D0", Length = "0x2A")]
		[Token(Token = "0x60015CD")]
		 get { } //Length: 42
	}

	[NativeProperty("CurTime")]
	[Token(Token = "0x1700032F")]
	public static double timeAsDouble
	{
		[Address(RVA = "0x308B2F0", Offset = "0x308A6F0", Length = "0x2A")]
		[Token(Token = "0x60015CE")]
		 get { } //Length: 42
	}

	[NativeProperty("CurTimeRational")]
	[Token(Token = "0x17000330")]
	public static RationalTime timeAsRational
	{
		[Address(RVA = "0x308B360", Offset = "0x308A760", Length = "0x3C")]
		[Token(Token = "0x60015CF")]
		 get { } //Length: 60
	}

	[Token(Token = "0x17000339")]
	public static float timeScale
	{
		[Address(RVA = "0x308B3A0", Offset = "0x308A7A0", Length = "0x2A")]
		[Token(Token = "0x60015D9")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000335")]
	public static float unscaledDeltaTime
	{
		[Address(RVA = "0x308B400", Offset = "0x308A800", Length = "0x2A")]
		[Token(Token = "0x60015D4")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000333")]
	public static float unscaledTime
	{
		[Address(RVA = "0x308B430", Offset = "0x308A830", Length = "0x2A")]
		[Token(Token = "0x60015D2")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x308B0E0", Offset = "0x308A4E0", Length = "0x2A")]
	[Token(Token = "0x60015D0")]
	public static float get_deltaTime() { }

	[Address(RVA = "0x308B110", Offset = "0x308A510", Length = "0x2A")]
	[Token(Token = "0x60015D5")]
	public static float get_fixedDeltaTime() { }

	[Address(RVA = "0x308B140", Offset = "0x308A540", Length = "0x2A")]
	[Token(Token = "0x60015D1")]
	public static float get_fixedTime() { }

	[Address(RVA = "0x308B170", Offset = "0x308A570", Length = "0x2A")]
	[Token(Token = "0x60015D3")]
	public static float get_fixedUnscaledTime() { }

	[Address(RVA = "0x308B1A0", Offset = "0x308A5A0", Length = "0x2A")]
	[Token(Token = "0x60015DA")]
	public static int get_frameCount() { }

	[Address(RVA = "0x308B1D0", Offset = "0x308A5D0", Length = "0x2A")]
	[NativeName("IsUsingFixedTimeStep")]
	[Token(Token = "0x60015DE")]
	public static bool get_inFixedTimeStep() { }

	[Address(RVA = "0x308B200", Offset = "0x308A600", Length = "0x2A")]
	[Token(Token = "0x60015D7")]
	public static float get_maximumDeltaTime() { }

	[Address(RVA = "0x308B260", Offset = "0x308A660", Length = "0x2A")]
	[Token(Token = "0x60015DC")]
	public static float get_realtimeSinceStartup() { }

	[Address(RVA = "0x308B230", Offset = "0x308A630", Length = "0x2A")]
	[Token(Token = "0x60015DD")]
	public static double get_realtimeSinceStartupAsDouble() { }

	[Address(RVA = "0x308B290", Offset = "0x308A690", Length = "0x2A")]
	[Token(Token = "0x60015DB")]
	public static int get_renderedFrameCount() { }

	[Address(RVA = "0x308B2C0", Offset = "0x308A6C0", Length = "0x2A")]
	[Token(Token = "0x60015D8")]
	public static float get_smoothDeltaTime() { }

	[Address(RVA = "0x308B3D0", Offset = "0x308A7D0", Length = "0x2A")]
	[Token(Token = "0x60015CD")]
	public static float get_time() { }

	[Address(RVA = "0x308B2F0", Offset = "0x308A6F0", Length = "0x2A")]
	[Token(Token = "0x60015CE")]
	public static double get_timeAsDouble() { }

	[Address(RVA = "0x308B360", Offset = "0x308A760", Length = "0x3C")]
	[Token(Token = "0x60015CF")]
	public static RationalTime get_timeAsRational() { }

	[Address(RVA = "0x308B320", Offset = "0x308A720", Length = "0x33")]
	[Token(Token = "0x60015DF")]
	private static void get_timeAsRational_Injected(out RationalTime ret) { }

	[Address(RVA = "0x308B3A0", Offset = "0x308A7A0", Length = "0x2A")]
	[Token(Token = "0x60015D9")]
	public static float get_timeScale() { }

	[Address(RVA = "0x308B400", Offset = "0x308A800", Length = "0x2A")]
	[Token(Token = "0x60015D4")]
	public static float get_unscaledDeltaTime() { }

	[Address(RVA = "0x308B430", Offset = "0x308A830", Length = "0x2A")]
	[Token(Token = "0x60015D2")]
	public static float get_unscaledTime() { }

	[Address(RVA = "0x308B460", Offset = "0x308A860", Length = "0x3A")]
	[Token(Token = "0x60015D6")]
	public static void set_fixedDeltaTime(float value) { }

}

