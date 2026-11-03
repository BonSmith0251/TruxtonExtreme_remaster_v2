namespace UnityEngine.Playables;

[Token(Token = "0x200032B")]
public struct ScriptPlayable : IPlayable, IEquatable<ScriptPlayable`1<T>>
{
	[Token(Token = "0x400084D")]
	private static readonly ScriptPlayable<T> m_NullPlayable; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400084C")]
	private PlayableHandle m_Handle; //Field offset: 0x0

	[Token(Token = "0x170003B4")]
	public static ScriptPlayable<T> Null
	{
		[Address(RVA = "0xF56340", Offset = "0xF55740", Length = "0xA4")]
		[Token(Token = "0x60019AF")]
		 get { } //Length: 164
	}

	[Address(RVA = "0xF560A0", Offset = "0xF554A0", Length = "0xD6")]
	[Token(Token = "0x60019BD")]
	private static ScriptPlayable`1() { }

	[Address(RVA = "0xF56180", Offset = "0xF55580", Length = "0x1B1")]
	[Token(Token = "0x60019B7")]
	internal ScriptPlayable`1(PlayableHandle handle) { }

	[Address(RVA = "0xF55680", Offset = "0xF54A80", Length = "0x235")]
	[Token(Token = "0x60019B4")]
	private static object CloneScriptInstance(IPlayableBehaviour source) { }

	[Address(RVA = "0xF555A0", Offset = "0xF549A0", Length = "0x85")]
	[Token(Token = "0x60019B5")]
	private static object CloneScriptInstanceFromEngineObject(object source) { }

	[Address(RVA = "0xF55630", Offset = "0xF54A30", Length = "0x45")]
	[Token(Token = "0x60019B6")]
	private static object CloneScriptInstanceFromIClonable(ICloneable source) { }

	[Address(RVA = "0xF55E10", Offset = "0xF55210", Length = "0x10D")]
	[Token(Token = "0x60019B0")]
	public static ScriptPlayable<T> Create(PlayableGraph graph, int inputCount = 0) { }

	[Address(RVA = "0xF55CE0", Offset = "0xF550E0", Length = "0x121")]
	[Token(Token = "0x60019B1")]
	public static ScriptPlayable<T> Create(PlayableGraph graph, T template, int inputCount = 0) { }

	[Address(RVA = "0xF558C0", Offset = "0xF54CC0", Length = "0x2A4")]
	[Token(Token = "0x60019B2")]
	private static PlayableHandle CreateHandle(PlayableGraph graph, T template, int inputCount) { }

	[Address(RVA = "0xF55B70", Offset = "0xF54F70", Length = "0x169")]
	[Token(Token = "0x60019B3")]
	private static object CreateScriptInstance() { }

	[Address(RVA = "0xF55F20", Offset = "0xF55320", Length = "0xEC")]
	[Token(Token = "0x60019BC")]
	public override bool Equals(ScriptPlayable<T> other) { }

	[Address(RVA = "0xF56340", Offset = "0xF55740", Length = "0xA4")]
	[Token(Token = "0x60019AF")]
	public static ScriptPlayable<T> get_Null() { }

	[Address(RVA = "0xF56010", Offset = "0xF55410", Length = "0x73")]
	[Token(Token = "0x60019B9")]
	public T GetBehaviour() { }

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x60019B8")]
	public override PlayableHandle GetHandle() { }

	[Address(RVA = "0xF563F0", Offset = "0xF557F0", Length = "0xC4")]
	[Token(Token = "0x60019BB")]
	public static ScriptPlayable<T> op_Explicit(Playable playable) { }

	[Address(RVA = "0xF564C0", Offset = "0xF558C0", Length = "0xAF")]
	[Token(Token = "0x60019BA")]
	public static Playable op_Implicit(ScriptPlayable<T> playable) { }

}

