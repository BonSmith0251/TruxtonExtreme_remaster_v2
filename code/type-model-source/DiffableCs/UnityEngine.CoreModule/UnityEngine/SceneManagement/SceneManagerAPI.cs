namespace UnityEngine.SceneManagement;

[Token(Token = "0x2000261")]
public class SceneManagerAPI
{
	[Token(Token = "0x40007D0")]
	private static SceneManagerAPI s_DefaultAPI; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40007D1")]
	private static SceneManagerAPI <overrideAPI>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x17000396")]
	internal static SceneManagerAPI ActiveAPI
	{
		[Address(RVA = "0x3086B50", Offset = "0x3085F50", Length = "0xA7")]
		[Token(Token = "0x6001869")]
		internal get { } //Length: 167
	}

	[Token(Token = "0x17000397")]
	public static SceneManagerAPI overrideAPI
	{
		[Address(RVA = "0x3086C00", Offset = "0x3086000", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x600186A")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x3086AE0", Offset = "0x3085EE0", Length = "0x67")]
	[Token(Token = "0x600186F")]
	private static SceneManagerAPI() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600186B")]
	protected private SceneManagerAPI() { }

	[Address(RVA = "0x3086B50", Offset = "0x3085F50", Length = "0xA7")]
	[Token(Token = "0x6001869")]
	internal static SceneManagerAPI get_ActiveAPI() { }

	[Address(RVA = "0x3086C00", Offset = "0x3086000", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x600186A")]
	public static SceneManagerAPI get_overrideAPI() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600186E")]
	protected private override AsyncOperation LoadFirstScene(bool mustLoadAsync) { }

	[Address(RVA = "0x3086A70", Offset = "0x3085E70", Length = "0x2C")]
	[Token(Token = "0x600186C")]
	protected private override AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[Address(RVA = "0x3086AA0", Offset = "0x3085EA0", Length = "0x31")]
	[Token(Token = "0x600186D")]
	protected private override AsyncOperation UnloadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess) { }

}

