namespace TXEKernel;

[Token(Token = "0x2000012")]
public class PlayableDirectorUtility : MonoBehaviour, IDisposable
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000050")]
	private PlayableDirector _playableDirector; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000051")]
	private Camera _camera; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000052")]
	private Action _endCallback; //Field offset: 0x30

	[Token(Token = "0x14000001")]
	private event Action _endCallback
	{
		[Address(RVA = "0x26DCB40", Offset = "0x26DBF40", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600003A")]
		private add { } //Length: 158
		[Address(RVA = "0x26DCC10", Offset = "0x26DC010", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600003B")]
		private remove { } //Length: 158
	}

	[Token(Token = "0x1700000A")]
	public Camera Camera
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000039")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000009")]
	public bool IsPlaying
	{
		[Address(RVA = "0x26DCBE0", Offset = "0x26DBFE0", Length = "0x24")]
		[Token(Token = "0x6000038")]
		 get { } //Length: 36
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600003C")]
	public PlayableDirectorUtility() { }

	[Address(RVA = "0x26DCB40", Offset = "0x26DBF40", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600003A")]
	private void add__endCallback(Action value) { }

	[Address(RVA = "0x26DC890", Offset = "0x26DBC90", Length = "0xE3")]
	[Token(Token = "0x6000035")]
	public override void Dispose() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000039")]
	public Camera get_Camera() { }

	[Address(RVA = "0x26DCBE0", Offset = "0x26DBFE0", Length = "0x24")]
	[Token(Token = "0x6000038")]
	public bool get_IsPlaying() { }

	[Address(RVA = "0x26DC980", Offset = "0x26DBD80", Length = "0xA6")]
	[Token(Token = "0x6000032")]
	public void Initialize(Action endCallback) { }

	[Address(RVA = "0x26DCA30", Offset = "0x26DBE30", Length = "0x19")]
	[Token(Token = "0x6000036")]
	private void OnPlayableDirectorStopped(PlayableDirector aDirector) { }

	[Address(RVA = "0x26DCA50", Offset = "0x26DBE50", Length = "0x5B")]
	[Token(Token = "0x6000033")]
	public void Play(bool isLoop = false) { }

	[Address(RVA = "0x26DCC10", Offset = "0x26DC010", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600003B")]
	private void remove__endCallback(Action value) { }

	[Address(RVA = "0x26DCAB0", Offset = "0x26DBEB0", Length = "0x1D")]
	[Token(Token = "0x6000034")]
	public void Stop() { }

	[Address(RVA = "0x26DCAD0", Offset = "0x26DBED0", Length = "0x6E")]
	[Token(Token = "0x6000037")]
	private void Update() { }

}

