namespace UnityEngine.Playables;

[RequiredByNativeCode]
[Token(Token = "0x200031C")]
public struct Playable : IPlayable, IEquatable<Playable>
{
	[Token(Token = "0x400082F")]
	private static readonly Playable m_NullPlayable; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400082E")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Token(Token = "0x170003AC")]
	public static Playable Null
	{
		[Address(RVA = "0x307EF00", Offset = "0x307E300", Length = "0x60")]
		[Token(Token = "0x60018FF")]
		 get { } //Length: 96
	}

	[Address(RVA = "0x307EE60", Offset = "0x307E260", Length = "0x99")]
	[Token(Token = "0x6001906")]
	private static Playable() { }

	[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
	[Token(Token = "0x6001901")]
	[VisibleToOtherModules]
	internal Playable(PlayableHandle handle) { }

	[Address(RVA = "0x307EC10", Offset = "0x307E010", Length = "0xC7")]
	[Token(Token = "0x6001900")]
	public static Playable Create(PlayableGraph graph, int inputCount = 0) { }

	[Address(RVA = "0x307ECE0", Offset = "0x307E0E0", Length = "0xD4")]
	[Token(Token = "0x6001905")]
	public override bool Equals(Playable other) { }

	[Address(RVA = "0x307EF00", Offset = "0x307E300", Length = "0x60")]
	[Token(Token = "0x60018FF")]
	public static Playable get_Null() { }

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x6001902")]
	public override PlayableHandle GetHandle() { }

	[Address(RVA = "0x307EDC0", Offset = "0x307E1C0", Length = "0x97")]
	[Token(Token = "0x6001904")]
	public Type GetPlayableType() { }

	[Address(RVA = "0x8B1680", Offset = "0x8B0A80", Length = "0x114")]
	[Token(Token = "0x6001903")]
	public bool IsPlayableOfType() { }

}

