namespace DG.Tweening;

[Extension]
[Token(Token = "0x200001A")]
public static class TweenExtensions
{

	[Address(RVA = "0x65C820", Offset = "0x65BC20", Length = "0x132")]
	[Extension]
	[Token(Token = "0x600008D")]
	public static void Complete(Tween t) { }

	[Address(RVA = "0x65C960", Offset = "0x65BD60", Length = "0x14A")]
	[Extension]
	[Token(Token = "0x600008E")]
	public static void Complete(Tween t, bool withCallbacks) { }

	[Address(RVA = "0x65CAB0", Offset = "0x65BEB0", Length = "0x69")]
	[Extension]
	[Token(Token = "0x60000A5")]
	public static int CompletedLoops(Tween t) { }

	[Address(RVA = "0x65CB20", Offset = "0x65BF20", Length = "0x6C")]
	[Extension]
	[Token(Token = "0x60000A6")]
	public static float Delay(Tween t) { }

	[Address(RVA = "0x65CB90", Offset = "0x65BF90", Length = "0x194")]
	[Token(Token = "0x6000093")]
	private static void DoGoto(Tween t, float to, bool andPlay, bool withCallbacks) { }

	[Address(RVA = "0x65CD30", Offset = "0x65C130", Length = "0xA4")]
	[Extension]
	[Token(Token = "0x60000A8")]
	public static float Duration(Tween t, bool includeLoops = true) { }

	[Address(RVA = "0x65D000", Offset = "0x65C400", Length = "0x9C")]
	[Extension]
	[Token(Token = "0x60000A9")]
	public static float Elapsed(Tween t, bool includeLoops = true) { }

	[Address(RVA = "0x65CDE0", Offset = "0x65C1E0", Length = "0x6C")]
	[Extension]
	[Token(Token = "0x60000A7")]
	public static float ElapsedDelay(Tween t) { }

	[Address(RVA = "0x65CE50", Offset = "0x65C250", Length = "0xCF")]
	[Extension]
	[Token(Token = "0x60000AB")]
	public static float ElapsedDirectionalPercentage(Tween t) { }

	[Address(RVA = "0x65CF20", Offset = "0x65C320", Length = "0xDA")]
	[Extension]
	[Token(Token = "0x60000AA")]
	public static float ElapsedPercentage(Tween t, bool includeLoops = true) { }

	[Address(RVA = "0x65D0A0", Offset = "0x65C4A0", Length = "0x127")]
	[Extension]
	[Token(Token = "0x600008F")]
	public static void Flip(Tween t) { }

	[Address(RVA = "0x65D1D0", Offset = "0x65C5D0", Length = "0x12A")]
	[Extension]
	[Token(Token = "0x6000090")]
	public static void ForceInit(Tween t) { }

	[Address(RVA = "0x65D6B0", Offset = "0x65CAB0", Length = "0x1A")]
	[Extension]
	[Token(Token = "0x6000091")]
	public static void Goto(Tween t, float to, bool andPlay = false) { }

	[Address(RVA = "0x65D300", Offset = "0x65C700", Length = "0x38D")]
	[Extension]
	[Token(Token = "0x600009E")]
	public static void GotoWaypoint(Tween t, int waypointIndex, bool andPlay = false) { }

	[Address(RVA = "0x65D690", Offset = "0x65CA90", Length = "0x1A")]
	[Extension]
	[Token(Token = "0x6000092")]
	public static void GotoWithCallbacks(Tween t, float to, bool andPlay = false) { }

	[Address(RVA = "0x65D6D0", Offset = "0x65CAD0", Length = "0x10")]
	[Extension]
	[Token(Token = "0x60000AC")]
	public static bool IsActive(Tween t) { }

	[Address(RVA = "0x65D6E0", Offset = "0x65CAE0", Length = "0x67")]
	[Extension]
	[Token(Token = "0x60000AD")]
	public static bool IsBackwards(Tween t) { }

	[Address(RVA = "0x65D750", Offset = "0x65CB50", Length = "0x6A")]
	[Extension]
	[Token(Token = "0x60000AE")]
	public static bool IsComplete(Tween t) { }

	[Address(RVA = "0x65D7C0", Offset = "0x65CBC0", Length = "0x6A")]
	[Extension]
	[Token(Token = "0x60000AF")]
	public static bool IsInitialized(Tween t) { }

	[Address(RVA = "0x65D830", Offset = "0x65CC30", Length = "0x6A")]
	[Extension]
	[Token(Token = "0x60000B0")]
	public static bool IsPlaying(Tween t) { }

