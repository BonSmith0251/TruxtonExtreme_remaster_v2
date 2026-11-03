namespace UnityEngine.Playables;

[Extension]
[Token(Token = "0x2000323")]
public static class PlayableExtensions
{

	[Address(RVA = "0x8ABB20", Offset = "0x8AAF20", Length = "0xA4")]
	[Extension]
	[Token(Token = "0x6001926")]
	public static double GetDuration(U playable) { }

	[Address(RVA = "0x8ABD00", Offset = "0x8AB100", Length = "0xC6")]
	[Extension]
	[Token(Token = "0x6001920")]
	public static PlayableGraph GetGraph(U playable) { }

	[Address(RVA = "0x8AC2B0", Offset = "0x8AB6B0", Length = "0xD6")]
	[Extension]
	[Token(Token = "0x600192E")]
	public static Playable GetInput(U playable, int inputPort) { }

	[Address(RVA = "0x8ABEE0", Offset = "0x8AB2E0", Length = "0xA4")]
	[Extension]
	[Token(Token = "0x600192D")]
	public static int GetInputCount(U playable) { }

	[Address(RVA = "0x8AC0B0", Offset = "0x8AB4B0", Length = "0xB3")]
	[Extension]
	[Token(Token = "0x6001932")]
	public static float GetInputWeight(U playable, int inputIndex) { }

	[Address(RVA = "0x8AC4D0", Offset = "0x8AB8D0", Length = "0xD6")]
	[Extension]
	[Token(Token = "0x600192F")]
	public static Playable GetOutput(U playable, int outputPort) { }

	[Address(RVA = "0x8AC6C0", Offset = "0x8ABAC0", Length = "0xA4")]
	[Extension]
	[Token(Token = "0x6001921")]
	public static PlayState GetPlayState(U playable) { }

	[Address(RVA = "0x8AC880", Offset = "0x8ABC80", Length = "0xA4")]
	[Extension]
	[Token(Token = "0x6001929")]
	public static double GetPreviousTime(U playable) { }

	[Address(RVA = "0x8ACCB0", Offset = "0x8AC0B0", Length = "0xA4")]
	[Extension]
	[Token(Token = "0x6001928")]
	public static double GetTime(U playable) { }

	[Address(RVA = "0x8ACA40", Offset = "0x8ABE40", Length = "0xA4")]
	[Extension]
	[Token(Token = "0x6001934")]
	internal static DirectorWrapMode GetTimeWrapMode(U playable) { }

	[Address(RVA = "0x8ACE70", Offset = "0x8AC270", Length = "0xA4")]
	[Extension]
	[Token(Token = "0x600192A")]
	public static bool IsDone(U playable) { }

	[Address(RVA = "0x8AD0E0", Offset = "0x8AC4E0", Length = "0xA4")]
	[Extension]
	[Token(Token = "0x600191F")]
	public static bool IsValid(U playable) { }

	[Address(RVA = "0x8AD2A0", Offset = "0x8AC6A0", Length = "0xA4")]
	[Extension]
	[Token(Token = "0x6001923")]
	public static void Pause(U playable) { }

	[Address(RVA = "0x8AD460", Offset = "0x8AC860", Length = "0xA4")]
	[Extension]
	[Token(Token = "0x6001922")]
	public static void Play(U playable) { }

	[Address(RVA = "0x8AD790", Offset = "0x8ACB90", Length = "0xB5")]
	[Extension]
	[Token(Token = "0x6001925")]
	public static void SetDuration(U playable, double value) { }

	[Address(RVA = "0x8ADA30", Offset = "0x8ACE30", Length = "0xB3")]
	[Extension]
	[Token(Token = "0x600192C")]
	public static void SetInputCount(U playable, int value) { }

	[Address(RVA = "0x8ADAF0", Offset = "0x8ACEF0", Length = "0xC3")]
	[Extension]
	[Token(Token = "0x6001930")]
	public static void SetInputWeight(U playable, int inputIndex, float weight) { }

	[Address(RVA = "0x8AE4A0", Offset = "0x8AD8A0", Length = "0x110")]
	[Extension]
	[Token(Token = "0x6001931")]
	public static void SetInputWeight(U playable, V input, float weight) { }

	[Address(RVA = "0x8AE790", Offset = "0x8ADB90", Length = "0xB6")]
	[Extension]
	[Token(Token = "0x600192B")]
	public static void SetPropagateSetTime(U playable, bool value) { }

	[Address(RVA = "0x8AE970", Offset = "0x8ADD70", Length = "0xB5")]
	[Extension]
	[Token(Token = "0x6001924")]
	public static void SetSpeed(U playable, double value) { }

	[Address(RVA = "0x8AEDF0", Offset = "0x8AE1F0", Length = "0xB5")]
	[Extension]
	[Token(Token = "0x6001927")]
	public static void SetTime(U playable, double value) { }

	[Address(RVA = "0x8AEC10", Offset = "0x8AE010", Length = "0xB3")]
	[Extension]
	[Token(Token = "0x6001935")]
	internal static void SetTimeWrapMode(U playable, DirectorWrapMode value) { }

	[Address(RVA = "0x8AEFD0", Offset = "0x8AE3D0", Length = "0xB3")]
	[Extension]
	[Token(Token = "0x6001933")]
	public static void SetTraversalMode(U playable, PlayableTraversalMode mode) { }

}