	[Address(RVA = "0x65D8A0", Offset = "0x65CCA0", Length = "0x1DD")]
	[Extension]
	[Token(Token = "0x6000094")]
	public static void Kill(Tween t, bool complete = false) { }

	[Address(RVA = "0x65DA80", Offset = "0x65CE80", Length = "0x69")]
	[Extension]
	[Token(Token = "0x60000B1")]
	public static int Loops(Tween t) { }

	[Address(RVA = "0x65DAF0", Offset = "0x65CEF0", Length = "0x16F")]
	[Extension]
	[Token(Token = "0x6000095")]
	public static void ManualUpdate(Tween t, float deltaTime, float unscaledDeltaTime) { }

	[Address(RVA = "0x65DC60", Offset = "0x65D060", Length = "0x1E2")]
	[Extension]
	[Token(Token = "0x60000B3")]
	public static Vector3[] PathGetDrawPoints(Tween t, int subdivisionsXSegment = 10) { }

	[Address(RVA = "0x65DE50", Offset = "0x65D250", Length = "0x226")]
	[Extension]
	[Token(Token = "0x60000B2")]
	public static Vector3 PathGetPoint(Tween t, float pathPercentage) { }

	[Address(RVA = "0x65E080", Offset = "0x65D480", Length = "0x1D5")]
	[Extension]
	[Token(Token = "0x60000B4")]
	public static float PathLength(Tween t) { }

	[Address(RVA = "0x946B90", Offset = "0x945F90", Length = "0x12C")]
	[Extension]
	[Token(Token = "0x6000096")]
	public static T Pause(T t) { }

	[Address(RVA = "0x946CC0", Offset = "0x9460C0", Length = "0x12C")]
	[Extension]
	[Token(Token = "0x6000097")]
	public static T Play(T t) { }

	[Address(RVA = "0x65E260", Offset = "0x65D660", Length = "0x127")]
	[Extension]
	[Token(Token = "0x6000098")]
	public static void PlayBackwards(Tween t) { }

	[Address(RVA = "0x65E390", Offset = "0x65D790", Length = "0x127")]
	[Extension]
	[Token(Token = "0x6000099")]
	public static void PlayForward(Tween t) { }

	[Address(RVA = "0x65E4C0", Offset = "0x65D8C0", Length = "0x165")]
	[Extension]
	[Token(Token = "0x600009A")]
	public static void Restart(Tween t, bool includeDelay = true, float changeDelayTo = -1) { }

	[Address(RVA = "0x65E630", Offset = "0x65DA30", Length = "0x142")]
	[Extension]
	[Token(Token = "0x600009B")]
	public static void Rewind(Tween t, bool includeDelay = true) { }

	[Address(RVA = "0x65E780", Offset = "0x65DB80", Length = "0x127")]
	[Extension]
	[Token(Token = "0x600009C")]
	public static void SmoothRewind(Tween t) { }

	[Address(RVA = "0x65E8B0", Offset = "0x65DCB0", Length = "0x127")]
	[Extension]
	[Token(Token = "0x600009D")]
	public static void TogglePause(Tween t) { }

	[Address(RVA = "0x65E9E0", Offset = "0x65DDE0", Length = "0xD9")]
	[Extension]
	[Token(Token = "0x600009F")]
	public static YieldInstruction WaitForCompletion(Tween t) { }

	[Address(RVA = "0x65EAC0", Offset = "0x65DEC0", Length = "0xEC")]
	[Extension]
	[Token(Token = "0x60000A2")]
	public static YieldInstruction WaitForElapsedLoops(Tween t, int elapsedLoops) { }

	[Address(RVA = "0x65EBB0", Offset = "0x65DFB0", Length = "0xD9")]
	[Extension]
	[Token(Token = "0x60000A1")]
	public static YieldInstruction WaitForKill(Tween t) { }

	[Address(RVA = "0x65EC90", Offset = "0x65E090", Length = "0xEE")]
	[Extension]
	[Token(Token = "0x60000A3")]
	public static YieldInstruction WaitForPosition(Tween t, float position) { }

	[Address(RVA = "0x65ED80", Offset = "0x65E180", Length = "0xD9")]
	[Extension]
	[Token(Token = "0x60000A0")]
	public static YieldInstruction WaitForRewind(Tween t) { }

	[Address(RVA = "0x65EE60", Offset = "0x65E260", Length = "0xD9")]
	[Extension]
	[Token(Token = "0x60000A4")]
	public static Coroutine WaitForStart(Tween t) { }

}

